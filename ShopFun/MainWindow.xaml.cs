using System.Windows;

namespace ShopFun
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Models.Items> itemsList = new List<Models.Items>();

        public MainWindow()
        {
            InitializeComponent();
            populateItems();

        }
        public void populateItems()
        {
            for (int i = 0; i < 5; i++)
            {

                Models.Items itemsControl = new Models.Items();
                itemsControl.BrandName = "Lacoste Bag ";
                itemsControl.BrandPrice = 100 * (i + 1);
                itemsList.Add(itemsControl);
            }
            foreach (var item in itemsList)
            {
                stackItems.Children.Add(item);
            }
        }
        private void userButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}