   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LVTN_QLSpa.View.QLNVLVTN_QLSpa.View.QLNV  ,    &LVTN_QLSpa.View.QLNV.UC_PhuTrachDichVu   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:LVTN_QLSpa.View.QLNV     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��ucPhuTrachDichVu��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    PhuTrachDichVuVM � DataContext# [ .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ ucPhuTrachDichVu��.��� $��0 10 0 0q�	 � RowDefinitions	 �� $
��auto ��� $
��auto �.+�� $��0��
 � ColumnDefinitions
 �� $
��0.5* ��� .+�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 10Q�$��10q�$��0��$	��734��.��� 	 �� $
��auto ��� .+��� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Dịch vụ�� �� 
IsEditable . $��30 10 30 10q� & "MaterialDesignFloatingHintComboBox#��[  �� DisplayMemberPath$ DV_TEN��$��0������ *DICHVU+ �� SelectedItem �� *
SelectedDV+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $��Gói dịch vụ��  MaterialDesignGroupBox#���  $��30 10 30 20q�.  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Custom=�   
Background �	#FF2D2F4C   
Foreground
 �����$��1��.���� -   $��lbxGDV������ *	ListGDV+ �� *SelectedGDV+$ TwoWay=�$ PropertyChanged=�   $ SelectionChanged��.    �� *CommandSelectionGDV+ �� $ lbxGDV������ .R���  �� Orientation$ 
Horizontal=�.+��� $��40��$��40������ *GOIDICHVU.GDV_ANH+�� .+��� $��15(�$��30 0 0 0q�$
��Bold"����� *GOIDICHVU.GDV_TEN+�� $ 
Horizontal=�.+��� $ 
Horizontal=�$
��Left=�$��Center=�$��30 0 0 0q�.+���  " MaterialDesignCaptionTextBlock#��[ $��Loại: ���� #��[ $	��100������ *" GOIDICHVU.LOAIGOIDICHVU.LGDV_TEN+�� $ 
Horizontal=�$
��Left=�$��Center=�$��0 0 0 0q�.+��� #��[ $��Đơn giá: ��$
��Left=��� #��[ ���� *DONGIA+�� #��[ $	�� đ��� $��1��	 �� $
��auto ��� .+�  $��0��$��
10 10 10 0q�$ 10Q�.��� 
 �� $
��0.5* ��� �� $
��0.4* �.+��� -   $��	cbxVaiTro��$ Vai trò�� . $��
30 0 30 10q�#��[ $ VT_TEN��$��0������ *VAITRO+ �� *SelectedVAITRO+$ TwoWay=�$ PropertyChanged=�   $ SelectionChanged��.    �� *CommandSelectionVaiTro+ �� $ 	cbxVaiTro���� $ 
Horizontal=�$��1��$��	0 5 50 15q�$��Center=�.+��� -   $��txtKeySearch��$# Nhập từ khóa tìm kiếm�� % !MaterialDesignFloatingHintTextBox#��[ $	��250������ *	KeySearch+.��   $ TextChanged��.    �� *CommandKeySearch+ �� $ txtKeySearch��.����   MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��2��$��Lập phụ trách��$��
10 5 10 10q�$��Bottom=����	#FF2D2F4C$��0q�$��40������ *CommandLapPhuTrach+  $��1��$��10q�$ 10Q�.���� $��1������ *ListNhanVien+ �� *SelectedItemNhanVien+$ OneWayToSource=� �� View �� .P��� $��Mã nhân viên�� �� CellTemplate �� .R�� .+��� $ 
Horizontal=�.+��� $��70��$��70������ *NV_ANH+�� $��20 0 0 0q�$��Center=�$��Center=����� *NV_MA+�� $��	Họ tên�� �� .R�� .+��� $ 
Horizontal=�$��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *
NV_HOTEN+�� $��Số điện thoại�� �� .R�� .+��� $ 
Horizontal=�$��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *NV_SDT+�� $
��CCCD�� �� .R�� .+��� $ 
Horizontal=�$��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *	NV_CCCD+�� $��
Ngày sinh�� �� .R�� .+��� $ 
Horizontal=�$��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *NV_NGAYSINH+�� $��Giới tính�� �� .R�� .+��� $ 
Horizontal=�$��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *NV_GIOITINH+�� $��Tài khoản�� �� .R�� .+��� $ 
Horizontal=�$��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *NV_USERNAME+�� $��Trạng thái�� �� .R�� .+��� $ 
Horizontal=�$��70��.+��� $��20 0 0 0q�$��Center=�$��Center=����� *NV_TRANGTHAI+