using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind_Windows_Application
{
    public partial class ProductsForm : Form
    {
        DataModel dm = new DataModel();
        public ProductsForm()
        {
            InitializeComponent();
        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            cb_Category.ValueMember = "CategoryID";
            cb_Category.DisplayMember = "CategoryName";
            cb_Category.DataSource = dm.GetCategoryList();

            dataGridView1.DataSource = dm.GetProductList();

        }
    }
}
