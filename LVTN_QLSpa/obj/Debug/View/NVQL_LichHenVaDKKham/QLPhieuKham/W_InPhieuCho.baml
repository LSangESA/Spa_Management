   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham0LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham  5   	   E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  5   	   C    =LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham.W_InPhieuCho   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Plocal>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham     5   	   6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��wInPhieuCho��5	   	     � Title$  W_InPhieuCho��5   	   $	��450��6   $	��370��6+    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .    MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	     InPhieuChoVM � DataContext# [ 5   	   ��5   	   Z� .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
   	   	EventName$	 Loaded��6   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
LoadWindow+   CommandParameter 5    $   ��  �� ElementName$ wInPhieuCho��5!      .��5$      � .+�5%   
   �� 
���   �$��2q�6%    �� CornerRadius$ 15 15 15 15��69   ._�5&      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�6"   
�������.��5'      �  � RowDefinitions 5(      �� 5)      6*   �� 5*      $
��auto �6(   68   .+�5-      �� -   5        $��print��5-   .   $��0��6!   .+�5/      ��  �� Orientation$ 
Horizontal=�6%   $��Center=�50   !   $��Center=�51   !   .+�52      �� $��0��6%   
�������$��1q�54   !   $��70��55   !   $��70��56   !   ._�57   "   �� $Q��KE:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Image\logoSpaIcon.png��6(   6   58      �� 59       $  MaterialDesignHeadline2TextBlock#��[ 6(   $��LQS SPA��5:   $   $��50(�5;   $   $
��Bold"�5<   $   $	��20 q�5=   $   $��Center=�5>   $   5?      5@      �� 5B      $��	10 0 10 0q�6$   $��1q�67   
���   �$��1��6_   6n   �� 5E      .+�5F      ��  $  MaterialDesignHeadline3TextBlock#��[ 6(   $��30(�5G   (   $
��Bold"�5H   (   $��0 10 0 5q�5J   (   $��Center=�5K   (   ��5I   (   �� *PHONG+5L      �� 5M      #��[ 6(   $��20(�5N   (   $
��Bold"�5O   (   $��0 0 0 10q�5Q   (   $��Center=�5R   (   ��5P   (   �� *	GDV_TEN+5S      5T      �� 5V      $��	10 0 10 0q�6$   $��1q�67   
���   �$��1��6_   6n   �� 5Y      $ 
Horizontal=�6%   $��Center=�5Z   %   $��0 10 0 0q�5[   %   .+�5\      �� #��[ 6(   $��30(�5]   (   $��Số thứ tự: ��5^   (   5_      �� 5`      #��[ 6(   $��30(�5a   (   $
��Bold"�5c   (   $��10 0 0 0q�5d   (   ��5b   (   �� *STT+5e      5f      �� 5i      $ 
Horizontal=�6%   $��Center=�5j   %   $��0 5 0 0q�5k   %   .+�5l      �� #��[ 6(   $��25(�5m   (   $
��Bold"�5o   (   $
��Wrap=�5p   (   ��5n   (   �� *
KH_HOTEN+5q      5r      �� 5t      $ 
Horizontal=�6%   $��	0 10 0 10q�6>   $��Center=�6Q   .+�5u      �� #��[ 6(   $��14(�5v   (   $��Mã KH: ��5w   (   $
��Wrap=�5x   (   $��0 0 0 0q�5y   (   5z      �� 5{      #��[ 6(   $��14(�5|   (   $
��Wrap=�5~   (   ��5}   (   �� *KH_MA+5      �� 5�      #��[ 6(   $��14(�5�   (   $��|��5�   (   $
��Wrap=�5�   (   $��10 0 0 0q�5�   (   5�      �� 5�      #��[ 6(   $��14(�5�   (   $��Tuổi: ��5�   (   $
��Wrap=�5�   (   $��10 0 0 0q�5�   (   5�      �� 5�      #��[ 6(   $��14(�5�   (   $
��Wrap=�5�   (   ��5�   (   �� *	KH_TUOI+5�      5�      �� 5�      $��	10 0 10 0q�6$   $��1q�67   
���   �$��1��6_   6n   �� 5�      $ 
Horizontal=�6%   $��	15 10 0 5q�6>   .+�5�      �� #��[ 6(   $��13(�5�   (   $��Số phiếu: ��5�   (   $��Italic$�5�   (   $��60��5�   (   5�      �� 5�      #��[ 6(   $��13(�5�   (   $
��Bold"�5�   (   $
��Wrap=�5�   (   ��5�   (   �� *	PDT_STT+5�      5�      �� 5�      $ 
Horizontal=�6%   $��	15 0 0 10q�6>   .+�5�      �� #��[ 6(   $��13(�5�   (   $��Ngày: ��5�   (   $��Italic$�5�   (   $��60��5�   (   5�      �� 5�      #��[ 6(   $��13(�5�   (   $
��Bold"�5�   (   $
��Wrap=�5�   (   ��5�   (   �� *PDT_NGAYLAP+ �� StringFormat$ 
dd/MM/yyyy��5�      5�      5�      �� 5�      $��1��6!   $ 
Horizontal=�6.   $��Center=�6G   .+�5�      �� -   5           MaterialDesignOutlinedButton#��[ 5�   !    � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5�   !   $��10 10 10 10q�5�   !   $��0q�5�   !   $��35��5�   !   $��Center=�5�   !   
�������$��2q�5�   4   
��� � �$	��150��5�   !   
��� � �.��5�      �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   $��Right=�6T   .+�5�   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Printer=�6:   $��0 0 10 0q�6I   $��25��6[   $��25��6f   �� 5�   "   $��In��6,   $��0 5 0 0q�66   6I   5�      5�      �� 5�      #��[ 6!   $/ )Resource name: MaterialDesignRaisedButton��5�   !   $��10 10 10 10q�5�   !   
�������$��2q�5�   4   
���  ��$��35��5�   !   $	��150��5�   !   
���  ����5�   !   �� *CommandClose+��5�   !   �� $ wInPhieuCho��.��5�      �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   $��Right=�6T   .+�5�   "     $ CloseBox=�6:   $��	0 -1 10 0q�6J   $��25��6]   $��25��6h   �� 5�   "   $��Thoát��6,   $��0 4 0 0q�69   6L   5�      5�      5�      5�      5�      5�      5�      5�      