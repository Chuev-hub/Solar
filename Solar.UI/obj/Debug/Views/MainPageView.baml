   M S B A M L   `   `   `  ����C  ?Solar.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Solar.UI.ViewsSolar.UI.Views  5      9!clr-namespace:Solar.UI.ViewModelsSolar.UI.ViewModels  5      !    Solar.UI.Views.MainPageView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Solar.UI.Views     5      0vm!clr-namespace:Solar.UI.ViewModels     5        � DataContext  5
      +   %Solar.UI.ViewModels.MainPageViewModel  5   
   6!    � 	Resources 5       �� 
TargetType �� Property �� Value   DefaultButtonStyle �� 
TargetType ��Name J� SnapsToDevicePixels ��Name	 �� Triggers
 P� Property P� Value �� 
TargetName��%S  '��       &	  P     �� 5   
   " ��6   .�5      ��  � �� �	#FF1212126+   5      �� 5   
   " ��5      .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   #��z��5      #��z��5      #��z��5       . ._�5      �� $ contentPresenter��6/   #��z��5   !   #��z��5   !   #��z��5   !   |�.  ��. # z 5"   !   5#      	 5$      P� 5%      
 �@��IsDefaulted . . �5&   "   �� $ border��6)   # � ��6T    � ��5'      P� 5(      
 � {� .  5)      5+      5-      5.      50      .��51      � .+�53   
   �� -   5         ��Name$ MainPage��53      $��	0,80,0,10q�6*   .��54      � .+�56      �� .+�57      �� -   5         ��Name$ image��57      $��Center=�6A   $��Center=�6^   ��6'   �� *Main+6^   �� 58      $��Center=�6    �� Orientation$ 
Horizontal=�6:   $��	0,15,0,50q�6S   5;      �� 5<      ���	#FF121212���	#FF7A7A7A$	��324��6L   $��20(�6Y   $	��932��6g   $��Center=�6s   $��Center=�6�    �� 
IsReadOnly .  �� SelectionBrush 5=      �� 5>       �� Color$ 	#FFC9C9C9��6*    �� Opacity$
 0.54Q�6<   ��5@      �� 5A      $ 	#FFABADB3��6*   $ 0Q�6<   . �5C      /� .T�5D      J�  �� 
LineHeight$ 6��6$    �� TextAlignment$ Center=�63   .*�6J   .*�5E      �� $,�&WELCOME TO THE SOLAR GUITARS WEBSITE !��6"   5F      J� 5G      $ 6��6$   $ Center=�63   .*�6J   .*�5H      �� $��16(�6"   $���We are a guitar brand founded by and for the bedroom, studio and touring guitar player. Our objective is to create outstanding, high-quality guitars that offer premium features and construction, all at a fair price. We strongly believe in innovation; that is why we have chosen to add features like the Evertune Bridge to several of our models.��60   5I      J� 5J      $ 6��6$   $ Center=�63   .*�6J   .*�5K      �� $��16(�6"   5L      J� 5M      $ 6��6$   $ Center=�63   .*�6J   .*�5N      �� $��16(�6"   $���We will build your guitar according to the highest possible standards so you can concentrate on what's important to you: creating and performing the music you love.��60   5O      J� 5P      $ 6��6$   $ Center=�63   .*�6J   .*�5Q      �� $��16(�6"   5R      J� 5S      $ 6��6$   $ Center=�63   .*�6J   .*�5T      �� $��16(�6"   $���Grab a coffee, compare our different models and their features and check out our artist videos. In other words, 'stay a while and listen'!��60   5U      J� 5V      $ 6��6$   $ Center=�63   .*�6J   .*�5W      �� $�Ola Englund��6"   5X      5Y      5[      �� 5\      ���	#FF212121$	��537��64   .+�5]      �� -   5         ��Name$ label3��5]      $
��NEWS��6,   $��Center=�6;   $��Center=�6X   $��36(�6s   ���	#FF7A7A7A$��5,30,5,5q�6�   �� 5^      $ 
Horizontal=�6!   $	��396��6:   $��Center=�6G   $��Center=�6d   $
��1130��6   $��0,30,0,0q�6�   ���	#FF212121.+�5_      �� $��50,0,100,10q�6%   
���   �.+�5`      �� $	��300��6%   $	��200��61   $��UniformToFill=�6>   ��6V   �� *News1+�� 5a      -   5        $ lael3��5a   $   $����We've just made a couple of videos
 regarding the Evertune bridge. 
