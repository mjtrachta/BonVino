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
            labelNombreBodega = new Label();
            vinosDataGridView = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Añada = new DataGridViewTextBoxColumn();
            NotaDeCataBodega = new DataGridViewTextBoxColumn();
            PrecioArs = new DataGridViewTextBoxColumn();
            ImagenEtiqueta = new DataGridViewTextBoxColumn();
            Maridaje = new DataGridViewTextBoxColumn();
            Varietal = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)vinosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // labelNombreBodega
            // 
            labelNombreBodega.AutoSize = true;
            labelNombreBodega.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombreBodega.Location = new Point(12, 9);
            labelNombreBodega.Name = "labelNombreBodega";
            labelNombreBodega.Size = new Size(47, 15);
            labelNombreBodega.TabIndex = 10;
            labelNombreBodega.Text = "Bodega";
            // 
            // vinosDataGridView
            // 
            vinosDataGridView.BackgroundColor = SystemColors.ControlLight;
            vinosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vinosDataGridView.Columns.AddRange(new DataGridViewColumn[] { Nombre, Añada, NotaDeCataBodega, PrecioArs, ImagenEtiqueta, Maridaje, Varietal });
            vinosDataGridView.Location = new Point(12, 26);
            vinosDataGridView.Margin = new Padding(3, 2, 3, 2);
            vinosDataGridView.Name = "vinosDataGridView";
            vinosDataGridView.RowHeadersWidth = 51;
            vinosDataGridView.RowTemplate.Height = 29;
            vinosDataGridView.Size = new Size(1056, 194);
            vinosDataGridView.TabIndex = 14;
            vinosDataGridView.CellContentClick += vinosDataGridView_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 150;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Añada
            // 
            Añada.HeaderText = "Aniada";
            Añada.MinimumWidth = 80;
            Añada.Name = "Añada";
            // 
            // NotaDeCataBodega
            // 
            NotaDeCataBodega.HeaderText = "NotaDeCataBodega";
            NotaDeCataBodega.MinimumWidth = 200;
            NotaDeCataBodega.Name = "NotaDeCataBodega";
            NotaDeCataBodega.Width = 200;
            // 
            // PrecioArs
            // 
            PrecioArs.HeaderText = "PrecioArs";
            PrecioArs.MinimumWidth = 100;
            PrecioArs.Name = "PrecioArs";
            // 
            // ImagenEtiqueta
            // 
            ImagenEtiqueta.HeaderText = "ImagenEtiqueta";
            ImagenEtiqueta.MinimumWidth = 150;
            ImagenEtiqueta.Name = "ImagenEtiqueta";
            ImagenEtiqueta.Width = 150;
            // 
            // Maridaje
            // 
            Maridaje.HeaderText = "Maridaje";
            Maridaje.MinimumWidth = 150;
            Maridaje.Name = "Maridaje";
            Maridaje.Width = 150;
            // 
            // Varietal
            // 
            Varietal.HeaderText = "Varietal";
            Varietal.MinimumWidth = 150;
            Varietal.Name = "Varietal";
            Varietal.Width = 150;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 244);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 69);
            textBox1.TabIndex = 15;
            // 

            // 
            // InterfazAPIBodega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1080, 357);
            Controls.Add(textBox1);
            Controls.Add(vinosDataGridView);
            Controls.Add(labelNombreBodega);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InterfazAPIBodega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InterfazAPI";
            ((System.ComponentModel.ISupportInitialize)vinosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelNombreBodega;
        private DataGridView vinosDataGridView;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Añada;
        private DataGridViewTextBoxColumn NotaDeCataBodega;
        private DataGridViewTextBoxColumn PrecioArs;
        private DataGridViewTextBoxColumn ImagenEtiqueta;
        private DataGridViewTextBoxColumn Maridaje;
        private DataGridViewTextBoxColumn Varietal;
    }

}