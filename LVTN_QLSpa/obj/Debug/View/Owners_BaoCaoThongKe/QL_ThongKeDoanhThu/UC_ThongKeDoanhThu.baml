   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Eclr-namespace:LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDoanhThu7LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDoanhThu  5      U QInteractiveDataDisplay.WPF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullkLclr-namespace:InteractiveDataDisplay.WPF;assembly=InteractiveDataDisplay.WPFInteractiveDataDisplay.WPF 5	      P    JLVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDoanhThu.UC_ThongKeDoanhThu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      WlocalEclr-namespace:LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDoanhThu     5      [d3Lclr-namespace:InteractiveDataDisplay.WPF;assembly=InteractiveDataDisplay.WPF     5	      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5
      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��0.35* �6   6/   �� 5      6!   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $��0.35* �6    61   �� 5      6"   .+�5      #  MaterialDesignThemes.Wpf.Card   ! PrimaryHueDarkForegroundBrush#���  5   "   $��0q�5    "   $��0��5!   "   $��20q�5"   "      UniformCornerRadius$ 15Q�5#   "   ��5$      �� 5%       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5&      �  � Color$ 	#FF08FFFB��6'    � Offset$ 0.234Q�69   � 5'      $ White��6'   $ 1Q�65   5(      .��5*      �� .+�5+      �  5,      �� 5-      61   �� 5.      61   .+�50      �� $��0��6$   $��
16 16 16 4q�51   $    $  MaterialDesignHeadline5TextBlock#��[ 52   $   $��	Doanh thu��53   $   $
��Bold"�54   $   
���   �56      '  !MaterialDesignThemes.Wpf.PackIcon  58      	   Kind$	 CurrencyUsd=�62   $��1��59   2   $��15q�5:   2   $��30��5;   2   $��30��5<   2   
���   �$��Right=�5>   2   5?      � 5@      $��15q�6    5A      �� 5B      $
��0.8* �6/   6>   �� 5C      61   .+�5F      � $��0��6   .+�5G      �� $��Center=�6)   .+�5H   "   �� $��0 10 0 0q�6H   $��Center=�6Z   
���   �$��22(�6�   ��6,   �� *
SOPHIEUTHU+6�   �� 5I   "   $��Phiếu thu��6,   $��0 5 0 0q�6=   $��Center=�6N   
���   �$
��Bold"�6~   $��13(�6�   6�   5J      5K      � 5M      $��1��6   .+�5N      �� $��Center=�6)   .+�5O   "   �� $��0 10 0 0q�6N   $��Center=�6`   
���   �$��22(�6�   ��6,   �� *TONGTIENPHIEUTHU+6�   �� 5P   "   $��Tổng tiền��6,   $��0 5 0 0q�6=   $��Center=�6N   
���   �$
��Bold"�6~   $��13(�6�   6�   5Q      5R      5S      5T      5U        5W      $��20q�6"   $ 10Q�6.   $��1��6G   .��5X      �  5Y      �� 5Z      $
��auto �6(   68   �� 5[      6*   .+�5^      �� $��0��6!   
 �� Orientation$
 
Horizontal=�5_   !   $��10q�5`   !   .+�5a      �� $S��ME:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Image\Filter\filter.png��6    $��20��5b       $	��Top=�5c       $��20��5d       $��0 0 10 0q�5e       64   �� 5f      $��
Bộ lọc��6$   $��18(�62   $	��Top=�5g   $   6>   5h      �� 5j      $��1��6!   $��10q�6.   .+�5k      	� -   5        $��rdoYear��5n   &     MaterialDesignRadioButton#��[ 5k   &   $��Thống kê theo năm��5l   &    	� 	GroupName$ 	Statistic��5m   &   5n   &   �� 5o      -   5        $��editYearAll��5u   '   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Năm��5o   #    �� 
IsEditable . $��	20 5 20 5q�5q   '   $��1��5r   '    & "MaterialDesignFloatingHintComboBox#��[ 5s   '   ��5t   '   �� *#!LongListToTestComboVirtualization+5v      	� 5w      -   5        $��rdoDayMonth��5{   &   #��[ 5w   &   $��0 50 0 0q�5x   &   $��Thống kê theo tháng��5y   &   $ 	Statistic��5z   &   5{   &   � 5|       5}      �� 5~   "   65   �� 5   "   65   .+�5�      �� -   5        $��	editMonth��5�   '   $ Tháng��5�   '    . $��	20 5 10 5q�5�   '   $��0��5�   '   #��[ 5�   '   ��5�   '   �� *#!LongListToTestComboVirtualization+5�      �� 5�      -   5        $��editYear��5�   '   $
 Năm��5�   '    . $��	10 5 20 5q�5�   '   $��1��5�   '   #��[ 5�   '   ��5�   '   �� *#!LongListToTestComboVirtualization+5�      5�      �� 5�      $
 
Horizontal=�6%   $��Center=�6>   $��	0 180 0 0q�6[   .+�5�      �� -   5          MaterialDesignRaisedButton#��[ 5�   %    � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5�   %   $��10 10 10 10q�5�   %   $��35��5�   %   $	��0.5q�5�   %   $	��120��5�   %   
���   �
���   �
�������.��5�   "   �� $
 
Horizontal=�6-   $��0 0 10 0q�6F   .+�5�   &     $	 
FilterMenu=�6>   $��0 0 10 0q�6P   $��25��6b   $��25��6m   �� 5�   &   $��Lọc��60   $��0 5 0 0q�6;   6N   5�   #   5�      �� 5�      -   5        #��[ 5�   %   $/ )Resource name: MaterialDesignRaisedButton��5�   %   $��10 10 10 10q�5�   %   $��35��5�   %   $	��0.5q�5�   <   $	��120��5�   %   
���   �
���   �
�������.��5�   "   �� $
 
Horizontal=�6-   $��0 0 10 0q�6F   .+�5�   &     $	 CloseCircle=�6>   $��0 0 10 0q�6Q   $��25��6c   $��25��6n   �� 5�   &   $��
Bỏ lọc��60   $��0 5 0 0q�6>   6Q   5�   #   5�      5�      5�      5�      5�      5�      � 5�   
   $��1��6    5�      �� 5�      $
��1.1* �6    60   �� 5�      $
��0.9* �6    60   .+�5�        $��10q�6"   $ 10Q�6.   $��0��6G   $��0 10 0 0q�6T   .��5�      &   InteractiveDataDisplay.WPF.Chart  -   5        $��Plotter��5�      $��0,0,25,0q�5�      $��Sitka Subheading)�5�         BottomTitle$ Ngày��5�         	LeftTitle$ Tiền��5�      
������    LegendContent 5�      1  +InteractiveDataDisplay.WPF.LegendItemsPanel  5�       � 	Resources 5�       ( $InteractiveDataDisplay.WPF.LineGraph	 �� X1	 �� Y1	 �� X2	 �� Y2 �� Path��%"  &	       �� 5�   "   .R�5�   &   �� $
 
Horizontal=�61   .+�5�   *   �� $��15��6/   $��15��6:   $ 0��6F   $ 0��6M   $ 15��6T   $ 15��6\   $��2��6�   ��6d   �� $ Stroke�6�   �� 5�   *   $��5,0,0,0q�64   ��6E   �� $ Description�5�   '   5�   #   5�      5�      .��5�      � -	   5        $��Lines��5�      5�      5�        5�      $��10 10 10 20q�6"   $ 10Q�67   $��1��6P   .��5�      �  5�      �� 5�      $
��auto �6(   68   �� 5�      6*   .+�5�      � $��0��6   .+�5�      �� $
 
Horizontal=�6%   $��1��6>   $��	10 5 50 0q�6N   $��Center=�6a   .+�5�        $	 Magnify=�66   $��25��6E   $��25��6P   $��0 10 0 0q�6\   �� 5�      $# Nhập từ khóa tìm kiếm��6&    % !MaterialDesignFloatingHintTextBox#��[ 5�   .   $	��250��5�   .   ��5�   .   �� *
UserName+5�   .   5�      '  !MaterialDesignThemes.Wpf.PopupBox  5�      $��Right=�62      	StaysOpen . $	��Top=�5�   2   $��2 0 2 0q�5�   2   $��0 10 0 0q�5�   2      PopupContent. 5�      �� $	��200��6)   .+�5�   "   �� -
   5        $��Xuất Excel��5�   )   $��
10 0 10 10q�5�   )   5�   )   5�      5�      5�      �� 5�      -   5        $��lvwPHIEUTHU��5�      $��1��5�       �� View 5�      �� 5�      .P�5�   "   �� $��Số phiếu thu��61    �� CellTemplate 5�   &   �� 5�   *   .R�5�   .   � .+�5�   2   �� $��20 0 0 0q�6T   $��Center=�6f   ��6<   �� *PT_STT+6�   5�   /   5�   +   5�   #   �� 5�   "   $��Ngày lập��61    5�   &   �� 5   *   .R�5  .   � .+�5  2   �� $��20 0 0 0q�6�   $��Center=�6�   ��6<   �� *
PT_NGAYLAP+ �� StringFormat$ {0:dd/MM/yyyy h:mm tt}��6�   5  /   5  +   5  #   �� 5  "   $
��HTTT��61    5	  &   �� 5
  *   .R�5  .   � .+�5  2   �� $��20 0 0 0q�6h   $��Center=�6z   ��6<   �� *HINHTHUCTHANHTOAN.HTTT_TEN+6�   5  /   5  +   5  #   �� 5  "   $��Tổng tiền��61    5  &   �� 5  *   .R�5  .   � .+�5  2   �� $��20 0 0 0q�6p   $��Center=�6�   ��6<   �� *PT_TONGTIEN+$ {0:n0}��6�   5  /   5  +   5  #   �� 5  "   $��Nhân viên lập��61    5  &   �� 5  *   .R�5  .   � .+�5   2   �� $��20 0 0 0q�6_   $��Center=�6q   ��6<   �� *NHANVIEN.NV_HOTEN+6�   5!  /   5"  +   5$  #   5%     5'     5(     5)     5*     5+     5,     