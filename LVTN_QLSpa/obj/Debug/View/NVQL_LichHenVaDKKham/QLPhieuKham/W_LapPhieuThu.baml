   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham0LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham  5   	   E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  5   	   D    >LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham.W_LapPhieuThu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Plocal>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham     5   	   6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��wLapPhieuThu��5	   	     � Title$  W_LapPhieuThu��5   	   $	��680��6   $	��800��6,    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .    MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	     LapPhieuThuVM � DataContext# [ 5   	   ��5   	   Z� .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
   	   	EventName$	 Loaded��6   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
LoadWindow+   CommandParameter 5   $   ��  �� ElementName$ wLapPhieuThu��5       .��5"      � .+�5#   
   �� 
���   �$��2q�6%    �� CornerRadius$ 15 15 15 15��69   ._�5$      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�6"   .��5%      �  � RowDefinitions 5&      �� 5'      $
��auto �6(   68   �� 5(      $
��auto �6(   68   �� 5)      $	��280 �6(   67   �� 5*      $
��auto �6(   68   �� 5+      $
��auto �6(   68   �� 5,      $
��auto �6(   68   �� 5-      6*   .+�50      �� $��LẬP PHIẾU THU��6    $
��Bold"�51      $��25(�52      $��30 30 20 20q�53      $��0��54      55      � 57      $��1��6   .+�58      �� $��30 0 0 0q�6%   .+�59      ��  �� Orientation$ 
Horizontal=�6)   .+�5:   "   ��  " MaterialDesignCaptionTextBlock#��[ 6,   $��Số phiếu thu:��5;   $   $��15(�5<   $   $	��130��5=   $   5>   #   �� 5?   "   #��[ 6,   $��15(�5A   $   $
��Bold"�5B   $   ��5@   $   �� *PT_STT+5C   #   5D      �� 5E      $ 
Horizontal=�6)   .+�5F   "   �� #��[ 6,   $��Ngày:��5G   $   $��15(�5H   $   $	��130��5I   $   5J   #   �� 5K   "   #��[ 6,   $��15(�5M   $   ��5L   $   �� *
PT_NGAYLAP+ �� StringFormat$ dd/MM/yyyy hh:mm��5N   #   5O      �� 5P      $ 
Horizontal=�6)   .+�5Q   "   �� #��[ 6,   $��Khách hàng:��5R   $   $��15(�5S   $   $	��130��5T   $   5U   #   �� 5V   "   #��[ 6,   $��15(�5X   $   ��5W   $   �� *
KH_HOTEN+5Y   #   5Z      �� 5[      $ 
Horizontal=�6)   .+�5\   "   �� #��[ 6,   $��Nhân viên lập:��5]   $   $��15(�5^   $   $	��130��5_   $   5`   #   �� 5a   "   #��[ 6,   $��15(�5c   $   ��5b   $   �� *NV_HOTEN_MA+5d   #   5e      5f      5g      � 5i      $��2��6   $��20q�6(    � ColumnDefinitions 5j      �� 5k      $
��1.5* �6/   6>   �� 5l      61   .+�5o      �� $+��%Thanh toán cho phiếu điều trị��6#     MaterialDesignGroupBox#���  5p      $��10 10 10 30q�5q      $��0��5r      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Custom=�5s         
Background �	#FF2D2F4C   
Foreground
 �����.��5v      �� .��5w   "   ��  � IsSharedSizeScope . ��6/   �� *PHIEUDIEUTRI+��5x   &   �� 5y   *   .R�5z   .   ��  ��Name$ Border��65    �� Padding$ 8q�6E   $��0 0 0 1q�6Q     MaterialDesignDivider#���  6k   ._�5{   2   �  5|   6   �� 5}   :    z� SharedSizeGroup$ Checkerz��6K   �� 5~   :   .+�5�   6   d�  d�Name$ chkPDT��5�   7   $��Center=�5�   C    ) %MaterialDesignActionLightToggleButton#��[ 5�   7    d� 	IsChecked 5�   7   �� *
IsSelected+��5�   :   �� 5�   >   .R�5�   B   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
FormSelect=�6Z   5�   ?    5�   :     5�   >   $	 Checked��6M   .
 5�   B      6X   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" ��  �� Path$*  $DataContext.CommandCheckThanhToanPDT� 5�   <   �� $ chkPDT��5�   ?     5�   >   $	 	Unchecked��6M   .
 5�   B      6X   ��  �� *FindAncestor+" ��$,  &DataContext.CommandUnCheckThanhToanPDT� 5�   <   �� $ chkPDT��5�   ?   5�   7   �� 5�   6   $��8 0 0 0q�6A   $��1��5�   5   .+�5�   :   �� $ 
Horizontal=�6E   .+�5�   >   �� $
��Bold"�6H   $��16(�6Z   ��6h   �� *	PDT_STT+�� 5�   >   $
��Bold"�6H   $��16(�6Z   $	�� - ��6h   �� 5�   >   $
��Bold"�6H   $��16(�6Z   ��6h   �� *PDT_NGAYLAP+5�   ;   �� 5�   :   $ 
Horizontal=�6E   .+�5�   >   �� ��6H   �� *	PDK_STT+�� 5�   >   $
��Bold"�6H   $	�� - ��6Z   �� 5�   >   ��6H   �� *	GDV_TEN+5�   ;   5�   7   5�   3   5�   /   ! �� Triggers! 5�   .   �� 5�   2   " �� Value$
" True��5�   2   # �� Binding# 5�   >   �� *
IsSelected+.a�5�   6   �� $ �� 
TargetName$$ Border��6=     MaterialDesignSelection% �� Value#% �  5�   1   & �� Property& � ��5�   3   5�   +   5�   #   5�      5�      �� 5�      $��1��6%   $��Bottom=�65   $��0 0 0 25q�6P   $��Right=�6b   .+�5�      �� )	  #MaterialDesignThemes.Wpf.HintAssist' 	  Hint$' Hình thức thanh toán��6'   ( �� 
IsEditable( . $��10 10 20 10q�5�   '   $	��240��5�   '    & "MaterialDesignFloatingHintComboBox#��[ 5�   '   ) �� DisplayMemberPath$) HTTT_TEN��5�   '   ��5�   '   �� *HTTT+* �� SelectedItem* 5�   '   �� *SelectedHTTT++ �� Mode$+ TwoWay=�, �� UpdateSourceTrigger$, PropertyChanged=�5�      �� 5�      -   5        $��txtTIENKHACHDUA��5�   &   $ ' Nhập tiền khách đưa��5�   &    %	 !MaterialDesignFloatingHintTextBox#��[	 5�   &   $��10 10 20 10q�5�   &   $	��240��5�   &   ��5�   &   �� *TIENKHACHDUA+$+ TwoWay=�$, PropertyChanged=�.��6v   5�      �� 5�      -   5        $��txtTIENTHUACHOKHACH��5�   &   $' Trả lại khách��5�   &   #��[	 5�   &   $��10 10 20 10q�5�   &   $	��240��5�   &   {�.  $
��Bold"�5�   &   
���  ����5�   &   �� *TIENTHUACHOKHACH+$+ TwoWay=�$, PropertyChanged=�.��6z   5�      5�      5      � 5     $��3��6   .+�5     �� $��	10 0 10 0q�6$   $	��0.1q�67   
���   �6c   5     � 5     $��4��6    5     �� 5     61   �� 5     61   .+�5     �� $��30 0 0 0q�6%   $��0��67   .+�5     �� $��Thành tiền��6(   #��[ 5      $��15(�5      5     �� 5     $��Giảm giá��6(   $��15(�5      $��0 7 0 0q�5      #��[ 5      
���  ��5     �� 5     $��
Tổng thu��6(   #��[ 5      $��0 7 0 0q�5      $��20(�5      5     5     �� 5     $��0 0 30 0q�6%   $��1��67   $��Right=�6G   .+�5     �� $ 
Horizontal=�6)   $��Right=�5  !   .+�5  "   �� #��[ 5   $   $��15(�5!  $   $��Right=�5"  $   ��5  ,   �� *	THANHTIEN+5#  #   �� 5$  "   $	�� đ��6,   $��Right=�5%  $   #��[ 5&  $   $��15(�5'  $   5(  #   5)     �� 5*     $ 
Horizontal=�6)   $��Right=�5+  !   .+�5,  "   �� $��15(�5-      $��0 7 0 0q�5.      $��Right=�5/      #��[ 50      
���  ����5,  ,   �� *	GG_TIEN+52  #   �� 53  "   $	�� đ��6,   $��15(�54  $   $��0 7 0 0q�55  $   $��Right=�56  $   #��[ 57  $   
���  ��59  #   5:     �� 5;     $ 
Horizontal=�6)   $��Right=�5<  !   .+�5=  "   �� -   5        $��
txtTONGTHU��5B  ,   #��[ 5>  ,   $��0 7 0 0q�5?  ,   $��Right=�5@  ,   $��20(�5A  ,   ��5=  ,   �� *
TONGTIEN+5C  #   �� 5D  "   $	�� đ��6,   #��[ 5E  $   $��0 7 0 0q�5F      $��Right=�5G      $��20(�5H      5I  #   5J     5L     5M     � 5O     $��5��6   .+�5P     �� $��	10 0 10 0q�6$   $	��0.1q�67   
���   �6c   5Q     � 5S     $��6��6    5T     �� 5U     61   �� 5V     61   �� 5W     61   .+�5Y     ��  
 MaterialDesignRaisedButton#��[
 6!   - � ToolTip$/- )Resource name: MaterialDesignRaisedButton��5Z     $��10 10 10 20q�5[     +
  %MaterialDesignThemes.Wpf.ButtonAssist. 
  CornerRadius$. 10��5\     $��40��5]     $��0��5^     $��Bottom=�5a     $��0q�65   ���	#FF2D2F4C��5_     �� *CommandInHoaDon+��5`  !   �� $ wLapPhieuThu��.��5b     �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   .+�5c  "     $ Receipt=�6:   $��0 0 10 0q�6I   $��25��6[   $��25��6f   �� 5d  "   $��In hóa đơn��6,   $��0 5 0 0q�6>   6Q   5e     5f     �� 5g     #��[
 6!   $/- )Resource name: MaterialDesignRaisedButton��5h     $��10 10 10 20q�5i     $. 10��5j     $��40��5k     $��1��5l     $��Bottom=�5o     $��0q�65   ���	#FF2D2F4C��5m     �� *CommandAddPT+��5n     �� $ wLapPhieuThu��.��5p     �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   .+�5q  "     $ CheckAll=�6:   $��0 0 10 0q�6J   $��25��6\   $��25��6g   �� 5r  "   $��Hoàn thành��6,   $��0 5 0 0q�6>   6Q   5s     5t     �� 5u     #��[
 6!   $/- )Resource name: MaterialDesignRaisedButton��5v     $��10 10 10 20q�5w     $. 10��5x     $��40��5y     $��2��5z     $��Bottom=�5}     $��0q�65   ���	#FFCA3C2A��5{     �� *CommandHuyPhieuThu+��5|     �� $ wLapPhieuThu��.��5~     �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   .+�5  "     $ DeleteForeverOutline=�6:   $��0 0 5 0q�6V   $��25��6g   $��25��6r   �� 5�  "   $��Thoát��6,   $��0 5 0 0q�69   6L   5�     5�     5�     5�     5�     5�     5�     5�     