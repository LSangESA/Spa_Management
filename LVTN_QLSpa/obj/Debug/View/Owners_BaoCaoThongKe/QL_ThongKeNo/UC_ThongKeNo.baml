   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeNo1LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeNo  5      D    >LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeNo.UC_ThongKeNo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Qlocal?clr-namespace:LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeNo     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5        ThongKeNoVM � DataContext# [ 5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
LoadWindow+   CommandParameter 5   $   ��  �� ElementName$ wLapPhieuThu��5      .��5      � 	 � ColumnDefinitions	 5   
   �� 5      $��0.35* �6   6/   �� 5      6!   .+�5   
   � $��0��6   
 � RowDefinitions
 5       �� 5!      $��0.35* �6    61   �� 5"      6"   .+�5%      #  MaterialDesignThemes.Wpf.Card   ! PrimaryHueDarkForegroundBrush#���  5&   "   $��0q�5'   "   $��0��5(   "   $��20q�5)   "      UniformCornerRadius$ 15Q�5*   "   ��5+      �� 5,       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5-      �  � Color$ 	#FF08FBFF��6'    � Offset$ 0.234Q�69   � 5.      $ White��6'   $ 1Q�65   5/      .��51      �� .+�52      � 	 53      �� 54      61   �� 55      61   .+�57      �� $��0��6$   $��
