using QPI_App.Page.Customer_Page;
using QPI_App.Page.Store_Page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QPI_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            customizeDesign();
        }

        private void customizeDesign ()
        {
            panelStoreSubmenu.Visible = false;
            panelSystemSubmenu.Visible = false;
            panelCusSubmenu.Visible = false;

        }

        private void hideSubMenu ()
        {
            if (panelCusSubmenu.Visible == true)
            {
                panelCusSubmenu.Visible = false;
            }
                
            if (panelStoreSubmenu.Visible == true)
            {
                panelStoreSubmenu.Visible = false;
            }
                
            if (panelSystemSubmenu.Visible == true)
            {
                panelSystemSubmenu.Visible = false;
            }
                
        }

        private void showSubmenu (Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region StorePanel
        private void btnStore_Click(object sender, EventArgs e)
        {
            
            showSubmenu(panelStoreSubmenu);
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            // ...
            // code
            // ...
            hideSubMenu();
        }

        private void btnEditStore_Click(object sender, EventArgs e)
        {
            // ...
            // code
            // ...
            hideSubMenu();
        }

        private void btnDeleteStore_Click(object sender, EventArgs e)
        {
            // ...
            // code
            // ...
            hideSubMenu();
        }

        private void btnSelectStore_Click(object sender, EventArgs e)
        {
            openChildForm(new SelectStorePage());

            hideSubMenu();
        }
        #endregion

        #region SystemPanel
        private void btnSystem_Click(object sender, EventArgs e)
        {
            // ...
            // code
            // ...
            showSubmenu(panelSystemSubmenu);
        }

        private void btnAddSystem_Click(object sender, EventArgs e)
        {
            // ...
            // code
            // ...
            hideSubMenu();
        }

        private void btnEditSystem_Click(object sender, EventArgs e)
        {
            // ...
            // code
            // ...
            hideSubMenu();
        }

        private void btnDeleteSystem_Click(object sender, EventArgs e)
        {
            // ...
            // code
            // ...
            hideSubMenu();
        }

        private void btnSelectSystem_Click(object sender, EventArgs e)
        {

            openChildForm(new systemSelectForm());

            hideSubMenu();
        }
        #endregion

        #region CustomerPanel
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            showSubmenu(panelCusSubmenu);
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            // ...
            // code
            // ...
            hideSubMenu();
        }

        private void btnEditCus_Click(object sender, EventArgs e)
        {
            // ...
            // code
            // ...
            hideSubMenu();
        }

        private void btnDeleteCus_Click(object sender, EventArgs e)
        {
            // ...
            // code
            // ...
            hideSubMenu();
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new SelectCustomerPage());

            hideSubMenu();
        }
        #endregion

        private void btnCreateQuo_Click(object sender, EventArgs e)
        {
            // ...
            // code
            // ...
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm (Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.Show();
        }

        
    }
}
