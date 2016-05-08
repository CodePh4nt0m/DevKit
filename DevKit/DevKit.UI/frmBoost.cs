using DevKit.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevKit.UI
{
    public partial class frmBoost : Form
    {
        ConfigurationHelper config = new ConfigurationHelper();
        public frmBoost()
        {
            InitializeComponent();
        }

        private void btnsearchscript_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtSearchSpName.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Name is required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    GenerateSearchTempalte();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateSearchTempalte()
        {
            string sp_creatorname = config.GetConfigurationValue("sp_user_name");
            string spname = txtSearchSpName.Text.Trim();

            var sptemplate = ReadTemplate("SearchListTemplate.txt");
            sptemplate = sptemplate.Replace("{tag_sqp_spname}", spname);
            sptemplate = sptemplate.Replace("{tag_sqp_creator}", sp_creatorname);
            sptemplate = sptemplate.Replace("{tag_sqp_createddate}", DateTime.Now.ToString("dd MMM yyyy"));
            frmQueryWindow frm = new frmQueryWindow(sptemplate);
            frm.Show();
        }

        private string ReadTemplate(string tempname)
        {
            string counttemplate = File.ReadAllText(Path.Combine(System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\Templates\" + tempname)));
            return counttemplate;
        }
    }
}
