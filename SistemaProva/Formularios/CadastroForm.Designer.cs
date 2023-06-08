namespace SistemaProva
{
    partial class CadastroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroForm));
            this.idLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.siglaLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.salvarButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.siglaComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(25, 24);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(25, 93);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(35, 13);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome";
            // 
            // siglaLabel
            // 
            this.siglaLabel.AutoSize = true;
            this.siglaLabel.Location = new System.Drawing.Point(440, 94);
            this.siglaLabel.Name = "siglaLabel";
            this.siglaLabel.Size = new System.Drawing.Size(30, 13);
            this.siglaLabel.TabIndex = 2;
            this.siglaLabel.Text = "Sigla";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(28, 41);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(28, 109);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(375, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // salvarButton
            // 
            this.salvarButton.Image = global::SistemaProva.Properties.Resources.save4;
            this.salvarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salvarButton.Location = new System.Drawing.Point(370, 160);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 6;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Image = global::SistemaProva.Properties.Resources._352270_close_icon;
            this.sairButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sairButton.Location = new System.Drawing.Point(468, 160);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 7;
            this.sairButton.Text = "Sair";
            this.sairButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // siglaComboBox
            // 
            this.siglaComboBox.FormattingEnabled = true;
            this.siglaComboBox.Location = new System.Drawing.Point(443, 107);
            this.siglaComboBox.Name = "siglaComboBox";
            this.siglaComboBox.Size = new System.Drawing.Size(121, 21);
            this.siglaComboBox.TabIndex = 8;
            // 
            // CadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(579, 206);
            this.Controls.Add(this.siglaComboBox);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.siglaLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.idLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroForm";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label siglaLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.ComboBox siglaComboBox;
    }
}