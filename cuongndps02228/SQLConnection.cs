using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace cuongndps02228
{

     public class SQLConnection
    {
         public static string chuoiketnoi = "Data Source = MRDUNG-PC; database = QLDienthoai; Integrated Security=True";


public static int executeNonquery(string strQuery)
     {
         SqlConnection conn = new SqlConnection(chuoiketnoi); 

         conn.Open(); 

         SqlCommand command = new SqlCommand(strQuery, conn); 

         try
         {
             int result = command.ExecuteNonQuery(); 
             conn.Close(); 

             return result;
         }
         catch (Exception ex)
         {
             throw ex; 
         }
     }

     public static DataTable executeQuery(string strQuery)
     {
         DataSet ds = new DataSet(); 
         SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

         SqlConnection conn = new SqlConnection(chuoiketnoi);
         conn.Open();

         SqlCommand command = new SqlCommand(strQuery, conn);
         sqlDataAdapter.SelectCommand = command; 

         sqlDataAdapter.Fill(ds); 
         conn.Close(); 

         return ds.Tables[0]; 

     }

         public static string laymaloai(string tenloai)
     {
         string query = "Select Maloai from Phanloai where Tenloai = N'" + tenloai + "'";
         DataTable dt = SQLConnection.executeQuery(query);
         return dt.Rows[0].ItemArray[0].ToString();
     }
         public static string laytenloai(string maloai)
         {
             string query = "Select Tenloai from Phanloai where Maloai = '" + maloai + "'";
             DataTable dt = SQLConnection.executeQuery(query);
             return dt.Rows[0].ItemArray[0].ToString();
         }
  }
}
    
