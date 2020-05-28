using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_App
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            //set panel to true
            addItemPanel.Visible = true;
            dash.Visible = true;

            //remove other panels
            history.Visible = false;
            settings.Visible = false;
            



            //historyPanel.Visible = false;

            //change color of btn
            dashboardbtn.BaseColor = Color.FromArgb(0, 93, 255);
            
            //change colors of btns
            addItembtn.BaseColor = Color.FromArgb(14, 83, 201);
            settingsBtn.BaseColor = Color.FromArgb(14, 83, 201);
            historyBtn.BaseColor = Color.FromArgb(14, 83, 201);
            
            //add indicator
            dashboardIndc.Visible = true;

            //remove other indicators
            addItemInd.Visible = false;
            settingsIndc.Visible = false;
            hisIndc.Visible = false;

        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            //set panel to true
            addItemPanel.Visible = true;
            dash.Visible = true;
            history.Visible = true;

            //remove other panels
            settings.Visible = false;

            //change color of btn
            historyBtn.BaseColor = Color.FromArgb(0, 93, 255);

            //change colors of btns
            addItembtn.BaseColor = Color.FromArgb(14, 83, 201);
            settingsBtn.BaseColor = Color.FromArgb(14, 83, 201);
            dashboardbtn.BaseColor = Color.FromArgb(14, 83, 201);

            //add indicator
            hisIndc.Visible = true;

            //remove other indicators
            addItemInd.Visible = false;
            settingsIndc.Visible = false;
            dashboardIndc.Visible = false;
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            //set panel to true
            addItemPanel.Visible = true;
            dash.Visible = true;
            history.Visible = true; ;
            settings.Visible = true;
            //remove other panels


            //change color of btn
            settingsBtn.BaseColor = Color.FromArgb(0, 93, 255);

            //change colors of btns
            addItembtn.BaseColor = Color.FromArgb(14, 83, 201);
            historyBtn.BaseColor = Color.FromArgb(14, 83, 201);
            dashboardbtn.BaseColor = Color.FromArgb(14, 83, 201);

            //add indicator
            settingsIndc.Visible = true;

            //remove other indicators
            addItemInd.Visible = false;
            hisIndc.Visible = false;
            dashboardIndc.Visible = false;
        }

        private void addItembtn_Click(object sender, EventArgs e)
        {
            //set panel to true
            addItemPanel.Visible = true;

            //remove other panels
            history.Visible = false;
            settings.Visible = false;
            dash.Visible = false;


            //change color of btn
            addItembtn.BaseColor = Color.FromArgb(0, 93, 255);

            //change colors of btns
            settingsBtn.BaseColor = Color.FromArgb(14, 83, 201);
            historyBtn.BaseColor = Color.FromArgb(14, 83, 201);
            dashboardbtn.BaseColor = Color.FromArgb(14, 83, 201);

            //add indicator
            addItemInd.Visible = true;

            //remove other indicators
            settingsIndc.Visible = false;
            hisIndc.Visible = false;
            dashboardIndc.Visible = false;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            string title = "LOG OUT";
            string msg = "Are you sure you want to log out?";
            DialogResult dr =  MessageBox.Show(msg,title,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
            
        }
    }
}
