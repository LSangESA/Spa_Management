   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLLichHen.LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLLichHen  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  A    ;LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLLichHen.W_TaoLichHen   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Nlocal<clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLLichHen     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wTaoLichHen��  � Title$  W_TaoLichHen��$	��750��$	��715�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    TaoLichHenVM � DataContext# [ ��Z� .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger  	   	EventName$	 Loaded��.  (System.Windows.Interactivity.TriggerBase
   Actions.
 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wTaoLichHen��.��� .+��� 
���   �$��2q� �� CornerRadius$ 15 15 15 15��._�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�.���  � RowDefinitions �� $
��auto ��� $	��255 ��� $
��auto ��� $
��auto ��� $
��auto ��� .+��� $��LẬP LỊCH HẸN��$��Center=�$��25(�$��10q�$��0��� $��1��$��20 10 20 20q�.+��� .+��� $��Thông tin khách hàng��$
��Left=�$��18(��� -   $��cbxKhachHang��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tìm kiếm khách hàng�� & "MaterialDesignFloatingHintComboBox#��[  �� DisplayMemberPath$ KH_HOTEN�� �� 
IsEditable . $��5q�$	��500��$
��Left=����� *	KHACHHANG+ �� SelectedItem �� *SelectedKHACHHANG+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectedKHACHHANG+ �� $ cbxKhachHang��� $��0��$��0 20 0 0q�y��� *ShowKhachHang+ �� �� .+�� $��0�� � ColumnDefinitions �� $	��100 ��� $
��auto ��� $
��auto ��� $
��auto ��� .+��� $��70��$��70��$��0��$��20 30 20 20q����� *	KH_ANHS+�� $��1��$��20 25 10 10q�.+���  $  MaterialDesignHeadline6TextBlock#��[ ���� *	KH_HOTENS+��  �� Orientation$ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
PhoneCheck=�$��0 3 5 0q���  " MaterialDesignCaptionTextBlock#��[ ���� *	KH_SDTS+�� $ 
Horizontal=�.+���    MaterialDesignBody2TextBlock#��[ $��Mã KH: ��$��0 10 0 0q��� #��[ $��0 10 0 0q����� *KH_MAS+�� $��2��$��30 49 10 10q�.+��� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $
 Cake=�$��0 0 5 0q��� #��[ ���� *KH_NGAYSINHS+ �� StringFormat$ 
dd/MM/yyyy���� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $ Email=�$��0 3 5 0q��� #��[ ���� *	KH_EMAILS+�� $��3��$��30 49 10 10q�.+��� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $ GenderMaleFemale=�$��0 0 5 0q��� #��[ ���� *KH_GIOITINHS+��    MaterialDesignOutlinedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��	0 20 10 0q�$��0q�$��30��$��4��
�������$��Right=�$	��Top=�$��0q����� *CommandRemoveKhachHang+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ CloseCircle=�$��5 0 5 0q�$��25��$��25��
���  ���� $
��Xóa��$��0 0 0 0q�
���  ��$��Center=��� $ 
Horizontal=�$��119 115 0 0q�$
��Left=�$��Center=�.+�  $ MapMarkerRadius=�$��0 1 5 0q�$��18��$��18���� #��[ ���� *
KH_DIACHIS+�� .+��� $ 
Horizontal=�.+��� $ Giới tính��#��[ $
 Name��$��5q�$	��160��$
��Left=�$��0������ *
GIOITINH+ �� *SelectedGIOITINH+$ TwoWay=�$ PropertyChanged=��� $ Tên khách hàng�� % !MaterialDesignFloatingHintTextBox#��[ $��5q�$	��330��$��1������ *
KH_HOTEN+$ TwoWay=�$ PropertyChanged=�.���� $ 
Horizontal=�.+��� $ Số điện thoại��#��[ $��5q�$	��160������ *KH_SDT+$ TwoWay=�$ PropertyChanged=�.���� $ Email��#��[ $��5q�$	��160������ *
KH_EMAIL+$ TwoWay=�$ PropertyChanged=�.��(	  "System.Windows.Controls.DatePicker	  $��5q�$	��160��$ 
Ngày sinh�� (	 $MaterialDesignFloatingHintDatePicker#��[	  	  SelectedDate �� *KH_NGAYSINH+$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�.+��� -   $��cbxSelectTinhThanh��$ Tỉnh/Thành phố��#��[ $ TT_TEN��$��5q�$	��160��$
��Left=����� *	TINHTHANH+ �� *SelectedTINHTHANH+$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectTinhThanh+ �� $ cbxSelectTinhThanh���� -   $��cbxSelectHuyenQuan��$ Quận/Huyện��#��[ $ HQ_TEN��$��5q�$	��160��$
��Left=����� *	HUYENQUAN+ �� *SelectedHUYENQUAN+$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectHuyenQuan+ �� $ cbxSelectHuyenQuan���� $ Xã/Phường��#��[ $ XP_TEN��$��5q�$	��160��$
��Left=����� *
XAPHUONG+ �� *SelectedXAPHUONG+$ TwoWay=�$ PropertyChanged=��� $ Địa chỉ��#��[ $��5q�$	��160������ *	KH_DIACHI+$ TwoWay=�$ PropertyChanged=�.���� $��	5 20 5 20q�$��2��$	��0.1q�
���   �� $��3��$��20q� �� �� $
��0.6* �.+��� $��0��.+��� $��Lịch hẹn��$
��Left=�$��18(��� $ 
Horizontal=�.+�	  $��5q�$	��160��$ Ngày hẹn��#��[	  �� *
LH_NGAYDEN+$ TwoWay=�$ PropertyChanged=�)
  #MaterialDesignThemes.Wpf.TimePicker
   
  	Is24Hours . $ Giờ bắt đầu��$��5 16 5 5q�$	��160�� 
  Text �� *LH_THOIGIANDEN+$ hh\:mm��$ TwoWay=�$ PropertyChanged=��� -   $��cbxGOIDICHVU��$ Gói dịch vụ chọn��#��[ $��5q�$	��330��$
��Left=����� *	GOIDICHVU+ �� *SelectedGOIDICHVU+$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectedGOIDICHVU+ �� $ cbxGOIDICHVU������ .R��� $ 
Horizontal=�.+�A� $��30��$��30��$��0 5 0 0q�����  �� ImageSource �� *	GDV_ANH+�� $��Center=�$��10 0 0 0q����� *	GDV_TEN+�� $��Center=�$	�� - ���� $��Center=����� *LOAIGOIDICHVU.LGDV_TEN+�� $( "Bác sĩ/Nhân viên chỉ định��#��[ $��5q�$	��330��$
��Left=����� *
NHANVIEN+ �� *SelectedNHANVIEN+$ TwoWay=�$ PropertyChanged=����� .R��� $ 
Horizontal=�.+�A� $��30��$��30��$��0 5 0 0q�����  �� *NV_ANH+�� $��Center=�$��10 0 0 0q����� *NV_TEN+�� $��Center=�$	�� - ���� $��Center=����� *VT_TEN+�� $��Center=�$	�� - ���� $��Center=����� *	CLV_TEN+�� $ Ghi chú��#��[   �� AcceptsReturn  . ! �� TextWrapping$
! Wrap=�"" �� VerticalScrollBarVisibility$
" Auto=�$��5q�$
��Left=�$	��330��$��60������ *	LH_GHICHU+$ PropertyChanged=�$ TwoWay=��� $��1��.+��� $��Trạng thái��$
��Left=�$��15(�$��5 0 0 10q��� $	��200������ *	TRANGTHAI+ �� *SelectedTRANGTHAI+$ TwoWay=�$ PropertyChanged=����� .R��� $ 
Horizontal=�.+�A� $��15��$��15��$��0 0 0 0q����� # �� Color# �� *Color+�� $��	10 2 0 2 q����� *Name+�� $��	5 10 5 10q�$��4��$	��0.1q�
���   �� $��5�� �� �� �� .+���  
 MaterialDesignRaisedButton#��[
 $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 20q�+  %MaterialDesignThemes.Wpf.ButtonAssist$   CornerRadius$$ 10��$��35��$��0��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandDangKyGDV+���� $ wTaoLichHen��.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ TextBoxPlusOutline=�$��0 0 10 0q�$��25��$��25���� $��Đăng ký dịch vụ��$��0 5 0 0q��� #��[
 $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 20q�$$ 10��$��35��$��1��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandAddLichHen+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ ContentSaveEditOutline=�$��0 0 10 0q�$��25��$��25���� $
��Lưu��$��0 5 0 0q��� #��[
 $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 20q�$$ 10��$��35��$��2��$��Bottom=�$��0q����	#FFCA3C2A���� *CommandClose+���� $ wTaoLichHen��.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ ArrowLeftCircle=�$��0 0 5 0q�$��25��$��25���� $��Thoát��$��0 5 0 0q