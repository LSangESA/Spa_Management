   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:LVTN_QLSpa.View.QLCTKMLVTN_QLSpa.View.QLCTKM  4    .LVTN_QLSpa.View.QLCTKM.UC_ChuongTrinhKhuyenMai   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:LVTN_QLSpa.View.QLCTKM     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��
wKhuyenMai��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    ChuongTrinhKhuyenMaiVM � DataContext# [ .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ 
wKhuyenMai��.��� 	 � RowDefinitions	 �� $
��auto ��� .+�� $��0��
 � ColumnDefinitions
 �� $
��1.4* ��� $
��0.6* �.+�#  MaterialDesignThemes.Wpf.Card  $��0��$��10q�   UniformCornerRadius$ 10Q�.��� 	 �� $
��auto ��� $
��auto �.+�� $��0��
 �� �� .+�� $��0��	 �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã chương trình KM�� % !MaterialDesignFloatingHintTextBox#��[ {�.  $��30 10 30 10q�$��0������ *GG_MA+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.���� -   $��	txtGG_TEN��$ Tên chương trình KM��#��[ $��30 10 30 10q�$��1������ *GG_TEN+$ TwoWay=�$ PropertyChanged=�.��   $ TextChanged��.    �� *CommandAddIdGG+ �� $ 	txtGG_TEN��.���� $ 
