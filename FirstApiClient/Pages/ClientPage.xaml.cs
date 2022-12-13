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
        private Client client = new();
        private readonly HttpClient _client = new();
        private readonly List<Client> _clients = new();
        public ClientPage()
        {
            InitializeComponent();
            SetConnectOpt();
            DisplayProducts();
        }

        private async Task DisplayProducts()
        {
            await GetClient();
            ClientListView.ItemsSource = _clients;
        }

        private void SetConnectOpt()
        {
            _client.BaseAddress = new Uri("https://localhost:7120/api/");
            _client.DefaultRequestHeaders.Accept.Clear();
        }

        private async Task GetClient()
        {
            var response = await _client.GetStringAsync("Client/GetClient?id=1");
            client = JsonSerializer.Deserialize<Client>(response);
            _clients.Add(client);
        }
    }
}