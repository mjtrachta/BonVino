namespace VinoApp.Boundary.Bodegas
{
    partial class InterfazNotificacion
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
            labelNotificacion = new Label();
            SuspendLayout();
            // 
            // labelNotificacion
            // 
            labelNotificacion.AutoSize = true;
            labelNotificacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelNotificacion.Location = new Point(28, 71);
            labelNotificacion.Name = "labelNotificacion";
            labelNotificacion.Size = new Size(554, 28);
            labelNotificacion.TabIndex = 0;
            labelNotificacion.Text = "Se ha notificado a los enofilos las actualizaciones realizadas!";
            // 
            // InterfazNotificacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 179);
            Controls.Add(labelNotificacion);
            Name = "InterfazNotificacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InterfazNotificacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNotificacion;
    }
}