   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeNo1LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeNo  D    >LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeNo.UC_ThongKeNo   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Qlocal?clr-namespace:LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeNo     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    ThongKeNoVM � DataContext# [ .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wLapPhieuThu��.��� 	 � ColumnDefinitions	 �� $��0.35* ��� .+�� $��0��
 � RowDefinitions
 �� $��0.35* ��� .+�#  MaterialDesignThemes.Wpf.Card   ! PrimaryHueDarkForegroundBrush#���  $��0q�$��0��$��20q�   UniformCornerRadius$ 15Q�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF08FBFF�� � Offset$ 0.234Q�� $ White��$ 1Q�.���� .+�� 	 �� �� .+��� $��0��$��
16 16 16 4q� $  MaterialDesignHeadline5TextBlock#��[ $��Nợ chưa thu��$
��Bold"�
���   �'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ CurrencyUsd=�$��1��$��15q�$��30��$��30��
���   �$��Right=�� $��15q�	 �� $
��0.8* ��� .+�� $��0��.+��� $��Center=�.+��� $��0 10 0 0q�$��Center=�
���   �$��22(����� *TONGKHACHHANG+�� $��Khách hàng��$��0 5 0 0q�$��Center=�
���   �$
��Bold"�$��13(�� $��1��.+��� $��Center=�.+��� $��0 10 0 0q�$��Center=�
���   �$��22(����� *
TONGTIENNO+�� $��Tổng nợ��$��0 5 0 0q�$��Center=�
���   �$
��Bold"�$��13(�  $��20q�$ 10Q�$��1��.��� 
 �� $
��auto ��� .+��� $��0�� �� Orientation$ 
Horizontal=�$��10q�.+��� $S��ME:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Image\Filter\filter.png��$��20��$	��Top=�$��20��$��0 0 10 0q��� $��
Bộ lọc��$��18(�$	��Top=��� $��1��$��10q�.+�	�  	� 	GroupName$ 	ThongKeNo��  MaterialDesignRadioButton#��[ $��Ngày tùy chọn�� d� 	IsChecked �� *CheckTuyChon+(  "System.Windows.Controls.DatePicker  )	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ Ngày bắt đầu��$��	20 5 20 5q� ( $MaterialDesignFloatingHintDatePicker#��[    SelectedDate �� *
NGAYBATDAU+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�  $ Ngày kết thúc��$��	20 5 20 5q�#��[  �� *NGAYKETTHUC+$ TwoWay=�$ PropertyChanged=�	� #��[ $��0 50 0 0q�$��Thời gian cụ thể��$ 	ThongKeNo�� �� *
CheckCuThe+� 	 �� �� .+��� $ Tháng�� �� 
IsEditable . $��	20 5 10 5q�$��0�� & "MaterialDesignFloatingHintComboBox#��[  �� DisplayMemberPath$
 Name������ *THANG+ �� SelectedItem �� *SelectedTHANG+$ TwoWay=�$ PropertyChanged=��� $
 Năm�� . $��	10 5 20 5q�$��1��#��[ $
 Name������ *NAM+ �� *SelectedNAM+$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�$��Center=�$��	0 180 0 0q�.+���   MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 20q�$��35��$	��0.5q�$	��120��
���   �
���   �
����������� *
CommandLoc+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ 
FilterMenu=�$��0 0 10 0q�$��25��$��25���� $��Lọc��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 20q�$��35��$	��0.5q�$	��120��
���   �
���   �
����������� *CommandBoLoc+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ CloseCircle=�$��0 0 10 0q�$��25��$��25���� $��
Bỏ lọc��$��0 5 0 0q�� $��1��
 �� $
��1.2* ��� .+�  $��10q�$ 10Q�$��0��.��� 
 �� $
��auto ��� .+�� $��0��.+��� $ 
Horizontal=�$��1��$��	10 5 50 0q�$��Center=�.+�  $ Magnify=�$��25��$��25��$��0 10 0 0q��� $" Tìm thông tin khách hàng�� %	 !MaterialDesignFloatingHintTextBox#��[	 $	��250������ *KeySearchKH+'
  !MaterialDesignThemes.Wpf.PopupBox
  $��Right=� 
  	StaysOpen . $	��Top=�$��2 0 2 0q�$��0 10 0 0q� 
  PopupContent. �� $	��200��.+��� $��Xuất Excel��$��
10 0 10 10q��� -   $��lvwKhachHang��$��1������ *ListKhachHangNo+ �� *SelectedKhachHangNo+$ TwoWay=�$ PropertyChanged=�   $ SelectionChanged��.    �� *CommandSelectedKhachHangNo+ �� $ lvwKhachHang�� �� View �� .P��� $��Mã KH�� �� CellTemplate �� .R�� .+��� $��20 0 0 0q�$��Center=����� *KH_MA+�� $��	Họ tên�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *KH_TEN+�� $��Số điện thoại�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *KH_SDT+�� $��Ngày khám cuối�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *KH_NGAYKHAMCUOI+  �� StringFormat$  
dd/MM/yyyy���� $��Số phiếu nợ�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *KH_TONGPHIEUNO+�� $��Tổng nợ�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *	KH_TONGNO+  $��10 10 10 20q�$ 10Q�$��1��.��� .+��� $��1������ *ListPhieuDieuTriNo+ �� *SelectedPhieuDieuTriNo+$ TwoWay=�$ PropertyChanged=� �� .P��� $��Số PDK�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *	PDK_STT+�� $��Số PDT�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *	PDT_STT+�� $��Gói dịch vụ�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *	GDV_TEN+�� $��Ngày khám�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *PDT_NGAYKHAM+�� $��Thành tiền�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *	THANHTIEN+$  {0:n0}���� $��Giá giảm�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *	GIAGIAM+$  {0:n0}���� $��
Tổng thu�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *	TONGTHU+$  {0:n0}��