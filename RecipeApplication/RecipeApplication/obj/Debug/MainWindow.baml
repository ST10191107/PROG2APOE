   M S B A M L   `   `   `  ����  RecipeApplication"    RecipeApplication.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Recipe Application��5   	   $	��450��6$   $	��600��61   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $��* �6   .+�5   
   �� $��Recipe Name:��6   �� 5   
   -   5         ��Name$ txtRecipeName��5      $��0��6)   $��	100,0,0,0q�66   �� 5   
   $��1��6   $��Ingredients��6    .��5      �� .+�5      �� $��Ingredient Name:��6   �� 5      -   5        $ txtIngredientName��5      �� 5      $��	Quantity:��6   �� 5      -   5        $ txtIngredientQuantity��5      �� 5      $��Unit:��6   �� 5      -   5        $ txtIngredientUnit��5      �� 5      -   5        $��Add Ingredient��5      62   5      5      �� 5   
   $��2��6   $��Steps��6    .��5      �� .+�5      �� $��Step Description:��6   �� 5       -   5        $ txtStepDescription��5       �� 5"      -   5        $��Add Step��5"      6,   5#      5$      �� 5&   
   -   5         ��Name$ listBoxRecipes��5&      $��3��6*   $��10q�67   �� 5(   
   -	   5        $��
Add Recipe��5(      $��3��6&   $
��Left=�63   $��10q�6N   6Z   �� 5)   
   -
   5        $��	Clear All��5)      $��3��6%   $��Right=�62   $��10q�6N   6Z   5*      5+      