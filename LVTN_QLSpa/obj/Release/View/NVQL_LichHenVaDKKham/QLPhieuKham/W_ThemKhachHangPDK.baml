   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham0LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  I    CLVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham.W_ThemKhachHangPDK   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Plocal>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wThemKhachHangPDK��  � Title$  W_ThemKhachHangPDK��$	��615��$	��400�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    ThemKhachHangPDKVM � DataContext# [ ��Z� .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger  	   	EventName$	 Loaded��.  (System.Windows.Interactivity.TriggerBase
   Actions.
 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wThemKhachHangPDK��.��� .+��� 
���   �$��2q� �� CornerRadius$ 15 15 15 15��._�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q����	#FFF7F7F7.���  � RowDefinitions �� $
��auto ��� .+�� $��0��.+�,   &LVTN_QLSpa.UserControlSpa.UseControlUC  
 � Tag �� *Title+$ WLapPhieuDangKy��� $��1�� �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� .+��� $$��Nhập thông tin khách hàng��$
��Bold"�$��20(�$��10q�� $��1��$��20 10 20 10q� � ColumnDefinitions �� $
��auto ��� .+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Magnify=�$��25��$��25��$��0��$��	0 10 10 0q�$��Center=��� -   $��cbxKhachHang��)	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ Tìm kiếm khách hàng�� 	  HintOpacity$	 .26Q� �� 
IsEditable .  & "MaterialDesignFloatingHintComboBox#��[ $��1�� �� DisplayMemberPath$ KH_HOTEN������ *	KHACHHANG+ �� SelectedItem �� *SelectedKHACHHANG+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectKhachHang+ �� $ cbxKhachHang��� $��2��.+��� $��5q�$	��0.1q�
���   ��� $ Tên khách hàng�� % !MaterialDesignFloatingHintTextBox#��[ $��30 10 30 10q�$��3������ *KH_TEN+$ TwoWay=�$ PropertyChanged=�.���� $ Số điện thoại��#��[ $��30 10 30 10q�$��4������ *KH_SDT+$ TwoWay=�$ PropertyChanged=�.���� $ Email��#��[ $��30 10 30 10q�$��5������ *
KH_EMAIL+$ TwoWay=�$ PropertyChanged=�.��(
  "System.Windows.Controls.DatePicker
  $��30 10 30 10q�$ Ngày sinh (dd/mm/yyyy)�� ( $MaterialDesignFloatingHintDatePicker#��[ $��6�� 
  SelectedDate �� *KH_NGAYSINH+$ TwoWay=�$ PropertyChanged=�� $��7�� �� �� $
��0.9* ��� .+��� -   $��cbxSelectTinhThanh��$ 	Tỉnh/TP��$	 .26Q� . $��
30 10 5 10q�#��[ $��0��$ TT_TEN������ *	TINHTHANH+ �� *SelectedTINHTHANH+$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectTinhThanh+ �� $ cbxSelectTinhThanh���� -   $��cbxSelectHuyenQuan��$ Quận/Huyện��$	 .26Q� . $��	5 10 5 10q�#��[ $��1��$ HQ_TEN������ *	HUYENQUAN+ �� *SelectedHUYENQUAN+$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectHuyenQuan+ �� $ cbxSelectHuyenQuan���� $ Xã/Phường��$	 .26Q� . $��
5 10 30 10q�#��[ $��2��$ XP_TEN������ *
XAPHUONG+ �� *SelectedXAPHUONG+$ TwoWay=�$ PropertyChanged=��� $ Địa chỉ��#��[ $��30 10 30 10q�$��8������ *	KH_DIACHI+$ TwoWay=�$ PropertyChanged=�.���� $��9��$��Center=� �� Orientation$ 
Horizontal=�$��	15 8 15 8q�.+��� -   $��ckKH_GIOITINHNAM��$	��Nam�� $  MaterialDesignActionDarkCheckBox#��[  � ToolTip$&  MaterialDesignActionDarkCheckBox��$��40��$��40��$��	30 0 30 0q� d� 	IsChecked �� *KH_GIOITINHNAM+$ TwoWay=�$ PropertyChanged=�   $	 Checked��.
    �� *CheckedChangeCommandKHGTNAM+ �� $ ckKH_GIOITINHNAM���� -   $��ckKH_GIOITINHNU��$
��Nữ��#��[ $&  MaterialDesignActionDarkCheckBox��$��40��$��40��$��	30 0 30 0q� �� *KH_GIOITINHNU+$ TwoWay=�$ PropertyChanged=�   $	 Checked��.
    �� *CheckedChangeCommandKHGTNU+ �� $ ckKH_GIOITINHNU��� $��10�� �� �� .+���   MaterialDesignRaisedButton#��[ $/ )Resource name: MaterialDesignRaisedButton��$��10q�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��$��40��$��0��$��Bottom=����	#FF2D2F4C$��0q����� *CommandAddKhachHang+���� $ wThemKhachHangPDK��.���� $ 
Horizontal=�$��0 0 6 0q�.+�  $ ContentSave=�$��0 0 5 0q�$��25��$��25���� $��Lưu thông tin��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10q�$ 10��$��40��$��1��$��Bottom=�$��0q����	#FFCA3C2A���� *CommandClose+���� $ wThemKhachHangPDK��.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ DeleteForeverOutline=�$��0 0 0 0q�$��25��$��25���� $��Hủy��$��0 5 0 0q