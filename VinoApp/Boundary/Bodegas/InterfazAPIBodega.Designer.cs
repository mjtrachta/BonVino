namespace VinoApp.Formularios.Bodegas
{
    partial class InterfazAPIBodega
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
            label1 = new Label();
            vinosDataGridView = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Aniada = new DataGridViewTextBoxColumn();
            ImagenEtiqueta = new DataGridViewTextBoxColumn();
            NotaDeCataBodega = new DataGridViewTextBoxColumn();
            PrecioArs = new DataGridViewTextBoxColumn();
            Maridaje = new DataGridViewTextBoxColumn();
            Varietal = new DataGridViewTextBoxColumn();
            Bodega = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)vinosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 59);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 10;
            label1.Text = "Bodega Ahora";
            // 
            // vinosDataGridView
            // 
            vinosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vinosDataGridView.Columns.AddRange(new DataGridViewColumn[] { Nombre, Aniada, ImagenEtiqueta, NotaDeCataBodega, PrecioArs, Maridaje, Varietal, Bodega });
            vinosDataGridView.Location = new Point(12, 128);
            vinosDataGridView.Name = "vinosDataGridView";
            vinosDataGridView.RowHeadersWidth = 51;
            vinosDataGridView.RowTemplate.Height = 29;
            vinosDataGridView.Size = new Size(646, 259);
            vinosDataGridView.TabIndex = 14;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Aniada
            // 
            Aniada.HeaderText = "Aniada";
            Aniada.MinimumWidth = 6;
            Aniada.Name = "Aniada";
            Aniada.Width = 125;
            // 
            // ImagenEtiqueta
            // 
            ImagenEtiqueta.HeaderText = "ImagenEtiqueta";
            ImagenEtiqueta.MinimumWidth = 6;
            ImagenEtiqueta.Name = "ImagenEtiqueta";
            ImagenEtiqueta.Width = 125;
            // 
            // NotaDeCataBodega
            // 
            NotaDeCataBodega.HeaderText = "NotaDeCataBodega";
            NotaDeCataBodega.MinimumWidth = 6;
            NotaDeCataBodega.Name = "NotaDeCataBodega";
            NotaDeCataBodega.Width = 125;
            // 
            // PrecioArs
            // 
            PrecioArs.HeaderText = "PrecioArs";
            PrecioArs.MinimumWidth = 6;
            PrecioArs.Name = "PrecioArs";
            PrecioArs.Width = 125;
            // 
            // Maridaje
            // 
            Maridaje.HeaderText = "Maridaje";
            Maridaje.MinimumWidth = 6;
            Maridaje.Name = "Maridaje";
            Maridaje.Width = 125;
            // 
            // Varietal
            // 
            Varietal.HeaderText = "Varietal";
            Varietal.MinimumWidth = 6;
            Varietal.Name = "Varietal";
            Varietal.Width = 125;
            // 
            // Bodega
            // 
            Bodega.HeaderText = "Bodega";
            Bodega.MinimumWidth = 6;
            Bodega.Name = "Bodega";
            Bodega.Width = 125;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(826, 151);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 15;
            // 
            // InterfazAPIBodega
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 505);
            Controls.Add(textBox1);
            Controls.Add(vinosDataGridView);
            Controls.Add(label1);
            Name = "InterfazAPIBodega";
            Text = "VerBodega";
            ((System.ComponentModel.ISupportInitialize)vinosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView vinosDataGridView;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Aniada;
        private DataGridViewTextBoxColumn ImagenEtiqueta;
        private DataGridViewTextBoxColumn NotaDeCataBodega;
        private DataGridViewTextBoxColumn PrecioArs;
        private DataGridViewTextBoxColumn Maridaje;
        private DataGridViewTextBoxColumn Varietal;
        private DataGridViewTextBoxColumn Bodega;
        private TextBox textBox1;
    }
}