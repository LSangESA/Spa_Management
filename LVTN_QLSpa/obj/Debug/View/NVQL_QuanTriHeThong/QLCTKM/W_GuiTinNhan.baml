   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLCTKM*LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLCTKM  5   	   E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  5   	   =    7LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLCTKM.W_GuiTinNhan   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Jlocal8clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLCTKM     5   	   6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��wGuiTinNhan��5	   	     � Title$  W_GuiTinNhan��5   	   $	��600��6   $
��1200��6+    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .    MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	     GuiTinNhanVM � DataContext# [ 5   	   ��5   	   Z� .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
   	   	EventName$	 Loaded��6   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
LoadWindow+   CommandParameter 5   $   ��  �� ElementName$ wGuiTinNhan��5       .��5"      � .+�5#   
   �� 
���   �$��2q�6%    �� CornerRadius$ 15 15 15 15��69   ._�5$      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�6"   ���	#FFF7F7F7.��5%      �  � ColumnDefinitions 5&      �� 5'      $
��0.5* �6+   6:   �� 5(      $
��1.5* �6+   6:   .+�5+      �� 
���   �$��0 0 1 0q�61   6M   �� 5,      $��0��6!   .+�5-      �� $��0��6%    �� Orientation$ 
Horizontal=�62   $��	0 10 0 10q�6K   .+�5.      �� -   5        $��	chkGuiSMS��51   '     MaterialDesignDarkCheckBox#��[ 5/   '   $	��SMS��50   '   $��
30 10 40 0q�65    d� 	IsChecked 5.   '   �� *CheckGuiSMS+ 52   "     53   &   $	 Checked��65   .
 54   *      6@   �� *CommandGuiSMS+ 55   @   �� $ 	chkGuiSMS��56   '   58      �� 59      -   5        $��chkGuiGmail��5=   '   #��[ 5:   '   $��Gmail��5;   '   $��
20 10 20 0q�5<   '    59   '   �� *CheckGuiMail+ 5>   "     5?   &   $	 Checked��65   .
 5@   *      6@   �� *CommandGuiGmail+ 5A   @   �� $ 	chkGuiSMS��5B   '   5D      5E      �� 5F        MaterialDesignRaisedButton#��[ 6!    � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5G   !   $��30 10 30 10q�5H   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��5I   !   $��35��5J   !   $��1��5K   !   $��Bottom=�5M   !   $��0q�6=   ���	#FF2D2F4C��5L   !   �� *CommandGuiGiamGia+.��5N      �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   .+�5O   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ EmailSendOutline=�6:   $��0 0 10 0q�6R   $��25��6d   $��25��6o   �� 5P   "   $��	Gửi đi��6,   $��0 5 0 0q�6:   6M   5Q      5R      �� 5T      $ 
Horizontal=�6%   $��	20 10 0 0q�6?   .+�5U      �� $��40��6>   $��40��6I   ��6$   �� *GG_ANH+6W   �� 5V      $��15(�6@   $��20 0 0 0q�6N   $
��Bold"�6`   $��Center=�6r   ��6(   �� *GG_TEN+6�   5W      �� 5Y      $ 
Horizontal=�6%   $
��Left=�5Z   %   $��Center=�5[   %   $��	20 30 0 0q�5\   %   .+�5]        $ CalendarCheckOutline=�66   $��0 3 5 0q�6R   �� 5^       " MaterialDesignCaptionTextBlock#��[ 6(   ��5_   (   �� *GG_NGAYBATDAU+ �� StringFormat$ 
dd/MM/yyyy��5`      5a      �� 5b      $ 
Horizontal=�6%   $
��Left=�5c   %   $��Center=�5d   %   $��	20 10 0 0q�5e   %   .+�5f        $ CalendarRemove=�66   $��0 3 5 0q�6L   �� 5g      #��[ 6(   ��5h   (   �� *GG_NGAYKETTHUC+$ 
dd/MM/yyyy��5i      5j      �� 5l      $ 
Horizontal=�6%   $
��Left=�5m   %   $��Center=�5n   %   $��	20 10 0 0q�5o   %   .+�5p        $
 Sale=�66   $��0 3 5 0q�6B   �� 5q      #��[ 6(   ��5r   (   �� *GG_PHANTRAMGIAM+5s      �� 5t      #��[ 6(   $��%��5u   (   5v      5w      �� 5y      $ 
Horizontal=�6%   $
��Left=�5z   %   $��Center=�5{   %   $��	20 10 0 0q�5|   %   .+�5}        $ CalendarClock=�66   $��0 3 5 0q�6K   �� 5~      #��[ 6(   ��5   (   �� *GG_TRANGTHAI+5�      5�      �� 5�      $ 
Horizontal=�6%   $
��Left=�5�   %   $��Center=�5�   %   $��	20 10 0 0q�5�   %   $��80��5�   %   .+�5�        $  CommentTextMultipleOutline=�66   $��0 3 5 0q�6X   �� 5�      #��[ 6(   $	��250��5�   D   $
��Wrap=�6P   ��6(   �� *
GG_NOIDUNG+5�      5�      �� 5�      $ 
Horizontal=�6%   $
��Left=�5�   %   $��Center=�5�   %   $��	20 10 0 0q�5�   %   .+�5�      �� #��[ 6(   $��Loại giảm: ��5�   (   5�      �� 5�      #��[ 6(   ��5�   (   �� *GG_LOAIGIAM+5�      5�      5�      �� 5�      $��1��6!   .+�5�      �� $ 
Horizontal=�6%   .+�5�      �� $��Danh sách khách hàng��6(   $��	20 15 0 0q�5�   $   $��16(�5�   $   64   �� 5�       & "MaterialDesignToolForegroundButton#��[ 6%   $��0q�5�   %   $��25��5�   %   $��
685 0 10 0q�5�   %   $��Bottom=�5�   %   $��0q�5�   %   $��Right=�5�   %   ��5�   %   �� *CommandClose+��5�   %   �� $ wGuiTinNhan��.��5�   "     $ Close=�6:   5�      5�      �� 5�      .��5�      �� $	��561��6�   ��6'   �� *ListKhachHang+ �� SelectedItem 6N   �� *SelectedKhachHang+ �� Mode$ OneWayToSource=� �� View 5�   "   �� 5�   &   .P�5�   *   ��  �� HeaderTemplate 5�   .   �� 5�   2   .R�5�   6   �� $ 
Horizontal=�6A   .+�5�   :   �� $��chkAllKH��5�   C   #��[ 5�   C   $��Chọn��5�   C   $
��Left=�5�   C    5�   >     5�   B   $	 Checked��6Q   .
 5�   F      6\   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� Path$# DataContext.CommandCheckAllKH� 5�   \   �� $ chkAllKH��5�   C     5�   B   $	 	Unchecked��6Q   .
 5�   F      6\   ��  �� *FindAncestor+" ��$% DataContext.CommandUnCheckAllKH� 5�   \   �� $ chkAllKH��5�   C   5�   ;   5�   7   5�   3    �� CellTemplate 5�   .   �� 5�   2   .R�5�   6   � $��17 0 0 0q�6;   .+�5�   :   �� $ 
Horizontal=�6E   .+�5�   >   �� $��chkAllKH��5�   G   #��[ 5�   G   $
��Left=�5�   G   $��Center=�5�   G    5�   G   �� *	IsCheck+5�   ?   �� 5�   >   $��35��6^   $��35��6i   ��6D   �� *KH_ANH+6x   5�   ;   5�   7   5�   3   5�   +   �� 5�   *   $��	Họ tên��69    5�   .   �� 5�   2   .R�5�   6   � .+�5�   :   �� $��	18 10 0 0q�6\   $��Center=�6o   $��Center=�6�   ��6D   �� *KH_TEN+6�   5�   7   5�   3   5�   +   �� 5�   *   $��Số điện thoại��69    5�   .   �� 5�   2   .R�5�   6   � .+�5�   :   �� $��	18 10 0 0q�6\   $��Center=�6o   $��Center=�6�   ��6D   �� *KH_SDT+6�   5�   7   5�   3   5�   +   �� 5�   *   $��Email��69    5�   .   �� 5�   2   .R�5�   6   � .+�5�   :   �� $��	18 10 0 0q�6^   $��Center=�6q   $��Center=�6�   ��6D   �� *
KH_EMAIL+6�   5�   7   5�   3   5�   +   �� 5�   *   $��Tuổi��69    5�   .   �� 5�   2   .R�5�   6   � .+�5�   :   �� $��	18 10 0 0q�6]   $��Center=�6p   $��Center=�6�   ��6D   �� *	KH_TUOI+6�   5�   7   5�   3   5�   +   �� 5�   *   $��Giới tính��69    5�   .   �� 5�   2   .R�5�   6   � .+�5�   :   �� $��	18 10 0 0q�6a   $��Center=�6t   $��Center=�6�   ��6D   �� *KH_GIOITINH+6�   5   7   5  3   5  +   �� 5  *   $��Địa chỉ��69    5  .   �� 5  2   .R�5  6   � .+�5  :   �� $��	18 10 0 0q�6_   $��Center=�6r   $��Center=�6�   ��6D   �� *	KH_DIACHI+6�   5	  7   5
  3   5  +   5  '   5     5     5     5     5     5     5     5     