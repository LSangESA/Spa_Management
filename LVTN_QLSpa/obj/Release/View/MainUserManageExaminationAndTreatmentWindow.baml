   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:LVTN_QLSpa.ViewLVTN_QLSpa.View  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  A    ;LVTN_QLSpa.View.MainUserManageExaminationAndTreatmentWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:LVTN_QLSpa.View     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     �Name$  
mainWindow�� � Title$' !QUẢN LÝ KHÁM VÀ ĐIÊU TRỊ��$	��800��$
��1220�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=� � WindowState$ 	Maximized=� + 'MainUserManageExaminationAndTreatmentVM	 � DataContext#	 [ ��Z� .  (System.Windows.Interactivity.Interaction
   Triggers
 /  )System.Windows.Interactivity.EventTrigger     	EventName$ Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ 
mainWindow��.��#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�  PrimaryBackgroundColor#���  .���  � ColumnDefinitions �� $
��Auto ��� .+�  $ 15Q�  SecundaryBackgroundColor#���  $��15 15 10 15q�.��� -    �Name$ gridMenu��$��60������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0.298Q�� $ 	#FFDFEEFF��$ 1Q� � RowDefinitions �� $��60 ��� $��80 ��� $
��Auto ��� .+��� $��1�� �� Orientation$ 
Horizontal=�$	��Top=�.+�F�   logo#���  $��16 0 0 0q� �� Stretch$
 Fill=�  PrimaryBlueColor#���  $��25��$��25��$
��Left=��� $��LQS SPA��#���  $
��Bold"�$��20(�$��Center=�$
��Left=�$
��Left=�$��14 0 0 0q�d� -    d�Name$ btnMenu��$��Right=�$��0q�
������ $��Center=�  MenuIconStyle#��[ $��0 0 15 0q� � Triggers :�  :� RoutedEvent$ ToggleButton.Unchecked��.[��� .���� -    ��Name$ HideStackPanel��.��W�  �� 
TargetName$ gridMenu�� �� TargetProperty$ Width�  g� 	BeginTime$  0:0:0X�! W� From$	! 200X�	" W� To$" 60X�# g� Duration$# 0:0:0.3D�:� $ ToggleButton.Checked��.[��� .���� -   $ ShowStackPanel��.��W� $ gridMenu��$ Width�$  0:0:0X�$! 60X�$	" 200X�$# 0:0:0.3D��� $��3��.+�	� -   $ 	�Name$$ rdHome��% d� 	IsChecked$
% TrueY�$��Trang chủ��  MenuRadioButtonStyle#���    home
& � Tag#& �  	� -   $$ rdHistoryExamination��$��Hồ sơ bệnh án��#���   	 file#& � 	 $��0 5 0 5q�	� -   $$ 
rdMedicine��$��Danh mục thuốc��#���   
 medicine#& � 
 $��0 5 0 5q��� $��3��$��Bottom=�$ 
Horizontal=�$	��200��$��0 0 0 20q�.+�A� -	   $��	txtNV_TEN��$��40��$��40��$��10 0 0 0q�
   $ 	MouseDown��.    �� *CommandDoubleClickNhanVien+ �� $ 	txtNV_TEN������ ' �� ImageSource' �� *NV_ANH+�� $ Vertical=�$��8 0 0 0q�.+��� 
���   �$��14(�$��SemiBold"�$��Center=�$
��Left=����� *NV_TEN+�� 
���   �$��11(�$��Regular"�$��Center=�$
��Left=�$��	0 -10 0 0q����� *NV_MA+� $��1�� �� $��40 ��� .+��� $��0��
�������.+�,   &LVTN_QLSpa.UserControlSpa.UseControlUC  & �� *Title+$ 
mainWindow���� $��1��._�� -
   $ GridMain��