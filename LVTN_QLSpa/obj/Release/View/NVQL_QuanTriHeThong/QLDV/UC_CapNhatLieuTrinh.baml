   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LVTN_QLSpa.View.QLDVLVTN_QLSpa.View.QLDV  .    (LVTN_QLSpa.View.QLDV.UC_CapNhatLieuTrinh   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:LVTN_QLSpa.View.QLDV     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    CapNhatLieuTrinhVM � DataContext# [ .��� $
��auto�� � ColumnDefinitions �� $
��0.5* ��� .+�#  MaterialDesignThemes.Wpf.Card  $��0��$��10q�   UniformCornerRadius$ 10Q�.���  � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� .+�� $��0��.+��� -   $
��cbDV��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Dịch vụ�� �� 
IsEditable . $��30 10 30 10q�$��1�� & "MaterialDesignFloatingHintComboBox#��[  �� DisplayMemberPath$ DV_TEN������ *
DICHVULT+	 �� SelectedItem	 �� *SelectedDVLT+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ SelectionChanged��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *CommandFilterDV+   CommandParameter ��  �� ElementName$
 cbDV��� $��1�� �� �� .+��� $ Gói dịch vụ��$��0�� . $��30 10 30 10q�#��[ $ GDV_TEN������ *	GOIDICHVU+	 �� *SelectedGDV+$
 TwoWay=�$ PropertyChanged=�   $ SelectionChanged��.    �� *CommandFilterGDV+ �� $
 cbDV��� $��2��.+��� $��	5 15 5 15q�$
��Bold"��� $��3��.+���  �� Orientation$ 
Horizontal=�.+��� $#��Số liệu trình tối đa:��$��30 0 5 0q��� $��0 0 30 0q�
���  ������ *	GDV_SOLAN+�� $ Số thứ tự�� % !MaterialDesignFloatingHintTextBox#��[ $��
30 5 30 10q����� *LT_STT+$
 TwoWay=�$ PropertyChanged=�� $��4��.+��� $% Ngày liệu trình tiếp theo��#��[ $��30 10 30 10q����� *
LT_NGAYTHU+$
 TwoWay=�$ PropertyChanged=�.��� $��5��.+��� $' !Thời gian thực hiện (phút)��#��[ $��30 10 30 10q����� *LT_THOIGIANTH+$
 TwoWay=�$ PropertyChanged=�� $��6��.+��� -   $��txtGiaLieuTrinh��$ Giá liệu trình��#��[ $��30 10 30 10q����� *DONGIA+$
 TwoWay=�$ PropertyChanged=�� $��7��.+��� $ Mô tả liệu trình��#��[  �� AcceptsReturn .  �� TextWrapping$
 Wrap=�$	��Top=�" �� VerticalScrollBarVisibility$
 Auto=�$��30 15 30 15q�$	��100������ *	LT_MOTA+$
 TwoWay=�$ PropertyChanged=�� $��8��� $��9��$	��150�� �� �� �� �� .+���   MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��10q�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��$��0��$��70��$��Bottom=����	#FF2D2F4C$��0q����� *AddLT+.���� $��0 0 6 0q�.+�'	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$
 Plus=�$��25��$��25��$��0 0 0 5q�$��Center=��� $��Thêm��$��Center=��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10q�$ 10��$��1��$��70��$��Bottom=����	#FF2D2F4C$��0q����� *EditLT+.���� $��0 0 6 0q�.+�	  $ ContentSaveEditOutline=�$��25��$��25��$��0 0 0 5q�$��Center=��� $��Sửa��$��Center=��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10q�$ 10��$��2��$��70��$��Bottom=����	#FF2D2F4C$��0q����� *
DeleteLT+.���� $��0 0 6 0q�.+�	  $ DeleteOutline=�$��25��$��25��$��0 0 0 5q�$��Center=��� $
��Xóa��$��Center=��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10q�$ 10��$��3��$��70��$��Bottom=����	#FF2D2F4C$��0q����� *	ClearLT+.���� $��0 0 6 0q�.+�	  $ Refresh=�$��25��$��25��$��0 0 0 5q�$��Center=��� $��
Làm mới��$��Center=�  $��1��$��10q�$ 10Q�.���  �� $
��auto ��� .+�� $��0��.+��� $ 
Horizontal=�$��	10 5 50 0q�$��Center=�.+�	  $ Magnify=�$��25��$��25��$��0 10 0 0q��� -   $��txtKeySearchLT��$# Nhập từ khóa tìm kiếm��#��[ $	��250������ *KeySearchLT+$
 TwoWay=�$ PropertyChanged=�.��   $ TextChanged��.    �� *KeySearchCommandLT+ �� $ txtKeySearchLT��.���� $��1������ *LTList+	 �� *SelectedItemLT+$
 OneWayToSource=� �� View �� .P��� $��Gói dịch vụ�� �� CellTemplate �� .R�� .+��� $��20 0 0 0q�$��Center=����� *LIEUTRINH.GOIDICHVU.GDV_TEN+�� $	��STT�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *LIEUTRINH.LT_STT+�� $��Ngày tiếp tục LT�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *LIEUTRINH.LT_NGAYTHU+�� $��Ngày tiếp tục LT�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *LIEUTRINH.LT_THOIGIANTH+�� $
��Giá�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *DONGIA+ �� StringFormat$ 	0#,##0 đ���� $��Mô tả�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *LIEUTRINH.LT_MOTA+