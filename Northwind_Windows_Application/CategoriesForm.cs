using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace Northwind_Windows_Application
{
    public partial class CategoriesForm : Form
    {
        int rowindex = -1;
        public CategoriesForm()
        {
            InitializeComponent();

            //DataGridTemelKonular();
            //DataGridDataBound();
            //DataGridDataTableDataBound();
            //DataGridCollectionToDataTableDataBound();
            //UzunYolVeritabaniBaglama();
            dataGridView1.ReadOnly = true;
        }
        public void DataGridTemelKonular()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Kolon 1";
            dataGridView1.Columns[1].Name = "Kolon 2";
            dataGridView1.Columns[2].Name = "Kolon 3";

            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;

            dataGridView1.Rows.Add("1", "Murtaza", "Şuayipoğlu");
        }
        public void DataGridDataBound()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Isim";
            dataGridView1.Columns[2].Name = "Açıklama";

            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            List<Kategori> kategoriler = new List<Kategori>();
            kategoriler.Add(new Kategori() { ID = 1, Isim = "Sebzeler", Aciklama = "Brokoli, prasa vs." });
            kategoriler.Add(new Kategori() { ID = 2, Isim = "Şarküteri", Aciklama = "Peynir, Zeytin vs." });
            kategoriler.Add(new Kategori() { ID = 3, Isim = "Giyim", Aciklama = "Ayakkabı, Bere" });

            foreach (Kategori item in kategoriler)
            {
                dataGridView1.Rows.Add(item.ID, item.Isim, item.Aciklama);
            }

        }
        public void DataGridDataTableDataBound()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Isim");
            dt.Columns.Add("Açıklama");

            DataRow row = dt.NewRow();
            row["ID"] = "1";
            row["Isim"] = "Sebzeler";
            row["Açıklama"] = "Açıklama işte";
            dt.Rows.Add(row);

            dataGridView1.DataSource = dt;

        }
        public void DataGridCollectionToDataTableDataBound()
        {
            List<Kategori> kategoriler = new List<Kategori>();
            kategoriler.Add(new Kategori() { ID = 1, Isim = "Sebzeler", Aciklama = "Brokoli, prasa vs." });
            kategoriler.Add(new Kategori() { ID = 2, Isim = "Şarküteri", Aciklama = "Peynir, Zeytin vs." });
            kategoriler.Add(new Kategori() { ID = 3, Isim = "Giyim", Aciklama = "Ayakkabı, Bere" });

            BindingList<Kategori> araci = new BindingList<Kategori>(kategoriler);
            dataGridView1.DataSource = new BindingSource(araci, null);
        }
        public void UzunYolVeritabaniBaglama()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Data Source=DESKTOP-6NIP90O\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories";
            baglanti.Open();
            SqlDataReader reader = komut.ExecuteReader();
            List<Kategori> kategoriler = new List<Kategori>();
            while (reader.Read())
            {
                Kategori k = new Kategori();
                k.ID = reader.GetInt32(0);
                k.Isim = reader.GetString(1);
                k.Aciklama = reader.GetString(2);
                kategoriler.Add(k);
            }
            baglanti.Close();

            BindingList<Kategori> araci = new BindingList<Kategori>(kategoriler);
            dataGridView1.DataSource = new BindingSource(araci, null);
        }

        DataModel dm = new DataModel();
        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = dm.GetCategoryList();
            dataGridView1.DataSource = dm.GetCategoryList();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Name.Text))
            {
                Category c = new Category();
                c.CategoryName = tb_Name.Text;
                c.Description = tb_description.Text;
                if (dm.AddCategory(c))
                {
                    MessageBox.Show("Kategori Eklendi", "Başarılı");
                    dataGridView1.DataSource = dm.GetCategoryList();
                }
                else
                {
                    MessageBox.Show("Kategori Eklerken Hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (rowindex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowindex].Selected = true;
                    contextMenuStrip1.Show(dataGridView1, e.X, e.Y);
                }
            }
        }

        private void TSMI_edit_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["CategoryID"].Value);
                Category c = dm.GetCategory(id);
                if (c != null)
                {
                    tb_ID.Text = c.CategoryID.ToString();
                    tb_Name.Text = c.CategoryName;
                    tb_description.Text = c.Description;
                    btn_edit.Visible = true;
                }
            }
        }

        private void TSMI_Delete_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["CategoryID"].Value);
                string name = dataGridView1.Rows[rowindex].Cells["CategoryName"].Value.ToString();
                if (MessageBox.Show(name + " kategorisini silmek istiyor musunuz", "Kategori Siliniyor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dm.DeleteCategory(id);
                }
                dataGridView1.DataSource = dm.GetCategoryList();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Name.Text))
            {
                Category c = new Category()
                {
                    CategoryID = Convert.ToInt32(tb_ID.Text),
                    CategoryName = tb_Name.Text,
                    Description = tb_description.Text
                };
                if (dm.UpdateCategory(c))
                {
                    MessageBox.Show("Kategori Düzenlendi", "Başarılı");
                    tb_ID.Text = tb_Name.Text = tb_description.Text = "";
                    btn_edit.Visible = false;
                    dataGridView1.DataSource = dm.GetCategoryList();
                }
                else
                {
                    MessageBox.Show("Kategori Düzenlenirken Hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    class Kategori
    {
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Aciklama { get; set; }
    }
}
