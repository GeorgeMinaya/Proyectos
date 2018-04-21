using Clinica.Dental.BE;
using Clinica.Dental.BL;
using Clinica.Dental.SantaApolonia.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Xml.Linq;

namespace Clinica.Dental.SantaApolonia.ViewModel
{
    public class OdontogramaViewModel : vmb, vmbClose
    {
        public OdontogramaViewModel()
        {
            this.Paciente = new PacienteBE();
        }

        public OdontogramaViewModel(PacienteBE paciente)
        {
            this.Paciente = paciente;
        }

        private PacienteBE paciente;
        private vmbCommand guardar;
        private vmbCommand imprimir;

        #region Propiedades

        public PacienteBE Paciente
        {
            get { return paciente; }
            set { paciente = value; OnPropertyChanged(); }
        }

        public string Titulo
        {
            get { return "Paciente : " + Paciente.Nombres; }
        }

        #endregion

        #region Comandos

        public ICommand Imprimir
        {
            get
            {
                return imprimir = imprimir ?? new vmbCommand((Object oCanvas) =>
                {
                    PrintDialog prnt = new PrintDialog();
                    if (prnt.ShowDialog() == true)
                    {
                        var cLienzo = oCanvas as DesignerCanvas;

                        System.Windows.Size pageSize = new System.Windows.Size(prnt.PrintableAreaWidth, prnt.PrintableAreaHeight);
                        cLienzo.Measure(pageSize);
                        cLienzo.Arrange(new System.Windows.Rect(5, 5, pageSize.Width, pageSize.Height));

                        if (prnt.ShowDialog() == true)
                        {
                            prnt.PrintVisual(cLienzo, "Printing Canvas");
                        }
                    }
                });
            }
        }

        public ICommand Guardar
        {
            get
            {
                return guardar = guardar ?? new vmbCommand((Object oCanvas) =>
                {
                    try
                    {
                        var cLienzo = oCanvas as DesignerCanvas;

                        IEnumerable<DesignerItem> designerItems = cLienzo.Children.OfType<DesignerItem>();
                        
                        // aqui se obtiene las atenciones por realizar en el paciente

                        TratamientoBL oServicio = new TratamientoBL();

                        var tratamientos = oServicio.listarTratamientos();                        

                        var tratados = (from t in tratamientos
                                        join a in (from di in designerItems
                                                   select new TratamientoBE.Atencion
                                                   {
                                                       CodTratamiento = (di.Content as System.Windows.FrameworkElement).Tag.ToString()
                                                   })
                                        on t.CodTratamiento.Substring(0, 2) equals a.CodTratamiento.Substring(0, 2)
                                        select new TratamientoBE.Atencion
                                        {
                                            CodTratamiento = a.CodTratamiento,
                                            Descripcion = t.Descripcion,
                                            IdTratamiento = t.IdTratamiento,
                                            Precio = t.Precio
                                        }).ToList();

                        for (int i = 0; i < tratados.Count; i++)
                        {
                            tratados[i].Indice = i + 1;
                        }

                        // generar el archivo correspondiente

                        XElement designerItemsXML = SerializeDesignerItems(designerItems);
                        XElement root = new XElement("Root");
                        root.Add(designerItemsXML);

                        var archivo = AppDomain.CurrentDomain.BaseDirectory + Paciente.Dni.ToString() + ".xml";

                        if (File.Exists(archivo)) File.Delete(archivo);

                        root.Save(archivo);

                        // mostrar el resumen 

                        var vm = new ResumenViewModel(Paciente, tratados);
                        var view = new Resumen() { DataContext = vm };
                        view.Show();

                        CloseWindowEvent?.Invoke(this, null);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show(ex.Message);
                    }
                });
            }
        }

        

        #endregion

        #region funciones

        private static XElement SerializeDesignerItems(IEnumerable<DesignerItem> designerItems)
        {
            XElement serializedItems = new XElement("DesignerItems",
                                       from item in designerItems
                                       let contentXaml = XamlWriter.Save(((DesignerItem)item).Content)
                                       select new XElement("DesignerItem",
                                                  new XElement("Left", Canvas.GetLeft(item)),
                                                  new XElement("Top", Canvas.GetTop(item)),
                                                  new XElement("Width", item.Width),
                                                  new XElement("Height", item.Height),
                                                  new XElement("ID", item.ID),
                                                  new XElement("zIndex", Canvas.GetZIndex(item)),
                                                  new XElement("IsGroup", item.IsGroup),
                                                  new XElement("ParentID", item.ParentID),
                                                  new XElement("Content", contentXaml)
                                              )
                                   );

            return serializedItems;
        }

        #endregion        

        #region Implementacion vmbClose

        public event EventHandler CloseWindowEvent;

        public ICommand Cerrar
        {
            get
            {
                return new vmbCommand(execute =>
                {
                    CloseWindowEvent?.Invoke(this, null);
                });
            }
        }

        #endregion

    }
}
