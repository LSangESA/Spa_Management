   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLNV(LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLNV  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  A    ;LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLNV.W_ThongTinNhanVien   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Hlocal6clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLNV     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wThongTinNhanVien��  � Title$  W_ThongTinNhanVien��$
��1100��$	��550�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    ThongTinNhanVienVM � DataContext# [ ��Z� .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger  	   	EventName$	 Loaded��.  (System.Windows.Interactivity.TriggerBase
   Actions.
 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wThongTinNhanVien��.��� .+��� 
���   �$��2q� �� CornerRadius$ 15 15 15 15��._�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q����	#FFF7F7F7.���  � ColumnDefinitions �� $	��270 ��� $
��0.8* ��� $
��1.2* �.+��� 
���   �$��0 0 1 0q��� $��0��.+��� $��	15 10 0 0q�.+��� $��15(�$��	10 20 0 0q�$
��Bold"�$��Center=����� *NV_TEN+��  �� Orientation$ 
Horizontal=�.+��� $��Mã: ��$��13(�$��	10 10 0 0q�$
��Bold"�$��Center=��� $��13(�$��5 10 0 0q�$
��Bold"�$��Center=����� *NV_MA+�� $ 
Horizontal=�$��Center=�$��
20 30 0 10q�.+�� $��30��.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Cake=�$��0 0 5 0q���  " MaterialDesignCaptionTextBlock#��[ ���� *NV_NGAYSINH+ �� StringFormat$ 
dd/MM/yyyy���� $ 
Horizontal=�$
��Left=�$��Center=�$��
20 10 0 10q�.+�� $��30��.+�  $ 
PhoneCheck=�$��0 3 5 0q��� #��[ ���� *NV_SDT+$ 
dd/MM/yyyy���� $ 
Horizontal=�$
��Left=�$��Center=�$��
20 10 0 10q�.+�� $��30��.+�  $ Email=�$��0 3 5 0q��� #��[ ���� *
NV_EMAIL+�� $ 
Horizontal=�$
��Left=�$��Center=�$��
20 10 0 10q�.+�� $��30��.+�  $ CardAccountDetailsOutline=�$��0 3 5 0q��� #��[ ���� *	NV_CCCD+�� $ 
Horizontal=�$
��Left=�$��Center=�$��
20 10 0 10q�.+�� $��30��.+�  $ GenderMaleFemale=�$��0 3 5 0q��� #��[ ���� *NV_GIOITINH+�� $ 
Horizontal=�$��
20 10 0 10q�$
��Left=�$��Center=�$��50��.+�� $��30��.+�  $ MapMarkerRadius=�$��0 1 5 0q�$��17��$��17���� #��[ $
��Wrap=�$	��200������ *	NV_DIACHI+�� $��1��$��	10 30 0 0q�.+��� 
���   �$��0��$	��0.5q�$	��Top=�$
��Left=�$��
20 0 20 20q�$	��140��$	��129��._��� $	��140��$	��129������ *NV_ANH+�� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tài khoản�� % !MaterialDesignFloatingHintTextBox#��[ $��
15 8 25 10q�$��1��{�.  ���� *NV_USERNAME+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�G� -    G�Name$ FloatingPasswordBox��$ Mật khẩu�� ) %MaterialDesignFloatingHintPasswordBox#��[ $��
15 8 25 10q�   $	 PasswordChanged��.
    �� *PasswordChangedCommand+ �� $ FloatingPasswordBox��G� -   $ FloatingPasswordBoxNew��$ Mật khẩu mới��#��[ $��
15 8 25 10q�   $	 PasswordChanged��.
    �� *PasswordNewChangedCommand+ �� $ FloatingPasswordBoxNew����    MaterialDesignOutlinedButton#��[ $��15 10 15 10q�$��35��$��0��$
��Left=����� *CommandDoiMatKhau+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ ContentSave=�$��0 0 10 0q�$��25��$��25���� $
��Lưu��$��0 5 0 0q��� $��	10 5 25 5q�$	��0.1q�
���   ��� $ 
Horizontal=�.+��� $��
Vai trò: ��$��13(�$��	15 10 0 0q�$
��Bold"�$��Center=��� $��13(�$
��Bold"�$��0 10 0 0q�$��Center=����� *VT_TEN+�� $ 
Horizontal=�.+��� $
��Wrap=�$	��300��$��13(�$��	15 20 0 0q�$
��Bold"�$��Center=����� *NV_PHUTRACH+�� 
���   �$��1 0 0 0q�$��2��._��� .+���  & "MaterialDesignToolForegroundButton#��[ $��0q�$��25��$��0 5 15 0q�$��Bottom=�$��0q�$��Right=����� *CommandClose+���� $ wThongTinNhanVien��.��  $ Close=��� -   $��lvwLichLamViec��$	��450��$	��Top=�{�.  ���� *LICHLAMVIEC+ �� SelectedItem �� *SelectedLICHLAMVIEC+$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectedLICHLAMVIEC+ �� $ lvwLichLamViec�� �� View �� .P��� $��Ngày�� �� CellTemplate �� .R�� $��30��.+��� $��17 0 0 0q�$��Center=�$
��Bold"�$	��100��$��Center=����� *NGAY+$ 
dd/MM/yyyy������ *
ColorDay+�� $��Sáng�� �� .R�� $��30��.+��� $��20 0 0 0q�$��Center=�$
��Bold"�$��80��$��Center=����� *SANG+���� *	ColorSang+�� $��Chiều�� �� .R�� $��30��.+��� $��20 0 0 0q�$��Center=�$
��Bold"�$��80��$��Center=����� *CHIEU+���� *
ColorChieu+�� $��
Cả ngày�� �� .R�� $��30��.+��� $��20 0 0 0q�$��Center=�$
��Bold"�$��80��$��Center=����� *CANGAY+���� *ColorCaNgay+