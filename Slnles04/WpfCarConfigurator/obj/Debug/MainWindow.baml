   M S B A M L   `   `   `  ����M  IWpfCarConfigurator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfCarConfiguratorWpfCarConfigurator  5   	   #    WpfCarConfigurator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WpfCarConfigurator     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      � -   5         �Name$ gamecb��5
      .+�5   
   �� -   5         ��Name$ mklbl��5      $��Spelconsole��6   $
��Left=�65   $��	90,61,0,0q�6P   $	��Top=�6c   �� 5   
   -   5        $ acclbl��5      $��Accessesoires��6    $
��Left=�68   $��
90,214,0,0q�6S   $	��Top=�6g   	� 5   
   -   5         	�Name$	 wit��5      $	��Wit��6#   $
��Left=�61   $��242,133,0,0q�6L   $	��Top=�6a   6y   	� 5   
   -   5        $ zwart��5      $��Zwart (+70 euro)��6%   $
��Left=�6@   $��242,173,0,0q�6[   $	��Top=�6p   6�   	� 5   
   -   5        $ grijs��5      $��Grijs (+25)��6%   $
��Left=�6;   $��242,153,0,0q�6V   $	��Top=�6k   6�   �� 5   
   -   5         ��Name$ 	dualshock��5      $��Extra dualshock (+70)��6&   $
��Left=�6F   $��243,228,0,0q�6a   $	��Top=�6v   6�   �� 5   
   -   5        $ headset��5      $��Headset (+40)��6$   $
��Left=�6<   $��242,247,0,0q�6W   $	��Top=�6l   6�   �� 5   
   -	   5        $ randgame��5      $��Random extra game (+60)��6%   $
��Left=�6G   $��242,267,0,0q�6b   $	��Top=�6w   6�   �� 5   
   -
   5        $��	ComboBox1��5      $	��202��6$   $��30��60   $	��Top=�6<   $
��Left=�6U   $��
242,57,0,0q�6p   .@�5      �� -   5         ��Name$ combops1��5      $��Playstation (100 euro)��6-   6Q   �� 5      -   5        $ combops2��5      $��Playstation 2 (120 euro)��6-   6S   �� 5      -   5        $ combops3��5      $��Playstation 3 (150 euro)��6-   6S   5      �� 5   
   -   5         ��Name$
 imgG��5      $��485,284,80.6,84q�6   $��	games.png��67    J� Opacity$	 0.3Q�6J   $
��Fill=�6X   �� 5   
   -   5        $ imgHd��5      $��485,214,229.6,158q�6   $��headset.jpg��6:   $
��Fill=�6O   $	 0.3Q�6^   �� 5   
   -   5        $ imgDs��5      $��611,224,117.6,158q�6   $��dualshock.jpg��6:   $
��Fill=�6Q   $	 0.3Q�6`   �� 5   
   -   5        $ psimg��5      $
��Left=�6   $	��142��6:   $��
510,36,0,0q�6G   $	��Top=�6[   $	��203��6s   �� 5   
   $��Prijs��6   $
��Left=�6    $��121,336,0,0q�6;   $	��Top=�6P   �� 5   
   -   5         ��Name$ txtBox��5      $
��Left=�6"   $��23��6=   $��243,336,0,0q�6I   	 �� TextWrapping$
	 Wrap=�6^   $	��Top=�6r   $	��120��6�   5      5      