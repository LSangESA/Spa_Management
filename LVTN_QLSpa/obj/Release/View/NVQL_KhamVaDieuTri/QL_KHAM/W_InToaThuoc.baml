   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM*LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  =    7LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM.W_InToaThuoc   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Jlocal8clr-namespace:LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��	wToaThuoc��  � Title$  W_InToaThuoc��$	��800��$	��600�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    InToaThuocVM � DataContext# [ ��Z� .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger  	   	EventName$	 Loaded��.  (System.Windows.Interactivity.TriggerBase
   Actions.
 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ 	wToaThuoc��.��� .+��� 
���   �$��2q� �� CornerRadius$ 15 15 15 15��._�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�.��� 
������� � RowDefinitions �� �� $
��auto �.+��� $��1�� �� Orientation$ 
Horizontal=�$��Right=�.+��� -      MaterialDesignOutlinedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��0q�$��40��$��Center=�
�������$��2q�
��� � �$	��150��
��� � �.���� $ 
Horizontal=�$��0 0 10 0q�$��Right=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Printer=�$��0 0 10 0q�$��25��$��25���� $��In��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�
�������$��2q�
���  ��$��40��$	��150��
���  ������ *CommandThoat+���� $ 	wToaThuoc��.���� $ 
Horizontal=�$��0 0 10 0q�$��Right=�.+�  $ CloseBox=�$��0 0 10 0q�$��25��$��25���� $��Thoát��$��0 5 0 0q�� -   $��print��$��0�� �� $
��auto ��� .+�� $��0��.+��� $��TOA THUỐC��$��Center=�$��40(�$��10q�$��0��� $��1�� �� $
��auto ��� $
��auto �.+�� $��0��.+��  � ColumnDefinitions �� $
��auto ��� .+�� $��0�� �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��Số phiếu DT: ��$
��Bold"�$��0��$��15(�$��25 5 0 5q��� $��Liệu trình: ��$
��Bold"�$��1��$��15(�$��25 5 0 5q��� $��Dịch vụ: ��$
��Bold"�$��3��$��15(�$��25 5 0 5q��� $��Ông, bà: ��$
��Bold"�$��4��$��15(�$��25 5 0 5q��� $��Chuẩn đoán: ��$
��Bold"�$��5��$��15(�$��25 5 0 5q��� $��Lời dặn: ��$
��Bold"�$��6��$��15(�$��25 5 0 5q��� $��Ngày khám: ��$
��Bold"�$��7��$��15(�$��25 5 0 5q�� $��1�� �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� .+��� $
��Bold"�$��0��$��15(�$��25 5 0 5q����� *	PDT_STT+ �� UpdateSourceTrigger$ PropertyChanged=��� $
��Bold"�$��1��$��15(�$��25 5 0 5q����� *	LT_MOTA+$ PropertyChanged=��� $
��Bold"�$��2��$��15(�$��25 5 0 5q����� *	GDV_TEN+$ PropertyChanged=��� $
��Bold"�$��3��$��15(�$��25 5 0 5q����� *
KH_HOTEN+$ PropertyChanged=��� $
��Bold"�$��4��$��15(�$��25 5 0 5q����� *PDT_CHUANDOAN+$ PropertyChanged=��� $
��Bold"�$��5��$��15(�$��25 5 0 5q����� *
PDT_LOIDAN+$ PropertyChanged=��� $
��Bold"�$��6��$��15(�$��25 5 0 5q����� *NGAY+$ PropertyChanged=� �� StringFormat$ 
dd/MM/yyyy��� $��1��$��0 10 0 0q�.+��� $��1��$��0 10 0 0q�
������ 
������ {�.  ���� *CHIDINHList+ �� SelectedItem �� *SelectedItemCHIDINH+ �� Mode$ OneWayToSource=����� .R��  �� $
��1.6* ��� .+�� $��0��.+��� $
��Left=�.+��� $
��Left=�$ 
Horizontal=�.+���  �� TextAlignment$ Center=�$
��Wrap=�$��15(�$��25,0,0,0q�$��Center=�$��Sitka Subheading)�$
��Bold"�$��Italic$�
���   ����� *T_STT+�� $��Sitka Subheading)�$��Center=�$��17(�$
��Bold"�$��Italic$�
���   ����� *T_TEN+$ TwoWay=�$ PropertyChanged=��� $��Sitka Subheading)�$��Center=�$��17(�$
��Bold"�$��Italic$�
���   ����� *	DVT_TEN+$ TwoWay=�$ PropertyChanged=��� $
��Left=�$ 
Horizontal=�.+��� $��Sitka Subheading)�$��Center=�$��15(�$��25,0,0,0q�$
��Bold"�
���   ����� *CD_LIEUDUNG+$ TwoWay=�$ PropertyChanged=��� $��Sitka Subheading)�$��Center=�$��15(�$
��Bold"�
���   ����� *CD_CACHDUNG+$ TwoWay=�$ PropertyChanged=�� $��1��.+��� $ 
Horizontal=�.+��� $��Số lượng: ��$��Sitka Subheading)�$��Center=�$��15(�$
��Bold"�
���   ��� $��Sitka Subheading)�$��Center=�$��15(�$
��Bold"�
���   ����� *
CD_SOLUONG+$ TwoWay=�$ PropertyChanged=