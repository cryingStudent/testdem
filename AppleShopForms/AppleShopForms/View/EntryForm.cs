using System;
using AppleShopForms.Service;
using System.Windows.Forms;
using System.Data.SqlClient;
using AppleShopForms.Controllers;
using AppleShopForms.Models;

namespace AppleShopForms.View
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            MainController controller = new MainController();
            SqlConnection connection = new SqlConnection(controller.ConnectionDataInfo());


            UserProvider provider = new UserProvider(connection);


            string password = provider.GetHashedPassword(passwordTextBox.Text);
            User searchClient = provider.SearchClient(loginTextBox.Text);
            var checkAccount = provider.CheckAccount(searchClient, password);

            SearchForm searchForm = new SearchForm();


            if (checkAccount && searchClient.Status == "admin")
                return;

            if (checkAccount && searchClient.Status == "client")
                searchForm.ShowDialog();

        }

        private void EntryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
