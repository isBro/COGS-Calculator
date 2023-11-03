namespace COGS_Calculator
{
    partial class ManageMenuView
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
            CancelButton = new Button();
            AllMenusDataGridView = new DataGridView();
            UseMenuButton = new Button();
            DeleteMenuButton = new Button();
            EditMenuButton = new Button();
            Search_Label = new Label();
            Menu_SearchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)AllMenusDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(28, 24);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 20;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AllMenusDataGridView
            // 
            AllMenusDataGridView.AllowUserToAddRows = false;
            AllMenusDataGridView.AllowUserToDeleteRows = false;
            AllMenusDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllMenusDataGridView.Location = new Point(121, 81);
            AllMenusDataGridView.Name = "AllMenusDataGridView";
            AllMenusDataGridView.ReadOnly = true;
            AllMenusDataGridView.RowTemplate.Height = 25;
            AllMenusDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllMenusDataGridView.Size = new Size(553, 150);
            AllMenusDataGridView.TabIndex = 21;
            AllMenusDataGridView.Click += AM_DataGridView_Selected;
            // 
            // UseMenuButton
            // 
            UseMenuButton.Location = new Point(121, 257);
            UseMenuButton.Name = "UseMenuButton";
            UseMenuButton.Size = new Size(75, 23);
            UseMenuButton.TabIndex = 22;
            UseMenuButton.Text = "Use";
            UseMenuButton.UseVisualStyleBackColor = true;
            UseMenuButton.Click += UseMenuButton_Click;
            // 
            // DeleteMenuButton
            // 
            DeleteMenuButton.Location = new Point(599, 257);
            DeleteMenuButton.Name = "DeleteMenuButton";
            DeleteMenuButton.Size = new Size(75, 23);
            DeleteMenuButton.TabIndex = 23;
            DeleteMenuButton.Text = "Delete";
            DeleteMenuButton.UseVisualStyleBackColor = true;
            DeleteMenuButton.Click += DeleteMenuButton_Click;
            // 
            // EditMenuButton
            // 
            EditMenuButton.Location = new Point(346, 257);
            EditMenuButton.Name = "EditMenuButton";
            EditMenuButton.Size = new Size(75, 23);
            EditMenuButton.TabIndex = 24;
            EditMenuButton.Text = "Edit";
            EditMenuButton.UseVisualStyleBackColor = true;
            EditMenuButton.Click += EditMenuButton_Click;
            // 
            // Search_Label
            // 
            Search_Label.AutoSize = true;
            Search_Label.Location = new Point(515, 27);
            Search_Label.Name = "Search_Label";
            Search_Label.Size = new Size(42, 15);
            Search_Label.TabIndex = 44;
            Search_Label.Text = "Search";
            // 
            // Menu_SearchBox
            // 
            Menu_SearchBox.Location = new Point(574, 24);
            Menu_SearchBox.Name = "Menu_SearchBox";
            Menu_SearchBox.Size = new Size(100, 23);
            Menu_SearchBox.TabIndex = 43;
            Menu_SearchBox.TextChanged += MenuSearchBarTextChanged;
            // 
            // ManageMenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Search_Label);
            Controls.Add(Menu_SearchBox);
            Controls.Add(EditMenuButton);
            Controls.Add(DeleteMenuButton);
            Controls.Add(UseMenuButton);
            Controls.Add(AllMenusDataGridView);
            Controls.Add(CancelButton);
            Name = "ManageMenuView";
            Text = "ManageMenuView";
            Activated += ManageMenuViewActivated;
            ((System.ComponentModel.ISupportInitialize)AllMenusDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private DataGridView AllMenusDataGridView;
        private Button UseMenuButton;
        private Button DeleteMenuButton;
        private Button EditMenuButton;
        private Label Search_Label;
        private TextBox Menu_SearchBox;
    }
}