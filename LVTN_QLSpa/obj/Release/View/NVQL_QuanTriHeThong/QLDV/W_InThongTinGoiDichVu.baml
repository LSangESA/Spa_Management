   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLDV(LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLDV  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  D    >LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLDV.W_InThongTinGoiDichVu   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Hlocal6clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLDV     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wInGDV��  � Title$  W_InThongTinGoiDichVu��$	��800��$	��690�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    InThongTinGoiDichVuVM � DataContext# [ ��Z� .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger  	   	EventName$	 Loaded��.  (System.Windows.Interactivity.TriggerBase
   Actions.
 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wInGDV��.��� .+��� 
���   �$��2q� �� CornerRadius$ 10��._�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 10Q�.��� 
������� � RowDefinitions �� �� $
��auto �.+��� $��1�� �� Orientation$ 
Horizontal=�$��Right=�.+��� -      MaterialDesignOutlinedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��0q�$��40��$��Center=�
�������$��2q�
��� � �$	��150��
��� � �.���� $ 
Horizontal=�$��0 0 10 0q�$��Right=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Printer=�$��0 0 10 0q�$��25��$��25���� $��In��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�
�������$��2q�
���  ��$��40��$	��150��
���  ������ *CommandClose+���� $ wInGDV��.���� $ 
Horizontal=�$��0 0 10 0q�$��Right=�.+�  $ CloseBox=�$��0 0 10 0q�$��25��$��25���� $��Thoát��$��0 5 0 0q�� -    �Name$ print��$��0�� �� $
��auto ��� .+��� $��0��$��0 20 0 0q�.+��� $��Sitka Subheading)�$��Center=�$��23(�$
��Bold"����� *	GDV_TEN+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��  �� �� �� �� .+�� $��0�� � ColumnDefinitions �� $	��130 ��� .+��� $��Sitka Subheading)�$��
Giá gói:��$��15(�$��
20 10 0 10q�$��0���� $��Sitka Subheading)�$��15(�$��
20 10 0 10q�$��1������ *DONGIA+ �� StringFormat$ 	0#,##0 đ��$ TwoWay=�$ PropertyChanged=�� $��1�� �� $	��130 ��� .+��� $��Sitka Subheading)�$��Lần liệu trình:��$��15(�$��
20 10 0 10q�$��0���� $��Sitka Subheading)�$��15(�$��
20 10 0 10q�$��1������ *	GDV_SOLAN+$ TwoWay=�$ PropertyChanged=�� $��2�� �� $	��130 ��� .+��� $��Sitka Subheading)�$��	Mô tả:��$��15(�$��
20 10 0 10q�$��0���� $��Sitka Subheading)�$��15(�$��20 10 20 10q�$��1��$
��Wrap=����� *
GDV_MOTA+$ TwoWay=�$ PropertyChanged=�� $��3�� �� $	��130 ��� .+��� $��Sitka Subheading)�$��Phương pháp:��$��15(�$��
20 10 0 10q�$��0���� $��Sitka Subheading)�$��15(�$��20 10 20 10q�$��1��$
��Wrap=����� *PP_TEN_MOTA+$ TwoWay=�$ PropertyChanged=�� $��1�� �� $
��auto ��� $
��auto ��� .+��� $��Sitka Subheading)�$"��Liệu trình thực hiện:��$��18(�$
��Bold"�$��	20 20 0 0q�$��0���� $��2������ *LTList+ �� SelectedItem �� *SelectedItemLT+$ OneWayToSource=� �� View �� .P��� $��Lần�� �� CellTemplate �� .R�� .+��� $��20 0 0 0q�$��Center=�
���   ����� *LIEUTRINH.LT_STT+�� $��Liệu trình�� �� .R�� .+��� $	��170��$��20 0 0 0q�$��Center=�$
��Wrap=�
���   ����� *LIEUTRINH.LT_MOTA+�� $��Ngày thứ�� �� .R�� .+��� $��20 0 0 0q�$��Center=�
���   ����� *LIEUTRINH.LT_NGAYTHU+�� $��Thực hiện�� �� .R�� .+��� $��18 0 0 0q�$��Center=�
���   ����� *LIEUTRINH.LT_THOIGIANTH+$ 	0#,##0 đ���� $��Giá liệu trình�� �� .R�� .+��� $��20 0 0 0q�$��Center=�
���   ����� *DONGIA+$ 	0#,##0 đ��