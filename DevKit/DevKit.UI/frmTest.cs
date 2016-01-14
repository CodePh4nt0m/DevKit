using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevKit.Business;

namespace DevKit.UI
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            LoadDataBases();
            dataGridView1.Rows.Add("1", "sp name");
            dataGridView1.Rows.Add("1", "sp name");
            dataGridView1.Rows.Add("1", "sp name");
            dataGridView1.Rows[0].Cells[2].Value = 4;
        }



        void LoadDataBases()
        {
            EntityBusiness edata = new EntityBusiness();
            var serverlist = edata.GetServerList();

            //Column5.DisplayMember = "Database";
            //Column5.ValueMember = "ServerID";
            Column3.DataSource = serverlist;
            DataGridViewComboBoxColumn ComboColumn = (DataGridViewComboBoxColumn)(dataGridView1.Columns[2]);

            ComboColumn.DataSource = serverlist;
            ComboColumn.DisplayMember = "Database";
            ComboColumn.ValueMember = "ServerID";

           
        }
    }
}
