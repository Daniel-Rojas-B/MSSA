using System.Security.AccessControl;
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
using Assignment11_1.Data;

namespace Assignment11_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BookContext dbContext;
        Book newBook = new Book();
        public MainWindow(BookContext _dbcontext)
        {
            this.dbContext = _dbcontext;
            InitializeComponent();
            GetBooks();
            AddBookGrid.DataContext = newBook;
        }
        private void GetBooks()
        {
            Book_Data_Grid.ItemsSource = this.dbContext.Books.ToList();
        }
        private void AddBook(object sender, RoutedEventArgs e)
        {
            this.dbContext.Books.Add(newBook);
            this.dbContext.SaveChanges();
            GetBooks();
            newBook = new Book();
            AddBookGrid.DataContext = newBook;
        }
        private void UpdateBookForEdit(object sender, RoutedEventArgs e)
        {

        }
        private void DeleteBook(object sender, RoutedEventArgs e)
        {
            var book = (sender as FrameworkElement).DataContext as Book;
            this.dbContext.Books.Remove(book);
            this.dbContext.SaveChanges();
            GetBooks();
        }
    }
}