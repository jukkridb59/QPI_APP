namespace QPI_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateQuo = new System.Windows.Forms.Button();
            this.panelCusSubmenu = new System.Windows.Forms.Panel();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCus = new System.Windows.Forms.Button();
            this.btnEditCus = new System.Windows.Forms.Button();
            this.btnAddCus = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.panelSystemSubmenu = new System.Windows.Forms.Panel();
            this.btnSelectSystem = new System.Windows.Forms.Button();
            this.btnDeleteSystem = new System.Windows.Forms.Button();
            this.btnEditSystem = new System.Windows.Forms.Button();
            this.btnAddSystem = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.panelStoreSubmenu = new System.Windows.Forms.Panel();
            this.btnSelectStore = new System.Windows.Forms.Button();
            this.btnDeleteStore = new System.Windows.Forms.Button();
            this.btnEditStore = new System.Windows.Forms.Button();
            this.btnAddStore = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelCusSubmenu.SuspendLayout();
            this.panelSystemSubmenu.SuspendLayout();
            this.panelStoreSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.btnCreateQuo);
            this.panel1.Controls.Add(this.panelCusSubmenu);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.panelSystemSubmenu);
            this.panel1.Controls.Add(this.btnSystem);
            this.panel1.Controls.Add(this.panelStoreSubmenu);
            this.panel1.Controls.Add(this.btnStore);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 529);
            this.panel1.TabIndex = 0;
            // 
            // btnCreateQuo
            // 
            this.btnCreateQuo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateQuo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateQuo.FlatAppearance.BorderSize = 0;
            this.btnCreateQuo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateQuo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQuo.ForeColor = System.Drawing.Color.LightGray;
            this.btnCreateQuo.Location = new System.Drawing.Point(0, 672);
            this.btnCreateQuo.Name = "btnCreateQuo";
            this.btnCreateQuo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCreateQuo.Size = new System.Drawing.Size(183, 40);
            this.btnCreateQuo.TabIndex = 7;
            this.btnCreateQuo.Text = "สร้างใบเสนอราคา";
            this.btnCreateQuo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateQuo.UseVisualStyleBackColor = true;
            this.btnCreateQuo.Click += new System.EventHandler(this.btnCreateQuo_Click);
            // 
            // panelCusSubmenu
            // 
            this.panelCusSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(52)))), ((int)(((byte)(29)))));
            this.panelCusSubmenu.Controls.Add(this.btnSelectCustomer);
            this.panelCusSubmenu.Controls.Add(this.btnDeleteCus);
            this.panelCusSubmenu.Controls.Add(this.btnEditCus);
            this.panelCusSubmenu.Controls.Add(this.btnAddCus);
            this.panelCusSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCusSubmenu.Location = new System.Drawing.Point(0, 522);
            this.panelCusSubmenu.Name = "panelCusSubmenu";
            this.panelCusSubmenu.Size = new System.Drawing.Size(183, 150);
            this.panelCusSubmenu.TabIndex = 6;
            this.panelCusSubmenu.Visible = false;
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelectCustomer.FlatAppearance.BorderSize = 0;
            this.btnSelectCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCustomer.ForeColor = System.Drawing.Color.LightGray;
            this.btnSelectCustomer.Location = new System.Drawing.Point(0, 111);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSelectCustomer.Size = new System.Drawing.Size(183, 35);
            this.btnSelectCustomer.TabIndex = 4;
            this.btnSelectCustomer.Text = "ดูรายการ";
            this.btnSelectCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // btnDeleteCus
            // 
            this.btnDeleteCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteCus.FlatAppearance.BorderSize = 0;
            this.btnDeleteCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCus.ForeColor = System.Drawing.Color.LightGray;
            this.btnDeleteCus.Location = new System.Drawing.Point(0, 74);
            this.btnDeleteCus.Name = "btnDeleteCus";
            this.btnDeleteCus.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDeleteCus.Size = new System.Drawing.Size(183, 37);
            this.btnDeleteCus.TabIndex = 2;
            this.btnDeleteCus.Text = "ลบ";
            this.btnDeleteCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCus.UseVisualStyleBackColor = true;
            this.btnDeleteCus.Click += new System.EventHandler(this.btnDeleteCus_Click);
            // 
            // btnEditCus
            // 
            this.btnEditCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditCus.FlatAppearance.BorderSize = 0;
            this.btnEditCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCus.ForeColor = System.Drawing.Color.LightGray;
            this.btnEditCus.Location = new System.Drawing.Point(0, 37);
            this.btnEditCus.Name = "btnEditCus";
            this.btnEditCus.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnEditCus.Size = new System.Drawing.Size(183, 37);
            this.btnEditCus.TabIndex = 1;
            this.btnEditCus.Text = "แก้ไข";
            this.btnEditCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCus.UseVisualStyleBackColor = true;
            this.btnEditCus.Click += new System.EventHandler(this.btnEditCus_Click);
            // 
            // btnAddCus
            // 
            this.btnAddCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCus.FlatAppearance.BorderSize = 0;
            this.btnAddCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCus.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddCus.Location = new System.Drawing.Point(0, 0);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddCus.Size = new System.Drawing.Size(183, 37);
            this.btnAddCus.TabIndex = 0;
            this.btnAddCus.Text = "เพิ่ม";
            this.btnAddCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCus.UseVisualStyleBackColor = true;
            this.btnAddCus.Click += new System.EventHandler(this.btnAddCus_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCustomer.Location = new System.Drawing.Point(0, 482);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(183, 40);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "ข้อมูลลูกค้า";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // panelSystemSubmenu
            // 
            this.panelSystemSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(52)))), ((int)(((byte)(29)))));
            this.panelSystemSubmenu.Controls.Add(this.btnSelectSystem);
            this.panelSystemSubmenu.Controls.Add(this.btnDeleteSystem);
            this.panelSystemSubmenu.Controls.Add(this.btnEditSystem);
            this.panelSystemSubmenu.Controls.Add(this.btnAddSystem);
            this.panelSystemSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSystemSubmenu.Location = new System.Drawing.Point(0, 330);
            this.panelSystemSubmenu.Name = "panelSystemSubmenu";
            this.panelSystemSubmenu.Size = new System.Drawing.Size(183, 152);
            this.panelSystemSubmenu.TabIndex = 4;
            this.panelSystemSubmenu.Visible = false;
            // 
            // btnSelectSystem
            // 
            this.btnSelectSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelectSystem.FlatAppearance.BorderSize = 0;
            this.btnSelectSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSystem.ForeColor = System.Drawing.Color.LightGray;
            this.btnSelectSystem.Location = new System.Drawing.Point(0, 111);
            this.btnSelectSystem.Name = "btnSelectSystem";
            this.btnSelectSystem.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSelectSystem.Size = new System.Drawing.Size(183, 35);
            this.btnSelectSystem.TabIndex = 4;
            this.btnSelectSystem.Text = "ดูรายการ";
            this.btnSelectSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectSystem.UseVisualStyleBackColor = true;
            this.btnSelectSystem.Click += new System.EventHandler(this.btnSelectSystem_Click);
            // 
            // btnDeleteSystem
            // 
            this.btnDeleteSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteSystem.FlatAppearance.BorderSize = 0;
            this.btnDeleteSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSystem.ForeColor = System.Drawing.Color.LightGray;
            this.btnDeleteSystem.Location = new System.Drawing.Point(0, 74);
            this.btnDeleteSystem.Name = "btnDeleteSystem";
            this.btnDeleteSystem.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDeleteSystem.Size = new System.Drawing.Size(183, 37);
            this.btnDeleteSystem.TabIndex = 2;
            this.btnDeleteSystem.Text = "ลบ";
            this.btnDeleteSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteSystem.UseVisualStyleBackColor = true;
            this.btnDeleteSystem.Click += new System.EventHandler(this.btnDeleteSystem_Click);
            // 
            // btnEditSystem
            // 
            this.btnEditSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditSystem.FlatAppearance.BorderSize = 0;
            this.btnEditSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSystem.ForeColor = System.Drawing.Color.LightGray;
            this.btnEditSystem.Location = new System.Drawing.Point(0, 37);
            this.btnEditSystem.Name = "btnEditSystem";
            this.btnEditSystem.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnEditSystem.Size = new System.Drawing.Size(183, 37);
            this.btnEditSystem.TabIndex = 1;
            this.btnEditSystem.Text = "แก้ไข";
            this.btnEditSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditSystem.UseVisualStyleBackColor = true;
            this.btnEditSystem.Click += new System.EventHandler(this.btnEditSystem_Click);
            // 
            // btnAddSystem
            // 
            this.btnAddSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddSystem.FlatAppearance.BorderSize = 0;
            this.btnAddSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSystem.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddSystem.Location = new System.Drawing.Point(0, 0);
            this.btnAddSystem.Name = "btnAddSystem";
            this.btnAddSystem.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddSystem.Size = new System.Drawing.Size(183, 37);
            this.btnAddSystem.TabIndex = 0;
            this.btnAddSystem.Text = "เพิ่ม";
            this.btnAddSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSystem.UseVisualStyleBackColor = true;
            this.btnAddSystem.Click += new System.EventHandler(this.btnAddSystem_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystem.FlatAppearance.BorderSize = 0;
            this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSystem.Location = new System.Drawing.Point(0, 290);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSystem.Size = new System.Drawing.Size(183, 40);
            this.btnSystem.TabIndex = 3;
            this.btnSystem.Text = "คลังระบบ";
            this.btnSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystem.UseVisualStyleBackColor = true;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // panelStoreSubmenu
            // 
            this.panelStoreSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(52)))), ((int)(((byte)(29)))));
            this.panelStoreSubmenu.Controls.Add(this.btnSelectStore);
            this.panelStoreSubmenu.Controls.Add(this.btnDeleteStore);
            this.panelStoreSubmenu.Controls.Add(this.btnEditStore);
            this.panelStoreSubmenu.Controls.Add(this.btnAddStore);
            this.panelStoreSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStoreSubmenu.Location = new System.Drawing.Point(0, 140);
            this.panelStoreSubmenu.Name = "panelStoreSubmenu";
            this.panelStoreSubmenu.Size = new System.Drawing.Size(183, 150);
            this.panelStoreSubmenu.TabIndex = 2;
            this.panelStoreSubmenu.Visible = false;
            // 
            // btnSelectStore
            // 
            this.btnSelectStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelectStore.FlatAppearance.BorderSize = 0;
            this.btnSelectStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectStore.ForeColor = System.Drawing.Color.LightGray;
            this.btnSelectStore.Location = new System.Drawing.Point(0, 111);
            this.btnSelectStore.Name = "btnSelectStore";
            this.btnSelectStore.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSelectStore.Size = new System.Drawing.Size(183, 35);
            this.btnSelectStore.TabIndex = 3;
            this.btnSelectStore.Text = "ดูรายการ";
            this.btnSelectStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectStore.UseVisualStyleBackColor = true;
            this.btnSelectStore.Click += new System.EventHandler(this.btnSelectStore_Click);
            // 
            // btnDeleteStore
            // 
            this.btnDeleteStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteStore.FlatAppearance.BorderSize = 0;
            this.btnDeleteStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStore.ForeColor = System.Drawing.Color.LightGray;
            this.btnDeleteStore.Location = new System.Drawing.Point(0, 74);
            this.btnDeleteStore.Name = "btnDeleteStore";
            this.btnDeleteStore.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDeleteStore.Size = new System.Drawing.Size(183, 37);
            this.btnDeleteStore.TabIndex = 2;
            this.btnDeleteStore.Text = "ลบ";
            this.btnDeleteStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteStore.UseVisualStyleBackColor = true;
            this.btnDeleteStore.Click += new System.EventHandler(this.btnDeleteStore_Click);
            // 
            // btnEditStore
            // 
            this.btnEditStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditStore.FlatAppearance.BorderSize = 0;
            this.btnEditStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStore.ForeColor = System.Drawing.Color.LightGray;
            this.btnEditStore.Location = new System.Drawing.Point(0, 37);
            this.btnEditStore.Name = "btnEditStore";
            this.btnEditStore.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnEditStore.Size = new System.Drawing.Size(183, 37);
            this.btnEditStore.TabIndex = 1;
            this.btnEditStore.Text = "แก้ไข";
            this.btnEditStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditStore.UseVisualStyleBackColor = true;
            this.btnEditStore.Click += new System.EventHandler(this.btnEditStore_Click);
            // 
            // btnAddStore
            // 
            this.btnAddStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddStore.FlatAppearance.BorderSize = 0;
            this.btnAddStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStore.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddStore.Location = new System.Drawing.Point(0, 0);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddStore.Size = new System.Drawing.Size(183, 37);
            this.btnAddStore.TabIndex = 0;
            this.btnAddStore.Text = "เพิ่ม";
            this.btnAddStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStore.UseVisualStyleBackColor = true;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // btnStore
            // 
            this.btnStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStore.FlatAppearance.BorderSize = 0;
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStore.Location = new System.Drawing.Point(0, 100);
            this.btnStore.Name = "btnStore";
            this.btnStore.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStore.Size = new System.Drawing.Size(183, 40);
            this.btnStore.TabIndex = 1;
            this.btnStore.Text = "คลังสินค้า";
            this.btnStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 100);
            this.panel2.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(72)))), ((int)(((byte)(41)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(784, 529);
            this.panelChildForm.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 529);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelCusSubmenu.ResumeLayout(false);
            this.panelSystemSubmenu.ResumeLayout(false);
            this.panelStoreSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCusSubmenu;
        private System.Windows.Forms.Button btnDeleteCus;
        private System.Windows.Forms.Button btnEditCus;
        private System.Windows.Forms.Button btnAddCus;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel panelSystemSubmenu;
        private System.Windows.Forms.Button btnDeleteSystem;
        private System.Windows.Forms.Button btnEditSystem;
        private System.Windows.Forms.Button btnAddSystem;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.Panel panelStoreSubmenu;
        private System.Windows.Forms.Button btnDeleteStore;
        private System.Windows.Forms.Button btnEditStore;
        private System.Windows.Forms.Button btnAddStore;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreateQuo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.Button btnSelectSystem;
        private System.Windows.Forms.Button btnSelectStore;
    }
}

