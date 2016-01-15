using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideBySideTextBox
{
    public partial class frmCompare : Form
    {
        public frmCompare(string left,string right)
        {
            InitializeComponent();
            comparebox.LeftText = left;
            comparebox.RightText = right;
            comparebox.CompareText();
        }
    }
}
