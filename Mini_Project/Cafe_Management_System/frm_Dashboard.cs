﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        public frm_Dashboard(String User)
        {
            InitializeComponent();

            if (User=="Guest")
            {
                btn_AddItem.Hide();
                btn_UpdateItem.Hide();
                btn_RemoveItem.Hide();
            }
        }
     

        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            uC_Welcome1.Visible = true;
            uC_Welcome1.BringToFront();
            uC_AddItem.Visible = false;
            uC_PlaceOrder1.Visible = false;
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            uC_AddItem.Visible = true;
            uC_AddItem.BringToFront();
        }

        private void btn_PlaceOrder_Click(object sender, EventArgs e)
        {
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void btn_UpdateItem_Click(object sender, EventArgs e)
        {
            uC_UpdateItem1.Visible = true;
            uC_UpdateItem1.BringToFront();
        }

        private void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            uC_DeleteItem1.Visible = true;
            uC_DeleteItem1.BringToFront();
        }

        private void pb_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MessageBox.Show("Are You Sure?","Log Out",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                frm_Login L = new frm_Login();
                this.Hide();
                L.Show();
            }
        }

    
    }
}
