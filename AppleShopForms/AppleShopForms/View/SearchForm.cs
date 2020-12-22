using AppleShopForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AppleShopForms.Controllers;
using AppleShopForms.Service;

namespace AppleShopForms.View
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void productsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            MainController controller = new MainController();
            SqlConnection connection = new SqlConnection(controller.ConnectionDataInfo());

            AssortmentProvider assortmentProvider = new AssortmentProvider(connection);

            productsGridView.DataSource = assortmentProvider.ShowAll();

        }


        private int openButton_Click(object sender, EventArgs e)
        {
            var selRows = -1;
            AddForm addForm = new AddForm();

            selRows = productsGridView.CurrentRow.Index;
            var selAssortment = productsGridView.Rows[selRows].DataBoundItem as Assortment;
            var idAssortment = selAssortment.Id;

            if (selRows == -1)
                return selRows;

            else
                addForm.ShowDialog();


            return idAssortment;
        }
    }
}
