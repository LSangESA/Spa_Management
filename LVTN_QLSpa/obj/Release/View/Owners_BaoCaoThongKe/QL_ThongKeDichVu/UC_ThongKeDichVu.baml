   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDichVu5LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDichVu  ` \De.TorstenMandelkow.MetroChart, Version=0.9.5818.20693, Culture=neutral, PublicKeyToken=nullwTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChartDe.TorstenMandelkow.MetroChart L    FLVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDichVu.UC_ThongKeDichVu   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     UlocalCclr-namespace:LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDichVu     gchart1Tclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChart     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���  .���  � RowDefinitions �� �� $
��auto �.+�� $��0�� � ColumnDefinitions �� $��0.35* ��� .+�� $��0�� �� $��0.35* ��� .+�#  MaterialDesignThemes.Wpf.Card   ! PrimaryHueDarkForegroundBrush#���  $��0q�$��0��$��20q�   UniformCornerRadius$ 15Q�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFEFF035�� � Offset$ 0.234Q�� $ White��$ 1Q�.���� .+��  �� $
��auto ��� .+��� $��0��$��
16 16 16 4q� $  MaterialDesignHeadline5TextBlock#��[ $��Đăng ký nhiều nhất��$
��Bold"�
���   �'  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 StarOutline=�$��1��$��15q�$��30��$��30��
���   �$��Right=�� $��15q� �� $
��0.8* ��� .+�� $��0��.+��� $��Center=�.+��� $��0 10 0 0q�$��Center=�
���   �$��22(����� *LUOTDANGKYTOP+�� $��Lượt đăng ký��$��0 5 0 0q�$��Center=�
���   �$
��Bold"�$��13(�� $��1��.+��� $��Center=�.+��� $��0 10 0 0q�$��Center=�
���   �$��22(����� *	DICHVUTOP+�� $��Dịch vụ��$��0 5 0 0q�$��Center=�
���   �$
��Bold"�$��13(�  $��20q�$ 10Q�$��1��.���  �� $
��auto ��� .+��� $��0��
 �� Orientation$
 
Horizontal=�$��10q�.+��� $S��ME:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Image\Filter\filter.png��$��20��$	��Top=�$��20��$��0 0 10 0q��� $��
Bộ lọc��$��18(�$	��Top=��� $��1��$��10q�.+�	� -   $��	rdoOption��  MaterialDesignRadioButton#��[ $��Ngày tùy chọn�� 	� 	GroupName$ 	Statistic��(  "System.Windows.Controls.DatePicker  -   $��editFromDate��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ngày bắt đầu��$��	20 5 20 5q� ( $MaterialDesignFloatingHintDatePicker#��[   -   $��
editToDate��$ Ngày kết thúc��$��	20 5 20 5q�#��[ 	� -   $��rdoCuThe��#��[ $��0 50 0 0q�$��Thời gian cụ thể��$ 	Statistic���� $ Chọn ngày�� �� 
IsEditable . $��	20 5 20 5q� & "MaterialDesignFloatingHintComboBox#��[  �� DisplayMemberPath$ DV_TEN������ *DICHVU+ �� SelectedItem �� *
SelectedDV+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��  �� �� .+��� -   $��	editMonth��$ Tháng�� . $��	20 5 10 5q�$��0��#��[ ���� *#!LongListToTestComboVirtualization+�� -   $��editYear��$
 Năm�� . $��	10 5 20 5q�$��1��#��[ ���� *#!LongListToTestComboVirtualization+�� $
 
Horizontal=�$��Center=�$��	0 140 0 0q�.+��� -     MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 20q�$��35��$	��0.5q�$	��120��
���   �
���   �
�������.���� $
 
Horizontal=�$��0 0 10 0q�.+�  $	 
FilterMenu=�$��0 0 10 0q�$��25��$��25���� $��Lọc��$��0 5 0 0q��� -   #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 20q�$��35��$	��0.5q�$	��120��
���   �
���   �
�������.���� $
 
Horizontal=�$��0 0 10 0q�.+�  $	 CloseCircle=�$��0 0 10 0q�$��25��$��25���� $��
Bỏ lọc��$��0 5 0 0q�� $��1�� �� �� .+�  $��10q�$ 10Q�$��0��.��9  3De.TorstenMandelkow.MetroChart.ClusteredColumnChart  -	   $��myChart��$��Sitka Subheading)�.  (De.TorstenMandelkow.MetroChart.ChartBase   
ChartTitle$  ��$��1��$��1��   ChartSubTitle$3 -Số tiền bán được của từng loại��   ChartLegendVisibility$ Visible=�$��5,-15,5,-35q�$��0q�
������    Series 0  *De.TorstenMandelkow.MetroChart.ChartSeries  -
   $��columnChart2��   SeriesTitle$  ��   DisplayMember$
 Name��   ValueMember$
 Sold��  $��10 10 10 20q�$ 10Q�$��1��.��  $��Sitka Subheading)�$	��365��$	��Top=�$  ��$��1��$+ %Số sản phẩm của từng loại��$ Visible=�$��5,-15,5,-35q�$��0q�
������    -   $��columnChart1��$  ��$
 Name��$ NumOfProduct��