   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LVTN_QLSpa.View.QLDVLVTN_QLSpa.View.QLDV  .    (LVTN_QLSpa.View.QLDV.UC_CapNhatGoiDichVu   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:LVTN_QLSpa.View.QLDV     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��
wGoiDichVu��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    CapNhatGoiDichVuVM � DataContext# [ .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ 
wGoiDichVu��.��� 	 � ColumnDefinitions	 �� $
��0.5* ��� .+�#  MaterialDesignThemes.Wpf.Card  $��0��$��10q�
   UniformCornerRadius$
 10Q�.���  � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� .+�� $��0��	 �� $
��auto ��� .+��� 
���   �$	��0.2q�$	��150��$��90��$��
20 20 0 10q�._��� $��0q����� *	GDV_ANH+�� -   $��txtSourceImg��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Hình ảnh�� % !MaterialDesignFloatingHintTextBox#��[ $��30 10 30 10q�$��1��$��Bottom=����� *	GDV_ANH+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��   $ MouseDoubleClick��.    �� *CommandAddImageGDV+ �� $ txtSourceImg��.��� $��1��.+��� $ Mã gói DV��#��[ $��30 10 30 10q�{�.  ���� *GDV_MA+$ TwoWay=�$ PropertyChanged=�.��� $��2��.+��� -   $��
txtGDV_TEN��$ Tên gói DV��#��[ $��30 10 30 10q����� *	GDV_TEN+$ TwoWay=�$ PropertyChanged=�.��   $ TextChanged��.    �� *AddIdCommandGDV+ �� $ 
txtGDV_TEN��.��� $��3��	 �� �� .+�	�  " MaterialDesignLightRadioButton#��[ $��Có liệu trình��$��28 15 30 10q�$��0�� d� 	IsChecked �� *CheckedCoLieuTrinh+	� -    	�Name$ rdKoLieuTrinh��#��[ $��Không liệu trình��$��1�� �� *CheckedKhongLieuTrinh+   $ Checked��.    �� *CommandCheckKhongLieuTrinh+ �� $ rdKoLieuTrinh��  $ 	Unchecked��.    �� *CommandUnCheckKhongLieuTrinh+ �� $ rdKoLieuTrinh���� $ Số lần liệu trình��$��4��#��[ $��30 10 30 10q����� *	GDV_SOLAN+$ TwoWay=�$ PropertyChanged=�y��� *HiddenSoLanLieuTrinh+� $��5��.+��� -   $��txtGDV_DONGIA��$ 	Giá gói��#��[ $��30 10 30 10q����� *
GDV_DONGIA+$ TwoWay=�$ PropertyChanged=�.��� $��6��.+��� $ Phương pháp�� �� 
IsEditable . $��30 10 30 10q� & "MaterialDesignFloatingHintComboBox#��[  �� DisplayMemberPath$ PP_TEN������ *
PHUONGPHAP+ �� SelectedItem �� *
SelectedPP+$ TwoWay=�$ PropertyChanged=�� $��7��.+��� $ Dịch vụ�� . $��30 10 30 10q�#��[ $ DV_TEN������ *DICHVU+ �� *
SelectedDV+$ TwoWay=�$ PropertyChanged=�� $��8��.+��� $ Mô tả gói dịch vụ��#��[  �� AcceptsReturn .  �� TextWrapping$
 Wrap=�$	��Top=�" �� VerticalScrollBarVisibility$
 Auto=�$��30 15 30 15q�$��80������ *
GDV_MOTA+$ TwoWay=�$ PropertyChanged=�� $��9��$	��125��	 �� �� �� �� .+���   MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��10q�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��$��0��$��70��$��Bottom=����	#FF2D2F4C$��0q����� *CommandAddGDV+.���� $��0 0 6 0q�.+�'	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$
 Plus=�$��25��$��25��$��0 0 0 5q�$��Center=��� $��Thêm��$��Center=��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10q�$ 10��$��1��$��70��$��Bottom=����	#FF2D2F4C$��0q����� *CommandEditGDV+.���� $��0 0 6 0q�.+�	  $ ContentSaveEditOutline=�$��25��$��25��$��0 0 0 5q�$��Center=��� $��Sửa��$��Center=��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10q�$ 10��$��2��$��70��$��Bottom=����	#FF2D2F4C$��0q����� *CommandDeleteGDV+.���� $��0 0 6 0q�.+�	  $ DeleteOutline=�$��25��$��25��$��0 0 0 5q�$��Center=��� $
��Xóa��$��Center=��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10q�$ 10��$��3��$��70��$��Bottom=����	#FF2D2F4C$��0q����� *CommandClearGDV+.���� $��0 0 6 0q�.+�	  $ Refresh=�$��25��$��25��$��0 0 0 5q�$��Center=��� $��
Làm mới��$��Center=�  $��1��$��10q�$
 10Q�.���  �� $
��auto ��� .+�� $��0��.+���  �� Orientation$ 
Horizontal=�$��1��$��	10 5 50 0q�$��Center=�.+�	  $ Magnify=�$��25��$��25��$��0 10 0 0q��� -   $��txtKeySearchGDV��$# Nhập từ khóa tìm kiếm��#��[ $	��250������ *KeySearchGDV+$ TwoWay=�$ PropertyChanged=�.��   $ TextChanged��.    �� *KeySearchCommandGDV+ �� $ txtKeySearchGDV��.��'
  !MaterialDesignThemes.Wpf.PopupBox
  $
��Left=�$	��Top=�$��2 0 2 0q�$��0 10 0 0q� 
  	StaysOpen .  
  PopupContent. �� $	��250��.+��� 
���   �$��	0 0 0 0.1q�$��0 0 0 10q�._��� $$��In thông tin gói dịch vụ������ *CommandInThongTinGDV+�� 
���   �$��	0 0 0 0.1q�$��0 0 0 10q�._��� $ Dịch vụ�� . $��
15 8 15 10q�#��[ $ DV_TEN������ *
DVFilter+ �� *SelectedDVFilter+$ TwoWay=�$ PropertyChanged=��� 
���   �$��	0 0 0 0.1q�$��0 0 0 10q�._��� $ Loại dịch vụ�� . $��
15 8 15 10q�#��[ $ LGDV_TEN������ *	LDVFilter+ �� *SelectedLDVFilter+$ TwoWay=�$ PropertyChanged=��� $��1������ *ListGoiDichVu+ �� *SelectedItemGDV+$ OneWayToSource=� �� View �� .P��� $��Mã nhân viên�� �� CellTemplate �� .R�� .+��� $ 
Horizontal=�.+��� $��70��$��70������ *GOIDICHVU.GDV_ANH+�� $��20 0 0 0q�$��Center=�$��Center=����� *GOIDICHVU.GDV_MA+�� $��Tên GDV�� �� .R�� $��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *GOIDICHVU.GDV_TEN+�� $��Số liệu trình�� �� .R�� $��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *GOIDICHVU.GDV_SOLAN+�� $��	Giá gói�� �� .R�� $��70��.+��� $��18 0 0 0q�$��Center=�$��Center=����� *DONGIA+ �� StringFormat$ 	0#,##0 đ���� $��Phương pháp�� �� .R�� $��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *GOIDICHVU.PHUONGPHAP.PP_TEN+�� $��Dịch vụ�� �� .R�� $��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *GOIDICHVU.DICHVU.DV_TEN+�� $��Loại dịch vụ�� �� .R�� $��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *" GOIDICHVU.LOAIGOIDICHVU.LGDV_TEN+�� $��Mô tả�� �� .R�� $��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *GOIDICHVU.GDV_MOTA+