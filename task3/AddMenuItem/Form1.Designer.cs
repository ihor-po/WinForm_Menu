namespace AddMenuItem
{
    partial class cmi_form
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
            this.mci_menu = new System.Windows.Forms.MenuStrip();
            this.cmi_b_createItem = new System.Windows.Forms.Button();
            this.cmi_b_createSubItem = new System.Windows.Forms.Button();
            this.cmi_tb_topItem = new System.Windows.Forms.TextBox();
            this.cmi_tb_subItem = new System.Windows.Forms.TextBox();
            this.cmi_l_topItem = new System.Windows.Forms.Label();
            this.cmi_subItem = new System.Windows.Forms.Label();
            this.cmi_l_currentItem = new System.Windows.Forms.Label();
            this.cmi_cb_menuItems = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mci_menu
            // 
            this.mci_menu.Location = new System.Drawing.Point(0, 0);
            this.mci_menu.Name = "mci_menu";
            this.mci_menu.Size = new System.Drawing.Size(566, 24);
            this.mci_menu.TabIndex = 0;
            this.mci_menu.Text = "menuStrip1";
            // 
            // cmi_b_createItem
            // 
            this.cmi_b_createItem.Location = new System.Drawing.Point(403, 74);
            this.cmi_b_createItem.Name = "cmi_b_createItem";
            this.cmi_b_createItem.Size = new System.Drawing.Size(152, 23);
            this.cmi_b_createItem.TabIndex = 1;
            this.cmi_b_createItem.Text = "Создать пункт меню";
            this.cmi_b_createItem.UseVisualStyleBackColor = true;
            // 
            // cmi_b_createSubItem
            // 
            this.cmi_b_createSubItem.Location = new System.Drawing.Point(402, 110);
            this.cmi_b_createSubItem.Name = "cmi_b_createSubItem";
            this.cmi_b_createSubItem.Size = new System.Drawing.Size(154, 23);
            this.cmi_b_createSubItem.TabIndex = 2;
            this.cmi_b_createSubItem.Text = "Создать под-пункт меню";
            this.cmi_b_createSubItem.UseVisualStyleBackColor = true;
            // 
            // cmi_tb_topItem
            // 
            this.cmi_tb_topItem.Location = new System.Drawing.Point(166, 76);
            this.cmi_tb_topItem.Name = "cmi_tb_topItem";
            this.cmi_tb_topItem.Size = new System.Drawing.Size(222, 20);
            this.cmi_tb_topItem.TabIndex = 3;
            // 
            // cmi_tb_subItem
            // 
            this.cmi_tb_subItem.Location = new System.Drawing.Point(166, 112);
            this.cmi_tb_subItem.Name = "cmi_tb_subItem";
            this.cmi_tb_subItem.Size = new System.Drawing.Size(222, 20);
            this.cmi_tb_subItem.TabIndex = 4;
            // 
            // cmi_l_topItem
            // 
            this.cmi_l_topItem.AutoSize = true;
            this.cmi_l_topItem.Location = new System.Drawing.Point(45, 79);
            this.cmi_l_topItem.Name = "cmi_l_topItem";
            this.cmi_l_topItem.Size = new System.Drawing.Size(119, 13);
            this.cmi_l_topItem.TabIndex = 5;
            this.cmi_l_topItem.Text = "Название пукта меню";
            // 
            // cmi_subItem
            // 
            this.cmi_subItem.AutoSize = true;
            this.cmi_subItem.Location = new System.Drawing.Point(24, 115);
            this.cmi_subItem.Name = "cmi_subItem";
            this.cmi_subItem.Size = new System.Drawing.Size(140, 13);
            this.cmi_subItem.TabIndex = 6;
            this.cmi_subItem.Text = "Название под-пукта меню";
            // 
            // cmi_l_currentItem
            // 
            this.cmi_l_currentItem.AutoSize = true;
            this.cmi_l_currentItem.Location = new System.Drawing.Point(50, 43);
            this.cmi_l_currentItem.Name = "cmi_l_currentItem";
            this.cmi_l_currentItem.Size = new System.Drawing.Size(114, 13);
            this.cmi_l_currentItem.TabIndex = 7;
            this.cmi_l_currentItem.Text = "Текущий пункт меню";
            // 
            // cmi_cb_menuItems
            // 
            this.cmi_cb_menuItems.FormattingEnabled = true;
            this.cmi_cb_menuItems.Location = new System.Drawing.Point(166, 38);
            this.cmi_cb_menuItems.Name = "cmi_cb_menuItems";
            this.cmi_cb_menuItems.Size = new System.Drawing.Size(222, 21);
            this.cmi_cb_menuItems.TabIndex = 8;
            // 
            // cmi_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 161);
            this.Controls.Add(this.cmi_cb_menuItems);
            this.Controls.Add(this.cmi_l_currentItem);
            this.Controls.Add(this.cmi_subItem);
            this.Controls.Add(this.cmi_l_topItem);
            this.Controls.Add(this.cmi_tb_subItem);
            this.Controls.Add(this.cmi_tb_topItem);
            this.Controls.Add(this.cmi_b_createSubItem);
            this.Controls.Add(this.cmi_b_createItem);
            this.Controls.Add(this.mci_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mci_menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cmi_form";
            this.Text = "Создание пуктов меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mci_menu;
        private System.Windows.Forms.Button cmi_b_createItem;
        private System.Windows.Forms.Button cmi_b_createSubItem;
        private System.Windows.Forms.TextBox cmi_tb_topItem;
        private System.Windows.Forms.TextBox cmi_tb_subItem;
        private System.Windows.Forms.Label cmi_l_topItem;
        private System.Windows.Forms.Label cmi_subItem;
        private System.Windows.Forms.Label cmi_l_currentItem;
        private System.Windows.Forms.ComboBox cmi_cb_menuItems;
    }
}

