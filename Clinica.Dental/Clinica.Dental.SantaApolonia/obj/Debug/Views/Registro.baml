   M S B A M L   `   `   `  ����W  SClinica.Dental.SantaApolonia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Clinica.Dental.SantaApolonia.Views"Clinica.Dental.SantaApolonia.Views  5   	   _4clr-namespace:Clinica.Dental.SantaApolonia.ViewModel&Clinica.Dental.SantaApolonia.ViewModel  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   1    +Clinica.Dental.SantaApolonia.Views.Registro   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:Clinica.Dental.SantaApolonia.Views     5   	   Cvm4clr-namespace:Clinica.Dental.SantaApolonia.ViewModel     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  Registro��5
   	   $	��300��6   $	��800��6'    � WindowStartupLocation$ CenterScreen=�5   	    � WindowState$ Normal=�5   	    � Icon$ /icono_cdsa.ico��5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	   
�������$��1q�5       � DataContext 5      >   8Clinica.Dental.SantaApolonia.ViewModel.RegistroViewModel  5   
   .��5      � $��4q�6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      �� 5      $��50 �6   .+�5   
   � $��0��6   
�����F�	 � ColumnDefinitions	 5      �� 5      $��45 �6#   �� 5       $��* �6#   �� 5!      $��50 �6#   .+�5#      F� 
�������
 �� Stretch$

 Fill=�6    $��10q�6/   �������� ��� �$� ��� ��j ��� ��j �����j  -1���^ -1���^�����^��� p���� ��� ��� Ѐ�[ ��� р�[ ��j � 	= ��j � 	= ��� �@B ��� �@B  � � 	=  � � 	= ��� р�[ ��� р�[  � �@T�  � �@T� ��� ����  � ���! z   	=  	= ����  	=   	=  	= ��ا  z   	=  	= ����  �   	=  	= 	6;   �� 5$      $��1��6   $��Center=�6$   $��Center=�6?   $
��Bold"�6\   
�������$��16(�6�   .��6�   Registrar nuevo paciente5&      �� 5'      -   5         ��Name$ 	btnCerrar��5'   %   $��2��6    � ToolTip$ Cancelar��68   
�����F�
�������$��24��5)      $��24��6    ��6,   �� *Cerrar+.��5*      F� 
�����F�$

 Fill=�6(   $��3q�67   ����� b�  � ���!�����!��!Ѡ���!� �  b� �`�b ��!�@KL ��!�@KL ����Ӡ  � �@KL `�b �@KL @KL �`�b @KL � � �Ӡ Ѡ�@KL ���!@KL ���!`�b � b�  � 	6B   5+      5,      � 5-   
   $��1��6   $	��120��6   	 5.      �� 5/      $	��100 �6#   �� 50      �� 51      $	��140 �6#   �� 52       54      �� 55      �� 56      �� 57      �� 58      .+�5:      �� $��Right=�6   $��Center=�60   
�����F�$��DemiBold"�6b   .��6y   Dni :6�   �� 5;      $��1��6   $��Right=�6!   $��Center=�6=   
�����F�$��DemiBold"�6o   .��6�   	Nombres :6�   �� 5<      $��2��6   $��Right=�6!   $��Center=�6=   
�����F�$��DemiBold"�6o   .��6�   Apellidos :6�   �� 5=      $��3��6   $��Right=�6!   $��Center=�6=   
�����F�$��DemiBold"�6o   .��6�   	Celular :6�   �� 5?      -   5         ��Name$ txtDni��5?   3   $��1��6   $��0��6&   $��Center=�6C   $
��Left=�6^   $	��100��6y    �� 	MaxLength$ 8��6�   ��6�   �� *Paciente.Dni+ �� Mode$ TwoWay=�6�   �� 5@      -   5        $ 
txtNombres��5@   3   $��1��6   $��1��6&   $��Center=�6G   ��6b   �� *Paciente.Nombres+$ TwoWay=��� 5A      -   5        $ txtApellidos��5A   3   $��1��6   $��2��6&   $��Center=�6I   ��6d   �� *Paciente.Apellidos+$ TwoWay=��� 5B      -   5        $ 
txtCelular��5B   3   $��1��6   $��3��6&   $��Center=�6G   $
��Left=�6b   $	��100��6}   $ 12��6�   ��6�   �� *Paciente.Celular+$ TwoWay=�6�   �� 5D      $��2��6   $��0��6$   $��Right=�61   $��Center=�6M   
�����F�$��DemiBold"�6   .��6�   
Correo :6�   �� 5E      $��2��6   $��1��6$   $��Right=�61   $��Center=�6M   
�����F�$��DemiBold"�6   .��6�   Sexo :6�   �� 5F      $��2��6   $��2��6$   $��Right=�61   $��Center=�6M   
�����F�$��DemiBold"�6   .��6�   Fecha nacimiento :6�   �� 5G      $��2��6   $��3��6$   $��Right=�61   $��Center=�6M   
�����F�$��DemiBold"�6   .��6�   Estado civil :6�   �� 5I      -   5        $ 	txtCorreo��5I   3   $��3��6   $��0��6&   $��Center=�6F   ��6a   �� *Paciente.Correo+$ TwoWay=��� 5J      -   5         ��Name$ cbSexo��5J   4   $��3��6   $��1��6'   $��Center=�6D   $
��Left=�6_    �� SelectedValuePath$ Value��5L       �� DisplayMemberPath$	 Key��61    �� SelectedIndex$ 0��6I    �� SelectedValue 5K      �� *Paciente.Sexo+$ TwoWay=���6L   ��  �� Path$ 	ListaSexo�5L   I   (  "System.Windows.Controls.DatePicker  5M      -   5          Name$ txtFchNacimiento��5M   6   $��3��6   $��2��6)   $��Center=�6P   $
��Left=�6k   $	��130��6�      SelectedDate 5N      �� *Paciente.FchNacimiento+$ TwoWay=��� 5P      -	   5        $ cbEstadoCivil��5P   4   $��3��6   $��3��6'   $��Center=�6K   $
��Left=�6f   $ Value��5R      $	 Key��61   $ 0��6I    5Q      �� *Paciente.EstadoCivil+$ TwoWay=���6S   �� $ ListaEstados�5R   I   5S      � 5j   
   $��4��6   	 5k      �� 5l      �� 5m      $��90 �6#   .+�5o      �� $��4��6   
�����F�$��2��6=   $��0,0,10,0q�6H   �� 5v      -
   5        $ btnRegistrar��5v   %   $��1��6   $ Registrar nuevo paciente��6;   $��40��5w      
�����F�
���������5y      �� *	Registrar+.��5z      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   $��Center=�6S   
�����F�.+�5{      F� 
��������������� @T� �@KL @T� �@KL @KL ���� @KL � � ��!�@T�  $� ���- ��- � � @]� ���- ��- ����  $� ���- ��- � � ��!���- ��- �@f��- �@KL ��- �P[; ��- ��- `�; ��- @KL ���- ��!�@KL @o@ �� �� ���!@o@�@o@��! �� �� �@o@��j �@f��- 	6(   �� 5|      
�������.��6/   	Registrar6:   5}      5~      5      5�      5�      