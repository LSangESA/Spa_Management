   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDichVu5LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDichVu  5      ` \De.TorstenMandelkow.MetroChart, Version=0.9.5818.20693, Culture=neutral, PublicKeyToken=nullwTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChartDe.TorstenMandelkow.MetroChart 5	      L    FLVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDichVu.UC_ThongKeDichVu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDichVu     5      gchart1Tclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChart     5	      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5
      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      $
��auto �6   6,   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��0.35* �6#   63   �� 5      6%   .+�5      � $��0��6    5      �� 5      $��0.35* �6$   65   �� 5       6&   .+�5#      #  MaterialDesignThemes.Wpf.Card   ! PrimaryHueDarkForegroundBrush#���  5$   "   $��0q�5%   "   $��0��5&   "   $��20q�5'   "      UniformCornerRadius$ 15Q�5(   "   ��5)      �� 5*       �� EndPoint$ 0.5,1&�6.    �� 
StartPoint$ 0.5,0&�6?   .��5+      �  � Color$ 	#FFEFF035��6+    � Offset$ 0.234Q�6=   � 5,      $ White��6+   $ 1Q�69   5-      .��5/      �� .+�50      �  51      �� 52   "   $
��auto �63   6B   �� 53   "   65   .+�55      �� $��0��6(   $��
16 16 16 4q�56   ,    $  MaterialDesignHeadline5TextBlock#��[ 57   ,   $��Đăng ký nhiều nhất��58   ,   $
��Bold"�59   $   
���   �5;      '  !MaterialDesignThemes.Wpf.PackIcon  5=      	   Kind$	 StarOutline=�66   $��1��5>   2   $��15q�5?   2   $��30��5@   2   $��30��5A   2   
���   �$��Right=�5C   2   5D      � 5E      $��15q�6    5F      �� 5G   "   $
��0.8* �63   6B   �� 5H   "   65   .+�5K      � $��0��6#   .+�5L   "   �� $��Center=�6-   .+�5M   &   �� $��0 10 0 0q�6O   $��Center=�6a   
���   �$��22(�6�   ��60   �� *LUOTDANGKYTOP+6�   �� 5N   &   $��Lượt đăng ký��60   $��0 5 0 0q�6D   $��Center=�6U   
���   �$
��Bold"�6�   $��13(�6�   6�   5O   #   5P      � 5R      $��1��6#   .+�5S   "   �� $��Center=�6-   .+�5T   &   �� $��0 10 0 0q�6K   $��Center=�6]   
���   �$��22(�6�   ��60   �� *	DICHVUTOP+6�   �� 5U   &   $��Dịch vụ��60   $��0 5 0 0q�6?   $��Center=�6P   
���   �$
��Bold"�6�   $��13(�6�   6�   5V   #   5W      5X      5Y      5Z        5\      $��20q�6&   $ 10Q�62   $��1��6K   .��5]      �  5^      �� 5_      $
��auto �6,   6<   �� 5`      6.   .+�5c      �� $��0��6%   
 �� Orientation$
 
