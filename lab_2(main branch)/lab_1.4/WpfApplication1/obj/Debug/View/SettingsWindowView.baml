   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5   	   J FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WpfApplication1.PropertiesWpfApplication1.Properties 5   	   7 clr-namespace:TestApp.ConvertersTestApp.Converters 5   	   %   TestApp.View.SettingsWindowView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   \iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Bcmd2http://schemas.devexpress.com/winfx/2008/xaml/mvvm     5   	   6p(clr-namespace:WpfApplication1.Properties     5   	   8databinding clr-namespace:TestApp.Converters     5   	   -   5          �Name$  SettingsWindow��5   	    � Title$ Settings��5	   	   $��224.777��6   $��383.105��6+    � 
ResizeMode$ NoResize=�5   	    � AllowsTransparency . 
������  � WindowStyle$
 None=�5   	    � 	Resources 5      &   TestApp.Converters.LangConverter   LangConverter  GreenGradientBrush �� 
StartPoint �� EndPoint � Color	 � Offset
 �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%�  &	        &	      '�� �     7  '�� �       5   
   6<   �� 5   
   $	 0,0&�69   $	 1,1&�6J   .��5      � $ ForestGreen��6   $	 0Q�6/   � 5      $ 
LightGreen��6   $	 1Q�6.   5      �� 5   
   "
 ��6   .�5      ��  � ��8   5      5      �� 5   
   "
 ��6   .�5      ��  � ��
 ����6+    5       P� 5!       �@��
IsSelected .  . �5"      ��  �@J�Opacity$	 0.5Q�60   �� 5#       � ��
 �  ��63   �� 5$       � ��
 ����63   5%      P� 5&       �@��
IsSelected . . �5'      ��  � ��
 � � �63   �� 5(       � ��
 ����63   5)      5+      5,      .��5-      � .+�5.   
   �� $
��auto��6   $
��auto��6   
��� � �$��2q�6@    �� CornerRadius$ 30,30,30,30��5/      $��
34,10,34,0q�6,    J� Opacity$	 0.9Q�50      ��51      �� 52      $ 0.5,1&�6&   $ 0.5,0&�67   .��53      � $ ForestGreen��6#   $	 0Q�67   � 54      $ 
LightGreen��6#   $	 1Q�66   55      57      �� 58   
   $��Center=�6   $��15(�61   $
��Bold"�6@   ���#555$	��Top=�59      *  $WpfApplication1.Properties.Resources   SettingsButton#��Z 5:      $��125,19,129,0q�6A   .   (System.Windows.Interactivity.Interaction   Triggers 5;      /   )System.Windows.Interactivity.EventTrigger  5<         	EventName$ MouseLeftButtonDown��6   .   (System.Windows.Interactivity.TriggerBase   Actions. 5=      6   0System.Windows.Interactivity.InvokeCommandAction     Command 6(   �� *DragMoveCommand+   CommandParameter 5>   (   ��  �� ElementName$ SettingsWindow��5?      5A      �� 5C   
   -   5         ��Name$ CloseButton��5C      $��Center=�6&   $��25��5D      $	��Top=�5E      $��35��5F      $��0q�5G      $��0q�5H       � Cursor$
 Hand��6   $��302,24,46,0q�5J   I    K� ZIndex$ 1��5K      ��5I      �� *CloseWindowCommand+��5J      �� $ SettingsWindow�� 5M        5N      $ 
MouseEnter��6!   . 5O         6,   ��  �� RelativeSource ��  �� AncestorType$ WindowL� �� Mode$ FindAncestor=� �� Path$) #DataContext.CloseButtonEnterCommand� 5P   ,   �� $ CloseButton��5Q        5R      $ 
MouseLeave��6!   . 5S         6,   ��  �� $ WindowL�$ FindAncestor=�$) #DataContext.CloseButtonLeaveCommand� 5T   ,   �� $ CloseButton��5U        J� OpacityMask  5X      �� 5Y      ! j� Stretch$! Uniform=�6_   " �� ImageSource" 6   �� $ CloseButtonImage��$ Source�6_   .��5[      �� -   5        # ��Name$# CloseButtonImage��5[   N   $6��0pack://siteoforigin:,,,/Res/close_button_off.png��6   $ J� RenderTransformOrigin$$ 0.5,0.5&�6h   5\      �� 5^   
   % �� TabStripPlacement$
% Left=�6   $��
34,44,46,0q�6.   
������ $��0q�5`      .@�5a      �� &   General#��Z& 6   .��5b      �� 
������ .+�5d      �� $��26��6    #��Z& 6,   $��75��6R   $��Center=�6]   $��15(�5e       $
��Bold"�6/   ���#555' �� Left$' 73��6S   �� 5f      -   5        $��
stop_apply��5f      (   StopAll#��Z( 61   
) �� Top$) 25��6Z   $' 39��5g      ��60   �� *StopChangeCommand+* d� 	IsChecked* 5h      �� *Settings.StopAll+��5i      �� $ 
stop_apply��$ 	IsChecked�5j      5k      5l      �� 5m      +   Language#��Z+ 6   .��5n      �� 
������ .+�5o      �� -   5        $��	Combobox1��5p      $
��Left=�5o      $	��Top=�6;   $��93��6S   $' 54��5p   $   $) 30��65   .@�5q      �� 
����  �,   RussianLang#��Z, 5r      �� 5s      
���  ��-   EnglishLang#��Z- 5t      5u      �� 5v      $��26��6    .   
LangHeader#��Z. 6,   $��75��6U   $��Center=�6`   $��15(�5w       $
��Bold"�6/   ���#555$' 73��6S   �� 5x      -   5        $��
lang_apply��5x      /   ApplyNow#��Z/ 61   $) 66��6[   $' 53��5y      �� 5z      0   Apply#��Z0 6   $) 94��6D   $' 61��6T   $��25��6e   $��80��6q   ��5{      �� *ApplyCommand+��5|      `� 5}      1 `� 	Converter#1 [  6+   .1�5~   "   �� $ 	IsChecked�6*   $ 
lang_apply��6;   �� 5   "   $ 	Combobox1��6*   $ SelectedIndex�6B   5�      5�      5�      5�      �� 5�      2   About#��Z2 6   5�      5�      5�      5�      