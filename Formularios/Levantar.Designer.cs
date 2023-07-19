
namespace Edwin_Work.Formularios
{
    partial class Levantar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLevantar = new System.Windows.Forms.Button();
            this.txtValor = new Edwin_Work.Controlers.TextButton();
            this.txtConta = new Edwin_Work.Controlers.TextButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(173, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor a Levantar";
            // 
            // btnLevantar
            // 
            this.btnLevantar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLevantar.FlatAppearance.BorderSize = 0;
            this.btnLevantar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevantar.ForeColor = System.Drawing.Color.White;
            this.btnLevantar.Location = new System.Drawing.Point(338, 352);
            this.btnLevantar.Name = "btnLevantar";
            this.btnLevantar.Size = new System.Drawing.Size(270, 58);
            this.btnLevantar.TabIndex = 2;
            this.btnLevantar.Text = "Levantar";
            this.btnLevantar.UseVisualStyleBackColor = false;
            this.btnLevantar.Click += new System.EventHandler(this.btnLevantar_Click);
            // 
            // txtValor
            // 
            this.txtValor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtValor.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtValor.BorderSize = 2;
            this.txtValor.Location = new System.Drawing.Point(324, 217);
            this.txtValor.Margin = new System.Windows.Forms.Padding(8);
            this.txtValor.Multiline = false;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = false;
            this.txtValor.Size = new System.Drawing.Size(342, 29);
            this.txtValor.TabIndex = 0;
            this.txtValor.Texts = "";
            this.txtValor.UnderlinedStyle = false;
            // 
            // txtConta
            // 
            this.txtConta.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtConta.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtConta.BorderSize = 2;
            this.txtConta.Location = new System.Drawing.Point(324, 99);
            this.txtConta.Margin = new System.Windows.Forms.Padding(5);
            this.txtConta.Multiline = false;
            this.txtConta.Name = "txtConta";
            this.txtConta.PasswordChar = false;
            this.txtConta.Size = new System.Drawing.Size(342, 29);
            this.txtConta.TabIndex = 0;
            this.txtConta.Texts = "";
            this.txtConta.UnderlinedStyle = false;
            // 
            // Levantar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1117, 592);
            this.Controls.Add(this.btnLevantar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtConta);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Levantar";
            this.Text = "Levantar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controlers.TextButton txtConta;
        private Controlers.TextButton txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLevantar;
    }
}