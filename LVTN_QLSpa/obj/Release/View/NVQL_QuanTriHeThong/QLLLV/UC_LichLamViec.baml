   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV)LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV  >    8LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV.UC_LichLamViec   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Ilocal7clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wLichLamViec��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    LichLamViecVM � DataContext# [ .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wLichLamViec��.��#  MaterialDesignThemes.Wpf.Card  	   UniformCornerRadius$	 10Q�$��10q�$	��740��.��� 
 � RowDefinitions
 �� $
��auto ��� $
��auto �.+�� $��0��$y�Hidden=�� $��1��
 �� $
��auto ��� .+�� $��0��$��10 20 10 20q� � ColumnDefinitions �� �� �� �� $
��auto �.+���  �� Orientation$ 
Horizontal=�$��0��.+���    MaterialDesignOutlinedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��35��$	��195��$��20 0 0 0q�$
��Left=�$	��Top=�
�������$��1q�
���   �
���   ����� *CommandAddLichLamViec+.���� $ 
Horizontal=�$��0 0 10 0q�$��Right=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ CalendarPlus=�$��0 0 10 0q�$��25��$��25���� $��Xếp lịch làm việc��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��35��$	��140��$��20 0 0 0q�$
��Left=�$	��Top=�
�������$��1q�
���   �
���   ����� *CommandInLichLamViec+.���� $ 
Horizontal=�$��0 0 10 0q�$��Right=�.+�  $ Printer=�$��0 0 10 0q�$��25��$��25���� $��	In lịch��$��0 5 0 0q��� $ 
Horizontal=�$��Center=�$��1��.+��� $��25(�$
��Bold"����� *LLV_NGAYDAUTUAN+ �� StringFormat$ 
dd/MM/yyyy���� $	�� - ��$��25(�$
��Bold"��� $��25(�$
��Bold"����� *LLV_NGAYCUOITUAN+$ 
dd/MM/yyyy���� $ 
Horizontal=�$��2��$��Right=�$	��Top=�.+��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��Hôm nay��$	��120��$��0 0 20 0q�
�������$��1q�
���   �
���   ����� *CommandToDay+�� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��70��
�������$��1q�
���   �
���   ����� *CommandBack+.��  $ MenuLeft=�$��20��$��20���� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��70��$��0 0 20 0q�
�������$��1q�
���   �
���   ����� *CommandNext+.��  $ 	MenuRight=�$��20��$��20��'  !MaterialDesignThemes.Wpf.PopupBox  $��Center=�   	StaysOpen . $��3��   PopupContent. �� $	��300��.+��� $��Lọc dữ liệu��$��15(�$��
20 10 5 10q�$
��Left=��� )	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ Phòng�� & "MaterialDesignFloatingHintComboBox#��[  �� DisplayMemberPath$
 P_SO��$	��250��$��5q����� *PHONG+ �� SelectedItem �� *SelectedPHONG+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $ Vai trò��#��[ $ VT_TEN��$��5q�$	��250������ *VAITRO+ �� *SelectedVAITRO+$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�$��5 10 5 0q�.+���   MaterialDesignRaisedButton#��[ $/ )Resource name: MaterialDesignRaisedButton��+
  %MaterialDesignThemes.Wpf.ButtonAssist 
  CornerRadius$ 5��$��10 10 10 20q�$��35��$��0q�$	��130��$��Bottom=�$��0q�
��� � ����� *
CommnadLoc+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ Filter=�$��0 0 10 0q�$��25��$��25���� $��Lọc��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$ 5��$��10 10 10 20q�$��35��$	��130��$��2��$��Bottom=�$��0q����	#FFCA3C2A���� *CommandXoaLoc+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ FilterVariantRemove=�$��0 0 5 0q�$��25��$��25���� $��
Xóa lọc��$��0 5 0 0q��� $��1��.���� $	��665������ *
calendar+ �� *SelectedItemPDK+$ OneWayToSource=�����  �� 
TargetType" �� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  �� Property � �� �� Value
 �������  � ��
 ����� �� View �� .P��� .���� $	��130��.���� .+��� $��Thứ 2��$��Center=�$
��Bold"��� $
��Bold"�$��Center=����� *thu2+$ 
dd/MM/yyyy������ *	ColorT2+ �� CellTemplate �� .R��� 
���   �$��	0 0 0.1 0q�._�	�  & "MaterialDesignToolForegroundButton#��[ $��0q�$��50��$��0 0 10 0q�  	� 	GroupName$
  name��$��Bottom=�$��0q�! d� 	IsChecked! �� *
T2_Checked+   $ Checked��.    �� " �� RelativeSource" �� *FindAncestor+# �� AncestorType"# ��$ �� Path$$$ DataContext.CommandShowInfoLLV� �� .���� $ 
Horizontal=�$	��200��.+�A� $��40��$��40��$��5 0 0 0q�$��Center=����� % �� ImageSource% �� *	T2_NV_ANH+�� $��Center=�$
��Left=�.+��� $
��Left=�
���   �$��5 0 5 0q����� *	T2_NV_TEN+�� $
��Left=�
���   �$��5 0 0 0q����� *
T2_P_TEN+�� $
��Left=�
���   �$��5 0 0 0q����� *	T2_VT_TEN+�� .���� $	��130��.���� .+��� $��Thứ 3��$��Center=�$
��Bold"��� $��Center=����� *thu3+$ 
dd/MM/yyyy������ *	ColorT3+ �� .R��� 
���   �$��	0 0 0.1 0q�._�	� #��[ $��0q�$��50��$
  name��$��0 0 10 0q�$��Bottom=�$��0q�! �� *
T3_Checked+   $ Checked��.    �� " �� *FindAncestor+"# ��$$$ DataContext.CommandShowInfoLLV� �� .���� $ 
Horizontal=�$	��200��.+�A� $��40��$��40��$��5 0 0 0q����� % �� *	T3_NV_ANH+�� $��Center=�$
��Left=�.+��� $
��Left=�
���   �$��5 0 5 0q����� *	T3_NV_TEN+�� $
��Left=�
���   �$��5 0 0 0q����� *
T3_P_TEN+�� $
��Left=�
���   �$��5 0 0 0q����� *	T3_VT_TEN+�� .���� $	��130��.���� .+��� $��Thứ 4��$��Center=�$
��Bold"��� $��Center=����� *thu4+$ 
dd/MM/yyyy������ *	ColorT4+ �� .R��� 
���   �$��	0 0 0.1 0q�._�	� #��[ $��0q�$��50��$��0 0 10 0q�$
  name��$��Bottom=�$��0q�! �� *
T4_Checked+   $ Checked��.    �� " �� *FindAncestor+"# ��$$$ DataContext.CommandShowInfoLLV� �� .���� $ 
Horizontal=�$	��200��.+�A� $��40��$��40��$��5 0 0 0q����� % �� *	T4_NV_ANH+�� $��Center=�$
��Left=�.+��� $
��Left=�
���   �$��5 0 5 0q����� *	T4_NV_TEN+�� $
��Left=�
���   �$��5 0 0 0q����� *
T4_P_TEN+�� $
��Left=�
���   �$��5 0 0 0q����� *	T4_VT_TEN+�� .���� $	��130��.���� .+��� $��Thứ 5��$��Center=�$
��Bold"��� $��Center=����� *thu5+$ 
dd/MM/yyyy������ *	ColorT5+ �� .R��� 
���   �$��	0 0 0.1 0q�._�	� #��[ $��0q�$��50��$��0 0 10 0q�$
  name��$��Bottom=�$��0q�! �� *
T5_Checked+   $ Checked��.    �� " �� *FindAncestor+"# ��$$$ DataContext.CommandShowInfoLLV� �� .���� $ 
Horizontal=�$	��200��.+�A� $��40��$��40��$��5 0 0 0q����� % �� *	T5_NV_ANH+�� $��Center=�$
��Left=�.+��� $
��Left=�
���   �$��5 0 5 0q����� *	T5_NV_TEN+�� $
��Left=�
���   �$��5 0 0 0q����� *
T5_P_TEN+�� $
��Left=�
���   �$��5 0 0 0q����� *	T5_VT_TEN+�� .���� $	��130��.���� .+��� $��Thứ 6��$��Center=�$
��Bold"��� $��Center=����� *thu6+$ 
dd/MM/yyyy������ *	ColorT6+ �� .R��� 
���   �$��	0 0 0.1 0q�._�	� #��[ $��0q�$��50��$��0 0 10 0q�$
  name��$��Bottom=�$��0q�! �� *
T6_Checked+   $ Checked��.    �� " �� *FindAncestor+"# ��$$$ DataContext.CommandShowInfoLLV� �� .���� $ 
Horizontal=�$	��200��.+�A� $��40��$��40��$��5 0 0 0q����� % �� *	T6_NV_ANH+�� $��Center=�$
��Left=�.+��� $
��Left=�
���   �$��5 0 5 0q����� *	T6_NV_TEN+�� $
��Left=�
���   �$��5 0 0 0q����� *
T6_P_TEN+�� $
��Left=�
���   �$��5 0 0 0q����� *	T6_VT_TEN+�� .���� $	��130��.���� .+��� $��Thứ 7��$��Center=�$
��Bold"��� $��Center=����� *thu7+$ 
dd/MM/yyyy������ *	ColorT7+ �� .R��� 
���   �$��	0 0 0.1 0q�._�	� #��[ $��0q�$��50��$��0 0 10 0q�$
  name��$��Bottom=�$��0q�! �� *
T7_Checked+   $ Checked��.    �� " �� *FindAncestor+"# ��$$$ DataContext.CommandShowInfoLLV� �� .���� $ 
Horizontal=�$	��200��.+�A� $��40��$��40��$��5 0 0 0q����� % �� *	T7_NV_ANH+�� $��Center=�$
��Left=�.+��� $
��Left=�
���   �$��5 0 5 0q����� *	T7_NV_TEN+�� $
��Left=�
���   �$��5 0 0 0q����� *
T7_P_TEN+�� $
��Left=�
���   �$��5 0 0 0q����� *	T7_VT_TEN+�� .���� $	��130��.���� .+��� $��Chủ nhật��$��Center=�$
��Bold"��� $��Center=����� *	chunhat+$ 
dd/MM/yyyy������ *	ColorCN+ �� .R�	� #��[ $��0q�$��50��$��0 0 10 0q�$
  name��$��Bottom=�$��0q�! �� *
CN_Checked+   $ Checked��.    �� " �� *FindAncestor+"# ��$$$ DataContext.CommandShowInfoLLV� �� .���� $ 
Horizontal=�$	��200��.+�A� $��40��$��40��$��5 0 0 0q����� % �� *	CN_NV_ANH+�� $��Center=�$
��Left=�.+��� $
��Left=�
���   �$��5 0 5 0q����� *	CN_NV_TEN+�� $
��Left=�
���   �$��5 0 0 0q����� *
CN_P_TEN+�� $
��Left=�
���   �$��5 0 0 0q����� *	CN_VT_TEN+& �� 
GroupStyle& (  "System.Windows.Controls.GroupStyle  '   ContainerStyle' �� " ��.���  � �� �� .R�9� ( 9� 
IsExpanded( . ���� $ 
Horizontal=�.+��� $
��Bold"�
�������$��18(�$��Bottom=����� *Name+.���� 