We're introducing the bridge, 
showing how to set it up, change
 strings and tunings, intonating,
 trouble shooting etc. 
Check out the full play list below.

��63   $��Center=�6i  $��Center=�6�  $��14(�6�  ���	#FF7A7A7A$	��163��6�  $��5,15,5,5q�6�  5c      �� 5d      $��
0,0,100,10q�6%   
���   �.+�5e      �� $	��300��6%   $	��200��61   $��UniformToFill=�6>   ��6V   �� *News2+�� 5f      -   5        $ labe3��5f   $   $����We're proud to announce the 
addition of Solar Bass Guitars
to our lineup. Starting out with 
the AB2.4 BOP, the AB2.5 RB and 
the AB2.5 AN Designed for the 
modern metal bass player with 
high quality expectations at an 
affordable price, this Solar Type ��63   $��Center=�6}  $��Center=�6�  $��14(�6�  ���	#FF7A7A7A$	��206��6�  $��5,15,5,5q�6�  5h      �� 5i      $��0,0,0,10q�6%   
���   �.+�5j      �� $	��300��6%   $	��198��61   $��UniformToFill=�6>   ��6V   �� *News3+�� 5k      -   5        $ labre3��5k   $   $����With groundbreaking musicianship 
and energetic showmanship, 
Marzi Montazeri, is a guitarist
and producer from Houston, 
Texas. Marzi has consistently been 
an exciting draw for fans 
throughout the years, bringing 
varying styles to his music.��64   $��Center=�6P  $��Center=�6m  $��14(�6�  ���	#FF7A7A7A$	��182��6�  $��5,15,5,5q�6�  5m      5n      5o      �� 5q      $��0,20,0,0q�6   $��Center=�6*   $��40��6G   $��40��6R   $
��Fill=�6^   ��6m   �� *	SmallLogo+�� 5r      ���	#FF121212���	#FF7A7A7A$��70��6L   $��12(�6X   $
��1232��6f   $��Center=�6s   $��Center=�6�    . $��0q�6�   $��0,10,0,0q�6�   ��5s      �� 5t      $ 	#FFABADB3��6*   $ 0Q�6<   . �5v      /� .T�5w      J� $ Center=�6$   .*�6;   .*�5x      �� $���TERMS AND CONDITIONS / PRIVACY POLICY / SHIPPING COSTS AND DELIVERY TIMES / WARRANTY TERMS / RIGHT OF WITHDRAWAL / SUBSCRIBE TO NEWSLETTER��6"   5y      J� 5z      $ Center=�6$   .*�6;   .*�5{      �� $S�M2017 Chug Express SL - ALL RIGHTS RESERVED - powered by Digital Player Agency��6"   5|      5}      5      5�      �� 5�      #��[  6<   $	��300��6�   $��<��6�   $	��100��6�   $	��Top=�6�   $
��Left=�6�   $�� 0 100 0 0 q�6�   $
��Bold"�6
  $��72(�6  $��0q�6*  ���	#FF818181y�6   �� *Visibilitys+��6i   �� *backPh+��6�   Z� 6X  �� 5�      #��[  6<   $��>��6�   $	��300��6�   $	��100��6�   $	��Top=�6�   $��Right=�6�   $�� 0 100 0 0 q�6�   $
��Bold"�6  $��72(�6  $��0q�6(  ���	#FF818181y�6   �� *Visibilitys+��6i   �� *nextPh+��6�   Z� 6V  5�      5�      5�      5�      