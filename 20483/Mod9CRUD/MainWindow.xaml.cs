using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Mod9CRUD.Data;

namespace Mod9CRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductContext dbContext;
        public MainWindow(ProductContext _dbcontext)
        {
            this.dbContext = _dbcontext;
            InitializeComponent();
            GetProducts();
        }
        private void GetProducts()
        {
            ProductDG.ItemsSource = this.dbContext.Products.ToList();
        }
        private void DeleteProduct(object  sender, RoutedEventArgs e)
        {
            var product =(sender as FrameworkElement).DataContext as Product;
            this.dbContext.Products.remove(product);
            this.dbContext.SaveChanges();
            GetProducts();
        }
    }
}