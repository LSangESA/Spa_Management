   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLDV(LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLDV  5   	   E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  5   	   D    >LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLDV.W_InThongTinGoiDichVu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLDV     5   	   6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��wInGDV��5	   	     � Title$  W_InThongTinGoiDichVu��5   	   $	��800��6'   $	��690��64    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .    MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	     InThongTinGoiDichVuVM � DataContext# [ 5   	   ��5   	   Z� .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
   	   	EventName$	 Loaded��6   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
LoadWindow+   CommandParameter 5    $   ��  �� ElementName$ wInGDV��5!      .��5$      � .+�5%   
   �� 
���   �$��2q�6%    �� CornerRadius$ 10��69   ._�5&      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 10Q�6"   .��5'      � 
������� � RowDefinitions 5(      �� 5)      6*   �� 5*      $
��auto �6(   68   .+�5-      �� $��1��6!    �� Orientation$ 
Horizontal=�6.   $��Right=�6G   .+�5.      �� -   5           MaterialDesignOutlinedButton#��[ 5.   !    � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5/   !   $��10 10 10 10q�50   !   $��0q�51   !   $��40��52   !   $��Center=�53   !   
�������$��2q�54   4   
��� � �$	��150��56   !   
��� � �.��59      �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   $��Right=�6T   .+�5:   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Printer=�6:   $��0 0 10 0q�6I   $��25��6[   $��25��6f   �� 5;   "   $��In��6,   $��0 5 0 0q�66   6I   5<      5=      �� 5>      #��[ 6!   $/ )Resource name: MaterialDesignRaisedButton��5?   !   $��10 10 10 10q�5@   !   
�������$��2q�5C   4   
���  ��$��40��5E   !   $	��150��5F   !   
���  ����5A   !   �� *CommandClose+��5B   !   �� $ wInGDV��.��5H      �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   $��Right=�6T   .+�5I   "     $ CloseBox=�6:   $��0 0 10 0q�6J   $��25��6\   $��25��6g   �� 5J   "   $��Thoát��6,   $��0 5 0 0q�69   6L   5K      5L      5M      � 5O      -   5         �Name$ print��5O   (   $��0��6    5P      �� 5Q      $
��auto �6,   6<   �� 5R      6.   .+�5U      �� $��0��6%   $��0 20 0 0q�62   .+�5V      �� $��Sitka Subheading)�6(   $��Center=�5X   (   $��23(�5Y   (   $
��Bold"�5Z   (   ��5W   (   �� *	GDV_TEN+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5Z   <   � 5\       5]   "   �� 5^   &   66   �� 5_   &   66   �� 5`   &   66   �� 5a   &   66   .+�5d   "   � $��0��6'    � ColumnDefinitions 5e   &   �� 5f   *   $	��130 �6;   6I   �� 5g   *   6=   .+�5i   &   �� $��Sitka Subheading)�60   $��
Giá gói:��5j   0   $��15(�5k   0   $��
20 10 0 10q�6>   $��0��5l   0   �� 5m   &   $��Sitka Subheading)�60   $��15(�5o   0   $��
20 10 0 10q�6>   $��1��5p   0   ��5n   0   �� *DONGIA+ �� StringFormat$ 	0#,##0 đ��$ TwoWay=�$ PropertyChanged=�5p   0   5q   #   � 5r   "   $��1��6'    5s   &   �� 5t   *   $	��130 �6;   6I   �� 5u   *   6=   .+�5w   &   �� $��Sitka Subheading)�60   $��Lần liệu trình:��5x   0   $��15(�5y   0   $��
20 10 0 10q�6>   $��0��5z   0   �� 5{   &   $��Sitka Subheading)�60   $��15(�5}   0   $��
20 10 0 10q�6>   $��1��5~   0   ��5|   0   �� *	GDV_SOLAN+$ TwoWay=�$ PropertyChanged=�5~   0   5   #   � 5�   "   $��2��6'    5�   &   �� 5�   *   $	��130 �6;   6I   �� 5�   *   6=   .+�5�   &   �� $��Sitka Subheading)�60   $��	Mô tả:��5�   0   $��15(�5�   0   $��
20 10 0 10q�6>   $��0��5�   0   �� 5�   &   $��Sitka Subheading)�60   $��15(�5�   0   $��20 10 20 10q�6>   $��1��5�   0   $
��Wrap=�5�   0   ��5�   0   �� *
GDV_MOTA+$ TwoWay=�$ PropertyChanged=�5�   0   5�   #   � 5�   "   $��3��6'    5�   &   �� 5�   *   $	��130 �6;   6I   �� 5�   *   6=   .+�5�   &   �� $��Sitka Subheading)�60   $��Phương pháp:��5�   0   $��15(�5�   0   $��
20 10 0 10q�6>   $��0��5�   0   �� 5�   &   $��Sitka Subheading)�60   $��15(�5�   0   $��20 10 20 10q�6>   $��1��5�   0   $
��Wrap=�5�   0   ��5�   0   �� *PP_TEN_MOTA+$ TwoWay=�$ PropertyChanged=�5�   0   5�   #   5�      5�      � 5�      $��1��6    5�      �� 5�   "   $
��auto �60   6@   �� 5�   "   $
��auto �60   6@   �� 5�   "   62   .+�5�      �� $��Sitka Subheading)�6(   $"��Liệu trình thực hiện:��5�   (   $��18(�5�   (   $
��Bold"�5�   (   $��	20 20 0 0q�5�   (   $��0��5�   (   �� 5     $��2��5  '   ��5  '   �� *LTList+ �� SelectedItem 5  '   �� *SelectedItemLT+$ OneWayToSource=� �� View 5+  "   �� 5,  &   .P�54  *   �� $��Lần��69    �� CellTemplate 55  .   �� 56  2   .R�57  6   � .+�58  :   �� $��20 0 0 0q�6f   $��Center=�6x   
���   ���6D   �� *LIEUTRINH.LT_STT+6�   59  7   5:  3   5<  +   �� 5=  *   $��Liệu trình��69    5>  .   �� 5?  2   .R�5@  6   � .+�5A  :   �� $	��170��6g   $��20 0 0 0q�6s   $��Center=�6�   $
��Wrap=�6�   
���   ���6D   �� *LIEUTRINH.LT_MOTA+6�   5B  7   5C  3   5E  +   �� 5F  *   $��Ngày thứ��69    5G  .   �� 5H  2   .R�5I  6   � .+�5J  :   �� $��20 0 0 0q�6j   $��Center=�6|   
���   ���6D   �� *LIEUTRINH.LT_NGAYTHU+6�   5K  7   5L  3   5N  +   �� 5O  *   $��Thực hiện��69    5P  .   �� 5Q  2   .R�5R  6   � .+�5S  :   �� $��18 0 0 0q�6�   $��Center=�6�   
���   ���6D   �� *LIEUTRINH.LT_THOIGIANTH+$ 	0#,##0 đ��6�   5T  7   5U  3   5W  +   �� 5X  *   $��Giá liệu trình��69    5Y  .   �� 5Z  2   .R�5[  6   � .+�5\  :   �� $��20 0 0 0q�6v   $��Center=�6�   
���   ���6D   �� *DONGIA+$ 	0#,##0 đ��6�   5]  7   5^  3   5`  +   5a  '   5c     5e     5f     5g     5h     5i     5j     5k     