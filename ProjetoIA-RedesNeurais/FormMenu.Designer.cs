
namespace ProjetoIA_RedesNeurais
{
    partial class FormMenu
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panelCabecalho = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            btnRestaurar = new System.Windows.Forms.Button();
            btnMaximizar = new System.Windows.Forms.Button();
            btnFechar = new System.Windows.Forms.Button();
            panelMenu = new System.Windows.Forms.Panel();
            btnTestar = new System.Windows.Forms.Button();
            btnTreinar = new System.Windows.Forms.Button();
            panelConteudo = new System.Windows.Forms.Panel();
            panelCabecalho.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelCabecalho
            // 
            panelCabecalho.BackColor = System.Drawing.Color.DodgerBlue;
            panelCabecalho.Controls.Add(label1);
            panelCabecalho.Controls.Add(btnRestaurar);
            panelCabecalho.Controls.Add(btnMaximizar);
            panelCabecalho.Controls.Add(btnFechar);
            panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            panelCabecalho.Location = new System.Drawing.Point(0, 0);
            panelCabecalho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelCabecalho.Name = "panelCabecalho";
            panelCabecalho.Size = new System.Drawing.Size(933, 46);
            panelCabecalho.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(59, 7);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(183, 30);
            label1.TabIndex = 1;
            label1.Text = "Rede Neural MLP";
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRestaurar.FlatAppearance.BorderSize = 0;
            btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRestaurar.Image = (System.Drawing.Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new System.Drawing.Point(776, 3);
            btnRestaurar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new System.Drawing.Size(47, 39);
            btnRestaurar.TabIndex = 0;
            btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMaximizar.Image = (System.Drawing.Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new System.Drawing.Point(830, 3);
            btnMaximizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new System.Drawing.Size(47, 39);
            btnMaximizar.TabIndex = 0;
            btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFechar.Image = (System.Drawing.Image)resources.GetObject("btnFechar.Image");
            btnFechar.Location = new System.Drawing.Point(883, 3);
            btnFechar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new System.Drawing.Size(47, 39);
            btnFechar.TabIndex = 0;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = System.Drawing.Color.FromArgb(37, 46, 59);
            panelMenu.Controls.Add(btnTestar);
            panelMenu.Controls.Add(btnTreinar);
            panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelMenu.Location = new System.Drawing.Point(0, 46);
            panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new System.Drawing.Size(159, 567);
            panelMenu.TabIndex = 1;
            // 
            // btnTestar
            // 
            btnTestar.FlatAppearance.BorderSize = 0;
            btnTestar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            btnTestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTestar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTestar.ForeColor = System.Drawing.Color.White;
            btnTestar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTestar.Location = new System.Drawing.Point(4, 177);
            btnTestar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnTestar.Name = "btnTestar";
            btnTestar.Size = new System.Drawing.Size(152, 45);
            btnTestar.TabIndex = 0;
            btnTestar.Text = "Testar";
            btnTestar.UseVisualStyleBackColor = true;
            btnTestar.Click += btnTestar_Click;
            // 
            // btnTreinar
            // 
            btnTreinar.FlatAppearance.BorderSize = 0;
            btnTreinar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            btnTreinar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTreinar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTreinar.ForeColor = System.Drawing.Color.White;
            btnTreinar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTreinar.Location = new System.Drawing.Point(4, 97);
            btnTreinar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnTreinar.Name = "btnTreinar";
            btnTreinar.Size = new System.Drawing.Size(152, 45);
            btnTreinar.TabIndex = 0;
            btnTreinar.Text = " Treinar";
            btnTreinar.UseVisualStyleBackColor = true;
            btnTreinar.Click += btnTreinar_Click;
            // 
            // panelConteudo
            // 
            panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            panelConteudo.Location = new System.Drawing.Point(159, 46);
            panelConteudo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new System.Drawing.Size(774, 567);
            panelConteudo.TabIndex = 2;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 613);
            Controls.Add(panelConteudo);
            Controls.Add(panelMenu);
            Controls.Add(panelCabecalho);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormMenu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            panelCabecalho.ResumeLayout(false);
            panelCabecalho.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.Button btnTreinar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelConteudo;


    }
}