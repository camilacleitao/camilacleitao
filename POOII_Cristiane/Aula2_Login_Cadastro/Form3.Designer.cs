
namespace Aula2_Login_Cadastro
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF:";
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(98, 33);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(120, 20);
            this.textCPF.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "E-mail:";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(98, 65);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(540, 20);
            this.textNome.TabIndex = 8;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(98, 99);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(540, 20);
            this.textEndereco.TabIndex = 9;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(98, 134);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(120, 20);
            this.textTelefone.TabIndex = 10;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(98, 165);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(540, 20);
            this.textEmail.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 258);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Cadastrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textEmail;
    }
}