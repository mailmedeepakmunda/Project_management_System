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
    public partial class MASTER_ENTRY : MetroFramework.Forms.MetroForm
    {
        private OleDbConnection cn = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();

        public MASTER_ENTRY()
        {
            InitializeComponent();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\PMS\PMS\PMS\PMS.accdb";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MASTER_ENTRY_Load(object sender, EventArgs e)
        {
            
        }

        private void mbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                string qry = "INSERT INTO master_tbl(state, bank_name, branch_name, branch_code, lan_ip, lc_dtls, rf_meta, rf_lsi, rf_wan, 4g_meta, 4g_lsi, 4g_wan, 4g_sim_ip, rf_enoc, 4g_enoc, rf_rem, 4g_rem) Values('" + mtxtState.Text + "','" + mtxtBankName.Text + "','" + mtxtBranchName.Text + "','" + mtxtBcode.Text + "','" + mtxtLanip.Text + "','" + mtxtLcDtls.Text + "','" + mtxtRfMeta.Text + "','" + mtxtRfLsi.Text + "','" + mtxtRfWan.Text + "','" + mtxt4gMeta.Text + "','" + mtxt4gLsi.Text + "','" + mtxt4gwan.Text + "','" + mtxt4gsimip.Text + "','" + mtxtRfenoc.Text + "','" + mtxt4genoc.Text + "','" + mtxtRFremarks.Text + "','" + mtxt4gremark.Text + "')";
                cmd.CommandText = qry;
                cmd.ExecuteNonQuery();
                MessageBox.Show("MASTER_ENTRY_SUBMITTED");
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void mbtnSearch_Click(object sender, EventArgs e)
        {
            search_pms frm3 = new search_pms();
            frm3.Show();
        }

        private void mbtnMasterView_Click(object sender, EventArgs e)
        {
            CView frm4 = new CView();
            frm4.Show();
        }
    }
}
