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

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            UpdateDeleteMemberForm updateMember = new UpdateDeleteMemberForm();
            updateMember.Show();
            this.Hide();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
            this.Hide();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            ViewMembersForm viewMembersForm = new ViewMembersForm();
            viewMembersForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
