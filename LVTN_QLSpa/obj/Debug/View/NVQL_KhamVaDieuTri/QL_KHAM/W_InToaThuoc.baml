   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM*LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM  5   	   E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  5
   	   =    7LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM.W_InToaThuoc   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Jlocal8clr-namespace:LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM     5   	   6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     5
   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��	wToaThuoc��5   	     � Title$  W_InToaThuoc��5   	   $	��800��6   $	��600��6+    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .    MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	     InToaThuocVM � DataContext# [ 5   	   ��5   	   Z� .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
   	   	EventName$	 Loaded��6   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
LoadWindow+   CommandParameter 5   $   ��  �� ElementName$ 	wToaThuoc��5       .��5"      � .+�5#   
   �� 
���   �$��2q�6%    �� CornerRadius$ 15 15 15 15��69   ._�5$      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�6"   .��5%      � 
������� � RowDefinitions 5&      �� 5'      6*   �� 5(      $
��auto �6(   68   .+�5,      �� $��1��6!    �� Orientation$ 
Horizontal=�6.   $��Right=�6G   .+�5-      �� -   5           MaterialDesignOutlinedButton#��[ 5-   !    � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5.   !   $��10 10 10 10q�5/   !   $��0q�50   !   $��40��51   !   $��Center=�52   !   
�������$��2q�53   4   
��� � �$	��150��55   !   
��� � �.��58      �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   $��Right=�6T   .+�59   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Printer=�6:   $��0 0 10 0q�6I   $��25��6[   $��25��6f   �� 5:   "   $��In��6,   $��0 5 0 0q�66   6I   5;      5<      �� 5=      #��[ 6!   $/ )Resource name: MaterialDesignRaisedButton��5>   !   $��10 10 10 10q�5?   !   
�������$��2q�5B   4   
���  ��$��40��5D   !   $	��150��5E   !   
���  ����5@   !   �� *CommandThoat+��5A   !   �� $ 	wToaThuoc��.��5G      �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   $��Right=�6T   .+�5H   "     $ CloseBox=�6:   $��0 0 10 0q�6J   $��25��6\   $��25��6g   �� 5I   "   $��Thoát��6,   $��0 5 0 0q�69   6L   5J      5K      5L      � 5N      -   5        $��print��5N   (   $��0��6    5O      �� 5P      $
��auto �6,   6<   �� 5Q      6.   .+�5U      � $��0��6   .+�5V      �� $��TOA THUỐC��6(   $��Center=�5W   (   $��40(�5X   (   $��10q�5Y   (   $��0��5Z   (   5[      5\      � 5^      $��1��6    5_      �� 5`   "   $
��auto �60   6@   �� 5a   "   $
��auto �60   6@   .+�5e      � $��0��6#   .+�5f   "   �  � ColumnDefinitions 5g   &   �� 5h   *   $
��auto �6;   6J   �� 5i   *   6=   .+�5l   &   � $��0��6+    5m   *   �� 5n   .   $
��auto �6<   6L   �� 5o   .   $
��auto �6<   6L   �� 5p   .   $
��auto �6<   6L   �� 5q   .   $
��auto �6<   6L   �� 5r   .   $
��auto �6<   6L   �� 5s   .   $
��auto �6<   6L   �� 5t   .   $
��auto �6<   6L   �� 5u   .   $
��auto �6<   6L   .+�5x   *   �� $��Số phiếu DT: ��64   $
��Bold"�6I   $��0��6[   $��15(�6h   $��25 5 0 5q�6v   6�   �� 5y   *   $��Liệu trình: ��64   $
��Bold"�6H   $��1��6Z   $��15(�6g   $��25 5 0 5q�6u   6�   �� 5z   *   $��Dịch vụ: ��64   $
��Bold"�6E   $��3��6W   $��15(�6d   $��25 5 0 5q�6r   6�   �� 5{   *   $��Ông, bà: ��64   $
��Bold"�6E   $��4��6W   $��15(�6d   $��25 5 0 5q�6r   6�   �� 5|   *   $��Chuẩn đoán: ��64   $
��Bold"�6H   $��5��6Z   $��15(�6g   $��25 5 0 5q�6u   6�   �� 5}   *   $��Lời dặn: ��64   $
��Bold"�6E   $��6��6W   $��15(�6d   $��25 5 0 5q�6r   6�   �� 5~   *   $��Ngày khám: ��64   $
��Bold"�6G   $��7��6Y   $��15(�6f   $��25 5 0 5q�6t   6�   5�   '   � 5�   &   $��1��6+    5�   *   �� 5�   .   $
��auto �6<   6L   �� 5�   .   $
��auto �6<   6L   �� 5�   .   $
��auto �6<   6L   �� 5�   .   $
��auto �6<   6L   �� 5�   .   $
��auto �6<   6L   �� 5�   .   $
��auto �6<   6L   �� 5�   .   $
��auto �6<   6L   �� 5�   .   $
��auto �6<   6L   �� 5�   .   $
��auto �6<   6L   �� 5�   .   6>   .+�5�   *   �� $
��Bold"�6r   $��0��6�   $��15(�6�   $��25 5 0 5q�6�   ��64   �� *	PDT_STT+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5�   *   $
��Bold"�6r   $��1��6�   $��15(�6�   $��25 5 0 5q�6�   ��64   �� *	LT_MOTA+$ PropertyChanged=�6�   �� 5�   *   $
��Bold"�6r   $��2��6�   $��15(�6�   $��25 5 0 5q�6�   ��64   �� *	GDV_TEN+$ PropertyChanged=�6�   �� 5�   *   $
��Bold"�6s   $��3��6�   $��15(�6�   $��25 5 0 5q�6�   ��64   �� *
KH_HOTEN+$ PropertyChanged=�6�   �� 5�   *   $
��Bold"�6x   $��4��6�   $��15(�6�   $��25 5 0 5q�6�   ��64   �� *PDT_CHUANDOAN+$ PropertyChanged=�6�   �� 5�   *   $
��Bold"�6u   $��5��6�   $��15(�6�   $��25 5 0 5q�6�   ��64   �� *
PDT_LOIDAN+$ PropertyChanged=�6�   �� 5�   *   $
��Bold"�6�   $��6��6�   $��15(�6�   $��25 5 0 5q�6�   ��64   �� *NGAY+$ PropertyChanged=� �� StringFormat$ 
dd/MM/yyyy��6�   5�   '   5�   #   5�      � 5�      $��1��6#   $��0 10 0 0q�60   .+�5�   "   �� $��1��5�   +   $��0 10 0 0q�68   
������ 
������ {�.  ��5�   +   �� *CHIDINHList+ �� SelectedItem 5�   +   �� *SelectedItemCHIDINH+ �� Mode$ OneWayToSource=���5�   &   �� 5�   *   .R�5�   .   �  5�   2   �� 5�   6   $
��1.6* �6G   6V   �� 5�   6   6I   .+�5�   2   � $��0��67   .+�5�   6   �� $
��Left=�6A   .+�5�   :   �� $
��Left=�6E   $ 
Horizontal=�6`   .+�5�   >   ��  �� TextAlignment$ Center=�5�   H   $
��Wrap=�5�   H   $��15(�5�   H   $��25,0,0,0q�6V   $��Center=�5�   H   $��Sitka Subheading)�5�   H   $
��Bold"�5�   H   $��Italic$�5�   H   
���   ���5�   H   �� *T_STT+5�   H   �� 5�   >   $��Sitka Subheading)�5�   H   $��Center=�5�   H   $��17(�5�   H   $
��Bold"�5�   H   $��Italic$�5�   H   
���   ���5�   H   �� *T_TEN+$ TwoWay=�$ PropertyChanged=�5�   ?   �� 5�   >   $��Sitka Subheading)�5�   H   $��Center=�5�   H   $��17(�5�   H   $
��Bold"�5�   H   $��Italic$�5�   H   
���   ���5�   H   �� *	DVT_TEN+$ TwoWay=�$ PropertyChanged=�5�   ?   5�   ;   �� 5�   :   $
��Left=�6E   $ 
Horizontal=�6`   .+�5�   >   �� $��Sitka Subheading)�5�   H   $��Center=�5�   H   $��15(�5�   H   $��25,0,0,0q�5�   H   $
��Bold"�5�   H   
���   ���5�   H   �� *CD_LIEUDUNG+$ TwoWay=�$ PropertyChanged=�5�   ?   �� 5�   >   $��Sitka Subheading)�5�   H   $��Center=�5�   H   $��15(�5�   H   $
��Bold"�5�   H   
���   ���5�   H   �� *CD_CACHDUNG+$ TwoWay=�$ PropertyChanged=�5�   ?   5�   ;   5�   7   5�   3   � 5�   2   $��1��67   .+�5�   6   �� $ 
Horizontal=�6A   .+�5�   :   �� $��Số lượng: ��6D   $��Sitka Subheading)�5�   D   $��Center=�5�   D   $��15(�5�   D   $
��Bold"�5�   D   
���   �5�   ;   �� 5�   :   $��Sitka Subheading)�5�   D   $��Center=�5�   D   $��15(�5�   D   $
��Bold"�5�   D   
���   ���5�   D   �� *
CD_SOLUONG+$ TwoWay=�$ PropertyChanged=�5�   ;   5�   7   5�   3   5�   /   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      