16 16 16 4q�58   ,    $  MaterialDesignHeadline5TextBlock#��[ 59   ,   $��Nợ chưa thu��5:   ,   $
��Bold"�5;   $   
���   �5=      '  !MaterialDesignThemes.Wpf.PackIcon  5?         Kind$ CurrencyUsd=�62   $��1��5@   2   $��15q�5A   2   $��30��5B   2   $��30��5C   2   
���   �$��Right=�5E   2   5F      � 5G      $��15q�6   	 5H      �� 5I      $
��0.8* �6/   6>   �� 5J      61   .+�5M      � $��0��6   .+�5N      �� $��Center=�6)   .+�5O   "   �� $��0 10 0 0q�6K   $��Center=�6]   
���   �$��22(�6�   ��6,   �� *TONGKHACHHANG+6�   �� 5P   "   $��Khách hàng��6,   $��0 5 0 0q�6>   $��Center=�6O   
���   �$
��Bold"�6   $��13(�6�   6�   5Q      5R      � 5T      $��1��6   .+�5U      �� $��Center=�6)   .+�5V   "   �� $��0 10 0 0q�6H   $��Center=�6Z   
���   �$��22(�6�   ��6,   �� *
TONGTIENNO+6�   �� 5W   "   $��Tổng nợ��6,   $��0 5 0 0q�6;   $��Center=�6L   
���   �$
��Bold"�6|   $��13(�6�   6�   5X      5Y      5Z      5[      5\        5^      $��20q�6"   $ 10Q�6.   $��1��6G   .��5_      � 
 5`      �� 5a      $
��auto �6(   68   �� 5b      6*   .+�5e      �� $��0��6!    �� Orientation$ 
Horizontal=�5f   !   $��10q�5g   !   .+�5h      �� $S��ME:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Image\Filter\filter.png��6    $��20��5i       $	��Top=�5j       $��20��5k       $��0 0 10 0q�5l       64   �� 5m      $��
Bộ lọc��6$   $��18(�62   $	��Top=�5n   $   6>   5o      �� 5q      $��1��6!   $��10q�6.   .+�5r      	�  	� 	GroupName$ 	ThongKeNo��6&     MaterialDesignRadioButton#��[ 5s   &   $��Ngày tùy chọn��5t   &    d� 	IsChecked 5u   &   �� *CheckTuyChon+(  "System.Windows.Controls.DatePicker  5v      )	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ Ngày bắt đầu��6%   $��	20 5 20 5q�5w   %    ( $MaterialDesignFloatingHintDatePicker#��[ 5x   %      SelectedDate 5y   %   �� *
NGAYBATDAU+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�  5z      $ Ngày kết thúc��6%   $��	20 5 20 5q�5{   %   #��[ 5|   %    5}   %   �� *NGAYKETTHUC+$ TwoWay=�$ PropertyChanged=�	� 5~      #��[ 6&   $��0 50 0 0q�5   &   $��Thời gian cụ thể��5�   &   $ 	ThongKeNo��5�   &    5�   &   �� *
CheckCuThe+� 5�      	 5�      �� 5�   "   65   �� 5�   "   65   .+�5�      �� $ Tháng��6'    �� 
IsEditable . $��	20 5 10 5q�5�   '   $��0��5�   '    & "MaterialDesignFloatingHintComboBox#��[ 5�   '    �� DisplayMemberPath$
 Name��5�   '   ��5�   '   �� *THANG+ �� SelectedItem 5�   '   �� *SelectedTHANG+$ TwoWay=�$ PropertyChanged=�5�      �� 5�      $
 Năm��6'    . $��	10 5 20 5q�5�   '   $��1��5�   '   #��[ 5�   '   $
 Name��5�   '   ��5�   '   �� *NAM+ 5�   '   �� *SelectedNAM+$ TwoWay=�$ PropertyChanged=�5�      5�      �� 5�      $ 
Horizontal=�6%   $��Center=�6>   $��	0 180 0 0q�6[   .+�5�      ��   MaterialDesignRaisedButton#��[ 6%    � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5�   %   $��10 10 10 20q�5�   %   $��35��5�   %   $	��0.5q�5�   D   $	��120��5�   %   
���   �
���   �
���������5�   %   �� *
CommandLoc+.��5�   "   �� $ 
Horizontal=�6-   $��0 0 10 0q�6F   .+�5�   &     $ 
FilterMenu=�6>   $��0 0 10 0q�6P   $��25��6b   $��25��6m   �� 5�   &   $��Lọc��60   $��0 5 0 0q�6;   6N   5�   #   5�      �� 5�      #��[ 6%   $/ )Resource name: MaterialDesignRaisedButton��5�   %   $��10 10 10 20q�5�   %   $��35��5�   %   $	��0.5q�5�   F   $	��120��5�   %   
���   �
���   �
���������5�   %   �� *CommandBoLoc+.��5�   "   �� $ 
Horizontal=�6-   $��0 0 10 0q�6F   .+�5�   &     $ CloseCircle=�6>   $��0 0 10 0q�6Q   $��25��6c   $��25��6n   �� 5�   &   $��
Bỏ lọc��60   $��0 5 0 0q�6>   6Q   5�   #   5�      5�      5�      5�      5�      5�      � 5�   
   $��1��6   
 5�      �� 5�      $
��1.2* �6    60   �� 5�      6"   .+�5�        $��10q�6"   $ 10Q�6.   $��0��6G   .��5�      � 
 5�      �� 5�      $
��auto �6(   68   �� 5�      6*   .+�5�      � $��0��6   .+�5�      �� $ 
Horizontal=�6%   $��1��6>   $��	10 5 50 0q�6N   $��Center=�6a   .+�5�        $ Magnify=�66   $��25��6E   $��25��6P   $��0 10 0 0q�6\   �� 5�      $" Tìm thông tin khách hàng��6&    %	 !MaterialDesignFloatingHintTextBox#��[	 5�   .   $	��250��5�   .   ��5�   .   �� *KeySearchKH+5�   .   5�      '
  !MaterialDesignThemes.Wpf.PopupBox
  5�      $��Right=�62    
  	StaysOpen . $	��Top=�5�   2   $��2 0 2 0q�5�   2   $��0 10 0 0q�5�   2    
  PopupContent. 5�      �� $	��200��6)   .+�5�   "   �� $��Xuất Excel��6)   $��
10 0 10 10q�5�   )   5�      5�      5�      �� 5�      -   5        $��lvwKhachHang��5�      $��1��5�      ��5�      �� *ListKhachHangNo+ 5�      �� *SelectedKhachHangNo+$ TwoWay=�$ PropertyChanged=� 5�        5�      $ SelectionChanged��6-   . 5�   "      68   �� *CommandSelectedKhachHangNo+ 5�   $   �� $ lvwKhachHang��5�       �� View 5�      �� 5�      .P�5�   "   �� $��Mã KH��61    �� CellTemplate 5�   &   �� 5�   *   .R�5�   .   � .+�5�   2   �� $��20 0 0 0q�6S   $��Center=�6e   ��6<   �� *KH_MA+6�   5�   /   5�   +   5�   #   �� 5�   "   $��	Họ tên��61    5�   &   �� 5�   *   .R�5�   .   � .+�5�   2   �� $��20 0 0 0q�6T   $��Center=�6f   ��6<   �� *KH_TEN+6�   5�   /   5�   +   5�   #   �� 5�   "   $��Số điện thoại��61    5�   &   �� 5   *   .R�5  .   � .+�5  2   �� $��20 0 0 0q�6T   $��Center=�6f   ��6<   �� *KH_SDT+6�   5  /   5  +   5  #   �� 5  "   $��Ngày khám cuối��61    5	  &   �� 5
  *   .R�5  .   � .+�5  2   �� $��20 0 0 0q�6v   $��Center=�6�   ��6<   �� *KH_NGAYKHAMCUOI+  �� StringFormat$  
dd/MM/yyyy��6�   5  /   5  +   5  #   �� 5  "   $��Số phiếu nợ��61    5  &   �� 5  *   .R�5  .   � .+�5  2   �� $��20 0 0 0q�6\   $��Center=�6n   ��6<   �� *KH_TONGPHIEUNO+6�   5  /   5  +   5  #   �� 5  "   $��Tổng nợ��61    5  &   �� 5  *   .R�5  .   � .+�5   2   �� $��20 0 0 0q�6W   $��Center=�6i   ��6<   �� *	KH_TONGNO+6�   5!  /   5"  +   5$  #   5%     5'     5(     5)       5+     $��10 10 10 20q�6"   $ 10Q�67   $��1��6P   .��5,     � .+�5;     �� $��1��5=     ��5;     �� *ListPhieuDieuTriNo+ 5<     �� *SelectedPhieuDieuTriNo+$ TwoWay=�$ PropertyChanged=� 5>     �� 5?     .P�5@  "   �� $��Số PDK��61    5A  &   �� 5B  *   .R�5C  .   � .+�5D  2   �� $��20 0 0 0q�6U   $��Center=�6g   ��6<   �� *	PDK_STT+6�   5E  /   5F  +   5H  #   �� 5J  "   $��Số PDT��61    5K  &   �� 5L  *   .R�5M  .   � .+�5N  2   �� $��20 0 0 0q�6U   $��Center=�6g   ��6<   �� *	PDT_STT+6�   5O  /   5P  +   5R  #   �� 5T  "   $��Gói dịch vụ��61    5U  &   �� 5V  *   .R�5W  .   � .+�5X  2   �� $��20 0 0 0q�6U   $��Center=�6g   ��6<   �� *	GDV_TEN+6�   5Y  /   5Z  +   5\  #   �� 5^  "   $��Ngày khám��61    5_  &   �� 5`  *   .R�5a  .   � .+�5b  2   �� $��20 0 0 0q�6Z   $��Center=�6l   ��6<   �� *PDT_NGAYKHAM+6�   5c  /   5d  +   5f  #   �� 5h  "   $��Thành tiền��61    5i  &   �� 5j  *   .R�5k  .   � .+�5l  2   �� $��20 0 0 0q�6n   $��Center=�6�   ��6<   �� *	THANHTIEN+$  {0:n0}��6�   5m  /   5n  +   5p  #   �� 5r  "   $��Giá giảm��61    5s  &   �� 5t  *   .R�5u  .   � .+�5v  2   �� $��20 0 0 0q�6l   $��Center=�6~   ��6<   �� *	GIAGIAM+$  {0:n0}��6�   5w  /   5x  +   5z  #   �� 5|  "   $��
Tổng thu��61    5}  &   �� 5~  *   .R�5  .   � .+�5�  2   �� $��20 0 0 0q�6l   $��Center=�6~   ��6<   �� *	TONGTHU+$  {0:n0}��6�   5�  /   5�  +   5�  #   5�     5�     5�     5�     5�     5�     5�     