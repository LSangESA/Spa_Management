   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV)LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV  5      >    8LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV.UC_LichLamViec   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ilocal7clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5
      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $��wLichLamViec��5         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5        LichLamViecVM � DataContext# [ 5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
LoadWindow+   CommandParameter 5   $   ��  �� ElementName$ wLichLamViec��5      .��5      #  MaterialDesignThemes.Wpf.Card  	   UniformCornerRadius$	 10Q�6   $��10q�5      $	��740��5      .��5   
   � 
 � RowDefinitions
 5      �� 5       $
��auto �6    60   �� 5!      $
��auto �6    60   .+�5#      � $��0��6   $y�Hidden=�6    5%      � 5&      $��1��6   
 5'      �� 5(      $
��auto �6$   64   �� 5)      6&   .+�5,      � $��0��6   $��10 20 10 20q�6$    � ColumnDefinitions 5-      �� 5.      6-   �� 5/      6-   �� 50      6-   �� 51      $
��auto �6+   6:   .+�54      ��  �� Orientation$ 
Horizontal=�6!   $��0��6:   .+�55      ��    MaterialDesignOutlinedButton#��[ 6!    � ToolTip$/ )Resource name: MaterialDesignRaisedButton��56   !   $��35��57   !   $	��195��58   !   $��20 0 0 0q�59   !   $
��Left=�5;   !   $	��Top=�5<   !   
�������$��1q�5=   4   
���   �
���   ���5:   !   �� *CommandAddLichLamViec+.��5@      �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   $��Right=�6T   .+�5A   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ CalendarPlus=�6:   $��0 0 10 0q�6N   $��25��6`   $��25��6k   �� 5B   "   $��Xếp lịch làm việc��6,   $��0 5 0 0q�6E   6X   5C      5D      �� 5E      #��[ 6!   $/ )Resource name: MaterialDesignRaisedButton��5F   !   $��35��5G   !   $	��140��5H   !   $��20 0 0 0q�5I   !   $
��Left=�5K   !   $	��Top=�5L   !   
�������$��1q�5M   4   
���   �
���   ���5J   !   �� *CommandInLichLamViec+.��5P      �� $ 
Horizontal=�6)   $��0 0 10 0q�6B   $��Right=�6T   .+�5Q   "     $ Printer=�6:   $��0 0 10 0q�6I   $��25��6[   $��25��6f   �� 5R   "   $��	In lịch��6,   $��0 5 0 0q�6;   6N   5S      5T      5U      �� 5W      $ 
Horizontal=�6!   $��Center=�6:   $��1��6W   .+�5X      �� $��25(�5Y   $   $
��Bold"�5Z   $   ��5X   $   �� *LLV_NGAYDAUTUAN+ �� StringFormat$ 
dd/MM/yyyy��5Z   $   �� 5[      $	�� - ��6$   $��25(�5\   $   $
��Bold"�5]   $   �� 5^      $��25(�5_   $   $
��Bold"�5`   $   ��5^   $   �� *LLV_NGAYCUOITUAN+$ 
dd/MM/yyyy��5`   $   5a      �� 5c      $ 
Horizontal=�6!   $��2��6:   $��Right=�6J   $	��Top=�6f   .+�5d      �� #��[ 6!   $/ )Resource name: MaterialDesignRaisedButton��5e      $��Hôm nay��5g      $	��120��5h      $��0 0 20 0q�5i      
�������$��1q�5j   0   
���   �
���   ���5f      �� *CommandToDay+5m      �� 5n      #��[ 6!   $/ )Resource name: MaterialDesignRaisedButton��5o      $��70��5q      
�������$��1q�5r   0   
���   �
���   ���5p      �� *CommandBack+.��5u        $ MenuLeft=�66   $��20��6F   $��20��6Q   5v      �� 5w      #��[ 6!   $/ )Resource name: MaterialDesignRaisedButton��5x   !   $��70��5z   !   $��0 0 20 0q�5{   !   
�������$��1q�5|   4   
���   �
���   ���5y   !   �� *CommandNext+.��5        $ 	MenuRight=�66   $��20��6G   $��20��6R   5�      5�      '  !MaterialDesignThemes.Wpf.PopupBox  5�      $��Center=�6.      	StaysOpen . $��3��5�   .      PopupContent. 5�      �� $	��300��6%   .+�5�      �� $��Lọc dữ liệu��6(   $��15(�5�   $   $��
20 10 5 10q�5�   $   $
��Left=�5�   $   6A   �� 5�      )	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ Phòng��6'    & "MaterialDesignFloatingHintComboBox#��[ 5�   !    �� DisplayMemberPath$
 P_SO��5�   !   $	��250��5�   !   $��5q�5�   !   ��5�   !   �� *PHONG+ �� SelectedItem 5�   !   �� *SelectedPHONG+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5�      �� 5�      $ Vai trò��6'   #��[ 5�   '   $ VT_TEN��5�   '   $��5q�5�   '   $	��250��5�   '   ��5�   '   �� *VAITRO+ 5�   '   �� *SelectedVAITRO+$ TwoWay=�$ PropertyChanged=�5�      �� 5�      $ 
Horizontal=�6)   $��5 10 5 0q�6B   .+�5�   "   ��   MaterialDesignRaisedButton#��[ 6)   $/ )Resource name: MaterialDesignRaisedButton��5�   )   +
  %MaterialDesignThemes.Wpf.ButtonAssist 
  CornerRadius$ 5��5�   )   $��10 10 10 20q�5�   )   $��35��5�   )   $��0q�5�   )   $	��130��5�   )   $��Bottom=�5�   )   $��0q�6E   
��� � ���5�   )   �� *
CommnadLoc+.��5�   &   �� $ 
Horizontal=�61   $��0 0 10 0q�6J   .+�5�   *     $ Filter=�6B   $��0 0 10 0q�6P   $��25��6b   $��25��6m   �� 5�   *   $��Lọc��64   $��0 5 0 0q�6?   6R   5�   '   5�   #   �� 5�   "   #��[ 6)   $/ )Resource name: MaterialDesignRaisedButton��5�   )   $ 5��5�   )   $��10 10 10 20q�5�   )   $��35��5�   )   $	��130��5�   )   $��2��5�   )   $��Bottom=�5�   )   $��0q�6E   ���	#FFCA3C2A��5�   )   �� *CommandXoaLoc+.��5�   &   �� $ 
Horizontal=�61   $��0 0 10 0q�6J   .+�5�   *     $ FilterVariantRemove=�6B   $��0 0 5 0q�6]   $��25��6n   $��25��6y   �� 5�   *   $��
Xóa lọc��64   $��0 5 0 0q�6C   6V   5�   '   5�   #   5�      5�      5�      5�      �� 5�      $��1��6   .��5�      �� $	��665��6~   ��6   �� *
calendar+ 6@   �� *SelectedItemPDK+$ OneWayToSource=���5�      �� 5�       �� 
TargetType" ��6$    �� Triggers 5�   "   P� 5�   &    P� Property �@J�IsMouseOver P� Value . . �5�   *   ��  �� Property � �� �� Value
 �����6G   �� 5�   *    � ��
 �����6H   5�   '   5�       �� View 5�      �� 5�      .P�5�   "   �� .��5�   &   �� $	��130��6=   .��5�   *   �� .+�5�   .   �� $��Thứ 2��68   $��Center=�6E   $
��Bold"�6b   6v   �� 5�   .   $
��Bold"�6�   $��Center=�6�   ��68   �� *thu2+$ 
dd/MM/yyyy����6i   �� *	ColorT2+6�   5�   +   5�   '    �� CellTemplate 5�   &   �� 5�   *   .R�5�   .   �� 
���   �$��	0 0 0.1 0q�6I   ._�5�   2   	�  & "MaterialDesignToolForegroundButton#��[ 6>   $��0q�5�   6   $��50��5�   6   $��0 0 10 0q�5�   6     	� 	GroupName$
  name��5�   6   $��Bottom=�5�   6   $��0q�6Q   ! d� 	IsChecked! 5�   6   �� *
T2_Checked+ 5�   6     5�   :   $ Checked��6I   . 5�   >      6T   �� " �� RelativeSource" �� *FindAncestor+# �� AncestorType"# ��$ �� Path$$$ DataContext.CommandShowInfoLLV� 5�   <   �� 5�   ;   .��5�   6   �� $ 
Horizontal=�6A   $	��200��6Z   .+�5�   :   A� $��40��6B   $��40��6M   $��5 0 0 0q�6Y   $��Center=�6j   ��5�   >   �� 5�   B   % �� ImageSource% 6M   �� *	T2_NV_ANH+5�   ;   �� 5�   :   $��Center=�6E   $
��Left=�6`   .+�5�   >   �� $
��Left=�5�   @   
���   �$��5 0 5 0q�5�   @   ��5�   H   �� *	T2_NV_TEN+5�   S   �� 5�   >   $
��Left=�5�   @   
���   �$��5 0 0 0q�5�   @   ��5�   H   �� *
T2_P_TEN+5�   S   �� 5�   >   $
��Left=�5�   @   
���   �$��5 0 0 0q�5�   @   ��5�   H   �� *	T2_VT_TEN+5�   S   5�   ;   5�   7   5�   3   5�   /   5�   +   5�   #   �� 5�   "   .��5�   &   �� $	��130��6=   .��5�   *   �� .+�5�   .   �� $��Thứ 3��68   $��Center=�6F   $
��Bold"�6c   6w   �� 5   .   $��Center=�6�   ��68   �� *thu3+$ 
dd/MM/yyyy����6i   �� *	ColorT3+6�   5  +   5  '    5  &   �� 5  *   .R�5  .   �� 
���   �$��	0 0 0.1 0q�6I   ._�5  2   	� #��[ 6>   $��0q�5  6   $��50��5  6   $
  name��5	  6   $��0 0 10 0q�5  6   $��Bottom=�5  6   $��0q�6R   ! 5
  6   �� *
