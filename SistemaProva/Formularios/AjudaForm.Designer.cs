namespace SistemaProva
{
    partial class AjudaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjudaForm));
            this.linkLabel = new System.Windows.Forms.Label();
            this.contatoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.sairButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(95, 26);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(91, 13);
            this.linkLabel.TabIndex = 0;
            this.linkLabel.Text = "Link para Contato";
            // 
            // contatoLinkLabel
            // 
            this.contatoLinkLabel.AutoSize = true;
            this.contatoLinkLabel.Location = new System.Drawing.Point(115, 81);
            this.contatoLinkLabel.Name = "contatoLinkLabel";
            this.contatoLinkLabel.Size = new System.Drawing.Size(44, 13);
            this.contatoLinkLabel.TabIndex = 1;
            this.contatoLinkLabel.TabStop = true;
            this.contatoLinkLabel.Text = "Contato";
            this.contatoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contatoLinkLabel_LinkClicked);
            // 
            // sairButton
            // 
            this.sairButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sairButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sairButton.Location = new System.Drawing.Point(98, 135);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 2;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = false;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // AjudaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 185);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.contatoLinkLabel);
            this.Controls.Add(this.linkLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjudaForm";
            this.Text = "Ajuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label linkLabel;
        private System.Windows.Forms.LinkLabel contatoLinkLabel;
        private System.Windows.Forms.Button sairButton;
    }
}