namespace VinoApp.Formularios.Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BotonLogin = new Button();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BotonLogin
            // 
            BotonLogin.BackColor = SystemColors.Control;
            BotonLogin.Location = new Point(848, 586);
            BotonLogin.Name = "BotonLogin";
            BotonLogin.Size = new Size(139, 43);
            BotonLogin.TabIndex = 0;
            BotonLogin.Text = "Ingresar";
            BotonLogin.UseVisualStyleBackColor = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(771, 468);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 23);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(771, 542);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(300, 23);
            txtContraseña.TabIndex = 2;
            txtContraseña.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(779, 441);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(779, 514);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(809, 218);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(BotonLogin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonLogin;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
