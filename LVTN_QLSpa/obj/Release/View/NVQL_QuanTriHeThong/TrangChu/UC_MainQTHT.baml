   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.TrangChu-LVTN_QLSpa.View.NVQL_LichHenVaDKKham.TrangChu  ?    9LVTN_QLSpa.View.NVQL_LichHenVaDKKham.TrangChu.UC_MainQTHT   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Mlocal;clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.TrangChu     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���  .���  � RowDefinitions �� $
��auto ��� .+�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 10Q�$��10q�$��0��.���  � ColumnDefinitions �� �� �� .+���   MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��$��40��$��0��$��Bottom=�$��0q����	#FF2D2F4C���� *	ClearLT+.����  �� Orientation$ 
Horizontal=�$��0 0 10 0q�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	FileChart=�$��0 0 10 0q�$��25��$��25���� $��Báo cáo hôm nay��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$ 10��$��40��$��1��$��Bottom=�$��0q����	#FF2D2F4C���� *	ClearLT+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ CalendarPlus=�$��0 0 10 0q�$��25��$��25���� $��Tạo lịch hẹn mới��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$ 10��$��40��$��2��$��Bottom=�$��0q����	#FF2D2F4C���� *	ClearLT+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ TextBoxPlusOutline=�$��0 0 10 0q�$��25��$��25���� $"��Đăng ký mới dịch vụ��$��0 5 0 0q�� $��1�� �� $
��1.4* ��� $
��0.6* �.+�� $��0�� �� $
��auto ��� .+�� $��10q�$��0�� �� �� �� .+�  ���	#FFE77E7E ! PrimaryHueDarkForegroundBrush#���  $��0q�$��
0 10 20 20q�$ 15Q�.���� .+��  �� �� .+��� $��0��$��
16 16 16 4q� $  MaterialDesignHeadline5TextBlock#��[ $��	Doanh thu��
���   �  $ CurrencyUsd=�$��1��$��15q�$��30��$��30��
���   �$��Right=�� $��15q� �� �� .+��� $��Tổng tiền��$��0 20 0 0q�$
��Left=�$��Center=�
���   �$��15(��� $��123.000.000đ��$��0 20 0 0q�$��Right=�$��Center=�
���   �$��1��$��15(�  ���	#FF79F6B9#���  $��0q�$��1��$��20 10 20 20q�$ 15Q�.���� .+��  �� �� .+��� $��0��$��
16 16 16 4q�#��[ $��Tổng nợ��
���   �  $ DatabaseImport=�$��1��$��15q�$��30��$��30��
���   �$��Right=�� $��15q� �� �� .+��� $��Tổng tiền��$��0 20 0 0q�$
��Left=�$��Center=�
���   �$��15(��� $��123.000.000đ��$��0 20 0 0q�$��Right=�$��Center=�
���   �$��1��$��15(�  ���	#FFEBF077#���  $��0q�$��2��$��
20 10 0 20q�$ 15Q�.���� .+��  �� �� .+��� $��0��$��
16 16 16 4q�#��[ $��Khách hàng��
���   �  $ CardAccountDetailsOutline=�$��1��$��15q�$��30��$��30��
���   �$��Right=�� $��15q� �� �� .+�� $��0��.+��� $��Center=�.+��� $��15��$��0 5 0 0q�$��Center=�
���   �$��20(��� $��Khách mới hôm nay��$��0 5 0 0q�$��Center=�
���   �$��13(�� $��1��.+��� $��Center=�.+��� $��9��$��0 5 0 0q�$��Center=�
���   �$��20(��� $��Khách cũ hôm nay��$��0 5 0 0q�$��Center=�
���   �$��13(�  $��1��$ 10Q�$��10 10 10 20q�.���  �� $
��auto ��� �� .+�� $��0�� �� �� �� .+��� $��0��$��20q�#��[ $ ��Lịch tái khám hôm nay��
���   �$��20(�� $��1�� �� $
��auto ��� .+�  $ Magnify=�$��25��$��25��$��0��$��0 15 0 0q��� )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$7	 1Tìm kiếm theo tên hoặc số điện thoại�� % !MaterialDesignFloatingHintTextBox#��[ $��1��$��	10 0 0 25q����� *NV_MA+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.���� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��90 10 10 20q�$ 10��$��35��$��2��$��Bottom=�$��0q����	#FF2D2F4C���� *	ClearLT+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ NoteTextOutline=�$��0 0 10 0q�$��25��$��25���� $!��Lập phiếu điều trị��$��0 5 0 0q�� $��1�� �� $
��1.8* ��� �� .+�  $ 10Q�$��10 20 10 10q�$��0��.���  �� $
��auto ��� $
��auto ��� .+��� $��0��$��20 10 10 10q�#��[ $��Lịch hẹn hôm nay��
���   �$��18(��� $��5 0 5 5q�$	��0.1q�
���   �$��1��  $ 10Q�$��10 10 10 10q�$��1��.���  �� $
��auto ��� $
��auto ��� .+��� $��0��$��20 10 10 10q�#��[ $��Sinh nhật khách hàng��
���   �$��18(��� $��5 0 5 5q�$	��0.1q�
���   �$��1��  $ 10Q�$��10 10 10 20q�$��2��.���  �� $
��auto ��� $
��auto ��� .+��� $��0��$��20 10 10 10q�#��[ $��Khuyến mãi hôm nay��
���   �$��18(��� $��5 0 5 5q�$	��0.1q�
���   �$��1��