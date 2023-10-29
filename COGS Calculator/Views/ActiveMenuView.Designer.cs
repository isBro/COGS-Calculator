namespace COGS_Calculator.Views
{
    partial class ActiveMenuView
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
            PersonCountLabel = new Label();
            NotesLabel = new Label();
            MenuNameLabel = new Label();
            button5 = new Button();
            ActiveMenuGridView = new DataGridView();
            PrintButton = new Button();
            IngredientViewButton = new Button();
            MenuItemViewButton = new Button();
            BackButton = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)ActiveMenuGridView).BeginInit();
            SuspendLayout();
            // 
            // PersonCountLabel
            // 
            PersonCountLabel.AutoSize = true;
            PersonCountLabel.Location = new Point(12, 125);
            PersonCountLabel.Name = "PersonCountLabel";
            PersonCountLabel.Size = new Size(79, 15);
            PersonCountLabel.TabIndex = 17;
            PersonCountLabel.Text = "Person Count";
            // 
            // NotesLabel
            // 
            NotesLabel.AutoSize = true;
            NotesLabel.Location = new Point(12, 171);
            NotesLabel.Name = "NotesLabel";
            NotesLabel.Size = new Size(38, 15);
            NotesLabel.TabIndex = 16;
            NotesLabel.Text = "Notes";
            // 
            // MenuNameLabel
            // 
            MenuNameLabel.AutoSize = true;
            MenuNameLabel.Location = new Point(12, 88);
            MenuNameLabel.Name = "MenuNameLabel";
            MenuNameLabel.Size = new Size(73, 15);
            MenuNameLabel.TabIndex = 15;
            MenuNameLabel.Text = "Menu Name";
            // 
            // button5
            // 
            button5.Location = new Point(486, 15);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 14;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // ActiveMenuGridView
            // 
            ActiveMenuGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ActiveMenuGridView.Location = new Point(226, 63);
            ActiveMenuGridView.Name = "ActiveMenuGridView";
            ActiveMenuGridView.RowTemplate.Height = 25;
            ActiveMenuGridView.Size = new Size(547, 240);
            ActiveMenuGridView.TabIndex = 13;
            // 
            // PrintButton
            // 
            PrintButton.Location = new Point(226, 337);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(75, 23);
            PrintButton.TabIndex = 12;
            PrintButton.Text = "Print";
            PrintButton.UseVisualStyleBackColor = true;
            // 
            // IngredientViewButton
            // 
            IngredientViewButton.Location = new Point(226, 15);
            IngredientViewButton.Name = "IngredientViewButton";
            IngredientViewButton.Size = new Size(75, 23);
            IngredientViewButton.TabIndex = 11;
            IngredientViewButton.Text = "Ingredients";
            IngredientViewButton.UseVisualStyleBackColor = true;
            IngredientViewButton.Click += IngredientViewButton_Click;
            // 
            // MenuItemViewButton
            // 
            MenuItemViewButton.Location = new Point(354, 15);
            MenuItemViewButton.Name = "MenuItemViewButton";
            MenuItemViewButton.Size = new Size(94, 23);
            MenuItemViewButton.TabIndex = 10;
            MenuItemViewButton.Text = "Menu Items";
            MenuItemViewButton.UseVisualStyleBackColor = true;
            MenuItemViewButton.Click += MenuItemViewButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 15);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 9;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ActiveMenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PersonCountLabel);
            Controls.Add(NotesLabel);
            Controls.Add(MenuNameLabel);
            Controls.Add(button5);
            Controls.Add(ActiveMenuGridView);
            Controls.Add(PrintButton);
            Controls.Add(IngredientViewButton);
            Controls.Add(MenuItemViewButton);
            Controls.Add(BackButton);
            Name = "ActiveMenuView";
            Text = "ActiveMenuView";
            Load += ActiveMenuView_Load;
            ((System.ComponentModel.ISupportInitialize)ActiveMenuGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PersonCountLabel;
        private Label NotesLabel;
        private Label MenuNameLabel;
        private Button button5;
        private DataGridView ActiveMenuGridView;
        private Button PrintButton;
        private Button IngredientViewButton;
        private Button MenuItemViewButton;
        private Button BackButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}