   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:LVTN_QLSpa.ViewLVTN_QLSpa.View  5   	   E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  5   	   A    ;LVTN_QLSpa.View.MainUserManageExaminationAndTreatmentWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:LVTN_QLSpa.View     5   	   6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  
mainWindow��5   	    � Title$' !QUẢN LÝ KHÁM VÀ ĐIÊU TRỊ��5   	   $	��800��5
   	   $
��1220��6    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .    MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	    � WindowState$ 	Maximized=�6.    + 'MainUserManageExaminationAndTreatmentVM	 � DataContext#	 [ 5   	   ��5   	   Z� .  (System.Windows.Interactivity.Interaction
   Triggers
 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5       6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
LoadWindow+   CommandParameter 5!   $   ��  �� ElementName$ 
mainWindow��5"      .��5%      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�6     PrimaryBackgroundColor#���  63   .��5&   
   �  � ColumnDefinitions 5'      �� 5(      $
��Auto �6#   �� 5)      .+�5,        $ 15Q�6"     SecundaryBackgroundColor#���  6;   $��15 15 10 15q�6s   .��5-      � -   5         �Name$ gridMenu��5-      $��60��6)   ��5.      �� 5/       �� EndPoint$ 0.5,1&�6.    �� 
StartPoint$ 0.5,0&�6?   .��50      �  � Color$ Black��6+    � Offset$ 0.298Q�69   � 51      $ 	#FFDFEEFF��6+   $ 1Q�6=   52       � RowDefinitions 54      �� 55      $��60 �6(   �� 56      $��80 �6(   �� 57      $
��Auto �6(   �� 58      .+�5<      �� $��1��6!    �� Orientation$ 
Horizontal=�6.   $	��Top=�6G   .+�5=      F�   logo#���  6   $��16 0 0 0q�6=    �� Stretch$
 Fill=�6O     PrimaryBlueColor#���  6^   $��25��6�   $��25��6�   $
��Left=�6�   �� 5>      $��LQS SPA��6    #���  62   $
��Bold"�6b   $��20(�6t   $��Center=�6�   $
��Left=�6�   $
��Left=�6�   $��14 0 0 0q�6�   5?      d� 5B      -   5         d�Name$ btnMenu��5B   #   $��Right=�64   $��0q�6P   
������ $��Center=�6}     MenuIconStyle#��[ 6�   $��0 0 15 0q�6�    � Triggers 5C      :� 5D       :� RoutedEvent$ ToggleButton.Unchecked��6+   .[�5E   "   �� .��5F   &   �� -   5         ��Name$ HideStackPanel��5F   1   .��5G   *   W�  �� 
TargetName$ gridMenu��6:    �� TargetProperty$ Width�6[     g� 	BeginTime$  0:0:0X�6}   ! W� From$	! 200X�6�   	" W� To$" 60X�6�   # g� Duration$# 0:0:0.3D�6�   5H   +   5I   '   5J   #   5K      :� 5L      $ ToggleButton.Checked��6+   .[�5M   "   �� .��5N   &   �� -   5        $ ShowStackPanel��5N   1   .��5O   *   W� $ gridMenu��6:   $ Width�6[   $  0:0:0X�6}   $! 60X�6�   $	" 200X�6�   $# 0:0:0.3D�6�   5P   +   5Q   '   5R   #   5S      5U      �� 5W      $��3��6!   .+�5X      	� -   5        $ 	�Name$$ rdHome��5X   &   % d� 	IsChecked$
% TrueY�66   $��Trang chủ��6G     MenuRadioButtonStyle#���  6[     home
& � Tag#& �  6�   6�   	� 5Y      -   5        $$ rdHistoryExamination��5Y   &   $��Hồ sơ bệnh án��6D   #���  6\    	 file#& � 	 6�   $��0 5 0 5q�6�   6�   	� 5Z      -   5        $$ 
rdMedicine��5Z   &   $��Danh mục thuốc��6:   #���  6S    
 medicine#& � 
 6�   $��0 5 0 5q�6�   6�   5[      �� 5]      $��3��6!   $��Bottom=�6.   $ 
Horizontal=�6I   $	��200��6b   $��0 0 0 20q�6n   .+�5^      A� -	   5        $��	txtNV_TEN��5^   K   $��40��6"   $��40��6-   $��10 0 0 0q�69   
 5_        5`   "   $ 	MouseDown��61   . 5a   &      6<   �� *CommandDoubleClickNhanVien+ 5b   8   �� $ 	txtNV_TEN��5c   #   ��5e      �� 5f   "   ' �� ImageSource' 6-   �� *NV_ANH+5h      �� 5i      $ Vertical=�6%   $��8 0 0 0q�6<   .+�5j      �� 
���   �$��14(�6R   $��SemiBold"�6`   $��Center=�6v   $
��Left=�6�   ��6$   �� *NV_TEN+6�   �� 5k      
���   �$��11(�6Q   $��Regular"�6_   $��Center=�6t   $
��Left=�6�   $��	0 -10 0 0q�6�   ��6$   �� *NV_MA+6�   5l      5m      5n      5o      � 5s      $��1��6    5t      �� 5u      $��40 �6$   �� 5v      .+�5z      �� $��0��6   
�������.+�5{      ,   &LVTN_QLSpa.UserControlSpa.UseControlUC  & 6&   �� *Title+$ 
mainWindow��6V   5|      �� 5      $��1��6   ._�5�      � -
   5        $ GridMain��5�      5�      5�      5�      5�      5�      