   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.TrangChu,LVTN_QLSpa.View.NVQL_QuanTriHeThong.TrangChu  :    4LVTN_QLSpa.View.NVQL_QuanTriHeThong.TrangChu.UC_Main   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Llocal:clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.TrangChu     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wMain��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���   
 MainVM � DataContext# [ .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wMain��.��� 	 � RowDefinitions	 �� $
��auto ��� .+�#  MaterialDesignThemes.Wpf.Card  
   UniformCornerRadius$
 10Q�$��10q�$��0��.���  � ColumnDefinitions �� �� �� .+���   MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��$��40��$��0��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandLapBaoCaoExcel+.����  �� Orientation$ 
Horizontal=�$��0 0 10 0q�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	FileChart=�$��0 0 10 0q�$��25��$��25���� $��Báo cáo hôm nay��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$ 5��$��40��$��1��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandTaoLichHen+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ CalendarPlus=�$��0 0 10 0q�$��25��$��25���� $��Tạo lịch hẹn mới��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$ 5��$��40��$��2��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandLapPhieuDangKy+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ TextBoxPlusOutline=�$��0 0 10 0q�$��25��$��25���� $"��Đăng ký mới dịch vụ��$��0 5 0 0q�� $��1�� �� $
��1.4* ��� $
��0.6* �.+�� $��0��	 �� $
��auto ��� .+�� $��10q�$��0�� �� �� �� .+�  ���	#FFE77E7E ! PrimaryHueDarkForegroundBrush#���  $��0q�$��
0 10 20 10q�$
 15Q�.���� .+��  �� �� .+��� $��0��$��
