   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham0LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham  5   	   E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  5   	   H    BLVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham.W_LapPhieuDieuTri   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Plocal>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham     5   	   6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��wLapPhieuDieuTri��5	   	     � Title$  W_LapPhieuDieuTri��5   	   $	��650��6#   $	��500��60    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .    MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	     LapPhieuDieuTriVM � DataContext# [ 5   	   ��5   	   Z� .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
   	   	EventName$	 Loaded��6   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
LoadWindow+   CommandParameter 5   $   ��  �� ElementName$ wLapPhieuDieuTri��5       .��5"      � .+�5#   
   �� 
���   �$��2q�6%    �� CornerRadius$ 15 15 15 15��69   ._�5$      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�6"   .��5%      �  � RowDefinitions 5&      �� 5'      $
��auto �6(   68   �� 5(      6+   .+�5*      � -   5         �Name$ print��5*   (   $��0��6    5+      �� 5,      $
��auto �6,   6<   �� 5-      $
��auto �6,   6<   �� 5.      $
��auto �6,   6<   �� 5/      $
��auto �6,   6<   .+�51      � $��0��6   .+�52      �� $��PHIẾU ĐIỀU TRỊ��6(   $��Center=�53       $��40(�54       $��20q�55       $��0��56       57      58      � 59      $��1��6   .+�5:      �  � ColumnDefinitions 5;   "   �� 5<   &   $
��auto �67   6F   �� 5=   &   69   .+�5@   "   � $��0��6'    5A   &   �� 5B   *   $
��auto �68   6H   �� 5C   *   $
��auto �68   6H   �� 5D   *   $
��auto �68   6H   �� 5E   *   $
��auto �68   6H   �� 5F   *   $
��auto �68   6H   �� 5G   *   $
��auto �68   6H   �� 5H   *   $
��auto �68   6H   �� 5I   *   $
��auto �68   6H   .+�5L   &   �� $��Phiếu điều trị: ��60   $
��Bold"�6H   $��0��6Z   $��17(�6g   $��
25 15 0 15q�6u   6�   �� 5M   &   $��Phiếu đăng ký: ��60   $��1��6G   $��17(�6T   $��
25 15 0 15q�6b   6x   �� 5N   &   $��Gói dịch vụ: ��60   $��2��6E   $��17(�6R   $��
25 15 0 15q�6`   6v   �� 5O   &   $��Khách hàng: ��60   $��3��6D   $��17(�6Q   $��
25 15 0 15q�6_   6u   �� 5P   &   $��Liệu trình: ��60   $��4��6D   $��17(�6Q   $��
25 15 0 15q�6_   6u   �� 5Q   &   $��Ngày khám: ��60   $��6��6C   $��17(�6P   $��
25 15 0 15q�6^   6t   �� 5R   &   $��Cách thanh toán: ��60   $��7��6I   $��17(�6V   $��
25 15 0 15q�6d   6z   5S   #   � 5U   "   $��1��6'    5V   &   �� 5W   *   $
��auto �68   6H   �� 5X   *   $
��auto �68   6H   �� 5Y   *   $
��auto �68   6H   �� 5Z   *   $
��auto �68   6H   �� 5[   *   $
��auto �68   6H   �� 5\   *   $
��auto �68   6H   �� 5]   *   $
��auto �68   6H   �� 5^   *   $
��auto �68   6H   .+�5`   &   �� $
��Bold"�6l   $��0��6~   $��17(�6�   $��
25 15 0 15q�6�   ��60   �� *SOPDT+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5a   &   $��1��6l   $��17(�6y   $��
25 15 0 15q�6�   ��60   �� *SOPDK+$ PropertyChanged=�6�   �� 5b   &   $��2��6m   $��17(�6z   $��
25 15 0 15q�6�   ��60   �� *TENGDV+$ PropertyChanged=�6�   �� 5c   &   $��3��6n   $��17(�6{   $��
25 15 0 15q�6�   ��60   �� *	HOTENKH+$ PropertyChanged=�6�   �� 5d   &   $��4��6m   $��17(�6z   $��
25 15 0 15q�6�   ��60   �� *LT_STT+$ PropertyChanged=�6�   �� 5e   &   $��6��6�   $��17(�6�   $��
25 15 0 15q�6�   ��60   �� *NGAYDT+ �� StringFormat$ dd/MM/yyyy HH:mm��$ PropertyChanged=�6�   �� 5f   &   $��7��6�   $��17(�6�   $��
25 15 0 15q�6�   ��60   �� *	CTT_TEN+$ dd/MM/yyyy hh:ss��$ PropertyChanged=�6�   5g   #   5h      5i      � 5k      $��2��6   .+�5l      �� -   5        $��cbxPhong��5p   '   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Phòng��5l   '   $��	30 5 30 5q�5m   '    & "MaterialDesignFloatingHintComboBox#��[ 5n   '   $��17(�5o   '   {�5q   '   �� *HienThiPhong+��5r   '   �� *PHONG+ �� SelectedItem 5s   '   �� *SelectedPHONG+ �� Mode$ TwoWay=�$ PropertyChanged=� 5t   "     5u   &   $	 SelectionChanged��65   .
 5v   *      6@   �� *CommandSelectedPHONG+ 5w   @   �� $ cbxPhong��5x   '   ��5z   "   �� 5{   &   .R�5|   *   ��  �� Orientation$ 
Horizontal=�65   .+�5}   .   �� ��68   �� *P_SO+6P   �� 5~   .   $	�� - ��68   6E   �� 5   .   ��68   �� *P_TEN+6Q   5�   +   5�   '   5�      5�      �� 5�      -   5        $��
chkKhachNo��5�        MaterialDesignDarkCheckBox#��[ 5�      $��3��5�      $��Khách nợ��5�      $��17(�5�      $��
25 20 0 15q�5�       d� 	IsChecked 5�   #   �� *CheckKhachNo+{�5�      �� *EnabledKhachNo+ 5�        5�   "   $	 Checked��61   .
 5�   &      6<   �� *CommandCheckKhachNo+ 5�   $   �� $ 
chkKhachNo��5�   #     5�   "   $	 	Unchecked��61   .
 5�   &      6<   �� *CommandUnCheckKhachNo+ 5�   $   �� $ 
chkKhachNo��5�   #   5�      5�      � 5�      $��1��6    5�      �� 5�      61   �� 5�      61   �� 5�      61   .+�5�      ��   MaterialDesignRaisedButton#��[ 6!    � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5�   !   $��10 10 10 20q�5�   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5�   !   $��40��5�   !   $��0��5�   !   $��Bottom=�5�   !   $��0q�6=   ���	#FF2D2F4C��5�   !   �� *CommandInPhieu+��5�   !   �� $ wLapPhieuDieuTri��.��5�      �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   .+�5�   "   '	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$ Receipt=�6:   $��0 0 10 0q�6I   $��25��6[   $��25��6f   �� 5�   "   $��
In phiếu��6,   $��0 5 0 0q�6<   6O   5�      5�      �� 5�      #��[ 6!   $/ )Resource name: MaterialDesignRaisedButton��5�      $��10 10 10 20q�5�      $ 10��5�      $��40��5�      $��1��5�      $��Bottom=�5�      $��0q�65   ���	#FF2D2F4C��5�      �� *CommandOpenPhieuThu+��5�      �� $ wLapPhieuDieuTri��.��5�      �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   .+�5�   "   	  $ CurrencyUsd=�6:   $��0 0 0 0q�6M   $��25��6^   $��25��6i   �� 5�   "   $��Thanh toán��6,   $��0 5 0 0q�6>   6Q   5�      5�      �� 5�      #��[ 6!   $/ )Resource name: MaterialDesignRaisedButton��5�      $��10 10 10 20q�5�      $ 10��5�      $��40��5�      $��2��5�      $��Bottom=�5�      $��0q�65   ���	#FFCA3C2A��5�      �� *CommandClosePDT+��5�      �� $ wLapPhieuDieuTri��.��5�      �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   .+�5�   "   	  $ DeleteForeverOutline=�6:   $��0 0 0 0q�6V   $��25��6g   $��25��6r   �� 5�   "   $��Thoát��6,   $��0 5 0 0q�69   6L   5�      5�      5�      5�      5�      5�      5�      5�      