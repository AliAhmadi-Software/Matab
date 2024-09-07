using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Matab
{
    public partial class FrmListFile : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        public FrmListFile()
        {
            InitializeComponent();
        }
        public void Display()
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectFileS", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGFileS.DataSource = dt;
        }

        private void FrmListFile_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void txtNameK_TextChanged(object sender, EventArgs e)
        {
            if (txtNameK.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SelectFileSWN", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@namek", txtNameK.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGFileS.DataSource = dt;
            }
            else
            {
                Display();
            }
        }

        private void txtCodeF_TextChanged(object sender, EventArgs e)
        {
            if (txtCodeF.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SelectFileSWC", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@codef", txtCodeF.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGFileS.DataSource = dt;
            }
            else
            {
                Display();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectFileSWD", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@dateafter", MaskDateAfter.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGFileS.DataSource = dt;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("ReportFileS", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@dateafter", MaskDateAfter.Text);
            DataTable ReportFileS = new DataTable();
            da.Fill(ReportFileS);
            // 
            StiFileS.Load("ReportFileS.mrt");
            StiFileS.RegData(ReportFileS);
            StiFileS.Show();
        }
    }
}
