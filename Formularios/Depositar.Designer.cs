
namespace Edwin_Work.Formularios
{
    partial class Depositar
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
            this.txtNumeroConta = new Edwin_Work.Controlers.TextButton();
            this.txtValor = new Edwin_Work.Controlers.TextButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumeroConta.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumeroConta.BorderSize = 2;
            this.txtNumeroConta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroConta.Location = new System.Drawing.Point(305, 81);
            this.txtNumeroConta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNumeroConta.Multiline = false;
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.PasswordChar = false;
            this.txtNumeroConta.Size = new System.Drawing.Size(213, 29);
            this.txtNumeroConta.TabIndex = 0;
            this.txtNumeroConta.Texts = "";
            this.txtNumeroConta.UnderlinedStyle = false;
            // 
            // txtValor
            // 
            this.txtValor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtValor.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtValor.BorderSize = 2;
            this.txtValor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(305, 199);
            this.txtValor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtValor.Multiline = false;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = false;
            this.txtValor.Size = new System.Drawing.Size(213, 29);
            this.txtValor.TabIndex = 0;
            this.txtValor.Texts = "";
            this.txtValor.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(147, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor a depositar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(268, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Depositar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Depositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNumeroConta);
            this.Name = "Depositar";
            this.Text = "Depositar";
            this.Load += new System.EventHandler(this.Depositar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controlers.TextButton txtNumeroConta;
        private Controlers.TextButton txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}