   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5   	   J FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WpfApplication1.PropertiesWpfApplication1.Properties 5   	   7 clr-namespace:TestApp.ConvertersTestApp.Converters 5   	   !   TestApp.View.MainWindowView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   \iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Bcmd2http://schemas.devexpress.com/winfx/2008/xaml/mvvm     5   	   6p(clr-namespace:WpfApplication1.Properties     5   	   8databinding clr-namespace:TestApp.Converters     5   	   -   5          �Name$  
MainWindow��5
   	    � Title$
 Test��5   	   $��633.777��6   $��383.105��6'    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � AllowsTransparency . 
������  � WindowStyle$
 None=�5   	    � 	Resources 5         GrayBlueGradientBrush �� 
StartPoint �� EndPoint	 � Color
 � Offset �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value$  TestApp.Converters.MyConverter  MyConverter&   TestApp.Converters.RateConverter  RateConverter  	template1.   (System.Windows.Interactivity.Interaction   Triggers/   )System.Windows.Interactivity.EventTrigger   	EventName.   (System.Windows.Interactivity.TriggerBase   Actions6   0System.Windows.Interactivity.InvokeCommandAction   Command �� RelativeSource �� AncestorType �� Mode �� Path   CommandParameter �� ElementName �� StringFormat �� 	Converter  ButtonStyle��%	  &	        '�� �     7   '�� �     &	 �    &	 �    &	 	    7  &	 �    �� 5   
   $	 0,0&�6<   $	 1,1&�6M   .��5      � $	 ForestGreen��6   $
 0Q�6/   � 5      $	 
LightGreen��6   $
 1Q�6.   5      �� 5   
   " ��6   .�5      ��  � ��8   6+   5      �� 5   
   " ��6   .�5      ��  � ��
 ����6+    5      P� 5       �@��
IsSelected .  . �5       ��  �@J�Opacity$	 0.5Q�60   �� 5!       � ��
 �  ��63   �� 5"       � ��
 ����63   5#      5%        5'   
   68     5(   
   6<   �� 5)   
   .R�5+      �� $��listBox��6   $��10,10,10,10q�6%   $��Disabled=�5,      ��5+   :   �� ��5.      �� 5/      $ 0.5,1&�6*   $ 0.5,0&�6;   .��50      � $	 
LightGreen��6'   $
 0Q�6:   � 51      $	 ForestGreen��6'   $
 1Q�6;   53       55        56      $ SelectionChanged��6%   . 57         60   ��  �� $ WindowL�$ FindAncestor=�$&  DataContext.ChangeCurrentCommand� 58   0   �� $ listBox��5:      ��5=      �� 5>      .R�5?      � ��5@      �� 5A   "   " �6(    5B   &   P� 5C   *    �@J�IsMouseOver . . �5D   .   ��  � ��
 �����6K   5E   +   P� 5F   *    �@J�IsMouseOver . . �5G   .   ��  � ��
 �����6K   5H   +   5J   #   .+�5L      �� 
��� � �$��1��67   $��40��6K   $	��275��6W   $��2,2,2,2q�6d   �� 5M      $��	20,2,20,0q�6(   $
��Left=�6<   ��6W   �� $ TrackString��� 5N      $��	20,2,20,0q�6(   $��Right=�6<   ��6X   �� $ TrackLength�$ {00:mm\:ss}���� 5P      $��Rate5button��6$   $��Right=�68   $��0,12,5,0q�5R   $   $��90��5S      $��30��6*    5T   "     5U   &   $ MouseLeftButtonDown��65   . 5V   *      6@   ��  �� $ WindowL�$ FindAncestor=�$ DataContext.RateCommand� 5W   0   �� $ SelectedItem�$ listBox��5Y   '   .��5[   "   �� ��6(   �� $ Rating�8   5\      5]      5_      5a      5b      �� 5d   
   " ��6$    5e      P� 5f       � �� . . �5g      ��  �@J�Opacity$	 0.5Q�60   �� 5h       � ��
 �  ��63   5i      P� 5j       � {� .  . �5k      ��  � ��
 �  ��63   5l      5n      5p       J� InputBindings 5q      �� 5r   
    �� Gesture$ CTRL+N��5t       �� Command 5r      �� *SettingsCommand+  �� CommandParameter  5s      �� $ 
MainWindow��5t      �� 5u   
   $ CTRL+Q��5w       5u      �� *CloseWindowCommand+  5v      �� $ 
MainWindow��5w      .��5z      � .+�5{   
   �� $
��auto��6   $
��auto��6   
��� � �$��2q�6@   ! �� CornerRadius$! 30,30,30,30��5|      $��	0,0,0,403q�6,   ��5}      �� 5~      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $	 ForestGreen��6#   $
 0Q�67   � 5�      $	 
LightGreen��6#   $
 1Q�66   5�      ._�5�      �� -   5        $��
pos_slider��5�      $
��Left=�5�      $��23��60   $��
46,106,0,0q�6<   $	��Top=�5�      $	��313��6-   " � Maximum$	" 100Q�5�      # � Minimum$# 0Q�6#    5�        5�      $ ValueChanged��6%   . 5�         60   �� *ChangePositionCommand+ 5�      `� 5�   "   $ `� 	Converter#$ [ 6/   .1�5�   &   �� $	 tab��6.   $ SelectedContent�6@   �� 5�   &   $ 
pos_slider��6.   $ Value�6G   5�   #   5�      5�      5�      5�      �� 5�   
   $	��Top=�6   $��15(�6(   $
��Bold"�67   ���#555$��Right=�5�      *  $WpfApplication1.Properties.Resources%   Volume#��Z% 5�      $��0,131,164,0q�68   �� 5�   
   $	��Top=�6   $��15(�6(   $
��Bold"�67   ���#555$��Right=�5�      $��0,132,136,0q�5�   G   ��6   �� $ 
vol_slider��$ Value�6G   �� 5�   
   -   5        $��
vol_slider��5�      $
��Left=�5�      $��23��6,   $��245,137,0,0q�68   $	��Top=�5�      $	��111��6-   $	" 100Q�5�      $# 0Q�6#   & � Value$& 50Q�5�       5�        5�      $ ValueChanged��6!   . 5�         6,   �� *ChangeVolumeCommand+ 5�      `� 5�      #$ [ 6+   .1�5�   "   �� $	 tab��6*   $ SelectedContent�6<   �� 5�   "   $ 
vol_slider��6*   $ Value�6C   5�      5�      5�      5�      o� 5�   
   $��47,10,398,457q�6   .@�5�      m� $
��File��6   .@�5�      m� $	��New��6   6*   m� 5�      $
��Open��6   6+   m� 5�      $
��Save��6   6+   m� 5�      $��	SaveAs...��6   60   �� 5�      6   m� 5�      $
��Exit��6   6+   5�      m� 5�      $
��Edit��6   .@�5�      m� $
��Undo��6   6+   m� 5�      $
��Redo��6   6+   �� 5�      6   m� 5�      $	��Cut��6   6*   m� 5�      $
��Copy��6   6+   m� 5�      $��Paste��6   6,   5�      5�      �� 5�   
   -   5        $��	lblStyled��5�      $��	ALB Music��6%   $��18(�66   $��Center=�6D   $��Center=�6a   $��140,5,85,583q�6|   $	��158��6�   $��46��6�   ' J� RenderTransformOrigin$' -2.183,-2.253&�6�    5�        5�      $ MouseLeftButtonDown��6   . 5�         6(   �� *DragMoveCommand+ 5�   (   �� $ 
MainWindow��5�      ��5�      �� 5�      " ��6    5�      :� 5�      ( :� RoutedEvent$( 
MouseEnter��6'   [�5�      �� 5�   "   .��5�   &   �� .��5�   *   W� ) g� Duration$) 	0:0:0.300D�6:   * �� TargetProperty$* FontSize�6O   	+ W� To$+ 28X�6t   5�   '   5�   #   5�      :� 5�      $( 
MouseLeave��6'   [�5�      �� 5�   "   .��5�   &   �� .��5�   *   W� $) 	0:0:0.800D�6:   $* FontSize�6O   $+ 18X�6t   5�   '   5�   #   5�      5�      5�      �� 5�   
   -   5        , ��Name$, Canvas��5�      
������ $��32��6:   $	��Top=�5�      $��0,30,0,0q�6)   .+�5�      �� -   5        $��ticker��5�      $��Bottom=�6'   $��15(�6B   $
��Bold"�6Q   ���#555-   Ticker#��Z- 5�      . �� Right$. 0��6=   / �� Left$	/ 131��6N   0 � Triggers0 5�      :� 5�      $( TextBlock.Loaded��6#   [�5�      �� 5�      .��5�   "   �� .��5�   &   W� $* (Canvas.Left)�66   1 W� From$	1 400X�6`   $
+ -400X�6k   $) 0:0:9D�5�   6   2 g� RepeatBehavior$2 Forever��6G   5�   #   5�      5�      5�      5�      �� 5�   
   -   5        $	��tb1��5�      $
��Left=�5�      $��24��5�      $��401,136,0,0q�6   3 �� TextWrapping$
3 Wrap=�5�      $�� ��6&   $	��Top=�5�      $��93��6*   5�      �� 5�   
   -   5        $��play_button��5�      $��Center=�6%   $	��Top=�5�      $��43��6)   $��43��65   $' 1.191,0.583&�6A   $��0q�5�      $��172,67,148,0q�5      ��5�      �� *PlayCommand+��5     `� 5     #$ [ 6   .1�5     �� $	 tab��6   $ SelectedContent�60   �� 5     $ ticker��6   5      5       5     $ 
MouseEnter��6!   . 5	        6,   ��  �� $ WindowL�$ FindAncestor=�$&  DataContext.ButtonMouseElCommand� 5
  ,   �� $ play_button��5       5     $ 
MouseLeave��6!   . 5        6,   ��  �� $ WindowL�$ FindAncestor=�$&  DataContext.ButtonMouseElCommand� 5  ,   �� $ play_button��5     4 J� OpacityMask4 5     �� 5     5 j� Stretch$5 Uniform=�6^   6 �� ImageSource6 6   �� $ PlayButtonImage��$ Source�6^   .��5     �� -	   5        7 ��Name$7 PlayButtonImage��5  I   $1��+pack://siteoforigin:,,,/Res/play_button.png��6   $' 0.5,0.5&�6b   5     �� 5  
   -
   5        $��pause_button��5     $��Center=�6&   $	��Top=�5     $��43��6)   $��43��65   $' 0.511,0.467&�6A   $��0q�5     $��235,67,85,0q�6%   ��5     �� *PauseCommand+��5     �� $	 tab��$ SelectedContent� 5       5     $ 
MouseEnter��6!   . 5        6,   ��  �� $ WindowL�$ FindAncestor=�$&  DataContext.ButtonMouseElCommand� 5  ,   �� $ pause_button��5        5!     $ 
MouseLeave��6!   . 5"        6,   ��  �� $ WindowL�$ FindAncestor=�$&  DataContext.ButtonMouseElCommand� 5#  ,   �� $ pause_button��5$     4 5'     �� 5(     $5 Uniform=�6_   6 6   �� $ PauseButtonImage��$ Source�6_   .��5*     �� -   5        $7 PauseButtonImage��5*  J   $2��,pack://siteoforigin:,,,/Res/pause_button.png��6   $' 0.5,0.5&�6d   5+     �� 5,  
   -   5        $��stop_button��5,     $��Center=�6%   $	��Top=�5-     $��43��6)   $��43��65   $��0q�50     $��298,67,22,0q�6%   ��5.     �� *StopCommand+��5/     �� $	 tab�� 51       52     $ 
MouseEnter��6!   . 53        6,   ��  �� $ WindowL�$ FindAncestor=�$&  DataContext.ButtonMouseElCommand� 54  ,   �� $ stop_button��55       56     $ 
MouseLeave��6!   . 57        6,   ��  �� $ WindowL�$ FindAncestor=�$&  DataContext.ButtonMouseElCommand� 58  ,   �� $ stop_button��59     4 5<     �� 5=     $5 Uniform=�6^   6 6   �� $ StopButtonImage��$ Source�6^   .��5?     �� -   5        $7 StopButtonImage��5?  I   $1��+pack://siteoforigin:,,,/Res/stop_button.png��6   $' -0.532,1.07&�6b   5@     �� 5A  
   -   5        $��next_button��5A     $��Center=�6%   $	��Top=�5B     $��43��6)   $��43��65   $��0q�5D     $��110,67,211,0q�6%   ��5C     �� *NextTrackCommand+��5E     `� 5F     #$ [ 6   .1�5G     �� $	 tab��6   $ SelectedContent�60   �� 5H     $ ticker��6   5I      5K       5L     $ 
MouseEnter��6!   . 5M        6,   ��  �� $ WindowL�$ FindAncestor=�$&  DataContext.ButtonMouseElCommand� 5N  ,   �� $ next_button��5O       5P     $ 
MouseLeave��6!   . 5Q        6,   ��  �� $ WindowL�$ FindAncestor=�$&  DataContext.ButtonMouseElCommand� 5R  ,   �� $ next_button��5S     4 5V     �� 5W     $5 Uniform=�6^   6 6   �� $ NextButtonImage��$ Source�6^   .��5Y     �� -   5        $7 NextButtonImage��5Y  I   $1��+pack://siteoforigin:,,,/Res/next_button.png��6   $' -0.532,1.07&�6b   5Z     �� 5[  
   -   5        $��prev_button��5[     $��Center=�6%   $	��Top=�5\     $��43��6)   $��43��65   $��0q�5^     $��52,67,269,0q�6%   ��5]     �� *PrevTrackCommand+��5_     `� 5`     #$ [ 6   .1�5a     �� $	 tab��6   $ SelectedContent�60   �� 5b     $ ticker��6   5c      5e       5f     $ 
MouseEnter��6!   . 5g        6,   ��  �� $ WindowL�$ FindAncestor=�$&  DataContext.ButtonMouseElCommand� 5h  ,   �� $ prev_button��5i       5j     $ 
MouseLeave��6!   . 5k        6,   ��  �� $ WindowL�$ FindAncestor=�$&  DataContext.ButtonMouseElCommand� 5l  ,   �� $ prev_button��5m     4 5p     �� 5q     $5 Uniform=�6^   6 6   �� $ PrevButtonImage��$ Source�6^   .��5s     �� -   5        $7 PrevButtonImage��5s  I   $1��+pack://siteoforigin:,,,/Res/prev_button.png��6   $' -0.532,1.07&�6b   5t     �� 5v  
   -   5        8 ��Name$8 CloseButton��5v     $��Center=�6&   $��25��5w     $	��Top=�5x     $��35��5y     $��0q�5z     $��0q�5{     9 � Cursor$
9 Hand��6   $��338,10,10,0q�5|  8   ��6   �� *CloseWindowCommand+��5}     �� $ 
MainWindow�� 5       5�     $ 
MouseEnter��6!   . 5�        6,   ��  �� $ WindowL�$ FindAncestor=�$) #DataContext.CloseButtonEnterCommand� 5�  ,   �� $ CloseButton��5�       5�     $ 
MouseLeave��6!   . 5�        6,   ��  �� $ WindowL�$ FindAncestor=�$) #DataContext.CloseButtonLeaveCommand� 5�  ,   �� $ CloseButton��5�     4 5�     �� 5�     $5 Uniform=�6_   6 6   �� $ CloseButtonImage��$ Source�6_   .��5�     �� -   5        $7 CloseButtonImage��5�  N   $6��0pack://siteoforigin:,,,/Res/close_button_off.png��6   $' 0.5,0.5&�6h   5�     �� 5�  
   $��5��6   $	��100��6   
��� d �$
��Left=�6C   $	��Top=�5�     $��0,30,0,0q�5�     0 5�     :� 5�     $( StackPanel.MouseEnter��6   .[�5�     �� .��5�     �� .��5�     W� $* Width�6.   $	+ 100X�6P   $) 	00:00:0.3D�6Y   W� 5�     $* Opacity�6.   $	+ 0.8X�6R   $) 	00:00:0.3D�6[   5�     5�     5�     :� 5�     $( StackPanel.MouseLeave��6   .[�5�     �� .��5�     �� .��5�     W� $* Width�6.   $+ 5X�6P   $) 	00:00:0.3D�6W   W� 5�     $* Opacity�6.   $+ 1X�6R   $) 	00:00:0.3D�6Y   5�     5�     5�     .+�5�     �� $��5q�6   :   SettingsButton#��Z: 5�     ��5�      �� *SettingsCommand+��5�     �� $ 
MainWindow��5�  G   �� 5�     $��5q�6   ;   About#��Z; 6    ��5�     �� *AboutCommand+��5�     �� $ 
MainWindow���� 5�     $��5q�6   <   Quit#��Z< 6    ��5�     �� *CloseWindowCommand+��5�     �� $ 
MainWindow��5�     �� 5�  
   -   5        $��
stackpanel��5�     $	��326��5�     $	��280��6!   
������$
��Left=�6F   $	��Top=�5�     $��
30,208,0,0q�5�      5�       5�     $ MouseLeftButtonDown��6!   . 5�        6,   ��  �� $ WindowL�$ FindAncestor=�$% DataContext.PlaylistMoveCommand� 5�  0   �� $ 
stackpanel��5�     .+�5�     �� -   5        $	��tab��5�     $
��Left=�6%   $	��250��5�     $	��Top=�6"   $	��326��6:   = �� ContentTemplate#= [ 5�     
������$��2q�5�     
��� � � 5�       AugmentedTabItem> �� Orientation  ContentRight��%z  &	       '�� a    �� 5�     .R�5�     �� $> 
Horizontal=�6%   .+�5�     �� ��6/   �� �� 5�     #���  60   $��0q�6Y    5�  "     5�  &   $ MouseLeftButtonDown��65   . 5�  *      6@   ��  �� $ WindowL�$ FindAncestor=�$# DataContext.AddTabItemCommand� 5�  ,   �� $	 tab��5�  '   5�     5�     5�     �� 5�     " ��6   .�5�     ��  � �� 5�     �� 5�  "   .R�5�  &   �� $> 
Horizontal=�61   .+�5�  *   �� ��6;   �� �� 5�  *   $��5,0,0,0q�6<   ��5�  .   �� 5�  2   $��X��6<   
����  �6E    5�  .     5�  2   $ MouseLeftButtonDown��6A   . 5�  6      6L   ��  �� $ WindowL�$ FindAncestor=�$% DataContext.CloseTabItemCommand� 5�  ,   ��  �� $ TabItemL�$ FindAncestor=�5�  3   5�  +   5�  '   5�  #   5�     5�     5�     .@�5�     �� ��6   �� $ Playlist.Name���6@   �� $ Playlist��� 5�     #��[ 6,   ��6   Z�  5�     ��%5   &	       �� 5�     $��+��69   
����  �6B   5�     5�     5�     � 5�     $��31��6   $	��325��6   .+�5�     �� $��2q�6   
��� � �$��	0,-1,-1,1q�6A   �� 5�     -   5        $8 remove_track_button��5�     $��-��68   $
��Left=�6D   $��17��6_   $	��Top=�6l   $��26��6�   $��	46,5,0,-5q�5�  H   ��5�  
   �� *RemoveTrackCommand+��5�  
   �� *SelectedContent+$	 tab��5�     �� 5�     -   5        $��add_track_button��5�     $
��Left=�62   $��16��6M   $	��Top=�6Z   $��24��6r   $��	14,5,0,-4q�5�  Q   ��5�     �� *AddTrackCommand+��5�     �� $	 tab��$ SelectedItem�.��6e   +5�     5      5     5     5     