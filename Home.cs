using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_V_1
{
    public partial class Home : Form
    {
        private Form activeForm = null;
        public Home()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            CustomizeDesing();
        }

        private void CustomizeDesing()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void HideSubMenu()
        {
            if(panel1.Visible)
                panel1.Visible = false;
            if (panel2.Visible)
                panel2.Visible = false;
            if (panel3.Visible)
                panel3.Visible = false;
            if (panel4.Visible)
                panel4.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel3);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel4);
        }

        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel5.Controls.Add(childForm);
            panel5.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
