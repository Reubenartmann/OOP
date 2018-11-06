using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace API_crud_practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        HttpClient client = new HttpClient();


        public MainWindow()
        {
            InitializeComponent();
            List<string> todoList = new List<string>();
            var userInput = TxtInput.Text;
        }

        

        private async void BtnGet_Click(object sender, RoutedEventArgs e)
        {
            client.BaseAddress = new Uri("http://todoapiswin.azurewebsites.net");
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response = await client.GetAsync("/api/Todo?apiKey=" + TxtInput.Text);
                response.EnsureSuccessStatusCode(); // Throw on error code. 
                var toDos = await response.Content.ReadAsAsync<TodoItem>();
                //LstTasks.Visibility = Visibility.Visible;
                LstTasks.DataContext = toDos;
            }
            catch (Exception)
            {
                MessageBox.Show("Api Key not Found");
            }
        }

        private async void BtnPost_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var todo = new TodoItem()
                {
                    Task = TxtInput.Text,

                };
                var response = await client.PostAsJsonAsync("/api/Todos/", todo);
                response.EnsureSuccessStatusCode(); // Throw on error code. 
                MessageBox.Show("Task Added Successfully", "Result", MessageBoxButton.OK, MessageBoxImage.Information);
                LstTasks.ItemsSource = await GetAllTodos();
                LstTasks.ScrollIntoView(LstTasks.ItemContainerGenerator.Items[LstTasks.Items.Count - 1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Task not Added, May be due to Duplicate ID");
            }
        }



        public async Task<IEnumerable<TodoItem>> GetAllTodos()
        {
            HttpResponseMessage response = await client.GetAsync("/api/student");
            response.EnsureSuccessStatusCode(); // Throw on error code. 
            var todos = await response.Content.ReadAsAsync<IEnumerable<TodoItem>>();
            return todos;
        }


        public class TodoItem
        {
            public string Task { get; set; }
            public string Id { get; set; }
        }







        private void TxtInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LstTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
