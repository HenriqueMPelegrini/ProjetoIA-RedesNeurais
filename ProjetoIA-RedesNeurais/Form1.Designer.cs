namespace ProjetoIA_RedesNeurais
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
            btnTreinar = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            numSaida = new System.Windows.Forms.NumericUpDown();
            numEntradas = new System.Windows.Forms.NumericUpDown();
            numOculta = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txApren = new System.Windows.Forms.NumericUpDown();
            numValorErro = new System.Windows.Forms.NumericUpDown();
            numInteracoes = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            rbHiperbolica = new System.Windows.Forms.RadioButton();
            rbLogistica = new System.Windows.Forms.RadioButton();
            rbLinear = new System.Windows.Forms.RadioButton();
            groupBox4 = new System.Windows.Forms.GroupBox();
            nomeArq = new System.Windows.Forms.Label();
            btnEscArq = new System.Windows.Forms.Button();
            openFileArqTreino = new System.Windows.Forms.OpenFileDialog();
            labelConcluido = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSaida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEntradas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOculta).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txApren).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numValorErro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numInteracoes).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btnTreinar
            // 
            btnTreinar.Location = new System.Drawing.Point(297, 363);
            btnTreinar.Name = "btnTreinar";
            btnTreinar.Size = new System.Drawing.Size(133, 31);
            btnTreinar.TabIndex = 1;
            btnTreinar.Text = "Treinar";
            btnTreinar.UseVisualStyleBackColor = true;
            btnTreinar.Click += btnTreinar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numSaida);
            groupBox1.Controls.Add(numEntradas);
            groupBox1.Controls.Add(numOculta);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            groupBox1.Location = new System.Drawing.Point(39, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(375, 148);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configurar Neuronio";
            // 
            // numSaida
            // 
            numSaida.Location = new System.Drawing.Point(279, 111);
            numSaida.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSaida.Name = "numSaida";
            numSaida.ReadOnly = true;
            numSaida.Size = new System.Drawing.Size(68, 23);
            numSaida.TabIndex = 12;
            // 
            // numEntradas
            // 
            numEntradas.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            numEntradas.Location = new System.Drawing.Point(279, 15);
            numEntradas.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numEntradas.Name = "numEntradas";
            numEntradas.ReadOnly = true;
            numEntradas.Size = new System.Drawing.Size(68, 23);
            numEntradas.TabIndex = 11;
            // 
            // numOculta
            // 
            numOculta.Location = new System.Drawing.Point(279, 66);
            numOculta.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numOculta.Name = "numOculta";
            numOculta.Size = new System.Drawing.Size(68, 23);
            numOculta.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label4.Location = new System.Drawing.Point(27, 118);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(214, 16);
            label4.TabIndex = 9;
            label4.Text = "Neuronios na camada de saida:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label5.Location = new System.Drawing.Point(27, 68);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(210, 16);
            label5.TabIndex = 8;
            label5.Text = "Neuronios na camada oculta: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label6.Location = new System.Drawing.Point(27, 22);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(236, 16);
            label6.TabIndex = 7;
            label6.Text = "Neuronios na camada de entrada:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txApren);
            groupBox2.Controls.Add(numValorErro);
            groupBox2.Controls.Add(numInteracoes);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            groupBox2.Location = new System.Drawing.Point(39, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(375, 148);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // txApren
            // 
            txApren.DecimalPlaces = 2;
            txApren.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            txApren.Location = new System.Drawing.Point(260, 111);
            txApren.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            txApren.Name = "txApren";
            txApren.Size = new System.Drawing.Size(68, 23);
            txApren.TabIndex = 12;
            // 
            // numValorErro
            // 
            numValorErro.DecimalPlaces = 4;
            numValorErro.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numValorErro.Location = new System.Drawing.Point(260, 15);
            numValorErro.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numValorErro.Name = "numValorErro";
            numValorErro.Size = new System.Drawing.Size(68, 23);
            numValorErro.TabIndex = 11;
            // 
            // numInteracoes
            // 
            numInteracoes.Location = new System.Drawing.Point(260, 61);
            numInteracoes.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numInteracoes.Name = "numInteracoes";
            numInteracoes.Size = new System.Drawing.Size(68, 23);
            numInteracoes.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(27, 118);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(164, 16);
            label1.TabIndex = 9;
            label1.Text = "Taxa de aprendizagem :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(27, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(167, 16);
            label2.TabIndex = 8;
            label2.Text = "Número de Interações :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Location = new System.Drawing.Point(27, 22);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 16);
            label3.TabIndex = 7;
            label3.Text = "Valor de Erro :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbHiperbolica);
            groupBox3.Controls.Add(rbLogistica);
            groupBox3.Controls.Add(rbLinear);
            groupBox3.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            groupBox3.Location = new System.Drawing.Point(475, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(248, 148);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Função de Transfêrencia";
            // 
            // rbHiperbolica
            // 
            rbHiperbolica.AutoSize = true;
            rbHiperbolica.Location = new System.Drawing.Point(23, 111);
            rbHiperbolica.Name = "rbHiperbolica";
            rbHiperbolica.Size = new System.Drawing.Size(110, 20);
            rbHiperbolica.TabIndex = 2;
            rbHiperbolica.Text = "Hiperbolica";
            rbHiperbolica.UseVisualStyleBackColor = true;
            // 
            // rbLogistica
            // 
            rbLogistica.AutoSize = true;
            rbLogistica.Location = new System.Drawing.Point(23, 72);
            rbLogistica.Name = "rbLogistica";
            rbLogistica.Size = new System.Drawing.Size(89, 20);
            rbLogistica.TabIndex = 1;
            rbLogistica.Text = "Logistica";
            rbLogistica.UseVisualStyleBackColor = true;
            // 
            // rbLinear
            // 
            rbLinear.AutoSize = true;
            rbLinear.Checked = true;
            rbLinear.Location = new System.Drawing.Point(22, 32);
            rbLinear.Name = "rbLinear";
            rbLinear.Size = new System.Drawing.Size(71, 20);
            rbLinear.TabIndex = 0;
            rbLinear.TabStop = true;
            rbLinear.Text = "Linear";
            rbLinear.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(nomeArq);
            groupBox4.Controls.Add(btnEscArq);
            groupBox4.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            groupBox4.Location = new System.Drawing.Point(473, 183);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(250, 148);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Escolher Arquivo :";
            // 
            // nomeArq
            // 
            nomeArq.AutoSize = true;
            nomeArq.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nomeArq.Location = new System.Drawing.Point(120, 68);
            nomeArq.Name = "nomeArq";
            nomeArq.Size = new System.Drawing.Size(93, 14);
            nomeArq.TabIndex = 1;
            nomeArq.Text = "Nome Arquivo";
            // 
            // btnEscArq
            // 
            btnEscArq.Font = new System.Drawing.Font("Stencil", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            btnEscArq.ForeColor = System.Drawing.SystemColors.ControlText;
            btnEscArq.Location = new System.Drawing.Point(3, 59);
            btnEscArq.Name = "btnEscArq";
            btnEscArq.Size = new System.Drawing.Size(111, 28);
            btnEscArq.TabIndex = 0;
            btnEscArq.Text = "Escolher Arquivo";
            btnEscArq.UseVisualStyleBackColor = true;
            btnEscArq.Click += btnEscArq_Click;
            // 
            // openFileArqTreino
            // 
            openFileArqTreino.FileName = "openFileArqTreino";
            // 
            // labelConcluido
            // 
            labelConcluido.AutoSize = true;
            labelConcluido.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            labelConcluido.ForeColor = System.Drawing.Color.SpringGreen;
            labelConcluido.Location = new System.Drawing.Point(164, 418);
            labelConcluido.Name = "labelConcluido";
            labelConcluido.Size = new System.Drawing.Size(0, 22);
            labelConcluido.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(55, 75, 110);
            ClientSize = new System.Drawing.Size(754, 521);
            Controls.Add(labelConcluido);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnTreinar);
            Name = "Form1";
            Text = "TREINO";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSaida).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEntradas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOculta).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txApren).EndInit();
            ((System.ComponentModel.ISupportInitialize)numValorErro).EndInit();
            ((System.ComponentModel.ISupportInitialize)numInteracoes).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnTreinar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numSaida;
        private System.Windows.Forms.NumericUpDown numEntradas;
        private System.Windows.Forms.NumericUpDown numOculta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown txApren;
        private System.Windows.Forms.NumericUpDown numValorErro;
        private System.Windows.Forms.NumericUpDown numInteracoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbHiperbolica;
        private System.Windows.Forms.RadioButton rbLogistica;
        private System.Windows.Forms.RadioButton rbLinear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEscArq;
        private System.Windows.Forms.Label nomeArq;
        private System.Windows.Forms.OpenFileDialog openFileArqTreino;
        private System.Windows.Forms.Label labelConcluido;
    }
}