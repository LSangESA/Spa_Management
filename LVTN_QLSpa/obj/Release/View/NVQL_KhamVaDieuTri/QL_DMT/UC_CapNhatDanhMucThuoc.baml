   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_DMT)LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_DMT  F    @LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_DMT.UC_CapNhatDanhMucThuoc   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Ilocal7clr-namespace:LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_DMT     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wDanhMucThuc��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    CapNhatDanhMucThuocVM � DataContext# [ .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wDanhMucThuc��.���� .��� 	 � RowDefinitions	 �� $	��410 ��� $	��360 ��� $	��300 ��� $	��300 �.+��� $��0��$��Cập nhật thuốc��  MaterialDesignGroupBox#���  $��10 10 10 10q�.  (MaterialDesignThemes.Wpf.ColorZoneAssist
   Mode$
 Custom=�   
Background �	#FF2D2F4C   
Foreground
 �����.���  � ColumnDefinitions �� $
��0.5* ��� .+�#  MaterialDesignThemes.Wpf.Card  $��0��$��10q�   UniformCornerRadius$ 10Q�.���� .+��� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã thuốc�� % !MaterialDesignFloatingHintTextBox#��[ $��	15 5 15 5q�{�.  ���� *T_MA+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $ Tên thuốc��#��[ $��	15 5 15 5q����� *T_TEN+$ TwoWay=�$ PropertyChanged=��� $ Hoạt chất��$��8�� �� 
IsEditable . $��	15 5 15 5q� & "MaterialDesignFloatingHintComboBox#��[  �� DisplayMemberPath$ HC_TEN������ *
HOATCHAT+ �� SelectedItem �� *SelectedHOATCHAT+$ TwoWay=�$ PropertyChanged=��� $ Đơn vị tính��$��8�� . $��	15 5 15 5q�#��[ $ DVT_TEN������ *DVT+ �� *SelectedDVT+$ TwoWay=�$ PropertyChanged=��� $ Nhà sản xuất��$��8�� . $��	15 5 15 5q�#��[ $ NSX_TEN������ *NHASX+ �� *SelectedNHASX+$ TwoWay=�$ PropertyChanged=�� $��0 40 0 0q� �� �� �� .+���   MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��
10 5 10 10q�+	  %MaterialDesignThemes.Wpf.ButtonAssist 	  CornerRadius$ 10��$��30��$��0��$��Bottom=����	#FF2D2F4C$��0q����� *
AddTHUOC+.����  �� Orientation$ 
Horizontal=�$��0 0 10 0q�.+�'
  !MaterialDesignThemes.Wpf.PackIcon
   
  Kind$ ContentSaveEdit=�$��20��$��20���� $
��Lưu��$��0 3 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 5 10 10q�$ 10��$��30��$��1��$��Bottom=����	#FF2D2F4C$��0q����� *DeleteTHUOC+.���� $ 
Horizontal=�$��0 0 10 0q�.+�
  $ Delete=�$��20��$��20���� $
��Xóa��$��0 3 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 5 10 10q�$ 10��$��30��$��2��$��Bottom=����	#FF2D2F4C$��0q����� *
ClearTHUOC+.���� $ 
Horizontal=�$��0 0 10 0q�.+�
  $ Refresh=�$��20��$��20���� $��
Làm mới��$��0 3 0 0q�  $��1��$��10q�$ 10Q�.��� $��	10 0 10 0q�	 �� $
��auto ��� .+��� $ 
Horizontal=�$��0��$��	0 10 0 10q�$��Center=�.+�
  $ Magnify=�$��Center=�$��20��$��20��$��30 0 10 -10q��� $# Nhập từ khóa tìm kiếm��#��[ $	��210���� $��1������ *	THUOCList+ �� *SelectedItemTHUOC+$ OneWayToSource=� �� View �� .P��� $��Mã thuốc�� �� CellTemplate �� .R�� .+��� $��20 0 0 0q�$��Center=����� *T_MA+�� $��Tên thuốc�� �� Width$	 170�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *T_TEN+�� $��Biệc dược�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *HOATCHAT.HC_TEN+�� $
��ĐVT�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *DVT.DVT_TEN+�� $��Nhà sản xuất�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *NHASX.NSX_TEN+�� $��1��$ ��Cập nhật hoạt chất��#���  $��10 10 10 10q�$
 Custom=� �	#FF2D2F4C
 �����.���  �� $
��0.5* ��� .+�  $��0��$��10q�$ 10Q�.���� .+��� $ Mã hoạt chất��#��[ $��	15 5 15 5q�{�.  ���� *HC_MA+$ TwoWay=�$ PropertyChanged=��� $ Tên hoạt chất��#��[ $��	15 5 15 5q����� *HC_TEN+$ TwoWay=�$ PropertyChanged=��� $ Hàm lượng��#��[ $��	15 5 15 5q����� *HC_HAMLUONG+$ TwoWay=�$ PropertyChanged=��� $ Công dụng��#��[ $��	15 5 15 5q����� *HC_CONGDUNG+$ TwoWay=�$ PropertyChanged=�� $��0 35 0 0q� �� �� �� .+��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 5 10 10q�$ 10��$��30��$��0��$��Bottom=����	#FF2D2F4C$��0q����� *AddHOATCHAT+.���� $ 
Horizontal=�$��0 0 10 0q�.+�
  $ ContentSaveEdit=�$��20��$��20���� $
