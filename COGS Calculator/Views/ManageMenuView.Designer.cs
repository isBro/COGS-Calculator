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
            AllMenusDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllMenusDataGridView.Location = new Point(190, 51);
            AllMenusDataGridView.Name = "AllMenusDataGridView";
            AllMenusDataGridView.RowTemplate.Height = 25;
            AllMenusDataGridView.Size = new Size(434, 150);
            AllMenusDataGridView.TabIndex = 21;
            // 
            // ManageMenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AllMenusDataGridView);
            Controls.Add(CancelButton);
            Name = "ManageMenuView";
            Text = "ManageMenuView";
            Activated += ManageMenuViewActivated;
            ((System.ComponentModel.ISupportInitialize)AllMenusDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CancelButton;
        private DataGridView AllMenusDataGridView;
    }
}