   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLNV(LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLNV  5   	   E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  5   	   A    ;LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLNV.W_ThongTinNhanVien   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLNV     5   	   6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��wThongTinNhanVien��5	   	     � Title$  W_ThongTinNhanVien��5   	   $
��1100��5   	   $	��550��6    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .    MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	     ThongTinNhanVienVM � DataContext# [ 5   	   ��5   	   Z� .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
   	   	EventName$	 Loaded��6   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
LoadWindow+   CommandParameter 5    $   ��  �� ElementName$ wThongTinNhanVien��5!      .��5$      � .+�5%   
   �� 
���   �$��2q�6%    �� CornerRadius$ 15 15 15 15��69   ._�5&      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�6"   ���	#FFF7F7F7.��5'      �  � ColumnDefinitions 5(      �� 5)      $	��270 �6+   69   �� 5*      $
��0.8* �6+   6:   �� 5+      $
��1.2* �6+   6:   .+�5.      �� 
���   �$��0 0 1 0q�61   6M   �� 5/      $��0��6!   .+�50      �� $��	15 10 0 0q�6%   .+�51      �� $��15(�6@   $��	10 20 0 0q�6N   $
��Bold"�6a   $��Center=�6s   ��6(   �� *NV_TEN+6�   �� 52       �� Orientation$ 
Horizontal=�6)   .+�53   "   �� $��Mã: ��6,   $��13(�68   $��	10 10 0 0q�6F   $
��Bold"�6Y   $��Center=�6k   6�   �� 54   "   $��13(�6C   $��5 10 0 0q�6Q   $
��Bold"�6c   $��Center=�6u   ��6,   �� *NV_MA+6�   55      56      �� 58      $ 
Horizontal=�6%   $��Center=�59   %   $��
20 30 0 10q�5:   %   .+�5;      � $��30��6#   .+�5<   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Cake=�6:   $��0 0 5 0q�6F   5=      �� 5>       " MaterialDesignCaptionTextBlock#��[ 6(   ��5?   (   �� *NV_NGAYSINH+ �� StringFormat$ 
dd/MM/yyyy��5@      5A      �� 5B      $ 
Horizontal=�6%   $
��Left=�5C   %   $��Center=�5D   %   $��
20 10 0 10q�5E   %   .+�5F      � $��30��6#   .+�5G   "     $ 
PhoneCheck=�6:   $��0 3 5 0q�6L   5H      �� 5I      #��[ 6(   ��5J   (   �� *NV_SDT+$ 
dd/MM/yyyy��5K      5L      �� 5N      $ 
Horizontal=�6%   $
��Left=�5O   %   $��Center=�5P   %   $��
20 10 0 10q�5Q   %   .+�5R      � $��30��6#   .+�5S   "     $ Email=�6:   $��0 3 5 0q�6G   5T      �� 5U      #��[ 6(   ��5V   (   �� *
NV_EMAIL+5W      5X      �� 5Z      $ 
Horizontal=�6%   $
��Left=�5[   %   $��Center=�5\   %   $��
20 10 0 10q�5]   %   .+�5^      � $��30��6#   .+�5_   "     $ CardAccountDetailsOutline=�6:   $��0 3 5 0q�6[   5`      �� 5a      #��[ 6(   ��5b   (   �� *	NV_CCCD+5c      5d      �� 5f      $ 
Horizontal=�6%   $
��Left=�5g   %   $��Center=�5h   %   $��
20 10 0 10q�5i   %   .+�5j      � $��30��6#   .+�5k   "     $ GenderMaleFemale=�6:   $��0 3 5 0q�6R   5l      �� 5m      #��[ 6(   ��5n   (   �� *NV_GIOITINH+5o      5p      �� 5r      $ 
Horizontal=�6%   $��
20 10 0 10q�5s   %   $
��Left=�5t   %   $��Center=�5u   %   $��50��5v   %   .+�5w      � $��30��6#   .+�5x   "     $ MapMarkerRadius=�6:   $��0 1 5 0q�6Q   $��17��6b   $��17��6m   5y      �� 5z      #��[ 6(   $
��Wrap=�5|   (   $	��200��5}   (   ��5{   (   �� *	NV_DIACHI+5~      5      5�      �� 5�      $��1��6!   $��	10 30 0 0q�61   .+�5�      �� 
���   �$��0��5�   !   $	��0.5q�5�   !   $	��Top=�5�   !   $
��Left=�5�   !   $��
20 0 20 20q�5�   !   $	��140��5�   "   $	��129��6/   ._�5�      �� $	��140��6>   $	��129��6K   ��6$   �� *NV_ANH+6Y   5�      �� 5�      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tài khoản��6"    % !MaterialDesignFloatingHintTextBox#��[ 5�   &   $��
15 8 25 10q�5�   &   $��1��5�   &   {�.  ��5�   &   �� *NV_USERNAME+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5�   "   G� 5�      -   5         G�Name$ FloatingPasswordBox��5�   &   $ Mật khẩu��5�   &    ) %MaterialDesignFloatingHintPasswordBox#��[ 5�   &   $��
15 8 25 10q�5�   &    5�        5�   "   $	 PasswordChanged��61   .
 5�   &      6<   �� *PasswordChangedCommand+ 5�   <   �� $ FloatingPasswordBox��5�   #   5�      G� 5�      -   5        $ FloatingPasswordBoxNew��5�   &   $ Mật khẩu mới��5�   &   #��[ 5�   &   $��
15 8 25 10q�5�   &    5�        5�   "   $	 PasswordChanged��61   .
 5�   &      6<   �� *PasswordNewChangedCommand+ 5�   <   �� $ FloatingPasswordBoxNew��5�   #   5�      �� 5�         MaterialDesignOutlinedButton#��[ 6!   $��15 10 15 10q�5�   !   $��35��5�   !   $��0��5�   !   $
��Left=�5�   !   ��5�   !   �� *CommandDoiMatKhau+.��5�      �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   .+�5�   "     $ ContentSave=�6:   $��0 0 10 0q�6M   $��25��6_   $��25��6j   �� 5�   "   $
��Lưu��6,   $��0 5 0 0q�67   6J   5�      5�      �� 5�      $��	10 5 25 5q�6$   $	��0.1q�67   
���   �6c   �� 5�      $ 
Horizontal=�6%   .+�5�      �� $��
Vai trò: ��6(   $��13(�69   $��	15 10 0 0q�6G   $
��Bold"�6Z   $��Center=�6l   6�   �� 5�      $��13(�6@   $
��Bold"�6N   $��0 10 0 0q�6`   $��Center=�6r   ��6(   �� *VT_TEN+6�   5�      �� 5�      $ 
Horizontal=�6%   .+�5�      �� $
��Wrap=�6E   $	��300��6Y   $��13(�6e   $��	15 20 0 0q�6s   $
��Bold"�6�   $��Center=�6�   ��6(   �� *NV_PHUTRACH+6�   5�      5�      �� 5�      
���   �$��1 0 0 0q�61   $��2��6K   ._�5�      �� .+�5�      ��  & "MaterialDesignToolForegroundButton#��[ 6%   $��0q�5�      $��25��5�      $��0 5 15 0q�5�      $��Bottom=�5�      $��0q�5�      $��Right=�5�      ��5�      �� *CommandClose+��5�      �� $ wThongTinNhanVien��.��5�   "     $ Close=�6:   5�      �� 5�      -   5        $��lvwLichLamViec��5�      $	��450��5�      $	��Top=�5�      {�.  ��5�   '   �� *LICHLAMVIEC+ �� SelectedItem 5�      �� *SelectedLICHLAMVIEC+$ TwoWay=�$ PropertyChanged=� 5�   "     5�   &   $	 SelectionChanged��65   .
 5�   *      6@   �� *CommandSelectedLICHLAMVIEC+ 5�   $   �� $ lvwLichLamViec��5�   '    �� View 5�   "   �� 5�   &   .P�5�   *   �� $��Ngày��69    �� CellTemplate 5�   .   �� 5�   2   .R�5�   6   � $��30��6;   .+�5�   :   �� $��17 0 0 0q�5�   D   $��Center=�5�   D   $
��Bold"�5�   D   $	��100��5�   D   $��Center=�5�   D   ��5�   D   �� *NGAY+$ 
dd/MM/yyyy����5�   D   �� *
ColorDay+6f   5�   7   5�   3   5�   +   �� 5�   *   $��Sáng��69    5�   .   �� 5�   2   .R�5�   6   � $��30��6;   .+�5�   :   �� $��20 0 0 0q�5�   D   $��Center=�5�   D   $
��Bold"�5   D   $��80��5  D   $��Center=�5  D   ��5�   D   �� *SANG+��5  D   �� *	ColorSang+5  a   5  7   5  3   5  +   �� 5	  *   $��Chiều��69    5
  .   �� 5  2   .R�5  6   � $��30��6;   .+�5  :   �� $��20 0 0 0q�5  D   $��Center=�5  D   $
��Bold"�5  D   $��80��5  D   $��Center=�5  D   ��5  D   �� *CHIEU+��5  D   �� *
ColorChieu+5  b   5  7   5  3   5  +   �� 5  *   $��
Cả ngày��69    5  .   �� 5  2   .R�5  6   � $��30��6;   .+�5  :   �� $��20 0 0 0q�5  D   $��Center=�5  D   $
��Bold"�5   D   $��80��5"  D   $��Center=�5#  D   ��5  D   �� *CANGAY+��5!  D   �� *ColorCaNgay+5#  a   5$  7   5%  3   5'  +   5(  '   5*     5+     5,     5-     5.     5/     50     51     