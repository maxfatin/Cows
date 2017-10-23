using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1CowCounter
{
    public partial class CowCounterForm : Form
    {
        public CowCounterForm()
        {
            InitializeComponent();
        }

        public void CowCounter_Load(object sender, EventArgs e)
        {
            
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            bool num = int.TryParse(txtCowNum.Text, out int n);
            if ((num == false)||(n<0))
            {
                lblResult.Text = " ";
                MessageBox.Show("Введите целое положительное число.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCowNum.Clear();
                txtCowNum.Focus();
            }
            else
                lblResult.Text = ConsoleApplication6.Program.CowCounter(n);
        }
    }
}
