namespace SistemaProva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.fundoPictureBox = new System.Windows.Forms.PictureBox();
            this.entrarButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fundoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fundoPictureBox
            // 
            this.fundoPictureBox.Image = global::SistemaProva.Properties.Resources.Design_sem_nome__4_;
            this.fundoPictureBox.Location = new System.Drawing.Point(26, 12);
            this.fundoPictureBox.Name = "fundoPictureBox";
            this.fundoPictureBox.Size = new System.Drawing.Size(300, 426);
            this.fundoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fundoPictureBox.TabIndex = 0;
            this.fundoPictureBox.TabStop = false;
            // 
            // entrarButton
            // 
            this.entrarButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.entrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.entrarButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrarButton.Location = new System.Drawing.Point(102, 382);
            this.entrarButton.Name = "entrarButton";
            this.entrarButton.Size = new System.Drawing.Size(164, 36);
            this.entrarButton.TabIndex = 1;
            this.entrarButton.Text = "Entrar";
            this.entrarButton.UseVisualStyleBackColor = false;
            this.entrarButton.Click += new System.EventHandler(this.entrarButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTextBox.Location = new System.Drawing.Point(84, 229);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(217, 20);
            this.loginTextBox.TabIndex = 2;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.senhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaTextBox.Location = new System.Drawing.Point(84, 328);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(217, 20);
            this.senhaTextBox.TabIndex = 3;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.entrarButton);
            this.Controls.Add(this.fundoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.fundoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fundoPictureBox;
        private System.Windows.Forms.Button entrarButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
    }
}