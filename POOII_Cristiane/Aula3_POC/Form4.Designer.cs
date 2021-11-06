
namespace Aula3_POC
{
    partial class Form4
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textDtcheckin = new System.Windows.Forms.TextBox();
            this.textDtcheckout = new System.Windows.Forms.TextBox();
            this.textNumquarto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Check In:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Check Out:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número do Quarto:";
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(133, 23);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(183, 20);
            this.textCPF.TabIndex = 5;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(133, 53);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(473, 20);
            this.textNome.TabIndex = 6;
            // 
            // textDtcheckin
            // 
            this.textDtcheckin.Location = new System.Drawing.Point(133, 86);
            this.textDtcheckin.Name = "textDtcheckin";
            this.textDtcheckin.Size = new System.Drawing.Size(100, 20);
            this.textDtcheckin.TabIndex = 7;
            // 
            // textDtcheckout
            // 
            this.textDtcheckout.Location = new System.Drawing.Point(133, 120);
            this.textDtcheckout.Name = "textDtcheckout";
            this.textDtcheckout.Size = new System.Drawing.Size(100, 20);
            this.textDtcheckout.TabIndex = 8;
            // 
            // textNumquarto
            // 
            this.textNumquarto.Location = new System.Drawing.Point(133, 155);
            this.textNumquarto.Name = "textNumquarto";
            this.textNumquarto.Size = new System.Drawing.Size(56, 20);
            this.textNumquarto.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 235);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textNumquarto);
            this.Controls.Add(this.textDtcheckout);
            this.Controls.Add(this.textDtcheckin);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Cadastrar Hóspede";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textDtcheckin;
        private System.Windows.Forms.TextBox textDtcheckout;
        private System.Windows.Forms.TextBox textNumquarto;
        private System.Windows.Forms.Button button1;
    }
}