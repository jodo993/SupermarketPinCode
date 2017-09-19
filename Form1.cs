using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketCodeFlashCards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "mom")
            {
                this.Hide();

                Menu newMenu = new Menu();
                newMenu.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Try again.");
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
