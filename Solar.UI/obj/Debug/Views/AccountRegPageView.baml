   M S B A M L   `   `   `  ����C  ?Solar.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Solar.UI.ViewsSolar.UI.Views  5      9!clr-namespace:Solar.UI.ViewModelsSolar.UI.ViewModels  5      '    !Solar.UI.Views.AccountRegPageView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Solar.UI.Views     5      0vm!clr-namespace:Solar.UI.ViewModels     5        � DataContext  5
      1   +Solar.UI.ViewModels.AccountRegPageViewModel  5   
   6'   .��5      � $��Center=�6   .+�5   
   �� -   5         ��Name$ label��5      $��Register��6   $
��Left=�62   $��	82,89,0,0q�6M   $	��Top=�6`   
�������$��20(�6�   $
��Bold"�6�   ��6x   Z� 6�   �� 5   
   -   5         ��Name$ textBox��5   ,   $
��Left=�6=   $��23��6X   $��
82,157,0,0q�6d    �� TextWrapping$
 Wrap=�6x   $	��Top=�6�   $	��140��6�   ��6   �� *
EMAILreg+6�   G� 5   
   -   5         G�Name$ PasswordBox��5   *    G� PasswordChar$ *��6   $
��Left=�6?   $��23��6Z   $��
82,211,0,0q�6f   $	��Top=�6{   $	��140��6�   �� 5   
   -   5        $ 
label_Copy��5      $��Email��6$   $
��Left=�64   $��
82,121,0,0q�6O   $	��Top=�6c   
�������$��16(�6�   $��Italic$�6�   ��6{   Z� 6�   �� 5   
   -   5        $ 	label_Coy��5      $��password��6#   $
��Left=�66   $��
82,180,0,0q�6Q   $	��Top=�6e   
�������$��16(�6�   $��Italic$�6�   ��6}   Z� 6�   �� 5   
   -   5        $
 lbel��5      $��Log in��6   $
��Left=�6/   $��
347,89,0,0q�6J   $	��Top=�6^   
�������$��20(�6�   $
��Bold"�6�   ��6v   Z� 6�   �� 5   
   -   5        $ texBox��5      $
��Left=�6#   $��23��6>   $��347,157,0,0q�6J   $
 Wrap=�6_   $	��Top=�6�   $	��149��6�   ��6s   �� *
EMAILlog+6�   G� 5   
   -   5        $ PasswordBox2��5      $
��Left=�6,   $��23��6G   $��347,211,0,0q�6S   $	��Top=�6i   $	��149��6�   �� 5   
   -	   5        $ lel_opy��5      $��Email��6!   $
��Left=�61   $��347,121,0,0q�6L   $	��Top=�6a   
�������$��16(�6�   $��Italic$�6�   ��6y   Z� 6�   �� 5   
   -
   5        $ labl_CoyCopy��5      $��password��6&   $
��Left=�69   $��347,180,0,0q�6T   $	��Top=�6i   
�������$��16(�6�   $��Italic$�6�   ��6�   Z� 6�   �� 5   
   -   5         ��Name$ button��5   i   $��OK��6y   $
��Left=�6�   $��422,313,0,0q�6�   $	��Top=�6�   $��74��6�   $��33��6�   ���	#FF939393
���������6   �� *LoginCommand+��62   ��  �� ElementName$ PasswordBox2��6�   �� 5   
    �� 	IsDefault . $��OK��5   G   $
��Left=�6T   $��148,313,0,0q�6o   $	��Top=�6�   $��74��6�   $��33��6�   ���	#FF939393
���������5      �� *SigninCommand+��5      �� $ PasswordBox��5      �� 5   
   -   5        $ label1��5      $
��Left=�6<   $��
82,245,0,0q�6W   $	��Top=�6k   
���  ��$��16(�6�   $��Italic$�6�   ��6!   �� *Texts+��6�   Z� 6�   �� 5   
   -   5        $
 labe��5      $
��Left=�6=   $��347,245,0,0q�6X   $	��Top=�6m   
���  ��$��16(�6�   $��Italic$�6�   ��6   �� *
TextsLog+��6�   Z� 6�   �� 5   
   -   5        $ label1_Copy��5      $
��Left=�6D   $��
82,276,0,0q�6_   $	��Top=�6s   ���	#FF0CFF00$��16(�6�   $��Italic$�6�   ��6&   �� *
TextsScs+��6�   Z� 6�   5!      5"      