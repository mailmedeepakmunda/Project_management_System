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
    public partial class view_lsi : MetroFramework.Forms.MetroForm
    {
        private OleDbConnection cn = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        public view_lsi()
        {
            InitializeComponent();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\PMS\PMS\PMS\PMS.accdb";
        }

        // filter for lsi_search
        private void lsi_search_filter()
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                string qry1 = "SELECT [state], [bank_name], [branch_name], [branch_code], [lan_ip], [lc_dtls], [rf_lsi], [4g_lsi], [rf_enoc], [4g_enoc], [rf_rem], [4g_rem] FROM master_tbl WHERE [rf_lsi] LIKE '%" + txtSearchLSI.Text + "%' OR [4g_lsi] LIKE '%" + txtSearchLSI.Text + "%' ";
                cmd.CommandText = qry1;
                OleDbDataAdapter da1 = new OleDbDataAdapter();
                DataTable dt1 = new DataTable();
                da1.SelectCommand = cmd;
                dt1.Clear();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                OleDbDataReader dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    mtxtState.Text = Convert.ToString(dr1["state"]);
                    mtxtBankName.Text = dr1["bank_name"].ToString();
                    mtxtBranchName.Text = dr1["branch_name"].ToString();
                    mtxtBcode.Text = dr1["branch_code"].ToString();
                    mtxtLanip.Text = dr1["lan_ip"].ToString();
                    mtxtLcDtls.Text = dr1["lc_dtls"].ToString();
                    mtxtRfLSI.Text = dr1["rf_lsi"].ToString();
                    mtxt4gLSI.Text = dr1["4g_lsi"].ToString();
                    mtxtRfenoc.Text = dr1["rf_enoc"].ToString();
                    mtxt4genoc.Text = dr1["4g_enoc"].ToString();
                    mtxtRfrem.Text = dr1["rf_rem"].ToString();
                    mtxt4gRem.Text = dr1["4g_rem"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lsi_search_filter();
        }
    }
}
