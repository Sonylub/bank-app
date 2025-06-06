using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountManager
{
    public partial class Form2 : Form
    {
        public Form2(List<Operation> ops)
        {
            InitializeComponent();
            foreach (Operation o in ops)
            {
                grid.Rows.Add(o.type, o.sum, o.time);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid.Rows.Clear();
            DialogResult = DialogResult.OK;
        }
    }
}