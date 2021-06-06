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
    public partial class search_pms : MetroFramework.Forms.MetroForm
    {
        private OleDbConnection cn = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        public search_pms()
        {
            InitializeComponent();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\PMS\PMS\PMS\PMS.accdb";
        }

        // method for filter for state
        private void filter1()
        {
            
            
                cn.Open();
                cmd.Connection = cn;
                var qry2 = "SELECT DISTINCT bank_name FROM master_tbl WHERE state = '" + cmbSearchState.Text + "'";
                cmd.CommandText = qry2;
                OleDbDataReader dr2 = cmd.ExecuteReader();
                cmbSearchBankName.Text = "";
                cmbSearchBankName.Items.Clear();
                while(dr2.Read())
                {
                    cmbSearchBankName.Items.Add(dr2["bank_name"]);
                }
                cn.Close();
            
        }

        //method for filter for bank_name
        private void filter2()
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                var qry4 = "SELECT DISTINCT branch_code FROM master_tbl WHERE bank_name = '" +cmbSearchBankName.Text + "' ";
                cmd.CommandText = qry4;
                OleDbDataReader dr3 = cmd.ExecuteReader();
                txtSearchBCode.Text = "";
                while(dr3.Read())
                {
                    txtSearchBCode.Text = dr3["branch_code"].ToString();
                }
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        private void mbtnRaMetaSearch_Click(object sender, EventArgs e)
        {
            view_ra frm7 = new view_ra();
            frm7.Show();
        }

        private void mbtnSearchLSI_Click(object sender, EventArgs e)
        {
            view_lsi frm6 = new view_lsi();
            frm6.Show();
        }

        private void mbtnEscMatrix_Click(object sender, EventArgs e)
        {
            Esxm frm5 = new Esxm();
            frm5.Show();
        }

        private void mbtnCview_Click(object sender, EventArgs e)
        {
            CView frm4 = new CView();
            frm4.Show();
        }

        private void mbtnMaster_Click(object sender, EventArgs e)
        {
            MASTER_ENTRY frm2 = new MASTER_ENTRY();
            frm2.Show();
        }

        private void mbtnGo_Click(object sender, EventArgs e)
        {
                cn.Open();
                string qry3 = "SELECT * FROM master_tbl WHERE state = '" + cmbSearchState.Text + "' AND bank_name = '" + cmbSearchBankName.Text + "' AND branch_code = '" + txtSearchBCode.Text + "' ";
                OleDbDataAdapter da1 = new OleDbDataAdapter(qry3, cn);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(da1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0];
                cn.Close();
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                mtxtState.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                mtxtBankName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                mtxtBranchName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                mtxtBcode.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                mtxtLanip.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                mtxtLcDtls.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                mtxtRfMeta.Text= dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                mtxtRfLsi.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                mtxtRfWan.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                mtxt4gMeta.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                mtxt4gLsi.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                mtxt4gwan.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                mtxt4gsimip.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
                mtxtRfenoc.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
                mtxt4genoc.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
                rtfrfRem.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
                rtf4gRem.Text = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            
                cn.Open();
                cmd.Connection = cn;
                string qry1 = "SELECT DISTINCT state FROM master_tbl";
                cmd.CommandText = qry1;
                OleDbDataReader dr1 = cmd.ExecuteReader();
                while(dr1.Read())
                {
                    cmbSearchState.Items.Add(dr1["state"].ToString());
                }
                cn.Close();
            
        }

        private void cmbSearchState_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter1();
        }

        private void cmbSearchBankName_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter2();
        }
    }
}
