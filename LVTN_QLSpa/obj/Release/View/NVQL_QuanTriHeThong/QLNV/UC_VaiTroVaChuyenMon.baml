   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LVTN_QLSpa.View.QLNVLVTN_QLSpa.View.QLNV  /    )LVTN_QLSpa.View.QLNV.UC_VaiTroVaChuyenMon   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:LVTN_QLSpa.View.QLNV     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    VaiTroVaChuyenMonVM � DataContext# [ .���  � RowDefinitions �� $	��310 ��� $	��440 �.+��� $��Cập nhật vai trò��  MaterialDesignGroupBox#���  $��10 10 10 10q�.  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Custom=�   
Background �	#FF2D2F4C   
Foreground
 �����$��0��.���  � ColumnDefinitions �� $
��0.7* ��� $
��1.3* �.+�#  MaterialDesignThemes.Wpf.Card  $��0��$��10q�   UniformCornerRadius$ 10Q�.���  �� $
��auto ��� $
��auto ��� .+��� )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Mã vai trò�� % !MaterialDesignFloatingHintTextBox#��[ $��30 10 30 10q�$��0��{�.  ���� *VT_MA+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.���� $	 Tên vai trò��#��[ $��30 10 30 10q�$��1������ *VT_TEN+$
 TwoWay=�$ PropertyChanged=�.��� $��2�� �� �� �� �� .+���   MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��Thêm��$��10q�$��0��$��Bottom=����	#FF2D2F4C$��0q����� *CommandAddVaiTro+�� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��Sửa��$��10q�$��1��$��Bottom=����	#FF2D2F4C$��0q����� *CommandEditVaiTro+�� #��[ $/ )Resource name: MaterialDesignRaisedButton��$
��Xóa��$��10q�$��2��$��Bottom=����	#FF2D2F4C$��0q����� *CommandDeleteVaiTro+�� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
Làm mới��$��10q�$��3��$��Bottom=����	#FF2D2F4C$��0q����� *CommandClearVaiTro+  $��1��$��10q�$ 10Q�.���� ���� *
ListVaiTro+ �� SelectedItem �� *SelectedItemVaiTro+$
 OneWayToSource=� �� View �� .P��� $��Mã vai trò�� �� CellTemplate �� .R�� .+��� $��20 0 0 0q�$��Center=����� *VT_MA+�� $��Tên vai trò�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *VT_TEN+�� $��Cập nhật chuyên môn��#���  $��
10 10 10 0q�$ Custom=� �	#FF2D2F4C
 �����+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��$��1��.���  �� $
��0.7* ��� $
��1.3* �.+�  $��0��$��10q�$ 10Q�.���  �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� .+��� $	 Mã chuyên môn��#��[ $��30 10 30 10q�$��0��{�.  ���� *CM_MA+$
 TwoWay=�$ PropertyChanged=�.���� $	 Tên chuyên môn��#��[ $��30 10 30 10q�$��1������ *CM_TEN+$
 TwoWay=�$ PropertyChanged=�.���� $	 Mô tả��#��[ $��30 10 30 10q�$��2������ *	CM_MOTA+$
 TwoWay=�$ PropertyChanged=�.���� $	 Vai trò�� �� 
IsEditable . $��30 10 30 10q� & "MaterialDesignFloatingHintComboBox#��[  �� DisplayMemberPath$ VT_TEN��$��3������ *VAITRO+ �� *SelectedVAITRO+$
 TwoWay=�$ PropertyChanged=�� $��4�� �� �� �� �� .+��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��Thêm��$��10q�$��0��$��Bottom=����	#FF2D2F4C$��0q����� *CommandAddChuyenMon+�� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��Sửa��$��10q�$��1��$��Bottom=����	#FF2D2F4C$��0q����� *CommandEditChuyenMon+�� #��[ $/ )Resource name: MaterialDesignRaisedButton��$
��Xóa��$��10q�$��2��$��Bottom=����	#FF2D2F4C$��0q����� *CommandDeleteChuyenMon+�� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
Làm mới��$��10q�$��3��$��Bottom=����	#FF2D2F4C$��0q����� *CommandClearChuyenMon+  $��1��$��10q�$ 10Q�.���  �� $
��auto ��� .+���  �� Orientation$ 
Horizontal=�$��0��$��Center=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Magnify=�$��Center=�$��20��$��20��$��30 0 10 -10q��� -   $��txtKeySearchCM��$#	 Nhập từ khóa tìm kiếm��#��[ $	��210������ *KeySearchCM+$
 TwoWay=�$ PropertyChanged=�.��.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ TextChanged��.	  (System.Windows.Interactivity.TriggerBase 	  Actions. 6
  0System.Windows.Interactivity.InvokeCommandAction
   
  Command �� *KeySearchCommandCM+ 
  CommandParameter ��  �� ElementName$ txtKeySearchCM��.���� $��1������ *ListChuyenMon+ �� *SelectedItemCM+$
 OneWayToSource=� �� .P��� $��Mã chuyên môn�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *CM_MA+�� $��Tên chuyên môn�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *CM_TEN+�� $��Mô tả�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *	CM_MOTA+�� $��Vai trò�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *VAITRO.VT_TEN+