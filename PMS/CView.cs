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
    public partial class CView : MetroFramework.Forms.MetroForm
    {
        private OleDbConnection cn = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        public CView()
        {
            InitializeComponent();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\PMS\PMS\PMS\PMS.accdb";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                string qry2 = "DELETE FROM master_tbl WHERE ID =" + mtxtPID.Text + " ";
                cmd.CommandText = qry2;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Field Delted Successfully");
                OleDbDataAdapter da1 = new OleDbDataAdapter("SELECT * FROM master_tbl ORDER BY ID", cn);
                DataTable dt1 = new DataTable();
                dataGridView1.DataSource = dt1;
                da1.Fill(dt1);
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                string qry1 = "UPDATE master_tbl SET state = '"+mtxtState.Text+"',bank_name='"+mtxtBankName.Text+"',branch_name='"+mtxtBranchName.Text+"',branch_code='"+mtxtBcode.Text+"',lan_ip ='"+mtxtLanip.Text+"',lc_dtls='"+mtxtLcDtls.Text+"',rf_meta='"+mtxtPID.Text+"',rf_lsi='"+mtxtRfLsi.Text+"',rf_wan='"+mtxtRfWan.Text+"',4g_meta='"+mtxt4gMeta.Text+"',4g_lsi='"+mtxt4gLsi.Text+"',4g_wan='"+mtxt4gwan.Text+"',4g_sim_ip='"+mtxt4gsimip.Text+"',rf_enoc='"+mtxtRfenoc.Text+"',4g_enoc='"+mtxt4genoc.Text+"',rf_rem='"+mtxtRFremarks.Text+"',4g_rem='"+mtxt4gremark.Text+"' WHERE ID ="+mtxtPID.Text+" ";
                cmd.CommandText = qry1;
                cmd.ExecuteNonQuery();
                OleDbDataAdapter da1 = new OleDbDataAdapter("SELECT * FROM master_tbl", cn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                MessageBox.Show("Data Updated Successfully");
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void CView_Load(object sender, EventArgs e)
        {
            try 
            {
                cn.Open();
                OleDbDataAdapter da2 = new OleDbDataAdapter("SELECT * FROM master_tbl", cn);
                DataSet ds1 = new DataSet();
                da2.Fill(ds1,"master_tbl");
                dataGridView1.DataSource = ds1.Tables["master_tbl"].DefaultView;
                btnUpdate.Enabled = false;
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                mtxtPID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                mtxtState.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                mtxtBankName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                mtxtBranchName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                mtxtBcode.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                mtxtLanip.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                mtxtLcDtls.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                mtxtrfmeta.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                mtxtRfLsi.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                mtxtRfWan.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                mtxt4gMeta.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                mtxt4gLsi.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                mtxt4gwan.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                mtxt4gsimip.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
                mtxtRfenoc.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
                mtxt4genoc.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
                mtxtRFremarks.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
                mtxt4gremark.Text = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();
            }
            btnUpdate.Enabled = true;
        }
    }
}
