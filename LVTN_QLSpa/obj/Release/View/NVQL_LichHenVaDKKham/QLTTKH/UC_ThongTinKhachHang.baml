   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLTTKH+LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLTTKH  F    @LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLTTKH.UC_ThongTinKhachHang   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Klocal9clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLTTKH     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wThongTinKhachHang��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    ThongTinKhachHangVM � DataContext# [ .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wThongTinKhachHang��.��� 	 � RowDefinitions	 �� $
��auto ��� .+��� $��0��$��
16 16 16 4q� $  MaterialDesignHeadline5TextBlock#��[ $��Thông tin khách hàng��
���   �� $��1��
 � ColumnDefinitions
 �� $
��0.9* ��� $
��0.9* ��� $
��1.6* �.+�#  MaterialDesignThemes.Wpf.Card  $��0��$��10 10 10 20q�   UniformCornerRadius$ 10Q�.��� 	 �� $
��auto ��� .+�� $��0��
 �� $
��1.3* ��� .+��� -   $��txtKeySearchKH��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Nhập từ khóa tìm kiếm�� % !MaterialDesignFloatingHintTextBox#��[ $��0��$��15 10 10 10q����� *KeySearchKH+.��   $ TextChanged��.    �� *CommandKeySearchKH+ �� $ txtKeySearchKH��.����   MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��$��35��$��1��$��0q�$��Bottom=�$��0q����	#FF2D2F4C���� *CommandClearKH+.����  �� Orientation$ 
Horizontal=�$��0 0 10 0q�.+�'	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$ Refresh=�$��0 0 10 0q�$��25��$��25���� $��
Làm mới��$��0 5 0 0q�� $��1��.+��� -   $��lbxKhachHang������ *ListKhachHang+ �� SelectedItem �� *SelectedKhachHang+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   $ SelectionChanged��.    �� *CommandSelectedKhachHang+ �� $ lbxKhachHang������ .R��� $ 
Horizontal=�.+��� $��40��$��40������ *KH_ANH+�� .+��� $ 
Horizontal=�.+��� $��15 0 0 0q�$��15(�$
��Bold"����� *KH_TEN+�� $	�� - ��$��15(�$
��Bold"��� $��15(�$
��Bold"����� *KH_MA+�� $ 
Horizontal=�.+��� $ 
Horizontal=�$
��Left=�$��Center=�$��15 0 0 0q�.+�	  $ 
PhoneCheck=�$��0 3 5 0q���  " MaterialDesignCaptionTextBlock#��[ ���� *KH_SDT+$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�$
��Left=�$��Center=�$��30 0 0 0q�.+�	  $
 Cake=�$��0 0 5 0q��� #��[ ���� *KH_NGAYSINH+ �� StringFormat$ 
dd/MM/yyyy��$ TwoWay=�$ PropertyChanged=�  $��1��$��10 10 10 20q�$ 10Q�.��� 	 �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� .+�� $��0��$��0 0 0 0q�
 �� �� $
��auto �.+��� $ Mã khách hàng��#��[ $��30 15 30 10q�{�.  $��0������ *KH_MA+$ TwoWay=�$ PropertyChanged=�.��'
  !MaterialDesignThemes.Wpf.PopupBox
  $��Right=�$	��Top=�$��2 0 2 0q�$��0 10 0 0q� 
  	StaysOpen . $��1�� 
  PopupContent. �� $	��250��$	��190��.+��� $��0q����� *CommandThanhToanNo+.���� $ 
Horizontal=�$
��Left=�$��40��.+�	  $ CurrencyUsd=�$��35��$��35��$��0 15 0 0q�$��Center=�$
��Left=��� $��Thanh toán nợ��$
��Left=�$��	10 15 0 0q�$��16(�$��Center=��� $��0q����� *CommandDatLichHen+.���� $ 
Horizontal=�$
��Left=�$��40��.+�	  $ CalendarPlus=�$��35��$��35��$��0 15 0 0q�$��Center=�$
��Left=��� $��Đặt lịch hẹn��$
��Left=�$��	12 15 0 0q�$��16(�$��Center=��� $��0q����� *CommandDangKyDichVu+.���� $ 
Horizontal=�.+�	  $ TextBoxPlusOutline=�$��35��$��35��$��0 15 0 0q�$��Center=�$
��Left=��� $��Đăng ký dịch vụ��$
��Left=�$��	12 15 0 0q�$��16(�$��Center=��� -   $��	txtKH_TEN��$ Tên khách hàng��#��[ $��30 15 30 15q�$��1������ *
KH_HOTEN+$ TwoWay=�$ PropertyChanged=�.��   $ TextChanged��.    �� *AddIdCommandNhanVien+ �� $ 	txtKH_TEN��.���� $ Số điện thoại��#��[ $��30 15 30 15q�$��2������ *KH_SDT+$ TwoWay=�$ PropertyChanged=�.���� $ Email��#��[ $��30 15 30 15q�$��3������ *
KH_EMAIL+$ TwoWay=�$ PropertyChanged=�.��(  "System.Windows.Controls.DatePicker  $��30 15 30 15q�$ Ngày sinh (dd/mm/yyyy)�� ( $MaterialDesignFloatingHintDatePicker#��[ $��4��   SelectedDate �� *KH_NGAYSINH+$ TwoWay=�$ PropertyChanged=�� $��5��
 �� �� .+��� -   $��cbxSelectTinhThanh��$ 	Tỉnh/TP�� �� 
IsEditable . $��
30 15 5 15q� & "MaterialDesignFloatingHintComboBox#��[  �� DisplayMemberPath$ TT_TEN��$��0������ *	TINHTHANH+ �� *SelectedTINHTHANH+$ TwoWay=�$ PropertyChanged=�   $ SelectionChanged��.    �� *CommandSelectTinhThanh+ �� $ cbxSelectTinhThanh���� -   $��cbxSelectHuyenQuan��$ Huyện/Quận�� . $��
5 15 30 15q�#��[ $ HQ_TEN��$��1������ *	HUYENQUAN+ �� *SelectedHUYENQUAN+$ TwoWay=�$ PropertyChanged=�   $ SelectionChanged��.    �� *CommandSelectHuyenQuan+ �� $ cbxSelectHuyenQuan��� $��6��
 �� �� .+��� $ Xã/Phường�� . $��
30 15 5 15q�#��[ $ XP_TEN��$��0������ *
XAPHUONG+ �� *SelectedXAPHUONG+$ TwoWay=�$ PropertyChanged=��� $ Địa chỉ��#��[ $��
5 15 30 15q�$��1������ *	KH_DIACHI+$ TwoWay=�$ PropertyChanged=��� $��7��$��Center=�$ 
Horizontal=�$��	15 8 15 8q�.+��� -   $��ckKH_GIOITINHNAM��$	��Nam�� $	  MaterialDesignActionDarkCheckBox#��[	 $&  MaterialDesignActionDarkCheckBox��$��40��$��40��$��30 15 30 15q� d� 	IsChecked �� *KH_GIOITINHNAM+$ TwoWay=�$ PropertyChanged=�   $ Checked��.    �� *CheckedChangeCommandKHGTNAM+ �� $ ckKH_GIOITINHNAM���� -   $��ckKH_GIOITINHNU��$
��Nữ��#��[	 $&  MaterialDesignActionDarkCheckBox��$��40��$��40��$��30 15 30 15q� �� *KH_GIOITINHNU+$ TwoWay=�$ PropertyChanged=�   $ Checked��.    �� *CheckedChangeCommandKHGTNU+ �� $ ckKH_GIOITINHNU��� $��8��
 �� �� �� .+��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10q�$ 10��$��0��$��60��$��Bottom=����	#FF2D2F4C$��0q����� *CommandAddKH+.���� $��0 0 0 0q�.+�	  $
 Plus=�$��25��$��25��$��0 0 0 5q�$��Center=��� $��Thêm��$��Center=��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10q�$ 10��$��1��$��60��$��Bottom=����	#FF2D2F4C$��0q����� *CommandEditKH+.���� $��0 0 0 0q�.+�	  $ ContentSaveEditOutline=�$��25��$��25��$��0 0 0 5q�$��Center=��� $��Sửa��$��Center=��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10q�$ 10��$��2��$��60��$��Bottom=����	#FF2D2F4C$��0q����� *CommandDeleteKH+.���� $��0 0 0 0q�.+�	  $ DeleteOutline=�$��25��$��25��$��0 0 0 5q�$��Center=��� $
��Xóa��$��Center=�� $��2��	 �� $
��1.1* ��� $
��0.9* �.+�  $��0��$��10q�$ 10Q�.��� 	 �� $
��auto ��� .+�� $��0��
 �� $
��0.9* ��� $
��1.1* ��� $
��auto �.+��� $ 
Horizontal=�$��0��$��10 5 0 0q�$
��Left=�.+�	  $ Magnify=�$��25��$��25��$��0 10 0 0q��� -	   $��txtKeySearchPDK��$# Nhập từ khóa tìm kiếm��#��[ $	��200������ *KeySearchPDK+.��   $ TextChanged��.    �� *CommandKeySearchPDK+ �� $ txtKeySearchPDK��.���� $ 
Horizontal=�$��1��$��Right=�.+��� $ Trạng thái đăng ký�� . #��[ $
 Name��$��0 3 0 0q����� *TTDK+ �� *SelectedTTDK+$ TwoWay=�$ PropertyChanged=��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$ 5��$��Sửa�����	#FF2D2F4C$��70��$��
10 10 10 0q���Z� ���� *CommandEditTTDK+
  $��Right=�$	��Top=�$��2 0 2 0q�$��0 10 0 0q�$��2��. �� $	��200��.+��� $!��Lịch trình điều trị������ *CommandXemLichTrinhDieuTri+�� $!��Tạo phiếu điều trị������ *CommandLapPhieuDieuTri+�� $��1������ *ListPhieuDangKy+ �� *SelectedListPhieuDangKy+$ OneWayToSource=� �� View �� .P��� $��Số PDK�� �� CellTemplate �� .R�� .+��� $��20 0 0 0q�$��Center=����� *	PDK_STT+�� $��Gói dịch vụ�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *GOIDICHVU.GDV_TEN+�� $��Ngày đăng ký�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *
PDK_NGAYDK+$ 
dd/MM/yyyy���� $��Ngày bắt đầu�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *PDK_NGAYBATDAU+$ 
dd/MM/yyyy���� $��Trạng thái�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *PDK_TRANGTHAI+�� $��Cách thanh toán�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *CACHTHANHTOAN.CTT_TEN+  $��1��$��10 10 10 20q�$ 10Q�.���� ���� *ListPhieuDieuTri+ �� *SelectedPhieuDieuTri+$ OneWayToSource=� �� .P��� $��Số PDT�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *	PDT_STT+�� $��Ngày khám�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *PDT_NGAYLAP+$ 
dd/MM/yyyy���� $��Trạng thái khám�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *PDT_TRANGTHAI+�� $��Trạng thái thanh toán�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *PDT_TRANGTHAINNO+