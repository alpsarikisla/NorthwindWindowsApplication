using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }

        #region Category Functions

        //List
        public List<Category> GetCategoryList()
        {
            List<Category> categories = new List<Category>();
            try
            {
                cmd.CommandText = "SELECT * FROM Categories";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category();
                    c.CategoryID = reader.GetInt32(0);
                    c.CategoryName = reader.GetString(1);
                    c.Description = reader.GetString(2);
                    categories.Add(c);
                }
                return categories;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable GetCategoryDataTable()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM Categories";
            cmd.Parameters.Clear();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
        }

        public bool AddCategory(Category cat)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Categories(CategoryNAme,Description) VALUES(@cn,@d)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cn", cat.CategoryName);
                cmd.Parameters.AddWithValue("@d", cat.Description);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Category GetCategory(int id)
        {
            try
            {
                Category c = new Category();
                cmd.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    c.CategoryID = reader.GetInt32(0);
                    c.CategoryName = reader.GetString(1);
                    c.Description = reader.IsDBNull(2) ? "" : reader.GetString(2);
                }
                return c;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteCategory(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Categories WHERE CategoryID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdateCategory(Category c)
        {
            try
            {
                cmd.CommandText = "UPDATE Categories SET CategoryName = @cn, Description = @dc WHERE CategoryID =@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cn", c.CategoryName);
                cmd.Parameters.AddWithValue("@dc", c.Description);
                cmd.Parameters.AddWithValue("@id", c.CategoryID);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }


        #endregion

        #region Product Functions

        public List<Product> GetProductList()
        {
            List<Product> Products = new List<Product>();
            try
            {
                cmd.CommandText = "SELECT P.ProductID, P.Discontinued, P.ProductName, P.CategoryID, P.SupplierID,P.QuantityPerUnit, P.UnitsInStock, P.UnitsOnOrder, P.UnitPrice, P.ReorderLevel, C.CategoryName, S.CompanyName FROM Products AS P JOIN Categories AS C ON P.CategoryID=C.CategoryID JOIN Suppliers AS S ON P.SupplierID = S.SupplierID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Products.Add(new Product()
                    {
                        ProductID = reader.GetInt32(0),
                        Discontinued = reader.GetBoolean(1),
                        DiscontinuedStr = !reader.GetBoolean(1) ? "Evet" : "Hayır",
                        ProductName = reader.GetString(2),
                        CategoryID = reader.GetInt32(3),
                        SupplierID = reader.GetInt32(4),
                        QuantityPerUnit = reader.IsDBNull(5) ? "-" : reader.GetString(5),
                        UnitsInStock = reader.GetInt16(6),
                        UnitsOnOrder = reader.GetInt16(7),
                        UnitPrice = reader.GetDecimal(8),
                        ReorderLevel = reader.GetInt16(9),
                        Category = reader.GetString(10),
                        Supplier = reader.GetString(11)
                    });
                }
                return Products;
            }
            finally
            {
                con.Close();
            }
        }

        //public List<Product> GetProductDataTable()
        //{

        //}

        #endregion
    }
}
