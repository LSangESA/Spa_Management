   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Eclr-namespace:LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDoanhThu7LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDoanhThu  U QInteractiveDataDisplay.WPF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullkLclr-namespace:InteractiveDataDisplay.WPF;assembly=InteractiveDataDisplay.WPFInteractiveDataDisplay.WPF P    JLVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDoanhThu.UC_ThongKeDoanhThu   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     WlocalEclr-namespace:LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDoanhThu     [d3Lclr-namespace:InteractiveDataDisplay.WPF;assembly=InteractiveDataDisplay.WPF     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���  .���  � ColumnDefinitions �� $��0.35* ��� .+�� $��0�� � RowDefinitions �� $��0.35* ��� .+�#  MaterialDesignThemes.Wpf.Card   ! PrimaryHueDarkForegroundBrush#���  $��0q�$��0��$��20q�   UniformCornerRadius$ 15Q�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF08FFFB�� � Offset$ 0.234Q�� $ White��$ 1Q�.���� .+��  �� �� .+��� $��0��$��
16 16 16 4q� $  MaterialDesignHeadline5TextBlock#��[ $��	Doanh thu��$
��Bold"�
���   �'  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 CurrencyUsd=�$��1��$��15q�$��30��$��30��
���   �$��Right=�� $��15q� �� $
��0.8* ��� .+�� $��0��.+��� $��Center=�.+��� $��0 10 0 0q�$��Center=�
���   �$��22(����� *
SOPHIEUTHU+�� $��Phiếu thu��$��0 5 0 0q�$��Center=�
���   �$
��Bold"�$��13(�� $��1��.+��� $��Center=�.+��� $��0 10 0 0q�$��Center=�
���   �$��22(����� *TONGTIENPHIEUTHU+�� $��Tổng tiền��$��0 5 0 0q�$��Center=�
���   �$
��Bold"�$��13(�  $��20q�$ 10Q�$��1��.���  �� $
��auto ��� .+��� $��0��
 �� Orientation$
 
Horizontal=�$��10q�.+��� $S��ME:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Image\Filter\filter.png��$��20��$	��Top=�$��20��$��0 0 10 0q��� $��
Bộ lọc��$��18(�$	��Top=��� $��1��$��10q�.+�	� -   $��rdoYear��  MaterialDesignRadioButton#��[ $��Thống kê theo năm�� 	� 	GroupName$ 	Statistic���� -   $��editYearAll��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Năm�� �� 
IsEditable . $��	20 5 20 5q�$��1�� & "MaterialDesignFloatingHintComboBox#��[ ���� *#!LongListToTestComboVirtualization+	� -   $��rdoDayMonth��#��[ $��0 50 0 0q�$��Thống kê theo tháng��$ 	Statistic���  �� �� .+��� -   $��	editMonth��$ Tháng�� . $��	20 5 10 5q�$��0��#��[ ���� *#!LongListToTestComboVirtualization+�� -   $��editYear��$
 Năm�� . $��	10 5 20 5q�$��1��#��[ ���� *#!LongListToTestComboVirtualization+�� $
 
Horizontal=�$��Center=�$��	0 180 0 0q�.+��� -     MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��35��$	��0.5q�$	��120��
���   �
���   �
�������.���� $
 
Horizontal=�$��0 0 10 0q�.+�  $	 
FilterMenu=�$��0 0 10 0q�$��25��$��25���� $��Lọc��$��0 5 0 0q��� -   #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��35��$	��0.5q�$	��120��
���   �
���   �
�������.���� $
 
Horizontal=�$��0 0 10 0q�.+�  $	 CloseCircle=�$��0 0 10 0q�$��25��$��25���� $��
Bỏ lọc��$��0 5 0 0q�� $��1�� �� $
��1.1* ��� $
��0.9* �.+�  $��10q�$ 10Q�$��0��$��0 10 0 0q�.��&   InteractiveDataDisplay.WPF.Chart  -   $��Plotter��$��0,0,25,0q�$��Sitka Subheading)�   BottomTitle$ Ngày��   	LeftTitle$ Tiền��
������    LegendContent 1  +InteractiveDataDisplay.WPF.LegendItemsPanel   � 	Resources  ( $InteractiveDataDisplay.WPF.LineGraph	 �� X1	 �� Y1	 �� X2	 �� Y2 �� Path��%�   &	       �� .R��� $
 
Horizontal=�.+��� $��15��$��15��$ 0��$ 0��$ 15��$ 15��$��2������ $ Stroke��� $��5,0,0,0q����� $ Description�.��� -	   $��Lines��  $��10 10 10 20q�$ 10Q�$��1��.���  �� $
��auto ��� .+�� $��0��.+��� $
 
Horizontal=�$��1��$��	10 5 50 0q�$��Center=�.+�  $	 Magnify=�$��25��$��25��$��0 10 0 0q��� $# Nhập từ khóa tìm kiếm�� % !MaterialDesignFloatingHintTextBox#��[ $	��250������ *
UserName+'  !MaterialDesignThemes.Wpf.PopupBox  $��Right=�   	StaysOpen . $	��Top=�$��2 0 2 0q�$��0 10 0 0q�   PopupContent. �� $	��200��.+��� -
   $��Xuất Excel��$��
10 0 10 10q��� -   $��lvwPHIEUTHU��$��1�� �� View �� .P��� $��Số phiếu thu�� �� CellTemplate �� .R�� .+��� $��20 0 0 0q�$��Center=����� *PT_STT+�� $��Ngày lập�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *
PT_NGAYLAP+ �� StringFormat$ {0:dd/MM/yyyy h:mm tt}���� $
��HTTT�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *HINHTHUCTHANHTOAN.HTTT_TEN+�� $��Tổng tiền�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *PT_TONGTIEN+$ {0:n0}���� $��Nhân viên lập�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *NHANVIEN.NV_HOTEN+