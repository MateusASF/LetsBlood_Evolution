﻿namespace LetsBlood_2.Cadastros_Forms
{
    partial class frm_cadastrarBolsa
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
            this.dTp_DataColeta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Observacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_TipoSanguineo = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_NomeMedico = new System.Windows.Forms.TextBox();
            this.mTb_CpfDoador = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_HospitalDestino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_voltar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_resultado = new System.Windows.Forms.PictureBox();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.gb_TipoSanguineo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dTp_DataColeta
            // 
            this.dTp_DataColeta.Location = new System.Drawing.Point(65, 37);
            this.dTp_DataColeta.Name = "dTp_DataColeta";
            this.dTp_DataColeta.Size = new System.Drawing.Size(317, 27);
            this.dTp_DataColeta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data da Coleta";
            // 
            // tb_Observacao
            // 
            this.tb_Observacao.Location = new System.Drawing.Point(66, 294);
            this.tb_Observacao.Multiline = true;
            this.tb_Observacao.Name = "tb_Observacao";
            this.tb_Observacao.Size = new System.Drawing.Size(316, 56);
            this.tb_Observacao.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Obs";
            // 
            // gb_TipoSanguineo
            // 
            this.gb_TipoSanguineo.Controls.Add(this.radioButton8);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton7);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton6);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton5);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton4);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton3);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton2);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton1);
            this.gb_TipoSanguineo.Location = new System.Drawing.Point(413, 27);
            this.gb_TipoSanguineo.Name = "gb_TipoSanguineo";
            this.gb_TipoSanguineo.Size = new System.Drawing.Size(144, 264);
            this.gb_TipoSanguineo.TabIndex = 8;
            this.gb_TipoSanguineo.TabStop = false;
            this.gb_TipoSanguineo.Text = "Tipo Sanguíneo";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(27, 234);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(47, 24);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "O-";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(27, 202);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(51, 24);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "O+";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(27, 172);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(55, 24);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "AB-";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(27, 146);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(59, 24);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "AB+";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(27, 116);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(45, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "B-";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 86);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(49, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "B+";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(27, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "A-";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A+";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome do Médico";
            // 
            // tb_NomeMedico
            // 
            this.tb_NomeMedico.Location = new System.Drawing.Point(66, 103);
            this.tb_NomeMedico.Name = "tb_NomeMedico";
            this.tb_NomeMedico.Size = new System.Drawing.Size(316, 27);
            this.tb_NomeMedico.TabIndex = 10;
            // 
            // mTb_CpfDoador
            // 
            this.mTb_CpfDoador.Location = new System.Drawing.Point(66, 165);
            this.mTb_CpfDoador.Mask = "000-000-000-00";
            this.mTb_CpfDoador.Name = "mTb_CpfDoador";
            this.mTb_CpfDoador.Size = new System.Drawing.Size(316, 27);
            this.mTb_CpfDoador.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "CPF do Doador";
            // 
            // tb_HospitalDestino
            // 
            this.tb_HospitalDestino.Location = new System.Drawing.Point(65, 229);
            this.tb_HospitalDestino.Name = "tb_HospitalDestino";
            this.tb_HospitalDestino.Size = new System.Drawing.Size(317, 27);
            this.tb_HospitalDestino.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hospital de Destino";
            // 
            // lb_voltar
            // 
            this.lb_voltar.AutoSize = true;
            this.lb_voltar.BackColor = System.Drawing.Color.Transparent;
            this.lb_voltar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_voltar.Location = new System.Drawing.Point(64, 414);
            this.lb_voltar.Name = "lb_voltar";
            this.lb_voltar.Size = new System.Drawing.Size(66, 20);
            this.lb_voltar.TabIndex = 18;
            this.lb_voltar.Text = "VOLTAR";
            this.lb_voltar.Click += new System.EventHandler(this.lb_voltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LetsBlood_2.Properties.Resources.voltar;
            this.pictureBox1.Location = new System.Drawing.Point(33, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pb_resultado
            // 
            this.pb_resultado.Image = global::LetsBlood_2.Properties.Resources.bolsaCadastrada;
            this.pb_resultado.Location = new System.Drawing.Point(151, 356);
            this.pb_resultado.Name = "pb_resultado";
            this.pb_resultado.Size = new System.Drawing.Size(231, 78);
            this.pb_resultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_resultado.TabIndex = 19;
            this.pb_resultado.TabStop = false;
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_limpar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_limpar.Location = new System.Drawing.Point(601, 280);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(203, 62);
            this.bt_limpar.TabIndex = 28;
            this.bt_limpar.Text = "LIMPAR";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(601, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 62);
            this.button3.TabIndex = 27;
            this.button3.Text = "EXCLUIR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(601, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 62);
            this.button2.TabIndex = 26;
            this.button2.Text = "EDITAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cadastrar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_cadastrar.Location = new System.Drawing.Point(601, 37);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(203, 62);
            this.bt_cadastrar.TabIndex = 25;
            this.bt_cadastrar.Text = "CADASTRAR";
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // frm_cadastrarBolsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(842, 457);
            this.ControlBox = false;
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.pb_resultado);
            this.Controls.Add(this.lb_voltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_HospitalDestino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mTb_CpfDoador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_NomeMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gb_TipoSanguineo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Observacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTp_DataColeta);
            this.Name = "frm_cadastrarBolsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_cadastrarBolsa";
            this.Load += new System.EventHandler(this.frm_cadastrarBolsa_Load);
            this.gb_TipoSanguineo.ResumeLayout(false);
            this.gb_TipoSanguineo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dTp_DataColeta;
        private Label label1;
        private TextBox tb_Observacao;
        private Label label2;
        private GroupBox gb_TipoSanguineo;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private TextBox tb_NomeMedico;
        private MaskedTextBox mTb_CpfDoador;
        private Label label4;
        private TextBox tb_HospitalDestino;
        private Label label5;
        private Label lb_voltar;
        private PictureBox pictureBox1;
        private PictureBox pb_resultado;
        private Button bt_limpar;
        private Button button3;
        private Button button2;
        private Button bt_cadastrar;
    }
}