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

namespace Northwind_Windows_Application
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();

            //DataGridTemelKonular();
            //DataGridDataBound();
            //DataGridDataTableDataBound();
            //DataGridCollectionToDataTableDataBound();
            UzunYolVeritabaniBaglama();
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
    }
    class Kategori
    {
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Aciklama { get; set; }
    }
}
