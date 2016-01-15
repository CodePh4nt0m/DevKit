using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevKit.Model;
using FastColoredTextBoxNS;

namespace DevKit.UI
{
    public partial class frmTFSLog : Form
    {
        private List<LogText> result = null;

        FastColoredTextBoxNS.Style greenStyle = new TextStyle(Brushes.Green,null,FontStyle.Regular);
        FastColoredTextBoxNS.Style redsStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);
        FastColoredTextBoxNS.Style blueStyle = new TextStyle(Brushes.DodgerBlue, null, FontStyle.Regular);

        public frmTFSLog(List<LogText> output)
        {
            InitializeComponent();
            result = output;
            ApplyStyles();
        }

        void ApplyStyles()
        {
            if (result != null)
            {
                foreach (var text in result)
                {
                    AddLogText(text.Output,text.IsError);
                }
            }
        }

        private void AddLogText(string text, bool error)
        {
            int bl = txtLog.LinesCount;
            txtLog.AppendText(text + Environment.NewLine);
            int al = txtLog.LinesCount;
            for (int i = bl - 1; i < al; i++)
            {
                var ln = txtLog.GetLine(i);
                if (error)
                    ln.SetStyle(redsStyle);
                else
                    ln.SetStyle(greenStyle);
            }
        }
    }
}
