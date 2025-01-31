namespace ProjetoIA_RedesNeurais
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btnTestar = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            btnEscolherArq = new System.Windows.Forms.Button();
            nomeArquivo = new System.Windows.Forms.Label();
            labelTestar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(3, 329);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(464, 189);
            dataGridView1.TabIndex = 0;
            // 
            // btnTestar
            // 
            btnTestar.Location = new System.Drawing.Point(498, 430);
            btnTestar.Name = "btnTestar";
            btnTestar.Size = new System.Drawing.Size(101, 26);
            btnTestar.TabIndex = 1;
            btnTestar.Text = "Testar";
            btnTestar.UseVisualStyleBackColor = true;
            btnTestar.Click += btnTestar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnEscolherArq
            // 
            btnEscolherArq.Location = new System.Drawing.Point(498, 374);
            btnEscolherArq.Name = "btnEscolherArq";
            btnEscolherArq.Size = new System.Drawing.Size(101, 38);
            btnEscolherArq.TabIndex = 2;
            btnEscolherArq.Text = "Escolher Arquivo";
            btnEscolherArq.UseVisualStyleBackColor = true;
            btnEscolherArq.Click += btnEscolherArq_Click;
            // 
            // nomeArquivo
            // 
            nomeArquivo.AutoSize = true;
            nomeArquivo.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nomeArquivo.Location = new System.Drawing.Point(625, 387);
            nomeArquivo.Name = "nomeArquivo";
            nomeArquivo.Size = new System.Drawing.Size(93, 14);
            nomeArquivo.TabIndex = 3;
            nomeArquivo.Text = "Nome Arquivo";
            nomeArquivo.Click += nomeArquivo_Click;
            // 
            // labelTestar
            // 
            labelTestar.AutoSize = true;
            labelTestar.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTestar.ForeColor = System.Drawing.Color.Red;
            labelTestar.Location = new System.Drawing.Point(625, 437);
            labelTestar.Name = "labelTestar";
            labelTestar.Size = new System.Drawing.Size(0, 14);
            labelTestar.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(754, 521);
            Controls.Add(labelTestar);
            Controls.Add(nomeArquivo);
            Controls.Add(btnEscolherArq);
            Controls.Add(btnTestar);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEscolherArq;
        private System.Windows.Forms.Label nomeArquivo;
        private System.Windows.Forms.Label labelTestar;
    }
}