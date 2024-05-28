namespace VinoApp.Formularios.Bodegas
{
    partial class VerBodega
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
            nombreTextBox1 = new TextBox();
            descripcionTextBox2 = new TextBox();
            periodoTextBox3 = new TextBox();
            coordenadaTextBox4 = new TextBox();
            vinosListBox1 = new ListBox();
            vinosActListBox1 = new ListBox();
            periodoActTextBox3 = new TextBox();
            coordenadaActTextBox4 = new TextBox();
            descripcionActTextBox2 = new TextBox();
            nombreActTextBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // nombreTextBox1
            // 
            nombreTextBox1.Location = new Point(80, 78);
            nombreTextBox1.Name = "nombreTextBox1";
            nombreTextBox1.Size = new Size(212, 27);
            nombreTextBox1.TabIndex = 0;
            // 
            // descripcionTextBox2
            // 
            descripcionTextBox2.Location = new Point(80, 130);
            descripcionTextBox2.Name = "descripcionTextBox2";
            descripcionTextBox2.Size = new Size(212, 27);
            descripcionTextBox2.TabIndex = 1;
            // 
            // periodoTextBox3
            // 
            periodoTextBox3.Location = new Point(80, 178);
            periodoTextBox3.Name = "periodoTextBox3";
            periodoTextBox3.Size = new Size(212, 27);
            periodoTextBox3.TabIndex = 3;
            // 
            // coordenadaTextBox4
            // 
            coordenadaTextBox4.Location = new Point(80, 221);
            coordenadaTextBox4.Name = "coordenadaTextBox4";
            coordenadaTextBox4.Size = new Size(212, 27);
            coordenadaTextBox4.TabIndex = 2;
            // 
            // vinosListBox1
            // 
            vinosListBox1.FormattingEnabled = true;
            vinosListBox1.ItemHeight = 20;
            vinosListBox1.Location = new Point(80, 286);
            vinosListBox1.Name = "vinosListBox1";
            vinosListBox1.Size = new Size(212, 104);
            vinosListBox1.TabIndex = 4;
            // 
            // vinosActListBox1
            // 
            vinosActListBox1.FormattingEnabled = true;
            vinosActListBox1.ItemHeight = 20;
            vinosActListBox1.Location = new Point(483, 286);
            vinosActListBox1.Name = "vinosActListBox1";
            vinosActListBox1.Size = new Size(212, 104);
            vinosActListBox1.TabIndex = 9;
            // 
            // periodoActTextBox3
            // 
            periodoActTextBox3.Location = new Point(483, 178);
            periodoActTextBox3.Name = "periodoActTextBox3";
            periodoActTextBox3.Size = new Size(212, 27);
            periodoActTextBox3.TabIndex = 8;
            // 
            // coordenadaActTextBox4
            // 
            coordenadaActTextBox4.Location = new Point(483, 221);
            coordenadaActTextBox4.Name = "coordenadaActTextBox4";
            coordenadaActTextBox4.Size = new Size(212, 27);
            coordenadaActTextBox4.TabIndex = 7;
            // 
            // descripcionActTextBox2
            // 
            descripcionActTextBox2.Location = new Point(483, 130);
            descripcionActTextBox2.Name = "descripcionActTextBox2";
            descripcionActTextBox2.Size = new Size(212, 27);
            descripcionActTextBox2.TabIndex = 6;
            // 
            // nombreActTextBox1
            // 
            nombreActTextBox1.Location = new Point(483, 78);
            nombreActTextBox1.Name = "nombreActTextBox1";
            nombreActTextBox1.Size = new Size(212, 27);
            nombreActTextBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 31);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 10;
            label1.Text = "Bodega Ahora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(523, 31);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 11;
            label2.Text = "Bodega Actualizada";
            // 
            // button2
            // 
            button2.Location = new Point(342, 415);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // VerBodega
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(vinosActListBox1);
            Controls.Add(periodoActTextBox3);
            Controls.Add(coordenadaActTextBox4);
            Controls.Add(descripcionActTextBox2);
            Controls.Add(nombreActTextBox1);
            Controls.Add(vinosListBox1);
            Controls.Add(periodoTextBox3);
            Controls.Add(coordenadaTextBox4);
            Controls.Add(descripcionTextBox2);
            Controls.Add(nombreTextBox1);
            Name = "VerBodega";
            Text = "VerBodega";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreTextBox1;
        private TextBox descripcionTextBox2;
        private TextBox periodoTextBox3;
        private TextBox coordenadaTextBox4;
        private ListBox vinosListBox1;
        private ListBox vinosActListBox1;
        private TextBox periodoActTextBox3;
        private TextBox coordenadaActTextBox4;
        private TextBox descripcionActTextBox2;
        private TextBox nombreActTextBox1;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}