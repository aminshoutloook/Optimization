   M S B A M L   `   `   `  ����J  FOptimization.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Optimization.UI.HelpersOptimization.UI.Helpers  5           Optimization.UI.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      =StoryboardManager%clr-namespace:Optimization.UI.Helpers  5      -   5        (  "MahApps.Metro.Controls.MetroWindow   Name$  
mainWindow��5
   #      MaterialDesignBody#���   5      $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	    � WindowState$ 	Maximized=�6.   $	��800��6F   $
��1100��6S     AccentColorBrush   	GlowBrush# �  5        MaterialDesignFont#��[ 5        MaterialDesignPaper#���  5       � Title$ Optimization��6M    � 	Resources 5        StoryboardFadeOut/   )Optimization.UI.Helpers.StoryboardManager	   ID g� 	BeginTime	 �� TargetProperty
 O� KeyTime O� Value  StoryboardFadeIn  StoryboardShowWindow �� 	KeySpline  StoryboardHideWindow��%�  &	       &	 �     &	 �    &	     �� 5   
   $ StoryboardFadeOut��6/   .��5      U�  00:00:006,   $	 (UIElement.Opacity)�6A   .\�5      �� $
 00:00:00.1500000��6'   $	 0.4Q�6B   5      5      �� 5   
   $ StoryboardFadeIn��6.   .��5      U�  00:00:006,   $	 (UIElement.Opacity)�6A   .\�5      �� $
 00:00:00��6'   $	 0.4Q�6:   �� 5      $
 00:00:00.1500000��6'   $ 1Q�6B   5      5      �� 5   
   $ StoryboardShowWindow��62   .��5      U�  00:00:006,   $	 (UIElement.Opacity)�6A   .\�5      �� $
 00:00:00��6'   $ 0Q�6:   �� 5       $
 	00:00:0.2��6'   $	 0.3Q�6;   �� 5!      $
 	00:00:0.4��6'   $	 0.7Q�6;   �� 5"      $
 	00:00:0.5��6'   $ 1Q�6;   $ 0.705,0,0,1��6E   5#      5$      �� 5%   
   $ StoryboardHideWindow��62   .��5&      U�  00:00:006,   $	 (UIElement.Opacity)�6A   .\�5'      �� $
 00:00:00��6'   $ 1Q�6:   �� 5(      $
 	00:00:0.3��6'   $	 0.5Q�6;   �� 5)      $
 	00:00:0.5��6'   $ 0Q�6;   �� 5*      $
 00:00:01��6'   $ 0Q�6:   $ 0.705,0,0,1��6D   5+      5,      5-       � Triggers 5.      :� 5/   
    :� RoutedEvent$ FrameworkElement.Loaded��6   51       J� InputBindings 53      �� 54   
   
 �� Key$ F1��6    �� Command 6   �� *HelpCommand+.��56      � -   5         �Name$ RootGrid��56      .+�57   
   )  #MaterialDesignThemes.Wpf.DialogHost     
Identifier$ 
RootDialog��6$      SnackbarMessageQueue 58   $   ��  �� ElementName$ MainSnackbar�� �� Path$ MessageQueue�.��59      )  #MaterialDesignThemes.Wpf.DrawerHost     IsLeftDrawerOpen 6(   �� $ MenuToggleButton��$ 	IsChecked�   LeftDrawerContent 5:      ]� 5;      $	��212��6    .+�5<      d�  ' #MaterialDesignHamburgerToggleButton#��[ 6'   $	��Top=�5=   %   $��Right=�5>   %   $��16q�6A    d� 	IsChecked 5?   %   �� $ MenuToggleButton��$ 	IsChecked� �� Mode$ TwoWay=��� 5@      -   5         ��Name$ DemoItemsListBox��5@   "   $��	0 16 0 16q�6<   ��5B      �� 5C   "    �� DataType$ domain:DemoItem��6/   .R�5D   &   �� $��	32 0 32 0q�6F   ��60   �� *Name+6F   5E   #   5G      5H      .��5J      ]� .+�5K      (  "MaterialDesignThemes.Wpf.ColorZone  $��16q�6/   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth2=�6<      Mode$ 
PrimaryMid=�5L   -   $	��Top=�6?   .��5M      ]� .+�5N      d� -   5         d�Name$ MenuToggleButton��5O   )   #��[ 5N   +   $ FalseY�6h   5O   )   '  !MaterialDesignThemes.Wpf.PopupBox  5P      $��Right=�66       PlacementMode$  BottomAndAlignRightEdges=�6M   !   	StaysOpen$! False��6v   "   PopupContent." 5Q   "   �� -   5        # ��Name$# settingPane��5Q   -   .+�5U   &   �� �� 5V   &   -   5        $ ��Name$$ exitBtn��5V   -   $
��Exit��6>   6M   5W   #   5X      �� 5Y      $��Center=�6(   $��Center=�6E   $��22(�6`   ��5Z   $   �� $ 
mainWindow��$ Title�6Y   5[      5\      5]      5^      5_      5`      5a      