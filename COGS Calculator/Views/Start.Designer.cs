namespace COGS_Calculator
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            editMenusToolStripMenuItem = new ToolStripMenuItem();
            editIngredientsToolStripMenuItem = new ToolStripMenuItem();
            manageMenuItemsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1477, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(43, 20);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newMenuClicked;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(48, 20);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openMenuClicked;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editMenusToolStripMenuItem, editIngredientsToolStripMenuItem, manageMenuItemsToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // editMenusToolStripMenuItem
            // 
            editMenusToolStripMenuItem.Name = "editMenusToolStripMenuItem";
            editMenusToolStripMenuItem.Size = new Size(183, 22);
            editMenusToolStripMenuItem.Text = "Manage Menus";
            editMenusToolStripMenuItem.Click += manageMenuClicked;
            // 
            // editIngredientsToolStripMenuItem
            // 
            editIngredientsToolStripMenuItem.Name = "editIngredientsToolStripMenuItem";
            editIngredientsToolStripMenuItem.Size = new Size(183, 22);
            editIngredientsToolStripMenuItem.Text = "Manage  Ingredients";
            editIngredientsToolStripMenuItem.Click += manageIngredientsClicked;
            // 
            // manageMenuItemsToolStripMenuItem
            // 
            manageMenuItemsToolStripMenuItem.Name = "manageMenuItemsToolStripMenuItem";
            manageMenuItemsToolStripMenuItem.Size = new Size(183, 22);
            manageMenuItemsToolStripMenuItem.Text = "Manage Menu Items";
            manageMenuItemsToolStripMenuItem.Click += manageItemsClicked;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 566);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Start";
            Text = "Form1";
            Activated += StartViewActivated;
            Load += Start_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem editMenusToolStripMenuItem;
        private ToolStripMenuItem editIngredientsToolStripMenuItem;
        private ToolStripMenuItem manageMenuItemsToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
    }
}