16 16 16 4q� $  MaterialDesignHeadline5TextBlock#��[ $��Lịch hẹn��
���   �  $ CalendarClock=�$��1��$��15q�$��30��$��30��
���   �$��Right=�� $��15q� �� �� .+�� $��0��.+��� $��Center=�.+��� $��0 5 0 0q�$��Center=�
���   �$��20(����� *TongLichHenHomNay+�� $��Hôm nay��$��0 5 0 0q�$��Center=�
���   �$��13(�� $��1��.+��� $��Center=�.+��� $��0 5 0 0q�$��Center=�
���   �$��20(����� *TongLichHenNgayMai+�� $��	Ngày mai��$��0 5 0 0q�$��Center=�
���   �$��13(�  ���	#FF79F6B9#���  $��0q�$��1��$��20 10 20 10q�$
 15Q�.���� .+��  �� �� .+��� $��0��$��
16 16 16 4q�#��[ $��	Thu ngân��
���   �  $ 
Calculator=�$��1��$��15q�$��30��$��30��
���   �$��Right=�� $��15q� �� �� .+�� $��0��.+��� $��Center=�.+��� $��0 5 0 0q�$��Center=�
���   �$��20(����� *TongPhieuThuHomNay+�� $��Hóa đơn hôm nay��$��0 5 0 0q�$��Center=�
���   �$��13(�� $��1��.+��� $��Center=�.+��� $��0 5 0 0q�$��Center=�
���   �$��20(����� *TongTienThuHomNay+�� $��Doanh thu hôm nay��$��0 5 0 0q�$��Center=�
���   �$��13(�  ���	#FFEBF077#���  $��0q�$��2��$��
20 10 0 10q�$
 15Q�.���� .+��  �� �� .+��� $��0��$��
16 16 16 4q�#��[ $��Khách hàng��
���   �  $ CardAccountDetailsOutline=�$��1��$��15q�$��30��$��30��
���   �$��Right=�� $��15q� �� �� .+�� $��0��.+��� $��Center=�.+��� $��0 5 0 0q�$��Center=�
���   �$��20(����� *SoKhachHangHomNay+�� $��Khách hôm nay��$��0 5 0 0q�$��Center=�
���   �$��13(�� $��1��.+��� $��Center=�.+��� $��0 5 0 0q�$��Center=�
���   �$��20(����� *SoPhieuDangKyHomNay+�� $!��Phiếu đăng ký hôm nay��$��0 5 0 0q�$��Center=�
���   �$��13(�  $��1��$
 10Q�$��
10 0 10 20q�.��� 	 �� $
��auto ��� $
��auto ��� .+�� $��0�� �� �� �� .+��� $��0��$��20q�#��[ $ ��Lịch tái khám hôm nay��
���   �$��20(�� $��1�� �� $
��auto ��� .+�  $ Magnify=�$��25��$��25��$��0��$��0 15 0 0q��� -   $��txtKeySearch��)	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$7 1Tìm kiếm theo tên hoặc số điện thoại�� % !MaterialDesignFloatingHintTextBox#��[ $��1��$��	10 0 0 25q����� *	KeySearch+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��   $ TextChanged��.    �� *CommandKeySearch+ �� $ txtKeySearch��.���� #��[ $/ )Resource name: MaterialDesignRaisedButton��$ 5��$��90 10 10 20q�$��35��$��2��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandLapPhieuDieuTri+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ NoteTextOutline=�$��0 0 10 0q�$��25��$��25���� $!��Lập phiếu điều trị��$��0 5 0 0q��� $��	20 0 20 5q�$��1q�
���   �$��1���� -   $��lvwLTDT��$��2������ *ListLichTrinhDieuTri+ �� SelectedItem �� *SelectedLichTrinhDieuTri+$ OneWayToSource=� �� View �� .P��� $��Gói dịch vụ�� �� CellTemplate �� .R�� .+��� $��20 0 0 0q�$��Center=����� *PHIEUDANGKY.GOIDICHVU.GDV_TEN+�� $��Khách hàng�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� * PHIEUDANGKY.KHACHHANG.KH_HOTEN+�� $��Lần�� �� .R�� .+��� $��20 0 0 0q�$��Center=�
���   ����� *LIEUTRINH.LT_STT+�� $��Liệu trình�� �� .R�� .+��� $	��220��$��15 0 0 0q�$��Center=�$
��Wrap=����� *LIEUTRINH.LT_MOTA+�� $��Ngày đến�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *LTDT_NGAYDT+ �� StringFormat$ 
dd/MM/yyyy���� $��Buổi�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *LTDT_THOIGIANDEN+�� $��Thực hiện�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *LIEUTRINH.LT_THOIGIANTH+� $��1��	 �� $
��1.3* ��� $
��0.7* �.+�  $
 10Q�$��10,20,9.6,9.6q�$��0��$��2��.��� 	 �� $
��auto ��� $
��auto ��� .+��� $ 
Horizontal=�.+��� $^��XE:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Icons\calendar\calendar.png��$��30��$��20 0 0 0q��� $��0��$��10 10 10 10q�#��[ $��Lịch hẹn hôm nay��
���   �$��18(��� $��5 0 5 5q�$	��0.1q�
���   �$��1���� $��2��.���� -   $��
lbxLICHHEN������ *	LICHHEN+ �� *SelectedLICHHEN+$ TwoWay=�$ PropertyChanged=�   $ MouseDoubleClick��.    �� *CommandSelectedLICHHEN+ �� $ 
lbxLICHHEN������ .R��� $ 
Horizontal=�.+��� $^��XE:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Icons\calendar\calendar.png��$��30��$��30��$��15 0 0 0q��� .+��� $��15(�$��30 0 0 0q�$
��Bold"����� *KHACHHANG.KH_HOTEN+�� $ 
Horizontal=�.+��� $ 
Horizontal=�$
��Left=�$��Center=�$��30 0 0 0q�.+�  $ CalendarMonth=�$��0 3 5 0q���  " MaterialDesignCaptionTextBlock#��[ ���� *
LH_NGAYDEN+$ 
dd/MM/yyyy���� $ 
Horizontal=�$
��Left=�$��Center=�$��20 0 0 0q�.+�  $ ClockTimeTenOutline=�$��0 3 5 0q��� #��[ ���� *LH_THOIGIANDEN+$ hh\:mm��  $
 10Q�$��10,9.8,9.6,20q�$��2��$��2��.��� 	 �� $
��auto ��� $
��auto ��� .+��� $ 
Horizontal=�.+��� $_��YE:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Icons\calendar\price-tag.png��$��30��$��20 0 0 0q��� $��0��$��10 12 10 10q�#��[ $��Khuyến mãi hôm nay��
���   �$��18(��� $��5 0 5 5q�$	��0.1q�
���   �$��1���� $��2��.����  � IsSharedSizeScope . ���� *	GIAMGIA+���� .R���  ��Name$ Border�� �� Padding$ 8q�$��0 0 0 1q�  MaterialDesignDivider#���  ._��  ��  z� SharedSizeGroup$ Checkerz���� .+��� $_��YE:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Icons\calendar\price-tag.png��$��30��$��30��$��12 0 0 0q��� $��8 0 0 0q�$��1��.+��� $ 
Horizontal=�.+��� $
��Bold"�$��16(����� *GG_TEN+�� $
��Bold"�$��16(�$	�� - ���� $
��Bold"�$��16(����� *GG_MA+�� $ 
Horizontal=�.+��� $ 
Horizontal=�$��0 3 0 0q�.+�  $ CalendarCheckOutline=�$��0 0 5 0q��� ���� *GG_NGAYBATDAU+$ 
dd/MM/yyyy���� $ 
Horizontal=�$��25 3 0 0q�.+�  $ CalendarRemove=�$��0 1 5 0q��� $��0 0 5 0q����� *GG_NGAYKETTHUC+$ 
dd/MM/yyyy��