Nội dung��#��[ $��30 10 30 10q�$��2������ *
GG_NOIDUNG+$ TwoWay=�$ PropertyChanged=�.���� $��3�� �� Orientation$ 
Horizontal=�$��	0 10 0 10q�.+��� -   $��chkCheckGG_GDV��  MaterialDesignDarkCheckBox#��[ $��Theo gói dịch vụ��$��	30 0 20 0q� d� 	IsChecked �� *CheckGG_GDV+$ TwoWay=�$ PropertyChanged=��� -   $��chkCheckGG_LT��#��[ $��Theo liệu trình�� �� *
CheckGG_LT+$ TwoWay=�$ PropertyChanged=�� $��1��	 �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+�(  "System.Windows.Controls.DatePicker  $ Ngày bắt đầu�� ( $MaterialDesignFloatingHintDatePicker#��[ $��0��$��30 10 30 10q�   SelectedDate �� *GG_NGAYBATDAU+$ TwoWay=�$ PropertyChanged=�  $ Ngày kết thúc��#��[ $��1��$��30 10 30 10q� �� *GG_NGAYKETTHUC+$ TwoWay=�$ PropertyChanged=��� $ Phần trăm giảm (%)��#��[ $��30 10 30 10q�$��2������ *GG_PHANTRAMGIAM+$ TwoWay=�$ PropertyChanged=�.���� $ Trạng thái�� �� 
IsEditable . $��30 10 30 10q� & "MaterialDesignFloatingHintComboBox#��[  �� DisplayMemberPath$
 Name��$��3������ *TRANGTHAIGG+ �� SelectedItem �� *SelectedTRANGTHAIGG+$ TwoWay=�$ PropertyChanged=�� $��1��.+��� $ 
Horizontal=�$��Center=�$��Center=�.+���   MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��35��$	��150��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandAddGG+.���� $ 
Horizontal=�$��0 0 10 0q�.+�'	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$
 Plus=�$��0 0 0 0q�$��25��$��25���� $��Thêm��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��35��$	��150��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandEditGG+.���� $ 
Horizontal=�$��0 0 10 0q�.+�	  $ ContentSaveEditOutline=�$��0 0 5 0q�$��25��$��25���� $��Sửa��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��35��$	��150��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandDeleteGG+.���� $ 
Horizontal=�$��0 0 10 0q�.+�	  $ DeleteOutline=�$��0 0 5 0q�$��25��$��25���� $
��Xóa��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��35��$	��150��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandClearGG+.���� $ 
Horizontal=�$��0 0 10 0q�.+�	  $ Refresh=�$��0 0 5 0q�$��25��$��25���� $��
Làm mới��$��0 5 0 0q�  $��1��$��10q�$ 10Q�.��� 	 �� $
��auto ��� .+��� $ Dịch vụ�� . $��30 10 30 10q�#��[ $ DV_TEN��$��0������ *DICHVU+ �� *
SelectedDV+$ TwoWay=�$ PropertyChanged=��� $��Gói dịch vụ��  MaterialDesignGroupBox#���  $��10 10 10 10q�.
  (MaterialDesignThemes.Wpf.ColorZoneAssist 
  Mode$ Custom=� 
  
Background �	#FF2D2F4C 
  
Foreground
 �����$��1��.���� .+��� 
���   �$��	0 0 0 0.1q�._��� $ 
Horizontal=�.+��� -   $��chkCheckAllGDV��#��[ $��
Tất cả��$��	22 -7 0 0q� �� *CheckAllGDV+$ TwoWay=�$ PropertyChanged=�   $ Checked��.    �� *CommandCheckAllGDV+ �� $ chkCheckAllGDV��  $ 	Unchecked��.    �� *CommandUnCheckAllGDV+ �� $ chkCheckAllGDV���� $��Gói dịch vụ��$��25 0 0 5q�$��Center=���   	 MaterialDesignOutlinedButton#��[	 $/ )Resource name: MaterialDesignRaisedButton��$��130 0 10 10q�$��0q�$��15��
�������$��Bottom=�$��0q����� *CommandAddGiamGDV+.���� $ 
Horizontal=�$��0 0 10 0q�.+�	  $ CheckboxMarkedCircle=�$��5 0 5 0q�$��15��$��15��
��� � ��� $��Nhập��$��0 0 0 0q�
��� � �$��Center=�$��13(��� $	��150��.����  � IsSharedSizeScope . $��5 10 5 0q����� *	ListGDV+���� .R���  ��Name$ Border�� �� Padding$ 8q�$��0 0 0 1q� 
 MaterialDesignDivider#��� 
 ._�� 
 ��  z� SharedSizeGroup$ Checkerz���� .+�d� $��Center=� ) %MaterialDesignActionLightToggleButton#��[  �� *	IsCheck+���� *Code+�� $��25 0 0 0q�$��1��.+��� $
��Bold"�$��16(����� *	GDV_TEN+�� ���� *DV_TEN+ �� Triggers ��  �� Value$
 True��  �� Binding  �� *
IsSelected+.a��� ! �� 
TargetName$! Border��  MaterialDesignSelection" �� Value#" �  # �� Property# � ��� $��1��
 �� $
��1.4* ��� $
��0.6* �.+�  $��0��$��10 10 10 20q�$ 10Q�.��� 	 �� $
��auto ��� .+�� $��0��.+��� #��[ $/ )Resource name: MaterialDesignRaisedButton��+  %MaterialDesignThemes.Wpf.ButtonAssist$   CornerRadius$$ 5��$��Gửi tin nhắn��$��20 0 0 0q�$	��150��$��Bottom=����	#FF2D2F4C$��0q�$
��Left=����� *CommandShowGTN+�� $ 
Horizontal=�$��1��$��	10 5 50 0q�$��Center=�.+�	  $ Magnify=�$��25��$��25��$��0 10 0 0q��� -   $��txtKeySearch��$# Nhập từ khóa tìm kiếm��#��[ $	��250������ *	KeySearch+$ TwoWay=�$ PropertyChanged=�.��   $ TextChanged��.    �� *CommandKeySearch+ �� $ txtKeySearch��.��'  !MaterialDesignThemes.Wpf.PopupBox  $��Right=�$	��Top=�$��2 0 2 0q�$��0 10 0 0q�%   	StaysOpen% . &   PopupContent.& �� $	��300��.+��� 
���   �$��	0 0 0 0.1q�$��0 0 0 10q�._��� $ Trạng thái�� . $��
15 8 15 10q�#��[ $
 Name������ *TrangThaiFilter+ �� *SelectedTrangThaiFilter+$ TwoWay=�$ PropertyChanged=��� 
���   �$��	0 0 0 0.1q�$��0 0 0 10q�._��� $ Loại giảm giá�� . $��
15 8 15 10q�#��[ $ LGG_TEN������ *LoaiGiamGiaFilter+ �� *SelectedLoaiGiamGiaFilter+$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�$��5 10 5 0q�.+��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$$ 5��$��10 10 10 10q�$��35��$��0q�$	��130��$��Bottom=�$��0q�
��� � ����� *
CommnadLoc+.���� $ 
Horizontal=�$��0 0 10 0q�.+�	  $ Filter=�$��0 0 10 0q�$��25��$��25���� $��Lọc��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$$ 5��$��10 10 10 10q�$��35��$	��130��$��2��$��Bottom=�$��0q����	#FFCA3C2A���� *CommandXoaLoc+.���� $ 
Horizontal=�$��0 0 10 0q�.+�	  $ FilterVariantRemove=�$��0 0 5 0q�$��25��$��25���� $��
Xóa lọc��$��0 5 0 0q�� $��1��.+��� ���� *ListGiamGia+ �� *SelectedItemGiamGia+$ OneWayToSource=�' �� View' �� .P��� $��Mã giảm giá��( �� CellTemplate( �� .R�� .+��� $��20 0 0 0q�$��Center=�$��Center=����� *GG_MA+�� $��Tên giảm giá��( �� .R�� .+��� $��20 0 0 0q�$��Center=�$��Center=����� *GG_TEN+�� $��Phần trăm giảm��( �� .R�� .+��� $��20 0 0 0q�$��Center=�$��Center=����� *GG_PHANTRAMGIAM+�� $��Ngày bắt đầu��( �� .R�� .+��� $��20 0 0 0q�$��Center=�$��Center=����� *GG_NGAYBATDAU+) �� StringFormat$) 
dd/MM/yyyy���� $��Ngày kết thúc��( �� .R�� .+��� $��20 0 0 0q�$��Center=�$��Center=����� *GG_NGAYKETTHUC+$) 
dd/MM/yyyy���� $��
Nội dung��( �� .R�� .+��� $��20 0 0 0q�$��Center=�$��Center=����� *
GG_NOIDUNG+�� $��Trạng thái��( �� .R�� .+��� $��20 0 0 0q�$��Center=�$��Center=����� *GG_TRANGTHAI+  $��1��$��10 10 10 20q�$ 10Q�.���� .+��� $ 
Horizontal=�.+��� $��Gói dịch vụ chọn:��$��20q�$��15(�$
��Bold"��� #��[	 $/ )Resource name: MaterialDesignRaisedButton��$��130 0 10 10q�$��0q�$��30��
�������$��Bottom=�$��0q����� *CommandDeleteItemGDV+.���� $ 
Horizontal=�$��0 0 10 0q�.+�	  $ CloseCircle=�$��5 0 5 0q�$��25��$��25��
���  ���� $
��Xóa��$��0 0 0 0q�
���  ��$��Center=��� 
���   �$��	0 0 0 0.1q�._��� $ 
Horizontal=�.+��� -   $��chkCheckAllDeleteGDV��#��[ $��
Tất cả��$��	22 -7 0 0q� �� *CheckAllDeleteGG+$ TwoWay=�$ PropertyChanged=�   $ Checked��.    �� *CommandCheckAllDeleteGDV+ �� $ chkCheckAllDeleteGDV��  $ 	Unchecked��.    �� *CommandUnCheckAllDeleteGDV+ �� $ chkCheckAllDeleteGDV���� $��Gói dịch vụ��$��30 0 0 5q��� .����  . $��	10 0 10 0q����� *ListGiamGiaGDV+���� .R��� $ Border��$ 8q�$��0 0 0 1q�#��� 
 ._�� 
 �� $ Checkerz���� .+�d� $��Center=�#��[  �� *	IsCheck+�� $��25 0 0 0q�$��1��.+��� $
��Bold"�$��16(����� *	GDV_TEN+�� ���� *DV_TEN+ �� $
 True��  �� *
IsSelected+.a��� $! Border��#" �  # � ��