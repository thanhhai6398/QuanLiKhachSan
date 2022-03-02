
namespace QLHotel
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.imageLoginPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.laocongRadioButton = new System.Windows.Forms.RadioButton();
            this.tieptanRadioButton = new System.Windows.Forms.RadioButton();
            this.quanlyRadioButton = new System.Windows.Forms.RadioButton();
            this.nullUserErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nullPasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageLoginPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nullUserErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nullPasswordErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(25, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOTEL FAMILY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(179, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Login";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.Location = new System.Drawing.Point(26, 124);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(135, 24);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Name Login :";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Location = new System.Drawing.Point(47, 185);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(112, 24);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password :";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(186, 109);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTextBox.Multiline = true;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(242, 49);
            this.usernameTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.usernameTextBox, "Nhap Username");
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(186, 174);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(242, 49);
            this.passwordTextBox.TabIndex = 5;
            this.toolTip2.SetToolTip(this.passwordTextBox, "Nhap Password");
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.loginButton.Location = new System.Drawing.Point(365, 421);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(106, 45);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.cancelButton.Location = new System.Drawing.Point(114, 421);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(113, 45);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // imageLoginPictureBox
            // 
            this.imageLoginPictureBox.BackColor = System.Drawing.Color.Honeydew;
            this.imageLoginPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageLoginPictureBox.Location = new System.Drawing.Point(517, 112);
            this.imageLoginPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageLoginPictureBox.Name = "imageLoginPictureBox";
            this.imageLoginPictureBox.Size = new System.Drawing.Size(228, 223);
            this.imageLoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageLoginPictureBox.TabIndex = 8;
            this.imageLoginPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Location = new System.Drawing.Point(9, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 272);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Controls.Add(this.laocongRadioButton);
            this.panel2.Controls.Add(this.tieptanRadioButton);
            this.panel2.Controls.Add(this.quanlyRadioButton);
            this.panel2.Location = new System.Drawing.Point(9, 112);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 60);
            this.panel2.TabIndex = 6;
            // 
            // laocongRadioButton
            // 
            this.laocongRadioButton.AutoSize = true;
            this.laocongRadioButton.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laocongRadioButton.Location = new System.Drawing.Point(341, 25);
            this.laocongRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.laocongRadioButton.Name = "laocongRadioButton";
            this.laocongRadioButton.Size = new System.Drawing.Size(105, 27);
            this.laocongRadioButton.TabIndex = 2;
            this.laocongRadioButton.TabStop = true;
            this.laocongRadioButton.Text = "Lao công";
            this.laocongRadioButton.UseVisualStyleBackColor = true;
            // 
            // tieptanRadioButton
            // 
            this.tieptanRadioButton.AutoSize = true;
            this.tieptanRadioButton.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieptanRadioButton.Location = new System.Drawing.Point(176, 25);
            this.tieptanRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tieptanRadioButton.Name = "tieptanRadioButton";
            this.tieptanRadioButton.Size = new System.Drawing.Size(95, 27);
            this.tieptanRadioButton.TabIndex = 1;
            this.tieptanRadioButton.TabStop = true;
            this.tieptanRadioButton.Text = "Tiếp tân";
            this.tieptanRadioButton.UseVisualStyleBackColor = true;
            // 
            // quanlyRadioButton
            // 
            this.quanlyRadioButton.AutoSize = true;
            this.quanlyRadioButton.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanlyRadioButton.Location = new System.Drawing.Point(21, 25);
            this.quanlyRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quanlyRadioButton.Name = "quanlyRadioButton";
            this.quanlyRadioButton.Size = new System.Drawing.Size(92, 27);
            this.quanlyRadioButton.TabIndex = 0;
            this.quanlyRadioButton.TabStop = true;
            this.quanlyRadioButton.Text = "Quản lý";
            this.quanlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // nullUserErrorProvider
            // 
            this.nullUserErrorProvider.ContainerControl = this;
            // 
            // nullPasswordErrorProvider
            // 
            this.nullPasswordErrorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(755, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imageLoginPictureBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Hotel";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageLoginPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nullUserErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nullPasswordErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox imageLoginPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton laocongRadioButton;
        private System.Windows.Forms.RadioButton tieptanRadioButton;
        private System.Windows.Forms.RadioButton quanlyRadioButton;
        private System.Windows.Forms.ErrorProvider nullUserErrorProvider;
        private System.Windows.Forms.ErrorProvider nullPasswordErrorProvider;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