T3_Checked+ 5  6     5  :   $ Checked��6I   . 5  >      6T   �� " �� *FindAncestor+"# ��$$$ DataContext.CommandShowInfoLLV� 5  <   �� 5  ;   .��5  6   �� $ 
Horizontal=�6A   $	��200��6Z   .+�5  :   A� $��40��6B   $��40��6M   $��5 0 0 0q�6Y   ��5  >   �� 5  B   % 6M   �� *	T3_NV_ANH+5  ;   �� 5  :   $��Center=�6E   $
��Left=�6`   .+�5  >   �� $
��Left=�5  @   
���   �$��5 0 5 0q�5  @   ��5  H   �� *	T3_NV_TEN+5  S   �� 5  >   $
��Left=�5  @   
���   �$��5 0 0 0q�5!  @   ��5  H   �� *
T3_P_TEN+5!  S   �� 5"  >   $
��Left=�5#  @   
���   �$��5 0 0 0q�5%  @   ��5"  H   �� *	T3_VT_TEN+5%  S   5&  ;   5'  7   5(  3   5)  /   5*  +   5,  #   �� 5-  "   .��5.  &   �� $	��130��6=   .��5/  *   �� .+�50  .   �� $��Thứ 4��68   $��Center=�6E   $
��Bold"�6b   6v   �� 51  .   $��Center=�6�   ��68   �� *thu4+$ 
dd/MM/yyyy����6i   �� *	ColorT4+6�   52  +   53  '    54  &   �� 55  *   .R�56  .   �� 
���   �$��	0 0 0.1 0q�6I   ._�57  2   	� #��[ 6>   $��0q�58  6   $��50��59  6   $��0 0 10 0q�5;  6   $
  name��5<  6   $��Bottom=�5=  6   $��0q�6Q   ! 5:  6   �� *
T4_Checked+ 5>  6     5?  :   $ Checked��6I   . 5@  >      6T   �� " �� *FindAncestor+"# ��$$$ DataContext.CommandShowInfoLLV� 5A  L   �� 5B  ;   .��5D  6   �� $ 
Horizontal=�6A   $	��200��6Z   .+�5E  :   A� $��40��6B   $��40��6M   $��5 0 0 0q�6Y   ��5F  >   �� 5G  B   % 6M   �� *	T4_NV_ANH+5I  ;   �� 5J  :   $��Center=�6E   $
��Left=�6`   .+�5K  >   �� $
��Left=�5L  @   
���   �$��5 0 5 0q�5N  @   ��5K  H   �� *	T4_NV_TEN+5N  S   �� 5O  >   $
��Left=�5P  @   
���   �$��5 0 0 0q�5R  @   ��5O  H   �� *
T4_P_TEN+5R  S   �� 5S  >   $
��Left=�5T  @   
���   �$��5 0 0 0q�5V  @   ��5S  H   �� *	T4_VT_TEN+5V  S   5W  ;   5X  7   5Y  3   5Z  /   5[  +   5]  #   �� 5^  "   .��5_  &   �� $	��130��6=   .��5`  *   �� .+�5a  .   �� $��Thứ 5��68   $��Center=�6F   $
��Bold"�6c   6w   �� 5b  .   $��Center=�6�   ��68   �� *thu5+$ 
dd/MM/yyyy����6i   �� *	ColorT5+6�   5c  +   5d  '    5e  &   �� 5f  *   .R�5g  .   �� 
���   �$��	0 0 0.1 0q�6I   ._�5h  2   	� #��[ 6>   $��0q�5i  6   $��50��5j  6   $��0 0 10 0q�5l  6   $
  name��5m  6   $��Bottom=�5n  6   $��0q�6Q   ! 5k  6   �� *
