using System.Windows;
using System.Windows.Controls;

namespace ShopFun.Models
{
    /// <summary>
    /// Interaction logic for Items.xaml
    /// </summary>
    public partial class Items : UserControl
    {
        public Image _img;
        public string _brandName;
        public double _brandPrice;
        public Items()
        {
            InitializeComponent();
        }

        public Image Image
        {
            get { return _img; }
            set { _img = value; itemImage = value; }
        }
        public string BrandName
        {
            get { return _brandName; }
            set { _brandName = value; itemName.Content = value; }
        }
        public double BrandPrice
        {
            get { return _brandPrice; }
            set { _brandPrice = value; itemPrice.Content = "$ " + value; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
