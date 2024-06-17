namespace VinoApp.Formularios.Bodegas
{
    partial class PantallaImportadorBodega
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Agrega un ListView al formulario
        private System.Windows.Forms.ListView listViewBodegas;

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
            listViewBodegas = new ListView();
            label1 = new Label();
            SuspendLayout();
            // 
            // listViewBodegas
            // 
            listViewBodegas.BackColor = SystemColors.ControlLight;
            listViewBodegas.Location = new Point(54, 36);
            listViewBodegas.Margin = new Padding(3, 2, 3, 2);
            listViewBodegas.Name = "listViewBodegas";
            listViewBodegas.Size = new Size(173, 204);
            listViewBodegas.TabIndex = 0;
            listViewBodegas.UseCompatibleStateImageBehavior = false;
            listViewBodegas.View = View.List;
            listViewBodegas.SelectedIndexChanged += listViewBodegas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 15);
            label1.TabIndex = 1;
            label1.Text = "Bodegas con actualizacion disponible";
            // 
            // PantallaImportadorBodega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(290, 305);
            Controls.Add(label1);
            Controls.Add(listViewBodegas);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PantallaImportadorBodega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaImportadorBodega";
            Load += PantallaImportadorBodega_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}

