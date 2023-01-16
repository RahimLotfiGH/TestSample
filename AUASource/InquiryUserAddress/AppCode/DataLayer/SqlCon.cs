using System.Data;
using System.Data.SqlClient;

namespace InquiryUserAddress.AppCode.DataLayer
{
    public class SqlCon
    {
        //TODO:  read  from config
        private string _strCon = "Server=.;Database=ApSampleDb;Trusted_Connection=True;";
        private SqlConnection Con;


        public SqlConnection OpenCon()
        {
            if (Con == null)
                Con = new SqlConnection(_strCon);

            if (Con.State != ConnectionState.Open)
                Con.Open();


            return Con;
        }

        public void CloseCon()
        {
            if (Con.State != ConnectionState.Closed)
                Con.Close();

        }
    }
}

