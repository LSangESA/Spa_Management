   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham0LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  C    =LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham.W_InPhieuCho   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Plocal>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wInPhieuCho��  � Title$  W_InPhieuCho��$	��450��$	��370�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    InPhieuChoVM � DataContext# [ ��Z� .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger  	   	EventName$	 Loaded��.  (System.Windows.Interactivity.TriggerBase
   Actions.
 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wInPhieuCho��.��� .+��� 
���   �$��2q� �� CornerRadius$ 15 15 15 15��._�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�
�������.���  � RowDefinitions �� �� $
��auto �.+��� -   $��print��$��0��.+���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� $��0��
�������$��1q�$��70��$��70��._��� $Q��KE:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Image\logoSpaIcon.png����  $  MaterialDesignHeadline2TextBlock#��[ $��LQS SPA��$��50(�$
��Bold"�$	��20 q�$��Center=��� $��	10 0 10 0q�$��1q�
���   �$��1���� .+���  $  MaterialDesignHeadline3TextBlock#��[ $��30(�$
��Bold"�$��0 10 0 5q�$��Center=����� *PHONG+�� #��[ $��20(�$
��Bold"�$��0 0 0 10q�$��Center=����� *	GDV_TEN+�� $��	10 0 10 0q�$��1q�
���   �$��1���� $ 
Horizontal=�$��Center=�$��0 10 0 0q�.+��� #��[ $��30(�$��Số thứ tự: ���� #��[ $��30(�$
��Bold"�$��10 0 0 0q����� *STT+�� $ 
Horizontal=�$��Center=�$��0 5 0 0q�.+��� #��[ $��25(�$
��Bold"�$
��Wrap=����� *
KH_HOTEN+�� $ 
Horizontal=�$��	0 10 0 10q�$��Center=�.+��� #��[ $��14(�$��Mã KH: ��$
��Wrap=�$��0 0 0 0q��� #��[ $��14(�$
��Wrap=����� *KH_MA+�� #��[ $��14(�$��|��$
��Wrap=�$��10 0 0 0q��� #��[ $��14(�$��Tuổi: ��$
��Wrap=�$��10 0 0 0q��� #��[ $��14(�$
��Wrap=����� *	KH_TUOI+�� $��	10 0 10 0q�$��1q�
���   �$��1���� $ 
Horizontal=�$��	15 10 0 5q�.+��� #��[ $��13(�$��Số phiếu: ��$��Italic$�$��60���� #��[ $��13(�$
��Bold"�$
��Wrap=����� *	PDT_STT+�� $ 
Horizontal=�$��	15 0 0 10q�.+��� #��[ $��13(�$��Ngày: ��$��Italic$�$��60���� #��[ $��13(�$
��Bold"�$
��Wrap=����� *PDT_NGAYLAP+ �� StringFormat$ 
dd/MM/yyyy���� $��1��$ 
Horizontal=�$��Center=�.+��� -      MaterialDesignOutlinedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��0q�$��35��$��Center=�
�������$��2q�
��� � �$	��150��
��� � �.���� $ 
Horizontal=�$��0 0 10 0q�$��Right=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Printer=�$��0 0 10 0q�$��25��$��25���� $��In��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�
�������$��2q�
���  ��$��35��$	��150��
���  ������ *CommandClose+���� $ wInPhieuCho��.���� $ 
Horizontal=�$��0 0 10 0q�$��Right=�.+�  $ CloseBox=�$��	0 -1 10 0q�$��25��$��25���� $��Thoát��$��0 4 0 0q