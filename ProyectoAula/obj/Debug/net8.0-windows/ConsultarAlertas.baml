   M S B A M L   `   `   `  ����G  CProyectoAula, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ProyectoAulaProyectoAula  5      #    ProyectoAula.ConsultarAlertas   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ProyectoAula     5        N� Title$  ConsultarAlertas��5	       � 	Resources 5         RoundedButton �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius  RoundedCheckBox  RoundedDatePicker(  "System.Windows.Controls.DatePicker��%,  &	        &	 �    &	 T    �� 5   
   " ��6&   .�5      ��  � �� �#2EA0436+   �� 5       � ��
 �����6+   �� 5       � ��$ 14(�6)   �� 5       � ��$ SemiBold"�6+   �� 5       � ��$ 15,10q�6(   �� 5       � ��$ 0q�60   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $ 8��6K   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5      5      �� 5   
   " ��6(   .�5      ��  � ��
 �����6+   �� 5        � ��$ 14(�6)   �� 5!       � ��$	 0,5q�6'   5"      �� 5$   
   "  6*   .�5%      ��  � �� �#0D11176+   �� 5&       � ��
 �����6+   �� 5'       � ��$ 0q�60   �� 5(       � ��$ 5q�6(   5)      5*      .��5,      � ���#1B1F24 � ColumnDefinitions 5-   
   �� 5.      $	��300 �6   �� 5/      $��* �6   .+�53   
   �� $��0��6   ���#252B32$ 12��66   $��10q�6H   ._�54      �� $��20q�6   .+�55      �� $��Filtros��6   $��24(�56      $
��Bold"�57      
�������$��Center=�59      $��0,0,0,20q�5:      �� 5<      $��Tipos de Alerta��6   
�������$��18(�5>      $��0,0,0,10q�5?      �� 5A      $��Alerta Accidente��6   #��[ 66   �� 5B      $��Alerta Robo��6   #��[ 61   �� 5C      $��Zona Segura��6   #��[ 61   �� 5D      $��Zona Peligrosa��6   #��[ 64   �� 5F      $��Rango de Fechas��6   
�������$��18(�5H      $��	0,20,0,10q�5I      �� 5K      $��Desde:��6   
�������$	��0,5q�6=     5L      #��[ 6   �� 5N      $��Hasta:��6   
�������$��0,10,0,5q�6=     5O      #��[ 6   �� 5Q      $��Aplicar Filtros��6   #��[  5R      $��0,20,0,0q�5S      5T      5U      �� 5X   
   $��1��6   ���#0D1117$ 12��66   $��10q�6H   ._�5Y      � $��20q�6    � RowDefinitions 5Z      �� 5[      $
��Auto �6$   �� 5\      $��* �6$   .+�5_      �� $��Listado de Alertas��6   $��24(�5`      $
��Bold"�5a      
�������$��Center=�5c      $��0,0,0,20q�5d      &   System.Windows.Controls.DataGrid  5f      $��1��6   
������ 	   RowBackground	 �#252B32
   AlternatingRowBackground
 �#1E2329$��0q�5j         GridLinesVisibility$
 None=�5k         HeadersVisibility$ Column=�5l         
IsReadOnly$
 True��5m         AutoGenerateColumns$ False��5n       5o      =  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�   '        �� 5p      "  6    .�5q      ��  � �� �#2C3E506;   �� 5r       � ��
 �����6;   �� 5s       � ��$
 10,5q�68   5t      5u         Columns 5v      0  *System.Windows.Controls.DataGridTextColumn  5w      ,  &System.Windows.Controls.DataGridColumn   Header$
 Tipo��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Tipo+6T     5x      $ Fecha��6-   $
 Auto 6V    6<   �� *Fecha+6V     5y      $ Descripción��6-   $ * 6b    6B   �� *Descripcion+6b   5{      5|      5}      5~      5      