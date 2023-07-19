
namespace Edwin_Work
{
    partial class ClientSide
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
            this.panelList = new System.Windows.Forms.Panel();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.btnLevantamento = new System.Windows.Forms.Button();
            this.btnDepositos = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelList.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelList
            // 
            this.panelList.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelList.Controls.Add(this.btnSaldo);
            this.panelList.Controls.Add(this.btnLevantamento);
            this.panelList.Controls.Add(this.btnDepositos);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelList.Location = new System.Drawing.Point(629, 0);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(281, 467);
            this.panelList.TabIndex = 0;
            // 
            // btnSaldo
            // 
            this.btnSaldo.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSaldo.FlatAppearance.BorderSize = 0;
            this.btnSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaldo.ForeColor = System.Drawing.Color.White;
            this.btnSaldo.Location = new System.Drawing.Point(30, 370);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(239, 71);
            this.btnSaldo.TabIndex = 0;
            this.btnSaldo.Text = "Saldos";
            this.btnSaldo.UseVisualStyleBackColor = false;
            // 
            // btnLevantamento
            // 
            this.btnLevantamento.BackColor = System.Drawing.Color.DarkBlue;
            this.btnLevantamento.FlatAppearance.BorderSize = 0;
            this.btnLevantamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevantamento.ForeColor = System.Drawing.Color.White;
            this.btnLevantamento.Location = new System.Drawing.Point(30, 154);
            this.btnLevantamento.Name = "btnLevantamento";
            this.btnLevantamento.Size = new System.Drawing.Size(239, 67);
            this.btnLevantamento.TabIndex = 0;
            this.btnLevantamento.Text = "Levantamento";
            this.btnLevantamento.UseVisualStyleBackColor = false;
            this.btnLevantamento.Click += new System.EventHandler(this.btnLevantamento_Click);
            // 
            // btnDepositos
            // 
            this.btnDepositos.BackColor = System.Drawing.Color.DarkBlue;
            this.btnDepositos.FlatAppearance.BorderSize = 0;
            this.btnDepositos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositos.ForeColor = System.Drawing.Color.White;
            this.btnDepositos.Location = new System.Drawing.Point(30, 263);
            this.btnDepositos.Name = "btnDepositos";
            this.btnDepositos.Size = new System.Drawing.Size(239, 69);
            this.btnDepositos.TabIndex = 0;
            this.btnDepositos.Text = "Deposito";
            this.btnDepositos.UseVisualStyleBackColor = false;
            this.btnDepositos.Click += new System.EventHandler(this.btnDepositos_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(629, 130);
            this.panelTitle.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 130);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(629, 337);
            this.panelDesktop.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ClientSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(910, 467);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelList);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ClientSide";
            this.Text = "ClientSide";
            this.panelList.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Button btnLevantamento;
        private System.Windows.Forms.Button btnDepositos;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDesktop;
    }
}