
namespace Aula3_POC
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textDtnasc = new System.Windows.Forms.TextBox();
            this.textDtcontrat = new System.Windows.Forms.TextBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Contratação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status:";
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(141, 24);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(164, 20);
            this.textCPF.TabIndex = 5;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(141, 56);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(485, 20);
            this.textNome.TabIndex = 6;
            // 
            // textDtnasc
            // 
            this.textDtnasc.Location = new System.Drawing.Point(141, 88);
            this.textDtnasc.Name = "textDtnasc";
            this.textDtnasc.Size = new System.Drawing.Size(164, 20);
            this.textDtnasc.TabIndex = 7;
            // 
            // textDtcontrat
            // 
            this.textDtcontrat.Location = new System.Drawing.Point(141, 121);
            this.textDtcontrat.Name = "textDtcontrat";
            this.textDtcontrat.Size = new System.Drawing.Size(164, 20);
            this.textDtcontrat.TabIndex = 8;
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "---Selecione---",
            "A - Ativo",
            "F - Férias",
            "S - Suspenso",
            "V - Viagem",
            "D - Desligado"});
            this.comboStatus.Location = new System.Drawing.Point(141, 155);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(121, 21);
            this.comboStatus.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 233);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.textDtcontrat);
            this.Controls.Add(this.textDtnasc);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Cadastrar Funcionário";
            this.Load += new System.EventHandler(this.Form3_Load);
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
        private System.Windows.Forms.TextBox textDtnasc;
        private System.Windows.Forms.TextBox textDtcontrat;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Button button1;
    }
}