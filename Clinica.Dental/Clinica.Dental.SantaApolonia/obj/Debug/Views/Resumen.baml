   M S B A M L   `   `   `  ����W  SClinica.Dental.SantaApolonia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Clinica.Dental.SantaApolonia.Views"Clinica.Dental.SantaApolonia.Views  5   	   _4clr-namespace:Clinica.Dental.SantaApolonia.ViewModel&Clinica.Dental.SantaApolonia.ViewModel  5   	   0    *Clinica.Dental.SantaApolonia.Views.Resumen   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:Clinica.Dental.SantaApolonia.Views     5   	   Cvm4clr-namespace:Clinica.Dental.SantaApolonia.ViewModel     5   	     � Title$  Resumen��5	   	   $	��380��6   $	��400��6&    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowState$ Normal=�5   	    � Icon$ /icono_cdsa.ico��5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	   
�������$��1q�62    � DataContext 5      =   7Clinica.Dental.SantaApolonia.ViewModel.ResumenViewModel  5   
   .��5      � $��4q�6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      �� 5      $��25 �6   �� 5      $��50 �6   .+�5   
   � $��0��6   
�����F�	 � ColumnDefinitions	 5      �� 5      $��40 �6#   �� 5      $��* �6#   �� 5      $��50 �6#   .+�5       F� 
�������
 �� Stretch$

 Fill=�6    $��8q�6/   �������j @]� �@o@@]� �@o@�ا ���j �ا ���j ��!�@o@��!�@o@@f���j @f���j ��j �@o@��j �@o@@KL ���j @KL Ѐ� �ا ���9 �ا р� ��� р� ��� �@KL ��� �@KL @]� � �0 @]� �@KL  R� �@KL ��� р� ��� ���-  z � 	=  z � 	=  	= р�  	= р� @KL ���- @KL ��� @f� 	= @f� 	= `���- `���- �I� 	= �I� 	= ��!р� ��!р�  -1�@KL  -1�@KL  $� р�  $� р� @f	6:   �� 5!      $��1��6   $��Center=�6$   $��Center=�6?   $
��Bold"�6\   
�������$��16(�6�   .��6�   Resumen de la atención5#      �� 5$      -   5         ��Name$ 	btnCerrar��5$   %   $��2��6    � ToolTip$ Cancelar��68   
�����F�
�������$��24��5&      $��24��6    ��6,   �� *Cerrar+.��5'      F� 
�����F�$

 Fill=�6(   $��3q�67   ����� b�  � ���!�����!��!Ѡ���!� �  b� �`�b ��!�@KL ��!�@KL ����Ӡ  � �@KL `�b �@KL @KL �`�b @KL � � �Ӡ Ѡ�@KL ���!@KL ���!`�b � b�  � 	6B   5(      5)      �� 5*   
   -   5         ��Name$ 	lvResumen��5*       $��1��6   
�������$
��4,15q�6G   $��Stretch=�5,      
�����F���5+      �� *LTratamientos+��5-      �� 5.      .R�5/      � 	 50      �� 51      $��20 �6/   �� 52      �� 53      $��80 �6/   .+�55      �� ��6$   �� *Indice+�� 56      $��1��6$   ��64   �� *Descripcion+�� 57      -   5        $��2��57   "    �� 	MaxLength$ 5��6�   ��62   �� *Precio+ �� Mode$ TwoWay=�6�   58      59      5;      �� 5<   
   $��2��6   $
��Left=�6!   
�����F���6<   �� *Total+$ OneWay=�6`   �� 5=   
   -   5         ��Name$ lblSumaTotal��5=   !   $��2��6   $��Right=�67   
�����F�6S   � 5>   
   $��3��6   	 5?      �� 5@      �� 5A      $��90 �6#   .+�5C      �� $��0��6   
�����F�$��2��6@   $
��10,0q�6K   �� 5D      $��1��6   $1 +Imprimir la boleta y Finalizar la atención��6%   $��40��6Z   
�����F�
���������5F   !   �� *	Finalizar+.��5G      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   $��Center=�6S   
�����F�.+�5H      F� 
������������ -1 z � 	=  z � 	= ��[ � -1��[ � -1��� 	= ��� 	=  � � -1 � � -1 	= � 	=  	= �,  	= �� ��J �� ��[ р� ��� 	=  -1 �� �� � -1 -1׀�O�� �� �� р�O��[ Ӏ�O��J ��A 	=  -1 	= 	6(   �� 5I      
�������$��11(�6/   .��6=   	Finalizar6H   5J      5K      5L      5M      5N      