Horizontal=�5d   !   $��10q�5e   !   .+�5f      �� $S��ME:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Image\Filter\filter.png��6$   $��20��5g       $	��Top=�5h       $��20��5i       $��0 0 10 0q�5j       64   �� 5k      $��
Bộ lọc��6(   $��18(�66   $	��Top=�5l   $   6>   5m      �� 5o      $��1��6%   $��10q�62   .+�5p      	� -   5        $��	rdoOption��5s   *     MaterialDesignRadioButton#��[ 5p   *   $��Ngày tùy chọn��5q   *    	� 	GroupName$ 	Statistic��5r   *   5s   *   (  "System.Windows.Controls.DatePicker  5t      -   5        $��editFromDate��5w   )   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ngày bắt đầu��5t   )   $��	20 5 20 5q�5u   )    ( $MaterialDesignFloatingHintDatePicker#��[ 5v   )   5w   )     5x      -   5        $��
editToDate��5{   %   $ Ngày kết thúc��5x   )   $��	20 5 20 5q�5y   %   #��[ 5z   %   5{   %   	� 5}      -   5        $��rdoCuThe��5�   *   #��[ 5}   *   $��0 50 0 0q�5~   *   $��Thời gian cụ thể��5   *   $ 	Statistic��5�   *   5�   *   �� 5�      $ Chọn ngày��6'    �� 
IsEditable . $��	20 5 20 5q�5�       & "MaterialDesignFloatingHintComboBox#��[ 5�       �� DisplayMemberPath$ DV_TEN��5�      ��5�      �� *DICHVU+ �� SelectedItem 5�      �� *
SelectedDV+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5�      � 5�       5�   "   �� 5�   &   69   �� 5�   &   69   .+�5�   "   �� -   5        $��	editMonth��5�   +   $ Tháng��5�   +    . $��	20 5 10 5q�5�   +   $��0��5�   +   #��[ 5�   +   ��5�   +   �� *#!LongListToTestComboVirtualization+5�   #   �� 5�   "   -   5        $��editYear��5�   +   $
 Năm��5�   +    . $��	10 5 20 5q�5�   +   $��1��5�   +   #��[ 5�   +   ��5�   +   �� *#!LongListToTestComboVirtualization+5�   #   5�      �� 5�      $
 
Horizontal=�6)   $��Center=�6B   $��	0 140 0 0q�6_   .+�5�   "   �� -   5          MaterialDesignRaisedButton#��[ 5�   )    � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5�   %   $��10 10 10 20q�5�   %   $��35��5�   %   $	��0.5q�5�   =   $	��120��5�   %   
���   �
���   �
�������.��5�   &   �� $
 
Horizontal=�61   $��0 0 10 0q�6J   .+�5�   *     $	 
FilterMenu=�6B   $��0 0 10 0q�6T   $��25��6f   $��25��6q   �� 5�   *   $��Lọc��64   $��0 5 0 0q�6?   6R   5�   '   5�   #   �� 5�   "   -   5        #��[ 5�   )   $/ )Resource name: MaterialDesignRaisedButton��5�   %   $��10 10 10 20q�5�   %   $��35��5�   %   $	��0.5q�5�   ?   $	��120��5�   %   
���   �
���   �
�������.��5�   &   �� $
 
Horizontal=�61   $��0 0 10 0q�6J   .+�5�   *     $	 CloseCircle=�6B   $��0 0 10 0q�6U   $��25��6g   $��25��6r   �� 5�   *   $��
Bỏ lọc��64   $��0 5 0 0q�6B   6U   5�   '   5�   #   5�      5�      5�      5�      5�      � 5�      $��1��6    5�      �� 5�      6&   �� 5�      6&   .+�5�        $��10q�6&   $ 10Q�62   $��0��6K   .��5�      9  3De.TorstenMandelkow.MetroChart.ClusteredColumnChart  -	   5        $��myChart��5�   2   $��Sitka Subheading)�5�   2   .  (De.TorstenMandelkow.MetroChart.ChartBase   
ChartTitle$  ��5�   1   $��1��6?   $��1��6L      ChartSubTitle$3 -Số tiền bán được của từng loại��5�   1      ChartLegendVisibility$ Visible=�5�   1   $��5,-15,5,-35q�5�   1   $��0q�6F   
������    Series 5�      0  *De.TorstenMandelkow.MetroChart.ChartSeries  -
   5        $��columnChart2��5�   1      SeriesTitle$  ��5�   1      DisplayMember$
 Name��5�   1      ValueMember$
 Sold��5�   1   5�      5�        5�      $��10 10 10 20q�6&   $ 10Q�6;   $��1��6T   .��5�        $��Sitka Subheading)�62   $	��365��6P   $	��Top=�6]   $  ��5�   2   $��1��6@   $+ %Số sản phẩm của từng loại��5�   2   $ Visible=�5�   2   $��5,-15,5,-35q�5�   2   $��0q�6G   
������  5�        -   5        $��columnChart1��5�   1   $  ��5�   1   $
 Name��5�   1   $ NumOfProduct��5�   1   5�      5�      5�      5�      5�      5�      