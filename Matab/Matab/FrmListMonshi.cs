using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;


namespace Matab
{
    public partial class FrmListMonshi : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        public FrmListMonshi()
        {
            InitializeComponent();
        }
        public void Display()
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectMonshi", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGListMonshi.DataSource = dt;
        }
        private void FrmListMonshi_Load(object sender, EventArgs e)
        {
            Display();
            //PersianCalendar p = new PersianCalendar();
           // MaskSalary.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString() + p.GetDayOfMonth(DateTime.Now).ToString();
        }

        private void txtNameK_TextChanged(object sender, EventArgs e)
        {
            if (txtNameK.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SearchMonshiWName", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@name", txtNameK.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGListMonshi.DataSource = dt;
            }
            else
            {
                Display();
            }
        }

        private void txtCodeMonshi_TextChanged(object sender, EventArgs e)
        {
            if (txtCodeMonshi.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SearchMonshiWID", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Id", txtCodeMonshi.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGListMonshi.DataSource = dt;
            }
            else
            {
                Display();
            }
        }

        private void MaskSalary_TextChanged(object sender, EventArgs e)
        {
            if (MaskSalary.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SearchMonshiWDateS", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@DateS", MaskSalary.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGListMonshi.DataSource = dt;
            }
            else
            {
                Display();
            }
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا میخواهید این منشی با این مشخصات را پرداخت نمایید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("AddPay", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idmonshi", DataGListMonshi.CurrentRow.Cells[0].Value);
                cmd.Parameters.AddWithValue("@namekh",DataGListMonshi.CurrentRow.Cells[2].Value);
                cmd.Parameters.AddWithValue("@salary",DataGListMonshi.CurrentRow.Cells[7].Value);
                cmd.Parameters.AddWithValue("@date",DataGListMonshi.CurrentRow.Cells[8].Value);
                cmd.Parameters.AddWithValue("@tozih", DataGListMonshi.CurrentRow.Cells[9].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //****************
                MessageBox.Show("حقوق منشی پرداخت شد");
            }
        }
    }
}
           