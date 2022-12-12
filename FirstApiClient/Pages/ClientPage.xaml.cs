using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using FirstApiClient.Models.Client;

namespace FirstApiClient.Pages
{
    public partial class ClientPage : Page
    {
        List<Client> clients = new(); 
        HttpClient client = new HttpClient();
        public ClientPage()
        {
            InitializeComponent();
            SetConnectOpt();
            DisplayProducts();
        }
        
        public async Task DisplayProducts()
        {
            await GetClient();
            ClientListView.ItemsSource = clients;
        }

        public void SetConnectOpt()
        {
            client.BaseAddress = new Uri("https://localhost:7120/api/");
            client.DefaultRequestHeaders.Accept.Clear();
        }

        public async Task GetClient()
        {
            var response = await client.GetAsync("Client/GetClient?id=1");
            var result = await response.Content.ReadAsStringAsync();
            clients = JsonSerializer.Deserialize<List<Client>>(result);
            MessageBox.Show(clients.ElementAt(0).LastName);
        }
    }
}