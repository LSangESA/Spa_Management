   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLCTKM*LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLCTKM  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  =    7LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLCTKM.W_GuiTinNhan   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Jlocal8clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLCTKM     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wGuiTinNhan��  � Title$  W_GuiTinNhan��$	��600��$
��1200�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    GuiTinNhanVM � DataContext# [ ��Z� .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger  	   	EventName$	 Loaded��.  (System.Windows.Interactivity.TriggerBase
   Actions.
 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wGuiTinNhan��.��� .+��� 
���   �$��2q� �� CornerRadius$ 15 15 15 15��._�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q����	#FFF7F7F7.���  � ColumnDefinitions �� $
��0.5* ��� $
��1.5* �.+��� 
���   �$��0 0 1 0q��� $��0��.+��� $��0�� �� Orientation$ 
Horizontal=�$��	0 10 0 10q�.+��� -   $��	chkGuiSMS��  MaterialDesignDarkCheckBox#��[ $	��SMS��$��
30 10 40 0q� d� 	IsChecked �� *CheckGuiSMS+   $	 Checked��.
    �� *CommandGuiSMS+ �� $ 	chkGuiSMS���� -   $��chkGuiGmail��#��[ $��Gmail��$��
20 10 20 0q� �� *CheckGuiMail+   $	 Checked��.
    �� *CommandGuiGmail+ �� $ 	chkGuiSMS����   MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��30 10 30 10q�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��$��35��$��1��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandGuiGiamGia+.���� $ 
Horizontal=�$��0 0 10 0q�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ EmailSendOutline=�$��0 0 10 0q�$��25��$��25���� $��	Gửi đi��$��0 5 0 0q��� $ 
Horizontal=�$��	20 10 0 0q�.+��� $��40��$��40������ *GG_ANH+�� $��15(�$��20 0 0 0q�$
��Bold"�$��Center=����� *GG_TEN+�� $ 
Horizontal=�$
��Left=�$��Center=�$��	20 30 0 0q�.+�  $ CalendarCheckOutline=�$��0 3 5 0q���  " MaterialDesignCaptionTextBlock#��[ ���� *GG_NGAYBATDAU+ �� StringFormat$ 
dd/MM/yyyy���� $ 
Horizontal=�$
��Left=�$��Center=�$��	20 10 0 0q�.+�  $ CalendarRemove=�$��0 3 5 0q��� #��[ ���� *GG_NGAYKETTHUC+$ 
dd/MM/yyyy���� $ 
Horizontal=�$
��Left=�$��Center=�$��	20 10 0 0q�.+�  $
 Sale=�$��0 3 5 0q��� #��[ ���� *GG_PHANTRAMGIAM+�� #��[ $��%���� $ 
Horizontal=�$
��Left=�$��Center=�$��	20 10 0 0q�.+�  $ CalendarClock=�$��0 3 5 0q��� #��[ ���� *GG_TRANGTHAI+�� $ 
Horizontal=�$
��Left=�$��Center=�$��	20 10 0 0q�$��80��.+�  $  CommentTextMultipleOutline=�$��0 3 5 0q��� #��[ $	��250��$
��Wrap=����� *
GG_NOIDUNG+�� $ 
Horizontal=�$
��Left=�$��Center=�$��	20 10 0 0q�.+��� #��[ $��Loại giảm: ���� #��[ ���� *GG_LOAIGIAM+�� $��1��.+��� $ 
Horizontal=�.+��� $��Danh sách khách hàng��$��	20 15 0 0q�$��16(���  & "MaterialDesignToolForegroundButton#��[ $��0q�$��25��$��
685 0 10 0q�$��Bottom=�$��0q�$��Right=����� *CommandClose+���� $ wGuiTinNhan��.��  $ Close=��� .���� $	��561������ *ListKhachHang+ �� SelectedItem �� *SelectedKhachHang+ �� Mode$ OneWayToSource=� �� View �� .P���  �� HeaderTemplate �� .R��� $ 
Horizontal=�.+��� $��chkAllKH��#��[ $��Chọn��$
��Left=�   $	 Checked��.
    ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� Path$# DataContext.CommandCheckAllKH� �� $ chkAllKH��  $	 	Unchecked��.
    ��  �� *FindAncestor+" ��$% DataContext.CommandUnCheckAllKH� �� $ chkAllKH�� �� CellTemplate �� .R�� $��17 0 0 0q�.+��� $ 
Horizontal=�.+��� $��chkAllKH��#��[ $
��Left=�$��Center=� �� *	IsCheck+�� $��35��$��35������ *KH_ANH+�� $��	Họ tên�� �� .R�� .+��� $��	18 10 0 0q�$��Center=�$��Center=����� *KH_TEN+�� $��Số điện thoại�� �� .R�� .+��� $��	18 10 0 0q�$��Center=�$��Center=����� *KH_SDT+�� $��Email�� �� .R�� .+��� $��	18 10 0 0q�$��Center=�$��Center=����� *
KH_EMAIL+�� $��Tuổi�� �� .R�� .+��� $��	18 10 0 0q�$��Center=�$��Center=����� *	KH_TUOI+�� $��Giới tính�� �� .R�� .+��� $��	18 10 0 0q�$��Center=�$��Center=����� *KH_GIOITINH+�� $��Địa chỉ�� �� .R�� .+��� $��	18 10 0 0q�$��Center=�$��Center=����� *	KH_DIACHI+