   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:LVTN_QLSpa.View.QLLLVLVTN_QLSpa.View.QLLLV  +    %LVTN_QLSpa.View.QLLLV.UC_CapNhatPhong   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:LVTN_QLSpa.View.QLLLV     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    CapNhatPhongVM � DataContext# [ .���  � RowDefinitions �� $	��410 ��� $	��350 �.+��� $��Cập nhật phòng��  MaterialDesignGroupBox#���  $��10 10 10 10q�.  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Custom=�   
Background �	#FF2D2F4C   
Foreground
 �����$��0��.���  � ColumnDefinitions �� $
��0.8* ��� $
��1.2* �.+�#  MaterialDesignThemes.Wpf.Card  $��0��$��10q�   UniformCornerRadius$ 10Q�.���� .+��  �� $
��0.9* ��� $
��1.1* �.+�� $��0�� �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Số phòng�� % !MaterialDesignFloatingHintTextBox#��[ $��	30 7 10 7q�$��0��$y�Hidden=����� *P_MA+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.���� $	 Số phòng��#��[ $��	30 7 10 7q�$��0������ *P_SO+$
 TwoWay=�$ PropertyChanged=�.���� $	 Tên phòng��#��[ $��	30 7 10 7q�$��1������ *P_TEN+$
 TwoWay=�$ PropertyChanged=�.���� $)	 #Số lượng nhân viên tối đa��#��[ $��	30 7 10 7q�$��2������ *P_SOLUONGNHANVIEN+$
 TwoWay=�$ PropertyChanged=�.���� $	 Mô tả phòng��#��[  �� AcceptsReturn .  �� TextWrapping$
 Wrap=�$	��Top=�" �� VerticalScrollBarVisibility$
 Auto=�$��30 15 10 15q�$��70��$��3������ *P_MOTA+$
 TwoWay=�$ PropertyChanged=��� 
