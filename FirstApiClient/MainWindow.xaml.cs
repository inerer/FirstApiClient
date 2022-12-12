using FirstApiClient.Pages;

namespace FirstApiClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:5241/");
            //var responce = await client.GetAsync("Category");
            //var result = await responce.Content.ReadAsStringAsync();
            //var jsonProduct = JsonSerializer.Deserialize<List<Category>>(result);
            //categories = jsonProduct.ToList();
            //AllCategory.ItemsSource = jsonProduct;
            MainFrame.Navigate(new ClientPage());
        }
    }
}