��Lưu��$��0 3 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 5 10 10q�$ 10��$��30��$��1��$��Bottom=����	#FF2D2F4C$��0q����� *DeleteHOATCHAT+.���� $ 
Horizontal=�$��0 0 10 0q�.+�
  $ Delete=�$��20��$��20���� $
��Xóa��$��0 3 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 5 10 10q�$ 10��$��30��$��2��$��Bottom=����	#FF2D2F4C$��0q����� *ClearHOATCHAT+.���� $ 
Horizontal=�$��0 0 10 0q�.+�
  $ Refresh=�$��20��$��20���� $��
Làm mới��$��0 3 0 0q�  $��1��$��10q�$ 10Q�.��� 	 �� $
��auto ��� .+��� $ 
Horizontal=�$��0��$��	0 10 0 10q�$��Center=�.+�
  $ Magnify=�$��Center=�$��20��$��20��$��30 0 10 -10q��� $# Nhập từ khóa tìm kiếm��#��[ $	��210���� $��1������ *HOATCHATList+ �� *SelectedItemHOATCHAT+$ OneWayToSource=� �� .P��� $��Mã HC�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *HC_MA+�� $��Tên HC��$	 170�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *HC_TEN+�� $��Hàm lượng�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *HC_HAMLUONG+�� $��Công dụng�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *HC_CONGDUNG+�� $��2��$,��&Cập nhật nhà sản xuất thuốc��#���  $��10 10 10 10q�$
 Custom=� �	#FF2D2F4C
 �����.���  �� $
��0.5* ��� .+�  $��0��$��10q�$ 10Q�.���� $��0��.+��� $ Mã NSX��#��[ $��	15 5 15 5q�{�.  ���� *NSX_MA+$ TwoWay=�$ PropertyChanged=��� $ Tên NSX��#��[ $��	15 5 15 5q����� *	NSX_TEN+$ TwoWay=�$ PropertyChanged=�� $��0 70 0 0q� �� �� �� .+��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 5 10 10q�$ 10��$��30��$��0��$��Bottom=����	#FF2D2F4C$��0q����� *
AddNHASX+.���� $ 
Horizontal=�$��0 0 10 0q�.+�
  $ ContentSaveEdit=�$��20��$��20���� $
��Lưu��$��0 3 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 5 10 10q�$ 10��$��30��$��1��$��Bottom=����	#FF2D2F4C$��0q����� *DeleteNHASX+.���� $ 
Horizontal=�$��0 0 10 0q�.+�
  $ Delete=�$��20��$��20���� $
��Xóa��$��0 3 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 5 10 10q�$ 10��$��30��$��2��$��Bottom=����	#FF2D2F4C$��0q����� *
ClearNHASX+.���� $ 
Horizontal=�$��0 0 10 0q�.+�
  $ Refresh=�$��20��$��20���� $��
Làm mới��$��0 3 0 0q�  $��1��$��10q�$ 10Q�.���� ���� *	NHASXList+ �� *SelectedItemNHASX+$ OneWayToSource=� �� .P��� $��Mã NSX�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *NSX_MA+�� $��Tên NSX�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *	NSX_TEN+�� $��3��$#��Cập nhật đơn vị tính��#���  $��10 10 10 10q�$
 Custom=� �	#FF2D2F4C
 �����.���  �� $
��0.5* ��� .+�  $��0��$��10q�$ 10Q�.���� $��0��.+��� $ Mã DVT��#��[ $��	15 5 15 5q�{�.  ���� *DVT_MA+$ TwoWay=�$ PropertyChanged=��� $ Tên DVT��#��[ $��	15 5 15 5q����� *	DVT_TEN+$ TwoWay=�$ PropertyChanged=�� $��0 70 0 0q� �� �� �� .+��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 5 10 10q�$ 10��$��30��$��0��$��Bottom=����	#FF2D2F4C$��0q����� *AddDVT+.���� $ 
Horizontal=�$��0 0 10 0q�.+�
  $ ContentSaveEdit=�$��20��$��20���� $
��Lưu��$��0 3 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 5 10 10q�$ 10��$��30��$��1��$��Bottom=����	#FF2D2F4C$��0q����� *	DeleteDVT+.���� $ 
Horizontal=�$��0 0 10 0q�.+�
  $ Delete=�$��20��$��20���� $
��Xóa��$��0 3 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 5 10 10q�$ 10��$��30��$��2��$��Bottom=����	#FF2D2F4C$��0q����� *
ClearDVT+.���� $ 
Horizontal=�$��0 0 10 0q�.+�
  $ Refresh=�$��20��$��20���� $��
Làm mới��$��0 3 0 0q�  $��1��$��10q�$ 10Q�.���� ���� *	DVTList+ �� *SelectedItemDVT+$ OneWayToSource=� �� .P��� $��Mã DVT�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *DVT_MA+�� $��Tên DVT��$	 170�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *	DVT_TEN+