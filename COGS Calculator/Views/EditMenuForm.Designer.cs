namespace COGS_Calculator.Views
{
    partial class EditMenuForm
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
            Save_Menu_Button = new Button();
            Remove_Menu_Item_Button = new Button();
            AddMenu_Item_Button = new Button();
            label5 = new Label();
            label4 = new Label();
            CurrentMenu_ItemDataGrid = new DataGridView();
            AllMenu_ItemDataGrid = new DataGridView();
            MenuNameTextBox = new TextBox();
            label2 = new Label();
            PersonCountTextBox = new TextBox();
            label1 = new Label();
            NotesTextBox = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)CurrentMenu_ItemDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllMenu_ItemDataGrid).BeginInit();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(317, 419);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 33;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // Save_Menu_Button
            // 
            Save_Menu_Button.Location = new Point(188, 419);
            Save_Menu_Button.Name = "Save_Menu_Button";
            Save_Menu_Button.Size = new Size(75, 23);
            Save_Menu_Button.TabIndex = 32;
            Save_Menu_Button.Text = "Save Menu";
            Save_Menu_Button.UseVisualStyleBackColor = true;
            Save_Menu_Button.Click += Save_Menu_Button_Click;
            // 
            // Remove_Menu_Item_Button
            // 
            Remove_Menu_Item_Button.Location = new Point(594, 500);
            Remove_Menu_Item_Button.Margin = new Padding(3, 2, 3, 2);
            Remove_Menu_Item_Button.Name = "Remove_Menu_Item_Button";
            Remove_Menu_Item_Button.Size = new Size(82, 22);
            Remove_Menu_Item_Button.TabIndex = 31;
            Remove_Menu_Item_Button.Text = "Remove";
            Remove_Menu_Item_Button.UseVisualStyleBackColor = true;
            Remove_Menu_Item_Button.Click += Remove_Menu_Item_Button_Click;
            // 
            // AddMenu_Item_Button
            // 
            AddMenu_Item_Button.Location = new Point(594, 253);
            AddMenu_Item_Button.Margin = new Padding(3, 2, 3, 2);
            AddMenu_Item_Button.Name = "AddMenu_Item_Button";
            AddMenu_Item_Button.Size = new Size(82, 22);
            AddMenu_Item_Button.TabIndex = 30;
            AddMenu_Item_Button.Text = "Add";
            AddMenu_Item_Button.UseVisualStyleBackColor = true;
            AddMenu_Item_Button.Click += AddMenu_Item_Button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(725, 311);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 29;
            label5.Text = "Menu Items";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(725, 63);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 28;
            label4.Text = "All Products";
            // 
            // CurrentMenu_ItemDataGrid
            // 
            CurrentMenu_ItemDataGrid.AllowUserToAddRows = false;
            CurrentMenu_ItemDataGrid.AllowUserToDeleteRows = false;
            CurrentMenu_ItemDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CurrentMenu_ItemDataGrid.Location = new Point(548, 344);
            CurrentMenu_ItemDataGrid.Margin = new Padding(3, 2, 3, 2);
            CurrentMenu_ItemDataGrid.Name = "CurrentMenu_ItemDataGrid";
            CurrentMenu_ItemDataGrid.ReadOnly = true;
            CurrentMenu_ItemDataGrid.RowHeadersWidth = 51;
            CurrentMenu_ItemDataGrid.RowTemplate.Height = 29;
            CurrentMenu_ItemDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CurrentMenu_ItemDataGrid.Size = new Size(427, 141);
            CurrentMenu_ItemDataGrid.TabIndex = 27;
            CurrentMenu_ItemDataGrid.Click += CurrentMenu_ItemDataGrid_Clicked;
            // 
            // AllMenu_ItemDataGrid
            // 
            AllMenu_ItemDataGrid.AllowUserToAddRows = false;
            AllMenu_ItemDataGrid.AllowUserToDeleteRows = false;
            AllMenu_ItemDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllMenu_ItemDataGrid.Location = new Point(548, 95);
            AllMenu_ItemDataGrid.Margin = new Padding(3, 2, 3, 2);
            AllMenu_ItemDataGrid.Name = "AllMenu_ItemDataGrid";
            AllMenu_ItemDataGrid.ReadOnly = true;
            AllMenu_ItemDataGrid.RowHeadersWidth = 51;
            AllMenu_ItemDataGrid.RowTemplate.Height = 29;
            AllMenu_ItemDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllMenu_ItemDataGrid.Size = new Size(427, 141);
            AllMenu_ItemDataGrid.TabIndex = 26;
            AllMenu_ItemDataGrid.Click += AllMenu_ItemDataGrid_Clicked;
            // 
            // MenuNameTextBox
            // 
            MenuNameTextBox.Enabled = false;
            MenuNameTextBox.Location = new Point(444, 34);
            MenuNameTextBox.Margin = new Padding(3, 2, 3, 2);
            MenuNameTextBox.Name = "MenuNameTextBox";
            MenuNameTextBox.Size = new Size(170, 23);
            MenuNameTextBox.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 36);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 24;
            label2.Text = "Menu Name";
            // 
            // PersonCountTextBox
            // 
            PersonCountTextBox.Location = new Point(212, 84);
            PersonCountTextBox.Margin = new Padding(3, 2, 3, 2);
            PersonCountTextBox.Name = "PersonCountTextBox";
            PersonCountTextBox.Size = new Size(51, 23);
            PersonCountTextBox.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 86);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 22;
            label1.Text = "No. of Guests";
            // 
            // NotesTextBox
            // 
            NotesTextBox.Location = new Point(103, 164);
            NotesTextBox.Margin = new Padding(3, 2, 3, 2);
            NotesTextBox.Multiline = true;
            NotesTextBox.Name = "NotesTextBox";
            NotesTextBox.Size = new Size(349, 72);
            NotesTextBox.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 167);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 20;
            label3.Text = "Notes";
            // 
            // EditMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 564);
            Controls.Add(CancelButton);
            Controls.Add(Save_Menu_Button);
            Controls.Add(Remove_Menu_Item_Button);
            Controls.Add(AddMenu_Item_Button);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CurrentMenu_ItemDataGrid);
            Controls.Add(AllMenu_ItemDataGrid);
            Controls.Add(MenuNameTextBox);
            Controls.Add(label2);
            Controls.Add(PersonCountTextBox);
            Controls.Add(label1);
            Controls.Add(NotesTextBox);
            Controls.Add(label3);
            Name = "EditMenuForm";
            Text = "Edit Menu";
            Activated += EditMenuView_Activated;
            ((System.ComponentModel.ISupportInitialize)CurrentMenu_ItemDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllMenu_ItemDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private Button Save_Menu_Button;
        private Button Remove_Menu_Item_Button;
        private Button AddMenu_Item_Button;
        private Label label5;
        private Label label4;
        private DataGridView CurrentMenu_ItemDataGrid;
        private DataGridView AllMenu_ItemDataGrid;
        private TextBox MenuNameTextBox;
        private Label label2;
        private TextBox PersonCountTextBox;
        private Label label1;
        private TextBox NotesTextBox;
        private Label label3;
    }
}