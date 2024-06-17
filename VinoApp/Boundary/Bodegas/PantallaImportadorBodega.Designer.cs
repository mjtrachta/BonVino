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
            listViewBodegas.Location = new Point(199, 100);
            listViewBodegas.Name = "listViewBodegas";
            listViewBodegas.Size = new Size(439, 301);
            listViewBodegas.TabIndex = 0;
            listViewBodegas.UseCompatibleStateImageBehavior = false;
            listViewBodegas.View = View.List;
            listViewBodegas.SelectedIndexChanged += listViewBodegas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 47);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 1;
            label1.Text = "Bodegas por Actualizar";
            // 
            // PantallaImportadorBodega
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listViewBodegas);
            Name = "PantallaImportadorBodega";
            Text = "PantallaImportadorBodega";
            Load += PantallaImportadorBodega_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