���   �$��0 0 1 0q��� $��1��.+���  �� Orientation$ 
Horizontal=�$��0 5 0 0q�$
��Left=�.+��� $��Gói dịch vụ:��$��14(�$
��Bold"�$��10 7 0 0q���    MaterialDesignOutlinedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��
130 0 5 10q�$��0q�$��30�����	#FFF7F7F7$��Bottom=�$��0q����� *CommandDeletePhuTrach+.���� $ 
Horizontal=�$��0 0 10 0q�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ CloseCircle=�$��5 0 5 0q�$��25��$��25��
���  ���� $
��Xóa��$��0 0 0 0q�
���  ��$��Center=��� $��	10 10 5 0q�.����  � IsSharedSizeScope . ���� *ListGoiDichVuPhong+���� .R���  ��Name$ Border�� �� Padding$ 8q�$��0 0 0 1q�  MaterialDesignDivider#���  ._��  ��  z� SharedSizeGroup$ Checkerz���� .+�d�  d�Name$ chkPDT��$��Center=� ) %MaterialDesignActionLightToggleButton#��[  d� 	IsChecked �� *	IsCheck+.���� $��45��$��45������ *	GDV_ANH+�� $��8 0 0 0q�$��1��.+��� $ 
Horizontal=�.+��� $
��Bold"�$��16(����� *	GDV_TEN+�� $
��Bold"�$��16(�$	�� - ���� $
��Bold"�$��16(����� *GDV_MA+�� $ 
Horizontal=�.+��� ���� *
LGDV_TEN+�� $
��Bold"�$	�� - ���� ���� *DONGIA+ �� Triggers ��  �� Value$
 True�� �� Binding �� *
IsSelected+.a���  �� 
TargetName$ Border��  MaterialDesignSelection �� Value# �   �� Property � ��� $��4�� �� �� �� �� .+���  	 MaterialDesignRaisedButton#��[	 $/ )Resource name: MaterialDesignRaisedButton��$��Thêm��$��
10 10 10 0q�$��0��$��Bottom=����	#FF2D2F4C$��0q����� *CommandAddP+�� #��[	 $/ )Resource name: MaterialDesignRaisedButton��$��Sửa��$��
10 10 10 0q�$��1��$��Bottom=����	#FF2D2F4C$��0q����� *CommandEditP+�� #��[	 $/ )Resource name: MaterialDesignRaisedButton��$
��Xóa��$��
10 10 10 0q�$��2��$��Bottom=����	#FF2D2F4C$��0q����� *CommandDeleteP+�� #��[	 $/ )Resource name: MaterialDesignRaisedButton��$��
Làm mới��$��
10 10 10 0q�$��3��$��Bottom=����	#FF2D2F4C$��0q����� *CommandClearP+  $��1��$��10q�$ 10Q�.���  �� $
��1.3* ��� $
��0.7* �.+��� -   $��lvwPhong������ *	ListPhong+ �� SelectedItem �� *SelectedItemPhong+$
 OneWayToSource=�.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger      	EventName$  SelectionChanged��.  (System.Windows.Interactivity.TriggerBase!   Actions.! 6	  0System.Windows.Interactivity.InvokeCommandAction	  " 	  Command" �� *CommandSelectionPhong+# 	  CommandParameter# �� $ �� ElementName$$ lvwPhong��% �� View% �� .P��� $��Số phòng��& �� CellTemplate& �� .R�� .+��� $��20 0 0 0q�$��Center=����� *P_SO+�� $��Tên phòng��& �� .R�� .+��� $��20 0 0 0q�$��Center=����� *P_TEN+�� $��Số lượng nhân viên��& �� .R�� .+��� $��20 0 0 0q�$��Center=����� *P_SOLUONGNHANVIEN+�� $��Mô tả��& �� .R�� .+��� $
��Wrap=�$��20 0 0 0q�$��Center=����� *P_MOTA+�� 
���   �$��0 0 1 0q��� $��1��.+��� $ 
Horizontal=�.+��� -   $��	cbxDICHVU��$	 Dịch vụ��' �� 
IsEditable' . $��20 10 20 10q�$	��160�� &
 "MaterialDesignFloatingHintComboBox#��[
 ( �� DisplayMemberPath$( DV_TEN������ *DICHVU+ �� *SelectedDICHVU+$
 TwoWay=�$ PropertyChanged=�   $  SelectionChanged��.! 	  " �� *CommandSelectionDICHVU+# �� $$ 	cbxDICHVU���� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��	0 0 10 10q�$��0q�$��30�����	#FFF7F7F7$��Bottom=�$��0q����� *CommandAddPhuTrachDichVu+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ CheckBoxMultipleOutline=�$��5 0 5 0q�$��25��$��25��
��� � ��� $��Nhập��$��0 0 0 0q�
��� � �$��Center=��� $��
20 10 10 0q�.����  . $	��170������ *ListGoiDichVu+���� .R��� $ Border��$ 8q�$��0 0 0 1q�#���  ._��  �� $ Checkerz���� .+�d� $ chkPDT��$��Center=�#��[  �� *	IsCheck+.���� $��45��$��50������ *	GDV_ANH+�� $��8 0 0 0q�$��1��.+��� $ 
Horizontal=�.+��� $
��Bold"�$��16(����� *	GDV_TEN+�� $
��Bold"�$��16(�$	�� - ���� $
��Bold"�$��16(����� *GDV_MA+�� $ 
Horizontal=�.+��� ���� *
LGDV_TEN+ �� $
 True�� �� *
IsSelected+.a��� $ Border��# �   � ���� $5��/Số lượng vai trò nhân viên trong phòng��#���  $��10q�$ Custom=� �	#FF2D2F4C
 �����+
  %MaterialDesignThemes.Wpf.ButtonAssist) 
  CornerRadius$) 10��$��1��.���  �� $
��0.7* ��� $
��1.3* �.+�  $��0��$��10q�$ 10Q�.���  �� $
��auto ��� $
��auto ��� $
��auto ��� .+��� -   $��cbxPhong��$	 Phòng��' . $��	30 7 30 7q�#��[
 $
( P_SO��$��0������ *PHONG+ �� *SelectedPhong+$
 TwoWay=�$ PropertyChanged=�   $  SelectionChanged��.! 	  " �� *SLPhongCommand+# �� $$ cbxPhong���� $	 Vai trò��' . $��	30 7 30 7q�#��[
 $( VT_TEN��$��1������ *VAITRO+ �� *SelectedVaiTro+$
 TwoWay=�$ PropertyChanged=��� $0	 *Số lượng nhân viên thuộc vai trò��#��[ $��	30 7 30 7q�$��2������ *CTP_SOLUONG+$
 TwoWay=�$ PropertyChanged=�.��� $��3�� �� �� �� �� .+��� #��[	 $/ )Resource name: MaterialDesignRaisedButton��$��Thêm��$��10q�$��0��$��Bottom=����	#FF2D2F4C$��0q����� *CommandAddCTP+�� #��[	 $/ )Resource name: MaterialDesignRaisedButton��$��Sửa��$��10q�$��1��$��Bottom=����	#FF2D2F4C$��0q����� *CommandEditCTP+�� #��[	 $/ )Resource name: MaterialDesignRaisedButton��$
��Xóa��$��10q�$��2��$��Bottom=����	#FF2D2F4C$��0q����� *CommandDeleteCTP+�� #��[	 $/ )Resource name: MaterialDesignRaisedButton��$��
Làm mới��$��10q�$��3��$��Bottom=����	#FF2D2F4C$��0q����� *CommandClearCTP+  $��1��$��10q�$ 10Q�.��� .+��� ���� *ListChiTietPhong+ �� *SelectedItemCTP+$
 TwoWay=�% �� .P��� $��Phòng��* �� DisplayMemberBinding* �� *
PHONG.P_SO+�� $��Vai trò��* �� *VAITRO.VT_TEN+�� $'��!Số nhân viên thuộc vai trò��* �� *CTP_SOLUONG+'  !MaterialDesignThemes.Wpf.PopupBox  $��Right=�$	��Top=�$��2 0 2 0q�$��0 10 0 0q�+   PopupContent.+ �� $	��200��.+��� $
��More���� $��Options��