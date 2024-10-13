using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind_Windows_Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TSMI_CategoryForm_Click(object sender, EventArgs e)
        {
            FormOpen(new CategoriesForm());
        }
        private void TSMI_UrunIslem_Click(object sender, EventArgs e)
        {
            FormOpen(new ProductsForm());
        }
        public void FormOpen(Form frm)
        {
            Form[] forms = this.MdiChildren;
            bool isOpen = false;
           
            foreach (Form item in forms)
            {
                if (item.GetType() == frm.GetType())
                {
                    isOpen = true;
                    item.Activate();
                }
            }
            if (!isOpen)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

       
    }
}
