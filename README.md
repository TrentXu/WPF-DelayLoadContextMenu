# WPF-DelayLoadContextMenu
Delay load SubMenuItems in the WPF ContextMenu

It uses "IsSubmenuOpen" dp of MenuItem to implement delay load SubMenuItems, when user moves mouse over a menuitem which has sub-menuitems, the "IsSubmenuOpen" value will become "true".

Binding the ItemSource of menuitem with SubMenuItems property in the DataContext.

Binding the "IsSubmenuOpen" dp with a property "IsSubMenuItemOpened" in the DataContext, when IsSubMenuItemOpened becomes true, generate the related sub-menuitems, when it becomes false, initlize the related sub-menuitems.
