   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuThu/LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuThu  G    ALVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuThu.UC_BaoCaoPhieuThu   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Olocal=clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuThu     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wBaoCaoPhieuThu��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    BaoCaoPhieuThuVM � DataContext# [ .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wBaoCaoPhieuThu��.��� 	 � RowDefinitions	 �� $
��auto ��� .+�#  MaterialDesignThemes.Wpf.Card  $��0��$��10 20 10 10q�
   UniformCornerRadius$
 10Q�.���  � ColumnDefinitions �� �� $
��1.7* ��� $
��auto ��� $
��auto �.+���  �� Orientation$ 
Horizontal=�$��0��$��10 5 0 0q�$
��Left=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Magnify=�$��25��$��25��$��0 13 0 0q��� -   $��txtKeySearch��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Nhập từ khóa tìm kiếm�� % !MaterialDesignFloatingHintTextBox#��[ $��5 0 0 15q�$	��300������ *	KeySearch+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��   $ TextChanged��.    �� *KeySearchCommand+ �� $ txtKeySearch��.���� $��1��$ 
Horizontal=�.+�(	  "System.Windows.Controls.DatePicker	  $	��180��$��	0 0 20 10q�$ 
Từ ngày�� ( $MaterialDesignFloatingHintDatePicker#��[  	  SelectedDate �� *NGAYBD+$ TwoWay=�$ PropertyChanged=�	  $	��180��$ Đến ngày��$��	0 0 20 10q�#��[  �� *NGAYKT+$ TwoWay=�$ PropertyChanged=���   MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��
0 10 10 10q�+
  %MaterialDesignThemes.Wpf.ButtonAssist 
  CornerRadius$ 10��$��35��$��5q�$��Center=����	#FF2D2F4C$��0q����� *CommandLocNgay+.���� $ 
Horizontal=�$��0 0 6 0q�.+�  $ Filter=�$��0 0 0 0q�$��25��$��25���� $��Lọc��$��0 5 0 0q��� -   $��
cbxNgayXem��$ Chọn ngày xem��$��2�� �� 
IsEditable . $��	10 0 0 10q� & "MaterialDesignFloatingHintComboBox#��[  �� DisplayMemberPath$
 Name��$	��150������ *FilterNgayXem+ �� SelectedItem �� *SelectedFilterNgayXem+$ TwoWay=�$ PropertyChanged=�   $ SelectionChanged��.    �� *CommandSelectedFilterNgayXem+ �� $ 
cbxNgayXem���� -   $��cbxNHANVIEN��$ Nhân viên lập��$��2�� . $��
10 0 40 10q�$	��200��#��[ $
 Name������ *
NHANVIEN+ �� *SelectedNHANVIEN+$ TwoWay=�$ PropertyChanged=�   $ SelectionChanged��.    �� *CommandSelectedNHANVIEN+ �� $ cbxNHANVIEN��� $��1�� �� $
��1.3* ��� $
��0.7* �.+�  $��10 10 10 20q�$
 10Q�$��0��.��� 	 �� $
��auto ��� $
��auto ��� .+�� $��0�� �� $	��400 ��� �� $	��165 �.+��� $ 
Horizontal=�$��15 15 10 10q�$��0��.+��� $ 
Horizontal=�$��Center=�.+��� $��Danh sách phiếu thu: ��$
��Bold"�$��15(��� $��(��$��14(��� 
���  ��$��14(����� *TONGSOPHIEUTHU+�� $�� phiếu thu - ��$��14(��� $��Tổng: ��$��14(��� $ 
Horizontal=�.+��� 
���  ��$��14(����� *TONGTIENPHIEUTHU+�� $��đ��
���  ��$��14(��� $��)��$��14(��� $U��OE:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Icons\pay\bill.png��$��25��$��25��$��	10 -5 0 0q���    MaterialDesignOutlinedButton#��[ $/ )Resource name: MaterialDesignRaisedButton��$��150 10 10 10q�$��0q�$��35��$��1��$��Right=�
�������$��2q�
����d�$	��150��
����d����� *CommandInPhieuThu+.���� $ 
Horizontal=�$��0 0 10 0q�$��Right=�.+�  $ Printer=�$��0 0 10 0q�$��25��$��25���� $��In lại��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
0 10 10 10q�$��0q�$��35��$��2��$��Center=�
�������$��2q�
����d�$	��150��
����d����� *CommandXuatPhieuThu+.���� $ 
Horizontal=�$��0 0 10 0q�$��Right=�.+�  $ FileExportOutline=�$��0 0 10 0q�$��25��$��25���� $��Xuất Excel��$��0 5 0 0q��� $��	10 5 10 5q�$	��0.1q�
���   �$��1���� -   $��lvwPHIEUTHU��$��2������ *
PHIEUTHU+ �� *SelectedPHIEUTHU+$ TwoWay=�$ PropertyChanged=�   $ SelectionChanged��.    �� *CommandSelectedPHIEUTHU+ �� $ lvwPHIEUTHU�� �� View �� .P��� $��Số phiếu thu�� �� CellTemplate �� .R�� .+��� $��20 0 0 0q�$��Center=����� *PT_STT+�� $��Ngày lập�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *
PT_NGAYLAP+ �� StringFormat$ dd/MM/yyyy HH:mm���� $��Hình thức thanh toán�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *HINHTHUCTHANHTOAN.HTTT_TEN+�� $��Tổng tiền�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *PT_TONGTIEN+$ {0:n0}���� $��Nhân viên lập�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *NHANVIEN.NV_HOTEN+  $��10 10 10 20q�$
 10Q�$��1��.��� 	 �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $	��300 ��� $
��auto ��� $
��auto �.+�� $��0�� �� �� .+��� $ 
Horizontal=�$��Center=�$��15 15 10 10q�$��0��.+��� $��Chi tiết phiếu thu��$
��Bold"�$��17(��� $��1��.+��� $ 
Horizontal=�$��Center=�$��15 10 15 10q�$��Right=�.+��� $��Số phiếu: ��$��14(��� $��14(�
���  ������ *PT_STT+�� $ 
Horizontal=�$��Center=�$��	15 0 15 5q�$��Right=�.+��� $��Nhân viên lập: ��$��12(�$��Italic$��� $��12(�
���  ������ *NV_TEN+�� $��	10 5 10 5q�$	��0.1q�
���   �$��1��� $��2��	 �� $
��auto ��� �� �� .+�� $��0��$��0 10 0 0q� �� $	��100 ��� .+��� $��70��$��70��$��0��$��20 10 20 20q����� *KH_ANH+� $��1��	 �� $
��auto ��� $
��auto �.+��� $ 
Horizontal=�$��20 5 0 0q�$��0��$
��Left=�$��Center=�.+���  $  MaterialDesignHeadline6TextBlock#��[ ���� *KH_TEN+�� $ 
Horizontal=�.+���   	 MaterialDesignBody2TextBlock#��[	 $��Mã KH: ��$��20 5 0 0q��� #��[	 $��0 5 0 0q����� *KH_MA+� $��1�� �� $
��0.6* ��� .+��� $��0��$��
20 10 0 10q�.+��� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $ 
PhoneCheck=�$��0 3 5 0q���  "
 MaterialDesignCaptionTextBlock#��[
 ���� *KH_SDT+�� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $ GenderMaleFemale=�$��0 0 5 0q��� #��[
 ���� *KH_GIOITINH+�� $��1��$��20 10 10 10q�.+��� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $
 Cake=�$��0 0 5 0q��� #��[
 ���� *KH_NGAYSINH+$ 
dd/MM/yyyy���� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $ Email=�$��0 3 5 0q��� #��[
 ���� *
KH_EMAIL+�� $��10q�$	��0.1q�
���   �$��3��� $��4��$��
20 10 10 0q�	 �� �� $
��auto �.+��� $��0�� � IsSharedSizeScope . ���� *PHIEUDIEUTRI+���� .R���  ��Name$ Border�� �� Padding$ 8q�$��0 0 0 1q�  MaterialDesignDivider#���  ._��  ��  z� SharedSizeGroup$ Checkerz���� .+��� $Y��SE:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Icons\pay\expenses.png��$��30��$��30���� $��8 0 0 0q�$��1��.+��� $ 
Horizontal=�.+��� $
��Bold"�$��16(����� *	PDT_STT+�� $
��Bold"�$��16(�$	�� - ���� $
��Bold"�$��16(����� *PDT_NGAYLAP+�� $ 
Horizontal=�.+��� ���� *	PDK_STT+�� $
��Bold"�$	�� - ���� ���� *	GDV_TEN+�� $ 
Horizontal=�$��1��.+��� $ ��Hình thức thanh toán: ��#��[
 $��15(�$��Italic$��� $
��Bold"�#��[
 $��15(����� *
HTTT_TEN+�� $��25��$��25��$��5 0 0 0q����� *	HTTT_ICON+�� $��10q�$	��0.1q�
���   �$��5��� $��6�� �� �� .+��� $��20 0 0 0q�$��0��.+��� $��Thành tiền��#��[
 $��15(��� $��Giảm giá��$��15(�$��0 7 0 0q�#��[
 
���  ���� $��
Tổng thu��#��[
 $��0 7 0 0q�$��20(��� $��0 0 20 0q�$��1��$��Right=�.+��� $ 
Horizontal=�$��Right=�.+��� $��Right=�#��[
 $��15(����� *	THANHTIEN+�� $��đ��$��Right=�#��[
 $��15(��� $ 
Horizontal=�$��Right=�.+��� $��15(�$��0 7 0 0q�$��Right=�#��[
 
���  ������ *	GIAMGIA+�� $��đ��$��15(�$��0 7 0 0q�$��Right=�#��[
 
���  ���� $ 
Horizontal=�$��Right=�.+��� #��[
 $��0 7 0 0q�$��Right=�$��20(����� *
TONGTIEN+�� $��đ��#��[
 $��0 7 0 0q�$��Right=�$��20(