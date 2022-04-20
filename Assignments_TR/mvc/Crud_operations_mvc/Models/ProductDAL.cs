using System;
using System.Data.SqlClient;
using Crud_operations_mvc.Controllers;


namespace Crud_operations_mvc.Models
{
    public class ProductDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
      
        public ProductDAL()
        {
            con = new SqlConnection(StartUp.ConnectionString);
        }
        public List<Product> GetAllProduct()
        {
            List<Product> list = new List<Product>();
            String qry = " select * from Product_Details";
            cmd = new SqlCommand(qry, con);
            con.Open();
            dr = cmd.ExecuteReader();
            list = ArrangeList(dr);
            con.Close();
            return list;
           
        }
        public int save()
        {
            return 0;
        }
        public List<Product>? ArrangeList(SqlDataReader dr)
        {
            List<Product> li = new List<Product>();
            if(dr.HasRows)
            {
                while (dr.Read())
                {
                    Product p = new Product();
                    p.id = Convert.ToInt32(dr["Product_id"]);
                    p.pname = dr["Product_name"].ToString();
                    p.price = Convert.ToDecimal(dr["Product_price"]);
                    p.quantity = Convert.ToInt32(dr["productquantity"]);
                    li.Add(p);
                }
                return li;
            }
            else
            {
                return null;
            }
        }
    }
}
