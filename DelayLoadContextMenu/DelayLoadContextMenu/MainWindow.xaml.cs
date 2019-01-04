using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace DelayLoadContextMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isSubMenuItemOpened;

        public MainWindow()
        {
            InitializeComponent();

            SubMenuItems = new ObservableCollection<FrameworkElement>();
            InitSubMenuItems();
        }

        public bool IsSubMenuItemOpened
        {
            get
            {
                return _isSubMenuItemOpened;
            }
            set
            {
                if (_isSubMenuItemOpened != value)
                {
                    _isSubMenuItemOpened = value;

                    if (_isSubMenuItemOpened)
                    {
                        CreateSubMenuItems();
                    }
                    else
                    {
                        InitSubMenuItems();
                    }
                }
            }
        }

        public ObservableCollection<FrameworkElement> SubMenuItems
        {
            get;
            private set;
        }

        private void InitSubMenuItems()
        {
            SubMenuItems.Clear();
            // It needs to add a empty submenuitem firstly to make SubMenuItems has submenuitems.
            SubMenuItems.Add(new MenuItem());
        }

        private void CreateSubMenuItems()
        {
            SubMenuItems.Clear();
            SubMenuItems.Add(new MenuItem() { Header = "subMenu123" });
            SubMenuItems.Add(new MenuItem() { Header = "subMenu456" });
            SubMenuItems.Add(new MenuItem() { Header = "subMenu789" });
        }
    }
}
