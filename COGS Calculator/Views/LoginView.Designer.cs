namespace COGS_Calculator.Views
{
    partial class LoginView
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
            label1 = new Label();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 94);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(118, 129);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.PlaceholderText = "Username";
            userNameTextBox.Size = new Size(153, 23);
            userNameTextBox.TabIndex = 1;
            userNameTextBox.Text = "Operator";
            // 
            // passwordTextBox
            // 
            passwordTextBox.HideSelection = false;
            passwordTextBox.Location = new Point(118, 174);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(153, 23);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.Text = "Passw0rd!";
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(156, 225);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Go";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 329);
            Controls.Add(LoginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(label1);
            Name = "LoginView";
            Text = "LoginView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Button LoginButton;
    }
}