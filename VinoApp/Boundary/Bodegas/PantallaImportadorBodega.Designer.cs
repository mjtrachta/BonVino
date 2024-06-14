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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "PantallaImportadorBodega";

            // Inicializa el ListView
            this.listViewBodegas = new System.Windows.Forms.ListView();
            this.listViewBodegas.Location = new System.Drawing.Point(12, 12);
            this.listViewBodegas.Size = new System.Drawing.Size(300, 400); // Ajusta el tamaño según tu diseño
            this.listViewBodegas.View = System.Windows.Forms.View.List;
            this.listViewBodegas.SelectedIndexChanged += new System.EventHandler(this.listViewBodegas_SelectedIndexChanged);
            this.Controls.Add(this.listViewBodegas);

            // Puedes agregar más configuraciones al ListView según sea necesario

            // Llama al método Load de tu formulario
            this.Load += new System.EventHandler(this.PantallaImportadorBodega_Load);
        }

        #endregion
    }
}
