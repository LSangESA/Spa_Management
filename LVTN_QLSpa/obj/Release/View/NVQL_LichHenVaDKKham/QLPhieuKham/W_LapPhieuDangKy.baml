   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham0LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  G    ALVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham.W_LapPhieuDangKy   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Plocal>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     �Name$  WLapPhieuDangKy�� � Title$ Lập phiếu đăng ký��$	��800��$
��1300�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .  � WindowState$ 	Maximized=�   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    LapPhieuDangKyVM	 � DataContext#	 [ ��Z� .  (System.Windows.Interactivity.Interaction
   Triggers
 /  )System.Windows.Interactivity.EventTrigger     	EventName$ Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ WLapPhieuDangKy��.��� .+��� 
���   �$��2q� �� CornerRadius$ 15 15 15 15��._�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q����	#FFF7F7F7.���  � RowDefinitions �� $
��auto ��� .+�� $��0��.+�,   &LVTN_QLSpa.UserControlSpa.UseControlUC  
 � Tag �� *Title+$ WLapPhieuDangKy��� $��1�� � ColumnDefinitions �� $
��0.9* ��� .+�  $ 10Q�$��
10 10 0 10q�$��0��.���  �� $	��140 ��� $
��auto ��� $
��auto ��� $	��170 ��� $
��auto ��� $
��auto ��� $
��auto ��� .+�� $��0��$��0 10 0 0q�y��� *
ShowInfoKH+ �� $	��100 ��� $
��auto ��� .+��� $��70��$��70��$��0��$��20 30 20 20q����� *KH_ANH+� $��1�� �� $
��auto ��� $
��auto ��� $
��auto �.+���  �� Orientation$ 
Horizontal=�$��	20 15 0 0q�$��0��$
��Left=�$��Center=�.+���  $  MaterialDesignHeadline6TextBlock#��[ ���� *KH_TEN+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $ 
Horizontal=�.+���    MaterialDesignBody2TextBlock#��[ $��Mã KH: ��$��22 5 0 0q��� #��[ $��0 5 0 0q����� *KH_MA+$ TwoWay=�$ PropertyChanged=�� $��1�� �� �� .+��� $��0��$��20 10 10 10q�.+��� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
PhoneCheck=�$��0 3 5 0q���  " MaterialDesignCaptionTextBlock#��[ ���� *KH_SDT+$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $ GenderMaleFemale=�$��0 0 5 0q��� #��[ ���� *KH_GIOITINH+$ TwoWay=�$ PropertyChanged=��� $��1��$��20 10 10 10q�.+��� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $
 Cake=�$��0 0 5 0q��� #��[ ���� *KH_NGAYSINH+ �� StringFormat$ 
