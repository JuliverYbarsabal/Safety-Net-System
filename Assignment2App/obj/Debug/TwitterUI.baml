   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Assignment2AppAssignment2App  5   	       Assignment2App.TwitterUI   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Assignment2App     5   	   -   5          �Name$  Twitter��5   	    � Title$ Twitter��5   	   $	��452��6   $	��729��6&   .��5	      � ���	#FF63B0E7 � ColumnDefinitions 5
   
   �� 5      $	��15* �6   �� 5      $	��90* �6   �� 5      $
��616* �6   .+�5   
   �� -   5         ��Name$ TwitterInterface��5      $
��Left=�6,   $��66��6G    �� TextWrapping$
 Wrap=�6S   $��    Twitter 
	Interface��6g   $	��561��6�   $��30(�6�   $��Cooper Black)�6�   $
��Bold"�6�    �� 
IsReadOnly . 
�������$	��Top=�6   $��
45.4,0,0,0q�68  $��2��6L  .��6\  ��5      �� 5       �� ImageSource$  img/Sign-Up-Background.png��6    j� Stretch$ UniformToFill=�6F   .��5   "   5      �� 5   
   -   5         ��Name$ 	postTweet��5      $)��#Post User Tweet 
   (Ask for help)��6$   $
��Left=�6Z   $��438.4,220,0,0q�6u   $	��Top=�6�   $	��144��6�   $��39��6�   $��2��6�   $��Cooper Black)�6�   �� 5   
   -   5        $ GetTweet��5      $��Load User Latest Tweet��6#   $
��Left=�6D   $��	3,220,0,0q�6_   $	��Top=�6r   $	��151��6�   $��44��6�   	 J� RenderTransformOrigin$	 
0.597,1.28&�6�   $��3��6�   $��Cooper Black)�6�   �� 5   
   -   5        $ TweetBox��5      $
��Left=�6$   $	��130��6?   $��206.4,90,0,0q�6L   $
 Wrap=�6b   $	��Top=�6v   $	��376��6�   $��2q�6�   $��2��6�   �� 5   
   -   5        $ 	GetTweet2��5      $
��Left=�6%   $	��143��6@   $��	0,269,0,0q�6M   $
 Wrap=�6`   $	��Top=�6t   $	��688��6�    . $	 1.385,-0.377&�6�   $��3��6�   �� 5   
   -   5        $ FullName��5      $
��Left=�6$   $��23��6?   $��	0,170,0,0q�6K   $
 Wrap=�6^   $	��Top=�6r   $��95��6�    . ���	#FFFDFDFD���	#FF63B0E7���	#FF63B0E7
 �� SelectionBrush
 �	#FF0397FF$��2��6  �� 5   
   -   5        $ Handler��5      $
��Left=�6#   $��23��6>   $��	3,142,0,0q�6J   $
 Wrap=�6]   $	��Top=�6q   $	��112��6�    . ���	#FF63B0E7���	#FF63B0E7
�������$��3��6�   $	 0.347,-0.922&�6�   �� 5   
   -	   5        $ LoadAccount��5      $��Load Twitter Account��6&   $
��Left=�6E   $��3,10,0,0q�6`   $	��Top=�6r   $	��143��6�   $��3��6�   $��31��6�   $��Cooper Black)�6�   $	 0.457,0.774&�6�   �� 5   
   $��Tweet:��6   $
��Left=�6!   $��141.4,111,0,0q�6<   $	��Top=�6S   $��60��6k   $��2��6v   $��26��6�   $��Cooper Black)�6�   �� 5   
   -
   5         ��Name$ 	testimage��5      $
��Left=�6#   $	��104��6>   $��0,38,0,0q�6K   $	��Top=�6]   $	��151��6u    J� OpacityMask �	#FF464646$��3��6�   $	 0.056,0.451&�6�   �� 5   
   $��2��6   $
��Left=�6    $��85��6;   $��91.4,31,0,0q�6G   $	��Top=�6\   $��68��6t   $'��!img/icons8-twitter-circled-64.png��6   5      5       