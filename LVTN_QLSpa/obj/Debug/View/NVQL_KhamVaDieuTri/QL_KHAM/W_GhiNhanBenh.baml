   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM*LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM  5   	   E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  5   	   >    8LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM.W_GhiNhanBenh   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Jlocal8clr-namespace:LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM     5   	   6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  wGhiNhanBenh��5	   	    � Title$ GHI NHẬN BỆNH��5   	   $	��800��6   $
��1450��6,    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .    MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	     GhiNhanBenhVM � DataContext# [ 5   	   ��5   	   Z� .  (System.Windows.Interactivity.Interaction	   Triggers	 5      /  )System.Windows.Interactivity.EventTrigger  5   
   
   	EventName$
 Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
LoadWindow+   CommandParameter 5   $   ��  �� ElementName$ wGhiNhanBenh��5       .��5"      � .+�5#   
   �� 
���   �$��2q�6%    �� CornerRadius$ 15 15 15 15��69   ._�5$      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�6#   ���	#FFF7F7F7.��5%      �  � RowDefinitions 5&      �� 5'      $
��auto �6(   68   �� 5(      6*   .+�5+      � $��0��6   .+�5,      ,   &LVTN_QLSpa.UserControlSpa.UseControlUC  
 � Tag 6*   �� *Title+$ wGhiNhanBenh��6\   5-      � 5/      $��1��6    � ColumnDefinitions 50      �� 51      $
��0.3* �6/   6>   �� 52      $
��1.7* �6/   6>   .+�55        $��
10 10 0 10q�6.   $ 10Q�6B   $��0��6[   .��56      �� $��Lịch sử điều trị��6'     MaterialDesignGroupBox#���  57   '   $��10 10 10 30q�58   '   .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ 
PrimaryMid=�59   '      
Background �	#FF2D2F4C   
Foreground
 �   �.��5<   "   �� -   5        $��lbxPhieuDangKy��5>   "   ��5<   *   �� *PHIEUDIEUTRI+ �� SelectedItem 5=   "   �� *SelectedPHIEUDIEUTRI+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�	 5?   &     5@   *   $
 SelectionChanged��69   . 5A   .      6D   �� *CommandSelectedPHIEUDANGKY+ 5B   <   �� $ lbxPhieuDangKy��5C   +   ��5E   &   �� 5F   *   .R�5G   .   ��  �� Orientation$ 
Horizontal=�69   .+�5H   2   �� 
���   �$
��Bold"�5J   <   ��5H   <   �� *PDT_NGAYLAP+ �� StringFormat$ dd/MM/yyyy hh:mm��5J   P   5K   /   5L   +   5N   #   5O      5P      � 5R      $��1��6    5S      �� 5T   "   $
��auto �60   6@   �� 5U   "   $��70 �60   6>   .+�5X      � $��0��6#    5Y   "   �� 5Z   &   69   �� 5[   &   69   .+�5^   "     $��0��66   $ 10Q�6F   $��10q�6_   .��5_   &   �  5`   *   �� 5a   .   $
��auto �6<   6L   �� 5b   .   6>   .+�5e   *   �� $��Thông tin khách hàng��63   #���  5f   )   $��10 10 10 10q�5g   *   $ 
PrimaryMid=�5h   )    �	#FF2D2F4C
 �����$��0��5k   #   .��5l   .   �  5m   2   �� 5n   6   6I   �� 5o   6   6I   .+�5q   2   � $��0��67    5r   6   �� 5s   :   6J   �� 5t   :   6J   �� 5u   :   6J   .+�5w   6   �� )	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ Tên khách hàng��6>    % !MaterialDesignFloatingHintTextBox#��[ 5x   >   $��15 10 15 10q�5y   >   {�.  
���   �$
��Bold"�5|   >   $��0��5~   >   ��5}   >   �� *KH_TEN+$ TwoWay=�$ PropertyChanged=�.��5~   K   5   7   �� 5�   6   $ Tuổi��6>   #��[ 5�   >   $��15 10 15 10q�5�   >   {�.  
���   �$
��Bold"�5�   >   $��1��5�   >   ��5�   >   �� *	KH_TUOI+$ TwoWay=�$ PropertyChanged=�.��5�   K   5�   7   �� 5�   6   $ Giới tính��6>   #��[ 5�   >   $��15 10 15 10q�5�   >   {�.  
���   �$
��Bold"�5�   >   $��2��5�   >   ��5�   >   �� *KH_GIOITINH+$ TwoWay=�$ PropertyChanged=�.��5�   K   5�   7   5�   3   � 5�   2   $��1��67    5�   6   �� 5�   :   6J   �� 5�   :   6J   �� 5�   :   6J   .+�5�   6   �� $ Số điện thoại��6>   #��[ 5�   >   $��15 10 15 10q�5�   >   {�.  
���   �$
��Bold"�5�   >   $��0��5�   >   ��5�   >   �� *KH_SDT+$ TwoWay=�$ PropertyChanged=�.��5�   K   5�   7   �� 5�   6   $ Email��6>   #��[ 5�   >   $��15 10 15 10q�5�   >   {�.  
���   �$
��Bold"�5�   >   $��1��5�   >   ��5�   >   �� *
KH_EMAIL+$ TwoWay=�$ PropertyChanged=�.��5�   K   5�   7   �� 5�   6   $ Địa chỉ��6>   #��[ 5�   >   $��15 10 15 10q�5�   >   {�.  
���   �$
��Bold"�5�   >   $��2��5�   >   ��5�   >   �� *	KH_DIACHI+$ TwoWay=�$ PropertyChanged=�.��5�   K   5�   7   5�   3   5�   /   5�   +   �� 5�   *   $��Thông tin điều trị��63   #���  5�   +   $��10 10 10 10q�5�   +   $ 
PrimaryMid=�5�   +    �	#FF2D2F4C
 �����$��1��5�   +   .��5�   .   �  5�   2   �� 5�   6   $
��auto �6D   6T   �� 5�   6   $
��auto �6D   6T   �� 5�   6   $
��auto �6D   6T   �� 5�   6   $
��auto �6D   6T   �� 5�   6   $
��auto �6D   6T   �� 5�   6   $
��auto �6D   6T   �� 5�   6   $
��auto �6D   6T   .+�5�   2   � $��0��67    5�   6   �� 5�   :   6M   �� 5�   :   6M   .+�5�   6   �� $! Gói dịch vụ đăng ký��6>   #��[ 5�   >   $��	15 7 15 7q�5�   >   {�.  $��0��5�   >   
���   �$
��Bold"�5�   >   ��5�   >   �� *	GDV_TEN+$ TwoWay=�$ PropertyChanged=�.��6�   5�   7   �� 5�   6   $ Loại gói dịch vụ��6>   #��[ 5�   >   $��	15 7 15 7q�5�   >   {�.  $��1��5�   >   
���   �$
��Bold"�5�   >   ��5�   >   �� *
LGDV_TEN+$ TwoWay=�$ PropertyChanged=�.��6�   5�   7   5�   3   � 5�   2   $��1��67    5�   6   �� 5�   :   6M   �� 5�   :   6M   .+�5�   6   �� $  Số phiếu điều trị��6>   #��[ 5�   >   $��	15 7 15 7q�5�   >   {�.  $��0��5�   >   
���   �$
��Bold"�5�   >   ��5�   >   �� *	PDT_STT+$ TwoWay=�$ PropertyChanged=�.��6�   5�   7   �� 5�   6   $! Liệu trình điều trị��6>   #��[ 5�   >   $��	15 7 15 7q�5�   >   {�.  $��1��5�   >   
���   �$
��Bold"�5�   >   ��5�   >   �� *LT_STT_MOTA+$ TwoWay=�$ PropertyChanged=�.��6�   5�   7   5�   3   �� 5�   2   $ Ngày khám��6:   #��[ 5�   :   $��	15 7 15 7q�5�   :   {�.  $��2��5�   :   
���   �$
��Bold"�5  :   ��5  :   �� *PDT_NGAYKHAM+$ 
dd/MM/yyyy��$ TwoWay=�$ PropertyChanged=�.��6�   5  3   �� 5  2   $ Chuẩn đoán��6:   #��[ 5  6   $��	15 7 15 7q�5  6   $��3��5  6   ��5  6   �� *PDT_CHUANDOAN+$ TwoWay=�$ PropertyChanged=�.��6�   5	  3   �� 5
  2   $ Lời đặn��6:   #��[ 5  6   $��	15 7 15 7q�5  6   $��4��5  6   ��5  6   �� *
PDT_LOIDAN+$ TwoWay=�$ PropertyChanged=�.��6�   5  3   �� 5  2   $ Ghi chú��6:   #��[ 5  :   $��15 10 15 10q�5  :   $��5��5  :   ��5  :   �� *
PDT_GHICHU+$ TwoWay=�$ PropertyChanged=�.��6�   5  3   � 5  2   $��6��67    5  6   �� 5  :   6M   �� 5  :   6M   .+�5  6   �� $ Ngày khám tiếp theo��6>   #��[ 5  >   $��	15 7 15 7q�5  >   {�.  $��0��5  >   
���   �$
��Bold"�5!  >   ��5"  >   �� *	LTDT_NGAY+$ 
dd/MM/yyyy��$ TwoWay=�$ PropertyChanged=�.��6�   5#  7   �� 5$  6   $ Thời gian đến��6>   #��[ 5%  >   $��	15 7 15 7q�5&  >   {�.  $��1��5(  >   
���   �$
��Bold"�5*  >   ��5+  >   �� *LTDT_THOIGIAN+$ TwoWay=�$ PropertyChanged=�.��6�   5,  7   5-  3   5/  /   50  +   51  '   52  #     54  "   $��1��66   $ 10Q�6F   $��
0 10 10 10q�6_   .��55  &   � $��0��6+    56  *   �� 57  .   6>   �� 58  .   6>   .+�5;  *   � $��0��6/    5<  .   �� 5=  2   -   5         ��Name$ rdCDDT��5=  @   6R   �� 5>  2   -   5        $
 rdTT��5>  @   6P   .+�5@  .   � -   5         �Name$ grdCDDT��5@  @   $��0��63   .+�5A  2   �� $��Kê đơn thuốc��6;   #���  5B  ;   $��10 10 10 10q�5C  ;   $ 
PrimaryMid=�5D  ;    �	#FF2D2F4C
 �����.��5G  6   �� .+�5H  :   �  5I  >   �� 5J  B   6U   �� 5K  B   $��60 �6S   6`   .+�5N  >   �� -   5        $��txtSearchThuoc��5R  F   $ Thuốc��5N  F   #��[ 5O  F   $��15 15 15 15q�5P  F   $��0��5Q  F   ��5S  F   �� *TextSearchThuoc+$ TwoWay=�$ PropertyChanged=�.��6�   	 5T  B     5U  F   $
 TextChanged��6U   . 5V  J      6`   �� *CommandSearchThuoc+ 5W  a   �� $ txtSearchThuoc��5X  G   .��5Y  Z   5Z  ?   �� 5\  >   -   5           MaterialDesignOutlinedButton#��[ 5\  E    � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5]  E   +
  %MaterialDesignThemes.Wpf.ButtonAssist  
  CornerRadius$  0��5^  E   
�������$��2q�5_  X   
���   �$��0q�5a  E   $��50��5b  E   
���   �$��1��5d  E   .��5f  B   '  !MaterialDesignThemes.Wpf.PackIcon  !   Kind$
! Plus=�6Z   $��20��6f   $��20��6q   5g  ?   5h  ;   � 5i  :    5j  >   �� 5k  B   6U   �� 5l  B   6U   .+�5o  >   �� $ Số lượng��6F   #��[ 5p  F   $��15 15 15 15q�5q  F   $��0��5r  F   ��5s  F   �� *
CD_SOLUONG+$ TwoWay=�$ PropertyChanged=��� 5t  >   $ Liều dùng��6F   #��[ 5u  F   $��15q�5v  F   $��1��5w  F   ��5x  F   �� *CD_LIEUDUNG+$ TwoWay=�$ PropertyChanged=�5y  ;   �� 5z  :   $ Cách dùng��6B   #��[ 5{  B   $��15q�5|  B   ��5}  B   �� *CD_CACHDUNG+$ TwoWay=�$ PropertyChanged=�� 5~  :   $��0 20 0 0q�6?    5  >   �� 5�  B   6U   �� 5�  B   6U   .+�5�  >   ��   MaterialDesignRaisedButton#��[ 6E   $/ )Resource name: MaterialDesignRaisedButton��5�  E   $��0��5�  E   $��Nhập��5�  E   $��	15 8 15 8q�5�  E   $��30��5�  E   ���	#FF43D05E$��0q�5�  \   
���   ���5�  E   �� *CommandAddCHIDINH+5�  ?   �� 5�  >   #��[ 6E   $/ )Resource name: MaterialDesignRaisedButton��5�  E   $��1��5�  E   $
��Xóa��5�  E   $��	15 8 15 8q�5�  E   $��30��5�  E   ���	#FFF45757$��0q�5�  \   
���   ���5�  E   �� *CommandDeleteCHIDINH+5�  ?   5�  ;   5�  7   5�  3   5�  /     5�  .   $	��153��6B   $	��475��5�  B   $��29,90,90,61.4q�5�  B   y�5�  B   �� *HienThiListBox+.��5�  2   �� .��5�  6   �� -   5        $��lbxThuoc��5�  >   $��0,0,0.2,-0.4q�5�  >   " �� DisplayMemberPath$" T_TEN��5�  >   ��5�  >   �� *	ListThuoc+ 5�  >   �� *SelectedTHUOC+$ TwoWay=�$ PropertyChanged=�	 5�  :     5�  >   $
 SelectionChanged��6M   . 5�  B      6X   �� *CommandSelectedThuoc+ 5�  X   �� $ 	txtNV_TEN��5�  ?   5�  7   5�  3   5�  /   � 5�  .   -	   5        $ grdTT��5�  @   $��1��63   .+�5�  2   �� #���  6;   $��10 10 10 10q�5�  ;   $ 
PrimaryMid=�5�  ;    �	#FF2D2F4C
 �������5�  6   �� 5�  :   .R�5�  >   �� $ 
Horizontal=�6I   $��20��6b   .+�5�  B   �� -
   5         & "MaterialDesignToolForegroundButton#��[ 5�  I   $
��Left=�5�  I   $��Center=�5�  I   .��5�  F     $! 	ArrowLeft=�6^   
�������5�  V   5�  C   �� 5�  B   $��Thêm danh mục thuốc��6L   $��Center=�5�  L   $��10 0 0 0q�5�  L   6`   5�  ?   5�  ;   .��5�  6   �  5�  :   �� 5�  >   $
��auto �6L   6\   �� 5�  >   $
��auto �6L   6\   �� 5�  >   $
��auto �6L   6\   �� 5�  >   $
��auto �6L   6\   �� 5�  >   $
��auto �6L   6\   .+�5�  :   �� $ Tên thuốc��6B   #��[ 5�  B   $��	15 5 15 5q�5�  B   $��0��5�  B   ��5�  B   �� *T_TEN+$ TwoWay=�$ PropertyChanged=�.��5�  O   5�  ;   �� 5�  :   $ Hoạt chất��6C   $��1��5�  C   $��	15 5 15 5q�5�  C    & "MaterialDesignFloatingHintComboBox#��[ 5�  C   $" HC_TEN��5�  C   ��5�  C   �� *BIETDUOCAdd+ 5�  C   �� *SelectedBIETDUOCAdd+$ TwoWay=�$ PropertyChanged=�5�  ;   �� 5�  :   $ Đơn vị tính��6C   $��2��5�  C   $��	15 5 15 5q�5�  C   #��[ 5�  C   $" DVT_TEN��5�  C   ��5�  C   �� *DVT+ 5�  C   �� *SelectedDVT+$ TwoWay=�$ PropertyChanged=�5�  ;   �� 5�  :   $ Nhà sản xuất��6C   $��3��5�  C   $��	15 5 15 5q�5�  C   #��[ 5�  C   $" NSX_TEN��5�  C   ��5�  C   �� *NSX+ 5�  C   �� *SelectedNSX+$ TwoWay=�$ PropertyChanged=�5�  ;   �� 5�  :   #��[ 6A   $/ )Resource name: MaterialDesignRaisedButton��5�  A   $��
15 30 15 5q�5�  A   $��30��5�  A   $��4��5�  A   $  5��5�  A   ���	#FF43D05E$��0q�5�  X   
���   �$��Bottom=�5�  A   ��5�  A   �� *CommnadAddThuoc+.��5�  >   �� $ 
Horizontal=�6I   .+�5�  B     $! ContentSaveEdit=�6Z   $��25��6q   $��25��6|   $��0 0 10 0q�6�   $��Center=�6�   �� 5�  B   $��Lưu thuốc��6L   $��Center=�6]   6z   5�  ?   5�  ;   5�  7   5�  3   5�  /   5�  +   �� 5�  *   $��Toa thuốc��63   #���  5   /   $��10 10 10 10q�5  /   $ 
PrimaryMid=�5  /    �	#FF2D2F4C
 �����$��1��5  /   .��5  .   �� -   5        $��
lvwCHIDINH��5  /   ��5  7   �� *ListCHIDINH+ 5  /   �� *SelectedCHIDINH+$ OneWayToSource=�	 5	  2     5
  6   $
 SelectionChanged��6E   . 5  :      6P   �� *CommandSelectedCHIDINH+ 5  <   �� $ 
lvwCHIDINH��5  7   # �� View# 5  2   �� 5  6   .P�5  :   �� $	��STT��6I   $ �� Width$$ 90��6V   % �� CellTemplate% 5  >   �� 5  B   .R�5  F   � .+�5  J   �� $��20 0 0 0q�6i   $��Center=�6{   ��6T   �� *STT+6�   5  G   5  C   5  ;   �� 5  :   $��Tên thuốc��6I   $	$ 150��6\   % 5  >   �� 5  B   .R�5  F   � .+�5  J   �� $��20 0 0 0q�6k   $��Center=�6}   ��6T   �� *T_TEN+6�   5  G   5   C   5"  ;   �� 5#  :   $��Số lượng��6I   $	$ 120��6[   % 5$  >   �� 5%  B   .R�5&  F   � .+�5'  J   �� $��20 0 0 0q�6p   $��Center=�6�   ��6T   �� *
CD_SOLUONG+6�   5(  G   5)  C   5+  ;   �� 5,  :   $��Liều dùng��6I   $	$ 180��6\   % 5-  >   �� 5.  B   .R�5/  F   � .+�50  J   �� $��20 0 0 0q�6q   $��Center=�6�   $
��Wrap=�6�   ��6T   �� *CD_LIEUDUNG+6�   51  G   52  C   54  ;   �� 55  :   $��Cách dùng��6I   $	$ 250��6]   % 56  >   �� 57  B   .R�58  F   � .+�59  J   �� $��20 0 0 0q�6q   $��Center=�6�   $
��Wrap=�6�   ��6T   �� *CD_CACHDUNG+6�   5:  G   5;  C   5=  ;   5>  7   5@  /   5A  +   5B  '   5C  #   5E       5G     $��1��62   $��
10 0 10 10q�6?   $ 10Q�6S   $��Bottom=�6l   .��5H  "   �  5I  &   �� 5J  *   6=   �� 5K  *   6=   �� 5L  *   6=   �� 5M  *   6=   �� 5N  *   6=   �� 5O  *   6=   .+�5R  &   �� #��[ 6-   $/ )Resource name: MaterialDesignRaisedButton��5S  -   $��
10 5 10 10q�5T  -   $��40��5U  -   $��0��5V  -   $  5��5W  -   $��Bottom=�5Y  -   ���	#FF2D2F4C$��0q�6_   ��5X  -   �� *CommandLuuPhieu+.��5Z  *   �� $ 
Horizontal=�65   .+�5[  .     $! ContentSaveEdit=�6F   $��0 0 10 0q�6]   $��25��6o   $��25��6z   �� 5\  .   $
��Lưu��68   $��0 5 0 0q�6C   6V   5]  +   5^  '   �� 5_  &   #��[ 6-   $/ )Resource name: MaterialDesignRaisedButton��5`  -   $��10 10 10 10q�5a  -   $��40��5b  -   $��1��5c  -   $  5��5f  -   $��Bottom=�5g  -   ���	#FF2D2F4C$��0q�6_   ��5d  -   �� *CommandInToaThuoc+��5e  -   �� $ wGhiNhanBenh��.��5h  *   �� $ 
Horizontal=�65   .+�5i  .     $! PrinterCheck=�6F   $��0 0 10 0q�6Z   $��25��6l   $��25��6w   �� 5j  .   $��In toa thuốc��68   $��0 5 0 0q�6L   6_   5k  +   5l  '   �� 5m  &   #��[ 6-   $/ )Resource name: MaterialDesignRaisedButton��5n  -   $��10 10 10 10q�5o  -   $��40��5p  -   $��2��5q  -   $  5��5r  -   $��Bottom=�5u  -   ���	#FF2D2F4C$��0q�6_   ��5s  -   �� *CommandLichTrinhKham+��5t  -   �� $ wGhiNhanBenh��.��5v  *   �� $ 
Horizontal=�65   .+�5w  .     $! CalendarText=�6F   $��0 0 10 0q�6Z   $��25��6l   $��25��6w   �� 5x  .   $��Lịch trình khám��68   $��0 5 0 0q�6O   6b   5y  +   5z  '   �� 5{  &   #��[ 6-   $/ )Resource name: MaterialDesignRaisedButton��5|  -   $��10 10 10 10q�5}  -   $��40��5~  -   $��3��5  -   $  5��5�  -   $��Bottom=�5�  -   ���	#FF2D2F4C$��0q�6_   ��5�  -   �� *CommandDoiNgayKham+��5�  -   �� $ wGhiNhanBenh��.��5�  *   �� $ 
Horizontal=�65   .+�5�  .     $! CalendarArrowRight=�6F   $��0 0 10 0q�6`   $��25��6r   $��25��6}   �� 5�  .   $��Dời ngày khám��68   $��0 5 0 0q�6M   6`   5�  +   5�  '   �� 5�  &   #��[ 6-   $/ )Resource name: MaterialDesignRaisedButton��5�  -   $��10 10 10 10q�5�  -   $  5��5�  -   $��40��5�  -   $��4��5�  -   $��Bottom=�5�  -   ���	#FF2D2F4C$��0q�6_   ��5�  -   �� *CommandDichVuDaDangKy+��5�  -   �� $ wGhiNhanBenh��.��5�  *   �� $ 
Horizontal=�65   .+�5�  .     $! TextBoxPlus=�6F   $��25��6Y   $��25��6d   $��0 0 10 0q�6p   �� 5�  .   $��DV đã đăng ký��68   $��0 5 0 0q�6M   6`   5�  +   5�  '   �� 5�  &   #��[ 6-   $/ )Resource name: MaterialDesignRaisedButton��5�  -   $��10 10 10 10q�5�  -   $  5��5�  -   $��40��5�  -   $��5��5�  -   $��Center=�5�  -   ���	#FF2D2F4C$��0q�6_   ��5�  -   �� *CommandHoanThanh+��5�  -   �� $ wGhiNhanBenh��.��5�  *   �� $ 
Horizontal=�65   .+�5�  .     $! ClipboardCheckOutline=�6F   $��0 0 10 0q�6c   $��25��6u   $��25��6�   �� 5�  .   $��Hoàn thành khám��68   $��0 5 0 0q�6O   6b   5�  +   5�  '   5�  #   5�     5�     5�     5�     5�     5�     5�     5�     