﻿#pragma checksum "..\..\..\Views\Registro.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2950D3CA272E1483A3085D500CF59C4BD93FF04F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Clinica.Dental.SantaApolonia.ViewModel;
using Clinica.Dental.SantaApolonia.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Clinica.Dental.SantaApolonia.Views {
    
    
    /// <summary>
    /// Registro
    /// </summary>
    public partial class Registro : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\Views\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCerrar;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Views\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDni;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Views\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombres;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Views\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtApellidos;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Views\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCelular;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Views\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCorreo;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Views\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSexo;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Views\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtFchNacimiento;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Views\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbEstadoCivil;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\Views\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegistrar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Clinica.Dental.SantaApolonia;component/views/registro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Registro.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnCerrar = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.txtDni = ((System.Windows.Controls.TextBox)(target));
            
            #line 63 "..\..\..\Views\Registro.xaml"
            this.txtDni.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextInputSoloNumeros);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtNombres = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtApellidos = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtCelular = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\..\Views\Registro.xaml"
            this.txtCelular.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextInputSoloNumeros);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtCorreo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cbSexo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.txtFchNacimiento = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.cbEstadoCivil = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.btnRegistrar = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

