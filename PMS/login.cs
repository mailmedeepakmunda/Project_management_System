using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace PMS
{
    public partial class login : MetroFramework.Forms.MetroForm
    {
        private OleDbConnection cn = new OleDbConnection();
        public login()
        {
            InitializeComponent();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\PMS\PMS\PMS\PMS.accdb";
        }

        private void mbtnLgn_Click(object sender, EventArgs e)
        {
            try
            {
                string qry;
                cn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;

                qry = "SELECT * FROM admin WHERE user = '" + mtxtUsr.Text + "' AND pwd = '" + mtxtPwd.Text + "'";
                cmd.CommandText = qry;
                OleDbDataReader dr = cmd.ExecuteReader();

                int count = 0;
                while (dr.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MASTER_ENTRY frm2 = new MASTER_ENTRY();
                    frm2.Show();
                    //cn.Dispose();
                    this.Hide();
                }
                else if (count > 1)
                {
                    MessageBox.Show("DUPLICATE AUTHENTICATION");
                }
                else
                {
                    MessageBox.Show("WRONG CREDENTIALS");
                    mtxtUsr.Focus();
                    return;
                }
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
        }

        private void mbtnCncl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                mlblStatus.Text = "Connection_Establishes";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            cn.Close();
        }
    }
}