T5_Checked+ 5o  6     5p  :   $ Checked��6I   . 5q  >      6T   �� " �� *FindAncestor+"# ��$$$ DataContext.CommandShowInfoLLV� 5r  L   �� 5s  ;   .��5u  6   �� $ 
Horizontal=�6A   $	��200��6Z   .+�5v  :   A� $��40��6B   $��40��6M   $��5 0 0 0q�6Y   ��5w  >   �� 5x  B   % 6M   �� *	T5_NV_ANH+5z  ;   �� 5{  :   $��Center=�6E   $
��Left=�6`   .+�5|  >   �� $
��Left=�5}  @   
���   �$��5 0 5 0q�5  @   ��5|  H   �� *	T5_NV_TEN+5  S   �� 5�  >   $
��Left=�5�  @   
���   �$��5 0 0 0q�5�  @   ��5�  H   �� *
T5_P_TEN+5�  S   �� 5�  >   $
��Left=�5�  @   
���   �$��5 0 0 0q�5�  @   ��5�  H   �� *	T5_VT_TEN+5�  S   5�  ;   5�  7   5�  3   5�  /   5�  +   5�  #   �� 5�  "   .��5�  &   �� $	��130��6=   .��5�  *   �� .+�5�  .   �� $��Thứ 6��68   $��Center=�6F   $
��Bold"�6c   6w   �� 5�  .   $��Center=�6�   ��68   �� *thu6+$ 
dd/MM/yyyy����6i   �� *	ColorT6+6�   5�  +   5�  '    5�  &   �� 5�  *   .R�5�  .   �� 
���   �$��	0 0 0.1 0q�6I   ._�5�  2   	� #��[ 6>   $��0q�5�  6   $��50��5�  6   $��0 0 10 0q�5�  6   $
  name��5�  6   $��Bottom=�5�  6   $��0q�6Q   ! 5�  6   �� *
T6_Checked+ 5�  6     5�  :   $ Checked��6I   . 5�  >      6T   �� " �� *FindAncestor+"# ��$$$ DataContext.CommandShowInfoLLV� 5�  L   �� 5�  ;   .��5�  6   �� $ 
Horizontal=�6A   $	��200��6Z   .+�5�  :   A� $��40��6B   $��40��6M   $��5 0 0 0q�6Y   ��5�  >   �� 5�  B   % 6M   �� *	T6_NV_ANH+5�  ;   �� 5�  :   $��Center=�6E   $
��Left=�6`   .+�5�  >   �� $
��Left=�5�  @   
���   �$��5 0 5 0q�5�  @   ��5�  H   �� *	T6_NV_TEN+5�  S   �� 5�  >   $
��Left=�5�  @   
���   �$��5 0 0 0q�5�  @   ��5�  H   �� *
T6_P_TEN+5�  S   �� 5�  >   $
��Left=�5�  @   
���   �$��5 0 0 0q�5�  @   ��5�  H   �� *	T6_VT_TEN+5�  S   5�  ;   5�  7   5�  3   5�  /   5�  +   5�  #   �� 5�  "   .��5�  &   �� $	��130��6=   .��5�  *   �� .+�5�  .   �� $��Thứ 7��68   $��Center=�6F   $
��Bold"�6c   6w   �� 5�  .   $��Center=�6�   ��68   �� *thu7+$ 
dd/MM/yyyy����6i   �� *	ColorT7+6�   5�  +   5�  '    5�  &   �� 5�  *   .R�5�  .   �� 
���   �$��	0 0 0.1 0q�6I   ._�5�  2   	� #��[ 6>   $��0q�5�  6   $��50��5�  6   $��0 0 10 0q�5�  6   $
  name��5�  6   $��Bottom=�5�  6   $��0q�6Q   ! 5�  6   �� *
T7_Checked+ 5�  6     5�  :   $ Checked��6I   . 5�  >      6T   �� " �� *FindAncestor+"# ��$$$ DataContext.CommandShowInfoLLV� 5�  L   �� 5�  ;   .��5�  6   �� $ 
Horizontal=�6A   $	��200��6Z   .+�5�  :   A� $��40��6B   $��40��6M   $��5 0 0 0q�6Y   ��5�  >   �� 5�  B   % 6M   �� *	T7_NV_ANH+5�  ;   �� 5�  :   $��Center=�6E   $
��Left=�6`   .+�5�  >   �� $
��Left=�5�  @   
���   �$��5 0 5 0q�5�  @   ��5�  H   �� *	T7_NV_TEN+5�  S   �� 5�  >   $
��Left=�5�  @   
���   �$��5 0 0 0q�5�  @   ��5�  H   �� *
T7_P_TEN+5�  S   �� 5�  >   $
��Left=�5�  @   
���   �$��5 0 0 0q�5�  @   ��5�  H   �� *	T7_VT_TEN+5�  S   5�  ;   5�  7   5�  3   5�  /   5�  +   5�  #   �� 5�  "   .��5�  &   �� $	��130��6=   .��5�  *   �� .+�5�  .   �� $��Chủ nhật��68   $��Center=�6I   $
��Bold"�6f   6z   �� 5�  .   $��Center=�6�   ��68   �� *	chunhat+$ 
dd/MM/yyyy����6l   �� *	ColorCN+6�   5�  +   5�  '    5�  &   �� 5�  *   .R�5�  .   	� #��[ 6:   $��0q�5�  6   $��50��5�  6   $��0 0 10 0q�5�  6   $
  name��5�  6   $��Bottom=�5   6   $��0q�6Q   ! 5�  6   �� *
CN_Checked+ 5  2     5  6   $ Checked��6E   . 5  :      6P   �� " �� *FindAncestor+"# ��$$$ DataContext.CommandShowInfoLLV� 5  L   �� 5  7   .��5  2   �� $ 
Horizontal=�6=   $	��200��6V   .+�5  6   A� $��40��6>   $��40��6I   $��5 0 0 0q�6U   ��5	  :   �� 5
  >   % 6I   �� *	CN_NV_ANH+5  7   �� 5  6   $��Center=�6A   $
��Left=�6\   .+�5  :   �� $
��Left=�5  @   
���   �$��5 0 5 0q�5  @   ��5  D   �� *	CN_NV_TEN+5  S   �� 5  :   $
��Left=�5  @   
���   �$��5 0 0 0q�5  @   ��5  D   �� *
CN_P_TEN+5  S   �� 5  :   $
��Left=�5  @   
���   �$��5 0 0 0q�5  @   ��5  D   �� *	CN_VT_TEN+5  S   5  7   5  3   5  /   5  +   5  #   5      & �� 
GroupStyle& 5"     (  "System.Windows.Controls.GroupStyle  5#     '   ContainerStyle' 5$  "   �� 5%  &   " ��6,   .�5&  *   ��  � �� 5'  .   �� 5(  2   .R�5)  6   9� ( 9� 
IsExpanded( . ��5*  :   �� 5+  >   $ 
Horizontal=�6I   .+�5,  B   �� $
��Bold"�6b   
�������$��18(�6�   $��Bottom=�6�   ��6L   �� *Name+6�   5-  ?   .��5/  :   �� 50  7   51  3   53  +   54  '   56     58     59     5:     5;     5<     5=     