namespace Trab_2C
{
    partial class Form1
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
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCapCarro = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtQtdCarro = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCarros = new System.Windows.Forms.TextBox();
            this.bntCdastro = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.regsPassa = new System.Windows.Forms.Button();
            this.btnsolicite = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(93, 126);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(93, 80);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // txtCapCarro
            // 
            this.txtCapCarro.Location = new System.Drawing.Point(93, 176);
            this.txtCapCarro.Name = "txtCapCarro";
            this.txtCapCarro.Size = new System.Drawing.Size(100, 20);
            this.txtCapCarro.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(93, 35);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // txtQtdCarro
            // 
            this.txtQtdCarro.Location = new System.Drawing.Point(115, 241);
            this.txtQtdCarro.Name = "txtQtdCarro";
            this.txtQtdCarro.Size = new System.Drawing.Size(100, 20);
            this.txtQtdCarro.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(123, 249);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 6;
            // 
            // txtCarros
            // 
            this.txtCarros.Location = new System.Drawing.Point(292, 332);
            this.txtCarros.Name = "txtCarros";
            this.txtCarros.Size = new System.Drawing.Size(100, 20);
            this.txtCarros.TabIndex = 7;
            // 
            // bntCdastro
            // 
            this.bntCdastro.Location = new System.Drawing.Point(292, 49);
            this.bntCdastro.Name = "bntCdastro";
            this.bntCdastro.Size = new System.Drawing.Size(75, 23);
            this.bntCdastro.TabIndex = 8;
            this.bntCdastro.Text = "btnCds";
            this.bntCdastro.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(322, 228);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "button1";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // regsPassa
            // 
            this.regsPassa.Location = new System.Drawing.Point(322, 122);
            this.regsPassa.Name = "regsPassa";
            this.regsPassa.Size = new System.Drawing.Size(75, 23);
            this.regsPassa.TabIndex = 10;
            this.regsPassa.Text = "button1";
            this.regsPassa.UseVisualStyleBackColor = true;
            // 
            // btnsolicite
            // 
            this.btnsolicite.Location = new System.Drawing.Point(338, 387);
            this.btnsolicite.Name = "btnsolicite";
            this.btnsolicite.Size = new System.Drawing.Size(75, 23);
            this.btnsolicite.TabIndex = 11;
            this.btnsolicite.Text = "button1";
            this.btnsolicite.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsolicite);
            this.Controls.Add(this.regsPassa);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.bntCdastro);
            this.Controls.Add(this.txtCarros);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtQtdCarro);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtCapCarro);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPlaca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCapCarro;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtQtdCarro;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCarros;
        private System.Windows.Forms.Button bntCdastro;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button regsPassa;
        private System.Windows.Forms.Button btnsolicite;
        private System.Windows.Forms.Button button1;

    }
}