dd/MM/yyyy��$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $ Email=�$��0 3 5 0q��� #��[ ���� *
KH_EMAIL+$ TwoWay=�$ PropertyChanged=���  & "MaterialDesignToolForegroundButton#��[ $��25 -10 10 10q�$��0q�$��30��$��2��$
��Left=�$��Bottom=�$��0q����� *CommandThanhToanNo+���� $ WLapPhieuDangKy��.���� $ 
Horizontal=�$��0 0 10 0q�.+��� $��Nợ: ��$��0 0 0 0q�
���  ��$��Center=��� $��0 0 0 0q�
���  ��$��Center=����� *SONOKHACHHANG+  $ Pencil=�$��5 0 5 0q�$��15��$��15��
���  ����   MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��30��$��70��$��2��+	  %MaterialDesignThemes.Wpf.ButtonAssist 	  CornerRadius$ 10��$��0q�$��Right=�$	��Top=�$��	0 10 20 0q����� *CommandEditKhachHang+����  �� EndPoint$ 0.5,1&� � MappingMode$ RelativeToBoundingBox=� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF00070F��  � Offset$  0Q�� $ 	#FF4976A6��$  1Q�.��  $ 
PencilPlus=�
�������� $��0��$��10 30 10 10q�y��� *
NullInfo+ �� $	��100 ��� $
��auto ��� .+�(
  "MaterialDesignThemes.Wpf.ColorZone
  ! 
  Mode$! PrimaryLight=�$��Stretch=�$��0��$��90��$��70��
�������
���   �$	��0.4q�.��  $ AccountCircle=�$��30��$��30��$��Center=�$��Center=��� #��[ $��Thông tin khách hàng��$��1���� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��30��$��70��$��2��$ 10��$��0q�$��Right=�$	��Top=�$��
0 -10 10 0q����� *CommandAddKhachHang+���� $ 0.5,1&�$ RelativeToBoundingBox=�$ 0.5,0&�.��� $ 	#FF00070F��$  0Q�� $ 	#FF4976A6��$  1Q�.��  $ 
PencilPlus=�
�������� $��1��$��30 10 30 10q�.+��� $��5q�$	��0.1q�
���   �� $��2��$��
30 20 10 0q� �� $
��0.9* ��� $
��1.1* ��� $��1* �.+��� $��0��.+��� $ 
Horizontal=�.+���  $  MaterialDesignSubtitle1TextBlock#��[ $��Số phiếu ĐK: ���� #��[ ���� *	PDK_STT+(  "System.Windows.Controls.DatePicker  )  #MaterialDesignThemes.Wpf.HintAssist"   Hint$" Ngày đăng ký�� (	 $MaterialDesignFloatingHintDatePicker#��[	 $��
0 10 10 10q�{�.  #   SelectedDate# �� *
PDK_NGAYDK+$ PropertyChanged=�$ TwoWay=��� -   $��cbxPhong��$" Phòng��$��0 5 10 5q� &
 "MaterialDesignFloatingHintComboBox#��[
 ���� *PHONG+$ �� SelectedItem$ �� *SelectedPHONG+$ TwoWay=�$ PropertyChanged=�
   $ SelectionChanged��.    �� *CommandSelectedPHONG+ �� $ cbxPhong������ .R��� $ 
Horizontal=�.+��� ���� *P_SO+�� $	�� - ���� ���� *P_TEN+�� $��1��$��0 20 0 0q�.+��� $" Cách thanh toán��% �� 
IsEditable% . $��30 10 30 10q�#��[
 & �� DisplayMemberPath$& CTT_TEN��$��2������ *CACHTHANHTOAN+$ �� *SelectedCACHTHANHTOAN+$ TwoWay=�$ PropertyChanged=��� $" Bác sĩ theo dỗi��$��
30 5 30 10q�#��[
 $��2������ *
NHANVIEN+$ �� *SelectedNHANVIEN+$ TwoWay=�$ PropertyChanged=����� .R��� $ 
Horizontal=�.+�A� $��30��$��30��$��0 5 0 0q����� ' �� ImageSource' �� *NV_ANH+�� $��Center=�$��10 0 0 0q����� *NV_TEN+�� $��Center=�$	�� - ���� $��Center=����� *VT_TEN+�� $��2��$��0 20 0 0q�.+�  $" Ngày bắt đầu��#��[	 $��
0 10 20 10q�# �� *PDK_NGAYBDTH+$ PropertyChanged=�$ TwoWay=���    MaterialDesignOutlinedButton#��[ $/ )Resource name: MaterialDesignRaisedButton��$��
0 10 10 10q�$��0q�$��30��$	��150��$
��Left=�
�������$��2q�
����d�
����d����� *CommandLapLich+.���� $ 
Horizontal=�$��0 0 10 0q�$��Right=�.+�  $ CalendarAdd=�$��0 0 10 0q�$��25��$��25���� $��Lập lịch��$��0 5 0 0q�� $��3��$��	10 20 0 0q� �� $	��200 ��� $
��auto �.+�� $��0��$��20q�.+��� 
���   �$	��0.5q�._��� ���� *	GDV_ANH+$ TwoWay=�$ PropertyChanged=��� $��1��$��0 20 0 0q�.+��� $ 
Horizontal=�.+��� #��[ $��Gói dịch vụ:��$��22(�$	��120���� #��[ $��22(�$
��Bold"�$��10 0 0 0q����� *	GDV_TEN+$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�$��0 10 0 0q�.+��� #��[ $��Loại dịch vụ:��$��13(�$	��120���� #��[ $��13(�$
��Bold"�$��10 0 0 0q����� *
LGDV_TEN+$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�.+��� #��[ $��Số liệu trình:��$��13(�$	��120���� #��[ $��13(�$
��Bold"�$��10 0 0 0q����� *	GDV_SOLAN+$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�.+��� #��[ $��
Giá gói:��$��13(�$	��120���� #��[ $��13(�$
��Bold"�$��10 0 0 0q����� *DONGIA+$ TwoWay=�$ PropertyChanged=�� $��4��$��20 20 20 10q�.+��� $��5q�$	��0.1q�
���   �� $��5��$��
25 20 25 0q� �� $
��1.4* ��� $
��0.6* �.+��� $��0��.+��� $ 
Horizontal=�$
��Left=�.+��� $��50��$��50��$Y��SE:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Image\Discount\sale-label.png���� #��[ $��20(�$��Center=�$��10 0 0 0q�$
��Bold"����� *GG_TEN+$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�$
��Left=�$��Center=�$��20 0 0 0q�$y�	Collapsed=�.+�  $ CloseCircleOutline=�$��0 0 5 0q�$��25��$��25���� #��[ $H��BKhông có chương trình khuyến mãi nào cho gói dịch vụ��$��Center=��� $ 
Horizontal=�.+��� $ 
Horizontal=�$
��Left=�$��Center=�$��56 0 0 0q�.+�  $ CalendarCheckOutline=�$��0 3 5 0q��� #��[ ���� *GG_NGAYBATDAU+$ 
dd/MM/yyyy��$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�$
��Left=�$��Center=�$��40 0 0 0q�.+�  $ CalendarRemove=�$��0 3 5 0q��� #��[ ���� *GG_NGAYKETTHUC+$ 
dd/MM/yyyy��$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�$
��Left=�$��Center=�$��40 0 0 0q�.+�  $
 Sale=�$��0 3 5 0q��� #��[ ���� *GG_PHANTRAMGIAM+$ TwoWay=�$ PropertyChanged=��� $#" Chương trình khuyến mãi��% . #��[
 $& GG_TEN��$��1��$	��Top=����� *	GIAMGIA+$ �� *SelectedGIAMGIA+$ TwoWay=�$ PropertyChanged=�� $��6��$��20 10 20 10q�.+��� $��5q�$	��0.1q�
���   �� $��7��$��20 10 20 10q�$��Bottom=� �� �� �� �� .+��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$ 10��$��40��$��0��$��Center=����	#FF2D2F4C$��0q����� *CommandAddPhieuDK+.���� $ 
Horizontal=�$��0 0 6 0q�.+�  $ ContentSave=�$��0 0 5 0q�$��25��$��25���� $��Lưu phiếu��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$ 10��$��40��$��2��$��Center=����	#FF2D2F4C$��0q����� *CommandOpenPDT+���� $ WLapPhieuDangKy��.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ Receipt=�$��0 0 5 0q�$��25��$��25���� $��Phiếu chờ��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$ 10��$��40��$��1��$��Center=����	#FF2D2F4C$��0q����� *CommandInLichTrinh+���� $ WLapPhieuDangKy��.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ Printer=�$��0 0 5 0q�$��25��$��25���� $��In lịch trình��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$ 10��$��40��$��3��$��Center=�$��0q����	#FFCA3C2A���� *CommandClosePDK+���� $ WLapPhieuDangKy��.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ ArrowLeftThick=�$��0 0 0 0q�$��25��$��25���� $��Thoát��$��0 5 0 0q�  $��1��$��10q�$ 10Q�.���  �� $
��auto ��� .+��� $��0��$ 
Horizontal=�$��4q�.+�	� -   $��chkGDVLT��   MaterialDesignTabRadioButton#��[ $��4q�$#��DỊCH VỤ CÓ LIỆU TRÌNH��$	��380�����	#FF2D2F4C$��1q�( d� 	IsChecked( �� *
CheckGDVLT+
   $ Checked��.    �� *CommandCheckGDVLT+ �� $ chkGDVLT��	� -   $��chkGDVNotLT��#��[ $��4q�$&�� DỊCH VỤ KHÔNG LIỆU TRÌNH��$	��380�����	#FF2D2F4C$��1q�( �� *CheckGDVNotLT+
   $ Checked��.    �� *CommandCheckGDVNotLT+ �� $ chkGDVLT��� $��1�� �� $
��auto ��� .+��� $ 
Horizontal=�$��0��$��0 0 0 20q�.+��� $ 
Horizontal=�$��Center=�.+��� $S��ME:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Image\Filter\filter.png��$��	20 15 0 0q�$��Center=�$��25��$��25���� -   $��	cbxFilter��$" Sắp xếp theo��$��	15 5 15 5q�$	��140��#��[
 $
& Name������ *Filter+$ �� *SelectedFilter+$ TwoWay=�$ PropertyChanged=�
   $ SelectionChanged��.    �� *CommandSelectedFilter+ �� $ 	cbxFilter���� -   $��	cbxDichVu��$" Dịch vụ��$��	15 5 15 5q�$	��230��#��[
 $& DV_TEN������ *DICHVU+$ �� *SelectedDICHVU+$ TwoWay=�$ PropertyChanged=�
   $ SelectionChanged��.    �� *CommandSelectDICHVU+ �� $ 	cbxDichVu���� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��150 10 10 10q�$��0q�$��35��$��Center=�
�������$��2q�
����d�$	��150��
����d����� *CommandInThongTinGDV+.���� $ 
Horizontal=�$��0 0 10 0q�$��Right=�.+�  $ Printer=�$��0 0 10 0q�$��25��$��25���� $��In thông tin gói��$��0 5 0 0q��� -   $��lvGDV��$��	10,20,2,0q�$��1��
������ 
������ ���� *ListGoiDichVu+$ �� *SelectedGoiDichVu+$ OneWayToSource=�
   $ SelectionChanged��.    �� *CommandSelectGOIDICHVU+ �� $ lvGDV������ .R�A� ) A� Columns$) 4��* A� Rows$* 3������ .R��� $ Vertical=�$	��210��.+��� + J� Effect+ 3  -System.Windows.Media.Effects.DropShadowEffect  ,   Color$, Black��-   	Direction$	- 270Q�.   ShadowDepth$. 1Q�/   
BlurRadius$/ 10Q�._��� $��UniformToFill=�$	��140��$	��140��$��Center=�$��	20 10 0 0q����� *GOIDICHVU.GDV_ANH+0 J� Clip0 @� 1 @� RadiusX$1 60Q�2 @� RadiusY$2 60Q�3 @� Center$3 60,60&��� $	��190��4 �� TextAlignment$4 Center=�$
��Wrap=�$��15(�$��0,5,0,0q�$��Center=�$��Sitka Subheading)�$
��Bold"����� *GOIDICHVU.GDV_TEN+�� $��Sitka Subheading)�$��Center=�
���  ��$��13(�5 �� Padding$5 1q����� *DONGIA+�� .�B� .�đ