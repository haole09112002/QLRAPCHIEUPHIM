﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DBHelper
    {
        private static DBHelper _Instance;
        private SqlConnection cnn;
        private DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string cnnstr = "";
                    _Instance = new DBHelper(cnnstr);
                }
                return _Instance;
            }
            private set { }
        }
        public void ExcuteDB(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                if (parameter != null)
                {
                    string[] listData = query.Split(' ');
                    int i = 0;
                    foreach (string item in listData)
                    {
                        if (item.Contains('@'))
                        {
                            SqlParameter unitsParam = cmd.Parameters.AddWithValue(item, parameter[i]);
                            if (parameter[i] == null)
                            {
                                unitsParam.Value = DBNull.Value;
                            }
                            i++;
                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cnn.Open();
                da.Fill(data);
                cnn.Close();
                //  }
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi" + e.Message);
            }
            return data;
        }
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                if (parameter != null)
                {
                    string[] listData = query.Split(' ');
                    int i = 0;
                    foreach (string item in listData)
                    {
                        if (item.Contains('@'))
                        {
                            SqlParameter unitsParam = cmd.Parameters.AddWithValue(item, parameter[i]);
                            if (parameter[i] == null)
                            {
                                unitsParam.Value = DBNull.Value;
                            }
                            i++;
                        }
                    }
                }

                cnn.Open();
                data = cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi" + e.Message);
            }
            return data;
        }


        public object ExcuteScalar(string query, Object[] parameter = null)
        {
            object data = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                if (parameter != null)
                {
                    string[] listData = query.Split(' ');
                    int i = 0;
                    foreach (string item in listData)
                    {
                        if (item.Contains('@'))
                        {
                            SqlParameter unitsParam = cmd.Parameters.AddWithValue(item, parameter[i]);
                            if (parameter[i] == null)
                            {
                                unitsParam.Value = DBNull.Value;
                            }
                            i++;
                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cnn.Open();
                data = cmd.ExecuteScalar();
                cnn.Close();
                //  }
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi" + e.Message);
            }
            return data;
        }
    }
}
