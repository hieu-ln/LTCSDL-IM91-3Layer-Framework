using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using LTCSDL.IM91.DTO;

namespace LTCSDL.IM91.DAL
{
    public class CategoryDAL
    {
        private SqlConnection cnn;
        private SqlCommand cmd;

        public CategoryDAL()
        {
            string cnStr = "Server = localhost; Database = Northwind; User id = sa; password = Password123;";
            cnn = new SqlConnection(cnStr);
        }

        public List<Category> GetAll()
        {
            string sqlStr = "select CategoryID, CategoryName, [Description]  from Categories;";
            List<Category> lst = new List<Category>();
            try
            {
                cnn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = sqlStr;
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Category cat = new Category();
                    cat.CategoryID = int.Parse(reader["CategoryID"].ToString());
                    cat.CategoryName = reader["CategoryName"].ToString();
                    cat.Description = reader["Description"].ToString();
                    lst.Add(cat);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                lst = null;
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return lst;
        }
    }
}
