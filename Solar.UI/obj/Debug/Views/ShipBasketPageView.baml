   M S B A M L   `   `   `  ����C  ?Solar.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Solar.UI.ViewsSolar.UI.Views  5      9!clr-namespace:Solar.UI.ViewModelsSolar.UI.ViewModels  5      A%clr-namespace:Solar.UI.InfrastructureSolar.UI.Infrastructure  5      '    !Solar.UI.Views.ShipBasketPageView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Solar.UI.Views     5      0vm!clr-namespace:Solar.UI.ViewModels     5      5ist%clr-namespace:Solar.UI.Infrastructure     5        � DataContext  5      1  +Solar.UI.ViewModels.ShipBasketPageViewModel  5   
   6'   .��5      � .+�5   
   �� .+�5      �� $��Center=�6   $��0,20,0,0q�61   ���	#FF7A7A7A$��24(�6Z   .��6h   SHIP BASKET6u   �� 5      -   5         ��Name$ d��5   u   $��Center=�6    �� SelectedItem$  ��64   $	��300��6E   $	��800��6�   ��6S   �� *
Products+��6�   Z� ��6�   Z� ��5      �� 5      .R�5      �� ���	#FFACACAC$��2q�69   $��10q�6N   ._�5      � $��Center=�6   $	��720��6<   .+�5      ��  �� Orientation$ 
Horizontal=�6*   $
��Left=�6C   .+�5   "   �� $��50��6(   ��64   �� *	MainPhoto+6S   �� 5   "   $��30,0,0,0q�6(   
�������$��20(�6f   $
��Bold"�6t   $��Italic$�6�   ��6:   �� *Name+6�   �� 5   "   $	�� - ��6(   
�������$��20(�6I   $
��Bold"�6W   $��Italic$�6i   �� 5   "   
�������$��20(�6U   $
��Bold"�6c   $��Italic$�6u   ��6(   �� *Color+6u   5      �� 5      $ 
Horizontal=�6*   $��Right=�6C   .+�5   "   �� $��Center=�6(   $��30,0,0,0q�6C   ���	#FFBDBDBD$��20(�6�   $
��Bold"�6�   $��Italic$�6�   ��6U   �� *Price+6�   �� 5    "   $��Center=�6(   $	��€��6C   ���	#FFBDBDBD$��20(�6f   $
��Bold"�6t   $��Italic$�6�   ��6�   Z� �� 5!   &   $��20��6S   $��20��6^   $��5q�6j   $��Center=�6u   $��X��6�   ��6-   �� *
GuitarId+��6�   ��  �� RelativeSource ��  �� AncestorType$ UserControlL� �� Mode$ FindAncestor=� �� Path$ DataContext.RemoveCommand�6  5#   #   5%      5&      5'      5)      �� 5*      $ 
Horizontal=�6   $��Center=�62   $��	150,0,0,0q�6O   .+�5+      �� $��0,0,0,0q�6   $��Total: ��6)   
�������$��20(�6N   $
��Bold"�6\   $��Italic$�6n   �� 5,      $��0,0,0,0q�6   
�������$��20(�6T   $
��Bold"�6b   $��Italic$�6t   ��6)   �� *Sum+6t   �� 5-      $��0,0,0,0q�6   $	��€��6)   
�������$��20(�6H   $
��Bold"�6V   $��Italic$�6h   �� 5/      $��10,0,0,0q�68   ���	#FF323232$��70��6b   $��30��6m   $	��Buy��6z   $��Center=�6�   $��18(�6�   ���	#FF7A7A7A$��Center=�6�   $��Center=�6�   ��6   �� *
BuyCommand+��50      �� 51       �� Color$ 	#FF707070��6*   	 �� Opacity$	 0Q�6<   53      54      �� 55      $��18(�6   
���  ��$��Center=�63   $��Center=�6P   $��	0,0,300,0q�6k   ��6~   �� *Exc+6�   56      57      58      