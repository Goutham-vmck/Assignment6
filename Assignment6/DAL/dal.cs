using System;
using System.Collections.Generic;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace Assignment6.DAL
{
    public class dal
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        public MySqlConnection con = new MySqlConnection();
        public MySqlCommand cmd = new MySqlCommand();

        public dal()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new MySqlConnection(conn);
            cmd.Connection = con;
        }
        public MySqlConnection GetCon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public DataTable Getdeprt(BAL.bal obj)
        {
            string s = "SELECT * FROM department";
            MySqlCommand cmd = new MySqlCommand(s, GetCon());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable desigview(BAL.bal obj)
        {
            string s = "select * from designation td inner join department dt on td.departmentId=dt.departmentId";
            MySqlCommand cmd = new MySqlCommand(s, GetCon());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int desgUpdate(BAL.bal obj)
        {
            string s = "update designation set DesignationName='" + obj.Desgination + "' where DesignationId='" + obj.DesgId + "'";
            MySqlCommand cmd = new MySqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();

        }

        public int Deletedesig(BAL.bal obj)
        {
            string s = "delete from designation where DesignationId='" + obj.DesgId + "'";
            MySqlCommand cmd = new MySqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public int InsertDesig(BAL.bal obj)
        {
            string qry = "insert into designation(DesignationName,DepartmentId) values('" + obj.Desgination + "','" + obj.DepId + "')";
            MySqlCommand cmd = new MySqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }
    }
}