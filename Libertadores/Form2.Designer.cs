
namespace Libertadores
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVencedor = new System.Windows.Forms.Button();
            this.labelTime1 = new System.Windows.Forms.Label();
            this.labelTime2 = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxVencedor = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtA = new System.Windows.Forms.TextBox();
            this.bntResultado = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtMaior = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtMaior1 = new System.Windows.Forms.TextBox();
            this.bntResultado1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bntResultado2 = new System.Windows.Forms.Button();
            this.txtMaior2 = new System.Windows.Forms.TextBox();
            this.txtF = new System.Windows.Forms.TextBox();
            this.txtJ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mata-Mata";
            // 
            // buttonVencedor
            // 
            this.buttonVencedor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVencedor.Location = new System.Drawing.Point(633, 345);
            this.buttonVencedor.Name = "buttonVencedor";
            this.buttonVencedor.Size = new System.Drawing.Size(144, 33);
            this.buttonVencedor.TabIndex = 3;
            this.buttonVencedor.Text = "Vencedor";
            this.buttonVencedor.UseVisualStyleBackColor = true;
            this.buttonVencedor.Click += new System.EventHandler(this.buttonVencedor_Click);
            // 
            // labelTime1
            // 
            this.labelTime1.AutoSize = true;
            this.labelTime1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime1.Location = new System.Drawing.Point(47, 113);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(51, 16);
            this.labelTime1.TabIndex = 4;
            this.labelTime1.Text = "Time1:";
            // 
            // labelTime2
            // 
            this.labelTime2.AutoSize = true;
            this.labelTime2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime2.Location = new System.Drawing.Point(44, 185);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(66, 16);
            this.labelTime2.TabIndex = 5;
            this.labelTime2.Text = "Cruzeiro:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(47, 345);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(76, 16);
            this.lblB.TabIndex = 9;
            this.lblB.Text = "Palmeiras:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(47, 273);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(76, 16);
            this.lblA.TabIndex = 8;
            this.lblA.Text = "Flamengo:";
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Location = new System.Drawing.Point(633, 405);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(144, 33);
            this.buttonFechar.TabIndex = 19;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Palmeiras:",
            "Flamengo:"});
            this.comboBox1.Location = new System.Drawing.Point(304, 293);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // comboBoxVencedor
            // 
            this.comboBoxVencedor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVencedor.FormattingEnabled = true;
            this.comboBoxVencedor.Items.AddRange(new object[] {
            "Flamengo",
            "Palmeiras",
            "Cruzeiro"});
            this.comboBoxVencedor.Location = new System.Drawing.Point(644, 233);
            this.comboBoxVencedor.Name = "comboBoxVencedor";
            this.comboBoxVencedor.Size = new System.Drawing.Size(121, 24);
            this.comboBoxVencedor.TabIndex = 24;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Cruzeiro:",
            ""});
            this.comboBox2.Location = new System.Drawing.Point(304, 167);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(93, 24);
            this.comboBox2.TabIndex = 25;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Quartas de Finais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Final";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(624, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(129, 275);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(50, 20);
            this.txtA.TabIndex = 29;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // bntResultado
            // 
            this.bntResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntResultado.Location = new System.Drawing.Point(157, 389);
            this.bntResultado.Name = "bntResultado";
            this.bntResultado.Size = new System.Drawing.Size(84, 23);
            this.bntResultado.TabIndex = 30;
            this.bntResultado.Text = "Resultado";
            this.bntResultado.UseVisualStyleBackColor = true;
            this.bntResultado.Click += new System.EventHandler(this.bntResultado_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(129, 345);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(50, 20);
            this.txtB.TabIndex = 31;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // txtMaior
            // 
            this.txtMaior.Location = new System.Drawing.Point(195, 310);
            this.txtMaior.Name = "txtMaior";
            this.txtMaior.Size = new System.Drawing.Size(36, 20);
            this.txtMaior.TabIndex = 33;
            this.txtMaior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaior_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 27);
            this.label4.TabIndex = 34;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 27);
            this.label5.TabIndex = 35;
            this.label5.Text = "X";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(130, 114);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(50, 20);
            this.txtC.TabIndex = 36;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_KeyPress);
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(130, 182);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(50, 20);
            this.txtD.TabIndex = 37;
            this.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtD_KeyPress);
            // 
            // txtMaior1
            // 
            this.txtMaior1.Location = new System.Drawing.Point(197, 151);
            this.txtMaior1.Name = "txtMaior1";
            this.txtMaior1.Size = new System.Drawing.Size(35, 20);
            this.txtMaior1.TabIndex = 38;
            this.txtMaior1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaior1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaior1_KeyPress);
            // 
            // bntResultado1
            // 
            this.bntResultado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntResultado1.Location = new System.Drawing.Point(167, 216);
            this.bntResultado1.Name = "bntResultado1";
            this.bntResultado1.Size = new System.Drawing.Size(84, 23);
            this.bntResultado1.TabIndex = 39;
            this.bntResultado1.Text = "Resultado";
            this.bntResultado1.UseVisualStyleBackColor = true;
            this.bntResultado1.Click += new System.EventHandler(this.bntResultado1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(379, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 27);
            this.label6.TabIndex = 40;
            this.label6.Text = "X";
            // 
            // bntResultado2
            // 
            this.bntResultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntResultado2.Location = new System.Drawing.Point(478, 303);
            this.bntResultado2.Name = "bntResultado2";
            this.bntResultado2.Size = new System.Drawing.Size(84, 23);
            this.bntResultado2.TabIndex = 45;
            this.bntResultado2.Text = "Resultado";
            this.bntResultado2.UseVisualStyleBackColor = true;
            this.bntResultado2.Click += new System.EventHandler(this.bntResultado2_Click);
            // 
            // txtMaior2
            // 
            this.txtMaior2.Location = new System.Drawing.Point(501, 233);
            this.txtMaior2.Name = "txtMaior2";
            this.txtMaior2.Size = new System.Drawing.Size(35, 20);
            this.txtMaior2.TabIndex = 44;
            this.txtMaior2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaior2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaior2_KeyPress);
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(434, 264);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(50, 20);
            this.txtF.TabIndex = 43;
            this.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtF_KeyPress);
            // 
            // txtJ
            // 
            this.txtJ.Location = new System.Drawing.Point(434, 196);
            this.txtJ.Name = "txtJ";
            this.txtJ.Size = new System.Drawing.Size(50, 20);
            this.txtJ.TabIndex = 42;
            this.txtJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJ_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntResultado2);
            this.Controls.Add(this.txtMaior2);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.txtJ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bntResultado1);
            this.Controls.Add(this.txtMaior1);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaior);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.bntResultado);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBoxVencedor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.labelTime2);
            this.Controls.Add(this.labelTime1);
            this.Controls.Add(this.buttonVencedor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Classificação";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVencedor;
        private System.Windows.Forms.Label labelTime1;
        private System.Windows.Forms.Label labelTime2;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxVencedor;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button bntResultado;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtMaior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtMaior1;
        private System.Windows.Forms.Button bntResultado1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bntResultado2;
        private System.Windows.Forms.TextBox txtMaior2;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.TextBox txtJ;
    }
}