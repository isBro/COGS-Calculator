namespace COGS_Calculator
{
    partial class AddMenuView
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
            textBox3 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            AddMenu_Item_Button = new Button();
            Remove_Menu_Item_Button = new Button();
            Save_Menu_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(89, 166);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(349, 72);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 169);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Notes";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 86);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(51, 23);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 88);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 8;
            label1.Text = "No. of Guests";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(430, 36);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 38);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 10;
            label2.Text = "Menu Name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(534, 97);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(427, 141);
            dataGridView1.TabIndex = 12;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(534, 346);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(427, 141);
            dataGridView2.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(711, 65);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 14;
            label4.Text = "All Products";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(711, 313);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 15;
            label5.Text = "Menu Items";
            // 
            // AddMenu_Item_Button
            // 
            AddMenu_Item_Button.Location = new Point(580, 255);
            AddMenu_Item_Button.Margin = new Padding(3, 2, 3, 2);
            AddMenu_Item_Button.Name = "AddMenu_Item_Button";
            AddMenu_Item_Button.Size = new Size(82, 22);
            AddMenu_Item_Button.TabIndex = 16;
            AddMenu_Item_Button.Text = "Add";
            AddMenu_Item_Button.UseVisualStyleBackColor = true;
            AddMenu_Item_Button.Click += AddMenu_Item_Button_Click;
            // 
            // Remove_Menu_Item_Button
            // 
            Remove_Menu_Item_Button.Location = new Point(580, 502);
            Remove_Menu_Item_Button.Margin = new Padding(3, 2, 3, 2);
            Remove_Menu_Item_Button.Name = "Remove_Menu_Item_Button";
            Remove_Menu_Item_Button.Size = new Size(82, 22);
            Remove_Menu_Item_Button.TabIndex = 17;
            Remove_Menu_Item_Button.Text = "Remove";
            Remove_Menu_Item_Button.UseVisualStyleBackColor = true;
            Remove_Menu_Item_Button.Click += Remove_Menu_Item_Button_Click;
            // 
            // Save_Menu_Button
            // 
            Save_Menu_Button.Location = new Point(174, 421);
            Save_Menu_Button.Name = "Save_Menu_Button";
            Save_Menu_Button.Size = new Size(75, 23);
            Save_Menu_Button.TabIndex = 18;
            Save_Menu_Button.Text = "Save Menu";
            Save_Menu_Button.UseVisualStyleBackColor = true;
            Save_Menu_Button.Click += Save_Menu_Button_Click;
            // 
            // AddMenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 542);
            Controls.Add(Save_Menu_Button);
            Controls.Add(Remove_Menu_Item_Button);
            Controls.Add(AddMenu_Item_Button);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddMenuView";
            Text = "AddMenuView";
            Activated += AddMenuView_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label4;
        private Label label5;
        private Button AddMenu_Item_Button;
        private Button Remove_Menu_Item_Button;
        private Button Save_Menu_Button;
    }
}