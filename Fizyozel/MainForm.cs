using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fizyozel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // butona tıklandığında yeni bir üye ekleme formu açar
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            AddMemberForm addMember = new AddMemberForm();
            addMember.Show();
            this.Hide();
        }
    }
}
