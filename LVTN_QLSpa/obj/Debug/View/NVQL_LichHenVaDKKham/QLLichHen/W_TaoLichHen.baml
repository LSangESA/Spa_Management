   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLLichHen.LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLLichHen  5   	   E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  5   	   A    ;LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLLichHen.W_TaoLichHen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Nlocal<clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLLichHen     5   	   6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��wTaoLichHen��5	   	     � Title$  W_TaoLichHen��5   	   $	��750��6   $	��715��6+    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .    MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	     TaoLichHenVM � DataContext# [ 5   	   ��5   	   Z� .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
   	   	EventName$	 Loaded��6   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
LoadWindow+   CommandParameter 5   $   ��  �� ElementName$ wTaoLichHen��5       .��5"      � .+�5#   
   �� 
���   �$��2q�6%    �� CornerRadius$ 15 15 15 15��69   ._�5$      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�6"   .��5%      �  � RowDefinitions 5&      �� 5'      $
��auto �6(   68   �� 5(      $	��255 �6(   67   �� 5)      $
��auto �6(   68   �� 5*      $
��auto �6(   68   �� 5+      $
��auto �6(   68   �� 5,      6*   .+�5/      �� $��LẬP LỊCH HẸN��6    $��Center=�50      $��25(�51      $��10q�52      $��0��53      54      � 56      $��1��6   $��20 10 20 20q�6(   .+�57      �� .+�58      �� $��Thông tin khách hàng��6(   $
��Left=�59       $��18(�5:       5;      �� 5=      -   5        $��cbxKhachHang��5@      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tìm kiếm khách hàng��5=   '    & "MaterialDesignFloatingHintComboBox#��[ 5>       �� DisplayMemberPath$ KH_HOTEN��5?       �� 
IsEditable . $��5q�5B      $	��500��5C      $
��Left=�5D      ��5E      �� *	KHACHHANG+ �� SelectedItem 5F      �� *SelectedKHACHHANG+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� 5G   "     5H   &   $	 SelectionChanged��65   .
 5I   *      6@   �� *CommandSelectedKHACHHANG+ 5J   $   �� $ cbxKhachHang��5K   '   5M      � 5O      $��0��6#   $��0 20 0 0q�60   y�6B   �� *ShowKhachHang+ 5P   "   �� 5Q   &   66   �� 5R   &   66   .+�5T   "   � $��0��6'    � ColumnDefinitions 5U   &   �� 5V   *   $	��100 �6;   6I   �� 5W   *   $
��auto �6;   6J   �� 5X   *   $
��auto �6;   6J   �� 5Y   *   $
��auto �6;   6J   �� 5Z   *   6=   .+�5]   &   �� $��70��5^   $   $��70��5_   $   $��0��5`   $   $��20 30 20 20q�5a   $   ��5]   ,   �� *	KH_ANHS+5a   $   �� 5c   &   $��1��61   $��20 25 10 10q�6A   .+�5d   *   ��  $  MaterialDesignHeadline6TextBlock#��[ 64   ��5e   ,   �� *	KH_HOTENS+5f   +   �� 5h   *    �� Orientation$ 
Horizontal=�65   $��0 5 0 0q�6N   $
��Left=�6_   $��Center=�6z   .+�5i   .   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
PhoneCheck=�6F   $��0 3 5 0q�6X   �� 5j   .    " MaterialDesignCaptionTextBlock#��[ 68   ��5k   0   �� *	KH_SDTS+5l   /   5m   +   �� 5o   *   $ 
Horizontal=�65   .+�5p   .   ��    MaterialDesignBody2TextBlock#��[ 68   $��Mã KH: ��5q   ,   $��0 10 0 0q�5r   ,   5s   /   �� 5t   .   #��[ 68   $��0 10 0 0q�5v   ,   ��5u   ,   �� *KH_MAS+5w   /   5x   +   5z   '   �� 5|   &   $��2��61   $��30 49 10 10q�6A   .+�5}   *   �� $ 
Horizontal=�65   $��0 5 0 0q�6N   $
��Left=�6_   $��Center=�6z   .+�5~   .     $
 Cake=�6F   $��0 0 5 0q�6R   �� 5   .   #��[ 68   ��5�   0   �� *KH_NGAYSINHS+ �� StringFormat$ 
dd/MM/yyyy��5�   /   5�   +   �� 5�   *   $ 
Horizontal=�65   $��0 5 0 0q�6N   $
��Left=�6_   $��Center=�6z   .+�5�   .     $ Email=�6F   $��0 3 5 0q�6S   �� 5�   .   #��[ 68   ��5�   0   �� *	KH_EMAILS+5�   /   5�   +   5�   '   �� 5�   &   $��3��61   $��30 49 10 10q�6A   .+�5�   *   �� $ 
Horizontal=�65   $��0 5 0 0q�6N   $
��Left=�6_   $��Center=�6z   .+�5�   .     $ GenderMaleFemale=�6F   $��0 0 5 0q�6^   �� 5�   .   #��[ 68   ��5�   0   �� *KH_GIOITINHS+5�   /   5�   +   5�   '   �� 5�   &      MaterialDesignOutlinedButton#��[ 6-    � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5�   %   $��	0 20 10 0q�5�   %   $��0q�5�   %   $��30��5�   %   $��4��5�   %   
�������$��Right=�5�   %   $	��Top=�5�   %   $��0q�5�   %   ��5�   %   �� *CommandRemoveKhachHang+.��5�   *   �� $ 
Horizontal=�65   $��0 0 10 0q�6N   .+�5�   .     $ CloseCircle=�6F   $��5 0 5 0q�6Y   $��25��6j   $��25��6u   
���  ��6�   �� 5�   .   $
��Xóa��68   $��0 0 0 0q�6C   
���  ��$��Center=�6e   6�   5�   +   5�   '   5�   #   �� 5�   "   $ 
Horizontal=�6-   $��119 115 0 0q�5�   %   $
��Left=�5�   %   $��Center=�5�   %   .+�5�   &     $ MapMarkerRadius=�6>   $��0 1 5 0q�6U   $��18��6f   $��18��6q   �� 5�   &   #��[ 60   ��5�   0   �� *
KH_DIACHIS+5�   '   5�   #   5�      �� 5�      .+�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $ Giới tính��6/   #��[ 5�   '   $
 Name��5�   '   $��5q�5�   '   $	��160��5�   '   $
��Left=�5�   '   $��0��5�   '   ��5�   '   �� *
GIOITINH+ 5�   '   �� *SelectedGIOITINH+$ TwoWay=�$ PropertyChanged=�5�   '   �� 5�   &   $ Tên khách hàng��6.    % !MaterialDesignFloatingHintTextBox#��[ 5�   &   $��5q�5�   &   $	��330��5�   &   $��1��5�   &   ��5�   &   �� *
KH_HOTEN+$ TwoWay=�$ PropertyChanged=�.��5�   3   5�   '   5�   #   �� 5�   "   $ 
Horizontal=�6-   .+�5�   &   �� $ Số điện thoại��6.   #��[ 5�   &   $��5q�5�   &   $	��160��5�   &   ��5�   &   �� *KH_SDT+$ TwoWay=�$ PropertyChanged=�.��6p   5�   '   �� 5�   &   $ Email��6.   #��[ 5�   &   $��5q�5�   &   $	��160��5�   &   ��5�   &   �� *
KH_EMAIL+$ TwoWay=�$ PropertyChanged=�.��6r   5�   '   (	  "System.Windows.Controls.DatePicker	  5�   &   $��5q�61   $	��160��5�   )   $ 
Ngày sinh��5�   )    (	 $MaterialDesignFloatingHintDatePicker#��[	 5�   )    	  SelectedDate 5�   )   �� *KH_NGAYSINH+$ TwoWay=�$ PropertyChanged=�5�   #   �� 5�   "   $ 
Horizontal=�6-   .+�5�   &   �� -   5        $��cbxSelectTinhThanh��5�   '   $ Tỉnh/Thành phố��5�   /   #��[ 5�   #   $ TT_TEN��5�   #   $��5q�5�   #   $	��160��5�   #   $
��Left=�5�   #   ��5�   #   �� *	TINHTHANH+ 5�   #   �� *SelectedTINHTHANH+$ TwoWay=�$ PropertyChanged=� 5�   *     5�   .   $	 SelectionChanged��6=   .
 5�   2      6H   �� *CommandSelectTinhThanh+ 5�   D   �� $ cbxSelectTinhThanh��5�   /   5�   '   �� 5�   &   -   5        $��cbxSelectHuyenQuan��5�   '   $ Quận/Huyện��5�   /   #��[ 5�   #   $ HQ_TEN��5�   #   $��5q�5�   #   $	��160��5�   #   $
��Left=�5�   #   ��5�   #   �� *	HUYENQUAN+ 5�   #   �� *SelectedHUYENQUAN+$ TwoWay=�$ PropertyChanged=� 5�   *     5�   .   $	 SelectionChanged��6=   .
 5�   2      6H   �� *CommandSelectHuyenQuan+ 5�   D   �� $ cbxSelectHuyenQuan��5�   /   5�   '   �� 5�   &   $ Xã/Phường��6/   #��[ 5�   #   $ XP_TEN��5�   #   $��5q�5�   #   $	��160��5�   #   $
��Left=�5�   #   ��5�   #   �� *
XAPHUONG+ 5�   #   �� *SelectedXAPHUONG+$ TwoWay=�$ PropertyChanged=�5   '   �� 5  &   $ Địa chỉ��6.   #��[ 5  "   $��5q�5  "   $	��160��5  "   ��5  "   �� *	KH_DIACHI+$ TwoWay=�$ PropertyChanged=�.��6o   5  '   5  #   5     5	     5
     �� 5     $��	5 20 5 20q�6    $��2��63   $	��0.1q�6@   
���   �6l   � 5     $��3��6   $��20q�6(    5     �� 5     61   �� 5     $
��0.6* �6/   6>   .+�5     �� $��0��6%   .+�5     �� $��Lịch hẹn��6(   $
��Left=�5      $��18(�5      5     �� 5     $ 
Horizontal=�6)   .+�5  "   	  $��5q�6-   $	��160��5  %   $ Ngày hẹn��5  %   #��[	 5  %    5  %   �� *
LH_NGAYDEN+$ TwoWay=�$ PropertyChanged=�5  #   )
  #MaterialDesignThemes.Wpf.TimePicker
  5   "    
  	Is24Hours . $ Giờ bắt đầu��5!  4   $��5 16 5 5q�5"  4   $	��160��5#  4    
  Text 5$  4   �� *LH_THOIGIANDEN+$ hh\:mm��$ TwoWay=�$ PropertyChanged=�5%     �� 5&     -   5        $��cbxGOIDICHVU��5+     $ Gói dịch vụ chọn��5&  '   #��[ 5'  !   $��5q�5(  !   $	��330��5)  !   $
��Left=�5*  !   ��5,  !   �� *	GOIDICHVU+ 5-  !   �� *SelectedGOIDICHVU+$ TwoWay=�$ PropertyChanged=� 5.  "     5/  &   $	 SelectionChanged��65   .
 50  *      6@   �� *CommandSelectedGOIDICHVU+ 51  $   �� $ cbxGOIDICHVU��52  '   ��54  "   �� 55  &   .R�56  *   �� $ 
Horizontal=�65   .+�57  .   A� $��30��66   $��30��6A   $��0 5 0 0q�6M   ��58  2   �� 59  6    �� ImageSource 6A   �� *	GDV_ANH+5;  /   �� 5<  .   $��Center=�68   $��10 0 0 0q�6S   ��6e   �� *	GDV_TEN+6�   �� 5=  .   $��Center=�68   $	�� - ��6S   6`   �� 5>  .   $��Center=�68   ��6S   �� *LOAIGOIDICHVU.LGDV_TEN+6}   5?  +   5@  '   5B     �� 5C     $( "Bác sĩ/Nhân viên chỉ định��6'   #��[ 5D  )   $��5q�5E  )   $	��330��5F  )   $
��Left=�5G  )   ��5H  )   �� *
NHANVIEN+ 5I  )   �� *SelectedNHANVIEN+$ TwoWay=�$ PropertyChanged=���5J  "   �� 5K  &   .R�5L  *   �� $ 
Horizontal=�65   .+�5M  .   A� $��30��66   $��30��6A   $��0 5 0 0q�6M   ��5N  2   �� 5O  6    6A   �� *NV_ANH+5Q  /   �� 5R  .   $��Center=�68   $��10 0 0 0q�6S   ��6e   �� *NV_TEN+6   �� 5S  .   $��Center=�68   $	�� - ��6S   6`   �� 5T  .   $��Center=�68   ��6S   �� *VT_TEN+6m   �� 5U  .   $��Center=�68   $	�� - ��6S   6`   �� 5V  .   $��Center=�68   ��6S   �� *	CLV_TEN+6n   5W  +   5X  '   5Z     �� 5[     $ Ghi chú��6&   #��[ 5\       �� AcceptsReturn  . ! �� TextWrapping$
! Wrap=�5^     "" �� VerticalScrollBarVisibility$
" Auto=�5_     $��5q�5`     $
��Left=�5a     $	��330��5b     $��60��5c     ��5d     �� *	LH_GHICHU+$ PropertyChanged=�$ TwoWay=�5f     �� 5h     $��1��6%   .+�5i     �� $��Trạng thái��6(   $
��Left=�5j      $��15(�5k      $��5 0 0 10q�5l      5m     �� 5n     $	��200��5p     ��5n  &   �� *	TRANGTHAI+ 5o     �� *SelectedTRANGTHAI+$ TwoWay=�$ PropertyChanged=���5q  "   �� 5r  &   .R�5s  *   �� $ 
Horizontal=�65   .+�5t  .   A� $��15��66   $��15��6A   $��0 0 0 0q�6M   ��5u  2   �� 5v  6   # �� Color# 6F   �� *Color+5x  /   �� 5y  .   $��	10 2 0 2 q�68   ��6K   �� *Name+6c   5z  +   5{  '   5}     5~     5     �� 5�     $��	5 10 5 10q�6    $��4��63   $	��0.1q�6@   
���   �6l   � 5�     $��5��6    5�     �� 5�     61   �� 5�     61   �� 5�     61   .+�5�     ��  
 MaterialDesignRaisedButton#��[
 6!   $/ )Resource name: MaterialDesignRaisedButton��5�     $��10 10 10 20q�5�     +  %MaterialDesignThemes.Wpf.ButtonAssist$   CornerRadius$$ 10��5�     $��35��5�     $��0��5�     $��Bottom=�5�     $��0q�65   ���	#FF2D2F4C��5�     �� *CommandDangKyGDV+��5�     �� $ wTaoLichHen��.��5�     �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   .+�5�  "     $ TextBoxPlusOutline=�6:   $��0 0 10 0q�6T   $��25��6f   $��25��6q   �� 5�  "   $��Đăng ký dịch vụ��6,   $��0 5 0 0q�6C   6V   5�     5�     �� 5�     #��[
 6!   $/ )Resource name: MaterialDesignRaisedButton��5�     $��10 10 10 20q�5�     $$ 10��5�     $��35��5�     $��1��5�     $��Bottom=�5�     $��0q�65   ���	#FF2D2F4C��5�     �� *CommandAddLichHen+.��5�     �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   .+�5�  "     $ ContentSaveEditOutline=�6:   $��0 0 10 0q�6X   $��25��6j   $��25��6u   �� 5�  "   $
��Lưu��6,   $��0 5 0 0q�67   6J   5�     5�     �� 5�     #��[
 6!   $/ )Resource name: MaterialDesignRaisedButton��5�     $��10 10 10 20q�5�     $$ 10��5�     $��35��5�     $��2��5�     $��Bottom=�5�     $��0q�65   ���	#FFCA3C2A��5�     �� *CommandClose+��5�     �� $ wTaoLichHen��.��5�     �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   .+�5�  "     $ ArrowLeftCircle=�6:   $��0 0 5 0q�6Q   $��25��6b   $��25��6m   �� 5�  "   $��Thoát��6,   $��0 5 0 0q�69   6L   5�     5�     5�     5�     5�     5�     5�     5�     