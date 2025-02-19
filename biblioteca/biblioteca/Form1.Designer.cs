namespace biblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BemVindo = new Label();
            panelPrincipal = new Panel();
            btn_sair = new Button();
            btn_emprestar = new Button();
            btn_consultar = new Button();
            btn_remover = new Button();
            btn_adicionar = new Button();
            btn_home = new Button();
            panelLogo = new Panel();
            livros = new PictureBox();
            panelPrincipal.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)livros).BeginInit();
            SuspendLayout();
            // 
            // BemVindo
            // 
            BemVindo.AutoSize = true;
            BemVindo.BackColor = Color.Transparent;
            BemVindo.Font = new Font("Segoe UI", 20F);
            BemVindo.ForeColor = SystemColors.ControlText;
            BemVindo.Location = new Point(311, 110);
            BemVindo.Name = "BemVindo";
            BemVindo.Size = new Size(407, 37);
            BemVindo.TabIndex = 0;
            BemVindo.Text = "Bem Vindo à Biblioteca dos Aires";
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.MediumBlue;
            panelPrincipal.Controls.Add(btn_sair);
            panelPrincipal.Controls.Add(btn_emprestar);
            panelPrincipal.Controls.Add(btn_consultar);
            panelPrincipal.Controls.Add(btn_remover);
            panelPrincipal.Controls.Add(btn_adicionar);
            panelPrincipal.Controls.Add(btn_home);
            panelPrincipal.Controls.Add(panelLogo);
            panelPrincipal.Dock = DockStyle.Left;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(167, 476);
            panelPrincipal.TabIndex = 1;
            // 
            // btn_sair
            // 
            btn_sair.AutoSize = true;
            btn_sair.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_sair.BackColor = Color.MediumBlue;
            btn_sair.Dock = DockStyle.Top;
            btn_sair.FlatAppearance.BorderColor = Color.MediumBlue;
            btn_sair.FlatAppearance.BorderSize = 0;
            btn_sair.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            btn_sair.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn_sair.FlatStyle = FlatStyle.Flat;
            btn_sair.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_sair.ForeColor = Color.White;
            btn_sair.Image = (Image)resources.GetObject("btn_sair.Image");
            btn_sair.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sair.Location = new Point(0, 411);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(167, 61);
            btn_sair.TabIndex = 6;
            btn_sair.Text = "   Sair";
            btn_sair.TextAlign = ContentAlignment.MiddleLeft;
            btn_sair.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click;
            // 
            // btn_emprestar
            // 
            btn_emprestar.AutoSize = true;
            btn_emprestar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_emprestar.BackColor = Color.MediumBlue;
            btn_emprestar.Dock = DockStyle.Top;
            btn_emprestar.FlatAppearance.BorderColor = Color.MediumBlue;
            btn_emprestar.FlatAppearance.BorderSize = 0;
            btn_emprestar.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            btn_emprestar.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn_emprestar.FlatStyle = FlatStyle.Flat;
            btn_emprestar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_emprestar.ForeColor = Color.White;
            btn_emprestar.Image = (Image)resources.GetObject("btn_emprestar.Image");
            btn_emprestar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_emprestar.Location = new Point(0, 340);
            btn_emprestar.Name = "btn_emprestar";
            btn_emprestar.Size = new Size(167, 71);
            btn_emprestar.TabIndex = 5;
            btn_emprestar.Text = "Emprestar";
            btn_emprestar.TextAlign = ContentAlignment.MiddleLeft;
            btn_emprestar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_emprestar.UseVisualStyleBackColor = false;
            // 
            // btn_consultar
            // 
            btn_consultar.AutoSize = true;
            btn_consultar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_consultar.BackColor = Color.MediumBlue;
            btn_consultar.Dock = DockStyle.Top;
            btn_consultar.FlatAppearance.BorderColor = Color.MediumBlue;
            btn_consultar.FlatAppearance.BorderSize = 0;
            btn_consultar.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            btn_consultar.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn_consultar.FlatStyle = FlatStyle.Flat;
            btn_consultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_consultar.ForeColor = Color.White;
            btn_consultar.Image = (Image)resources.GetObject("btn_consultar.Image");
            btn_consultar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_consultar.Location = new Point(0, 269);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(167, 71);
            btn_consultar.TabIndex = 4;
            btn_consultar.Text = "Consultar";
            btn_consultar.TextAlign = ContentAlignment.MiddleLeft;
            btn_consultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_consultar.UseVisualStyleBackColor = false;
            // 
            // btn_remover
            // 
            btn_remover.AutoSize = true;
            btn_remover.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_remover.BackColor = Color.MediumBlue;
            btn_remover.Dock = DockStyle.Top;
            btn_remover.FlatAppearance.BorderColor = Color.MediumBlue;
            btn_remover.FlatAppearance.BorderSize = 0;
            btn_remover.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            btn_remover.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn_remover.FlatStyle = FlatStyle.Flat;
            btn_remover.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_remover.ForeColor = Color.White;
            btn_remover.Image = (Image)resources.GetObject("btn_remover.Image");
            btn_remover.ImageAlign = ContentAlignment.MiddleLeft;
            btn_remover.Location = new Point(0, 208);
            btn_remover.Name = "btn_remover";
            btn_remover.Size = new Size(167, 61);
            btn_remover.TabIndex = 3;
            btn_remover.Text = " Remover";
            btn_remover.TextAlign = ContentAlignment.MiddleLeft;
            btn_remover.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_remover.UseVisualStyleBackColor = false;
            // 
            // btn_adicionar
            // 
            btn_adicionar.AutoSize = true;
            btn_adicionar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_adicionar.BackColor = Color.MediumBlue;
            btn_adicionar.Dock = DockStyle.Top;
            btn_adicionar.FlatAppearance.BorderColor = Color.MediumBlue;
            btn_adicionar.FlatAppearance.BorderSize = 0;
            btn_adicionar.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            btn_adicionar.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn_adicionar.FlatStyle = FlatStyle.Flat;
            btn_adicionar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_adicionar.ForeColor = Color.White;
            btn_adicionar.Image = (Image)resources.GetObject("btn_adicionar.Image");
            btn_adicionar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_adicionar.Location = new Point(0, 147);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(167, 61);
            btn_adicionar.TabIndex = 2;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.TextAlign = ContentAlignment.MiddleLeft;
            btn_adicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_adicionar.UseVisualStyleBackColor = false;
            // 
            // btn_home
            // 
            btn_home.AutoSize = true;
            btn_home.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_home.BackColor = Color.MediumBlue;
            btn_home.Dock = DockStyle.Top;
            btn_home.FlatAppearance.BorderColor = Color.MediumBlue;
            btn_home.FlatAppearance.BorderSize = 0;
            btn_home.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            btn_home.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_home.ForeColor = Color.White;
            btn_home.Image = (Image)resources.GetObject("btn_home.Image");
            btn_home.ImageAlign = ContentAlignment.MiddleLeft;
            btn_home.Location = new Point(0, 81);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(167, 66);
            btn_home.TabIndex = 1;
            btn_home.Text = "Home";
            btn_home.TextAlign = ContentAlignment.MiddleLeft;
            btn_home.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_home.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Indigo;
            panelLogo.Controls.Add(livros);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(167, 81);
            panelLogo.TabIndex = 0;
            // 
            // livros
            // 
            livros.Dock = DockStyle.Left;
            livros.Image = (Image)resources.GetObject("livros.Image");
            livros.Location = new Point(0, 0);
            livros.Name = "livros";
            livros.Size = new Size(69, 81);
            livros.SizeMode = PictureBoxSizeMode.Zoom;
            livros.TabIndex = 0;
            livros.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(850, 476);
            Controls.Add(panelPrincipal);
            Controls.Add(BemVindo);
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)livros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BemVindo;
        private Panel panelPrincipal;
        private Panel panelLogo;
        private PictureBox livros;
        private Button btn_home;
        private Button btn_adicionar;
        private Button btn_remover;
        private Button btn_consultar;
        private Button btn_sair;
        private Button btn_emprestar;
    }
}
