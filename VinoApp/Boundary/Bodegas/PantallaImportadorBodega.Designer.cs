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
            labelBodegasConActDisponible = new Label();
            SuspendLayout();
            // 
            // listViewBodegas
            // 
            listViewBodegas.BackColor = SystemColors.ControlLight;
            listViewBodegas.Location = new Point(62, 48);
            listViewBodegas.Name = "listViewBodegas";
            listViewBodegas.Size = new Size(197, 271);
            listViewBodegas.TabIndex = 0;
            listViewBodegas.UseCompatibleStateImageBehavior = false;
            listViewBodegas.View = View.List;
            listViewBodegas.SelectedIndexChanged += listViewBodegas_SelectedIndexChanged;
            // 
            // labelBodegasConActDisponible
            // 
            labelBodegasConActDisponible.AutoSize = true;
            labelBodegasConActDisponible.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBodegasConActDisponible.ForeColor = SystemColors.ControlText;
            labelBodegasConActDisponible.Location = new Point(43, 12);
            labelBodegasConActDisponible.Name = "labelBodegasConActDisponible";
            labelBodegasConActDisponible.Size = new Size(268, 20);
            labelBodegasConActDisponible.TabIndex = 1;
            labelBodegasConActDisponible.Text = "Bodegas con actualizacion disponible";
            // 
            // PantallaImportadorBodega
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(331, 407);
            Controls.Add(labelBodegasConActDisponible);
            Controls.Add(listViewBodegas);
            ForeColor = SystemColors.ControlText;
            Name = "PantallaImportadorBodega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaImportadorBodega";
            Load += PantallaImportadorBodega_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBodegasConActDisponible;
    }
}

