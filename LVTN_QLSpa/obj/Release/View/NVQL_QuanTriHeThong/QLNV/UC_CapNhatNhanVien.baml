   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LVTN_QLSpa.View.QLNVLVTN_QLSpa.View.QLNV  -    'LVTN_QLSpa.View.QLNV.UC_CapNhatNhanVien   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:LVTN_QLSpa.View.QLNV     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��ucQuanLyNhanVien��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    CapNhatNhanVienVM � DataContext# [ .��� $
��Auto=� � RowDefinitions �� $
��auto ��� .+�� $��0�� � ColumnDefinitions �� $
��1.4* ��� $
��0.6* �.+�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 10Q�$��0��$��10q�.���  �� $
��auto ��� $
��auto �.+�� $��0�� �� $
��auto ��� �� �� .+�� $��0��$	��Top=�$��
10 20 0 10q� �� $
��auto ��� .+�� $��0��.+��� .+���    MaterialDesignOutlinedButton#��[ $��0q�$��20��
�������
�������$��0q�$
��Left=����� *CommandVisibilityColorZone+.����  �� Orientation$ 
Horizontal=�$��0 0 10 0q�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ CloseCircle=�$��0 0 0 0q�$��15��$��15��
���  ���� $��Bỏ chọn��
���   ��� 
���   �$	��0.5q�._��� $	��150��$	��129������ *NV_ANH+(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�$��Stretch=�$��0��$	��170��$	��130��y��� *HiddenCalorZone+���� 	 �� EndPoint$	 0.5,1&�
 � MappingMode$
 RelativeToBoundingBox=� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFFFCFB8�� � Offset$
 0.99Q�� $ 	#FF2CCEFF��.��  $ AccountCircle=�$	��170��$	��130��$��Center=�$��Center=��� $��1��$��0 15 0 0q�#��[  � ToolTip$" MaterialDesignOutlinedButton�����	#FF2D2F4C���	#FF2D2F4C���� *CommandThemAnhNV+.��Ảnh� $��1�� �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã nhân viên�� % !MaterialDesignFloatingHintTextBox#��[ $��15 10 15 10q�{�.  $��0������ *NV_MA+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.���� -   $��	txtNV_TEN��$ 	Họ tên��#��[ $��15 10 15 10q�$��1������ *
NV_HOTEN+$ TwoWay=�$ PropertyChanged=�.��.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ TextChanged��.  (System.Windows.Interactivity.TriggerBase   Actions. 6	  0System.Windows.Interactivity.InvokeCommandAction	   	  Command �� *AddIdCommandNhanVien+ 	  CommandParameter ��  �� ElementName$ 	txtNV_TEN��.��(
  "System.Windows.Controls.DatePicker
  $��15 10 15 10q�$ Ngày sinh (dd/mm/yyyy)�� ( $MaterialDesignFloatingHintDatePicker#��[ $��2�� 
  SelectedDate �� *NV_NGAYSINH+$ TwoWay=�$ PropertyChanged=��� $ Căn cước công dân��#��[ $��15 10 15 10q�$��3������ *	NV_CCCD+$ TwoWay=�$ PropertyChanged=�.��� $��2�� �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $ Email��#��[ $��15 10 15 10q�$��0������ *
NV_EMAIL+$ TwoWay=�$ PropertyChanged=��� $ Số điện thoại��#��[ $��15 10 15 10q�$��1������ *NV_SDT+$ TwoWay=�$ PropertyChanged=��� $��2��$��Center=�$ 
Horizontal=�$��15 10 15 10q�.+��� -   $��ckNV_GIOITINHNAM��$	��Nam�� $  MaterialDesignActionDarkCheckBox#��[ $&  MaterialDesignActionDarkCheckBox��$��40��$��40��$��	30 0 30 0q� d� 	IsChecked �� *NV_GIOITINHNAM+$ TwoWay=�$ PropertyChanged=�   $ Checked��. 	   �� *CheckedChangeCommandNVGTNAM+ �� $ ckNV_GIOITINHNAM���� -   $��ckNV_GIOITINHNU��$
��Nữ��#��[ $&  MaterialDesignActionDarkCheckBox��$��40��$��40��$��	30 0 30 0q� �� *NV_GIOITINHNU+$ TwoWay=�$ PropertyChanged=�   $ Checked��. 	   �� *CheckedChangeCommandNVGTNU+ �� $ ckNV_GIOITINHNU���� $ Trạng thái�� �� 
IsEditable . $��
15 8 15 10q� & "MaterialDesignFloatingHintComboBox#��[  �� DisplayMemberPath$
 Name��$��3������ *TRANGTHAINV+ �� SelectedItem �� *SelectedTRANGTHAI+$ TwoWay=�$ PropertyChanged=�� $��3�� �� $
��auto ��� $
��auto ��� $
��auto ��� .+��� -    ��Name$ chkTaoTaiKhoan��$��15 30 15 10q�$��0��$��Tạo tự động��   $ Checked��. 	   �� *CommandCreateUser+ �� $ chkTaoTaiKhoan���� -   $��txtTaiKhoan��$ Tài khoản��#��[ $��
15 8 15 10q�$��1������ *NV_USERNAME+$ TwoWay=�$ PropertyChanged=�� $��2�� �� �� .+��� -   $��cbxSelectTinhThanh��$ 	Tỉnh/TP�� . $��
15 10 5 10q�#��[ $ TT_TEN��$��0������ *	TINHTHANH+ �� *SelectedTINHTHANH+$ TwoWay=�$ PropertyChanged=�   $ SelectionChanged��. 	   �� *CommandSelectTinhThanh+ �� $ cbxSelectTinhThanh���� -   $��cbxSelectHuyenQuan��$ Huyện/Quận�� . $��
5 10 15 10q�#��[ $ HQ_TEN��$��1������ *	HUYENQUAN+ �� *SelectedHUYENQUAN+$ TwoWay=�$ PropertyChanged=�   $ SelectionChanged��. 	   �� *CommandSelectHuyenQuan+ �� $ cbxSelectHuyenQuan��� $��3�� �� �� .+��� $ Xã/Phường�� . $��
15 -7 5 10q�#��[ $ XP_TEN��$��0������ *
XAPHUONG+ �� *SelectedXAPHUONG+$ TwoWay=�$ PropertyChanged=��� $ Địa chỉ��#��[ $��
5 10 15 30q�$��1������ *	NV_DIACHI+$ TwoWay=�$ PropertyChanged=�� $��1��.+��� $ 
Horizontal=�$��Center=�$��Center=�.+���   MaterialDesignRaisedButton#��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��35��$	��150��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandAddNhanVien+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $
 Plus=�$��0 0 0 0q�$��25��$��25���� $��Thêm��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��35��$	��150��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandEditNhanVien+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ ContentSaveEditOutline=�$��0 0 5 0q�$��25��$��25���� $��Sửa��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��35��$	��150��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandDeleteNhanVien+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ DeleteOutline=�$��0 0 5 0q�$��25��$��25���� $
��Xóa��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��35��$	��150��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandClearNhanVien+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ Refresh=�$��0 0 5 0q�$��25��$��25���� $��
Làm mới��$��0 5 0 0q�  $��1��$ 10Q�$��10q�.���  �� $
��auto ��� .+��� $ Vai trò�� . $��20 10 20 10q�#��[ $ VT_TEN��$��0������ *VAITRO+ �� *SelectedVAITRO+$ TwoWay=�$ PropertyChanged=��� $��Chuyên môn�� 	 MaterialDesignGroupBox#��� 	 $��10 10 10 10q�.  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Custom=�   
Background �	#FF2D2F4C    
Foreground
  �����$��1��.���� .+��� 
���   �$��	0 0 0 0.1q�._��� $ 
Horizontal=�.+��� $��Chọn��$��15 0 0 5q��� $��Chuyên môn��$��25 0 0 5q��� .���� ! � IsSharedSizeScope! . $��5 10 5 0q����� *ListChuyenMon+���� .R��� " ��Name$" Border��# �� Padding$# 8q�$��0 0 0 1q� 
 MaterialDesignDivider#��� 
 ._��  �� $ z� SharedSizeGroup$$ Checkerz���� .+�d� $��Center=� ) %MaterialDesignActionLightToggleButton#��[  �� *
IsSelected+���� *Code+�� $��25 0 0 0q�$��1��.+��� $
��Bold"�$��16(����� *CM_TEN+�� ���� *VT_TEN+% �� Triggers% �� & �� Value$
& True��' �� Binding' �� *
IsSelected+.a��� ( �� 
TargetName$( Border��  MaterialDesignSelection) �� Value#) �  * �� Property* � ��� $��1��$	��420�� �� $
��1.4* ��� $
��0.6* �.+�  $ 10Q�$��
10 10 10 0q�$��1��.���  �� $
��auto ��� .+�� $��0��.+��� $ 
Horizontal=�$��1��$��	10 5 50 0q�$��Center=�.+�  $ Magnify=�$��25��$��25��$��0 10 0 0q��� -	   $��txtKeySearchNV��$# Nhập từ khóa tìm kiếm��#��[ $	��250������ *KeySearchNV+$ TwoWay=�$ PropertyChanged=�.��   $ TextChanged��. 	   �� *CommandKeySearchNV+ �� $ txtKeySearchNV��.��'  !MaterialDesignThemes.Wpf.PopupBox  $��Right=�$	��Top=�$��2 0 2 0q�$��0 10 0 0q�+   	StaysOpen+ . ,   PopupContent., �� $	��250��.+��� 
���   �$��	0 0 0 0.1q�$��0 0 0 10q�._��� $ Vai trò�� . $��
15 8 15 10q�#��[ $ VT_TEN������ *VaiTroFilter+ �� *SelectedVaiTroFilter+$ TwoWay=�$ PropertyChanged=��� 
���   �$��	0 0 0 0.1q�$��0 0 0 10q�._��� $ Trạng thái�� . $��
15 8 15 10q�#��[ $
 Name������ *TrangThaiFilter+ �� *SelectedTrangThaiFilter+$ TwoWay=�$ PropertyChanged=��� 
���   �$��	0 0 0 0.1q�$��0 0 0 10q�._��� $ Giới tính�� . $��
15 8 15 10q�#��[ $
 Name������ *GioiTinhFilter+ �� *SelectedGioiTinhFilter+$ TwoWay=�$ PropertyChanged=��� $��1������ *ListNhanVien+ �� *SelectedItemNhanVien+$ OneWayToSource=�   $ MouseDoubleClick��. 	   �� *CommandDoubleClickNhanVien+ �� $ 	txtNV_TEN��- �� View- �� .P��� $��Mã nhân viên��. �� CellTemplate. �� .R�� .+��� $ 
Horizontal=�.+��� $��70��$��70������ *NV_ANH+�� $��20 0 0 0q�$��Center=�$��Center=����� *NV_MA+�� $��	Họ tên��. �� .R�� .+��� $ 
Horizontal=�$��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *
NV_HOTEN+�� $��Số điện thoại��. �� .R�� .+��� $ 
Horizontal=�$��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *NV_SDT+�� $
��CCCD��. �� .R�� .+��� $ 
Horizontal=�$��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *	NV_CCCD+�� $��
Ngày sinh��. �� .R�� .+��� $ 
Horizontal=�$��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *NV_NGAYSINH+�� $��Giới tính��. �� .R�� .+��� $ 
Horizontal=�$��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *NV_GIOITINH+�� $��Tài khoản��. �� .R�� .+��� $ 
Horizontal=�$��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *NV_USERNAME+�� $��Trạng thái��. �� .R�� .+��� $ 
Horizontal=�$��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *NV_TRANGTHAI+  $��1��$��
10 10 10 0q�$ 10Q�.���� .+��� $ 
Horizontal=�.+��� $��Chuyên môn nhân viên:��$��20q�$��15(�$
��Bold"��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��130 0 10 10q�$��0q�$��30��
�������$��Bottom=�$��0q����� *CommandDeleteItemChuyenMon+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ CloseCircle=�$��5 0 5 0q�$��25��$��25��
���  ���� $
��Xóa��$��0 0 0 0q�
���  ��$��Center=��� 
���   �$��	0 0 0 0.1q�._��� $ 
Horizontal=�.+��� $
��Xóa��$��22 0 0 5q��� $��Chuyên môn��$��30 0 0 5q��� ! . $��	10 0 10 0q����� *ListChuyenMonNhanVien+���� .R��� $" Border��$# 8q�$��0 0 0 1q�#��� 
 ._��  �� $$ Checkerz���� .+�d� $��Center=�#��[  �� *IsCheckDelete+�� $��25 0 0 0q�$��1��.+��� $
��Bold"�$��16(����� *CM_TEN+�� ���� *VT_TEN+% �� $
& True��' �� *
IsSelected+.a��� $( Border��#) �  * � ��