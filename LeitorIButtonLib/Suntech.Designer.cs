namespace LeitorIButtonLib
{
    partial class Suntech
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
            this.Comando = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Comando
            // 
            this.Comando.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Comando.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Comando.Location = new System.Drawing.Point(12, 12);
            this.Comando.Name = "Comando";
            this.Comando.ReadOnly = true;
            this.Comando.Size = new System.Drawing.Size(355, 13);
            this.Comando.TabIndex = 0;
            this.Comando.Text = "ST300HAD;[%IMEI%];02";
            this.Comando.TextChanged += new System.EventHandler(this.Comando_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Copiar Comando";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // Suntech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 74);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Comando);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Suntech";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Suntech";
            this.Load += new System.EventHandler(this.Suntech_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Comando;
        private System.Windows.Forms.Button button1;
    }
}