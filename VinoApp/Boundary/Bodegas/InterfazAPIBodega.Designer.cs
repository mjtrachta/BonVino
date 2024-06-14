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
            label2 = new Label();
            button2 = new Button();
            vinosDataGridView = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Aniada = new DataGridViewTextBoxColumn();
            ImagenEtiqueta = new DataGridViewTextBoxColumn();
            NotaDeCataBodega = new DataGridViewTextBoxColumn();
            PrecioArs = new DataGridViewTextBoxColumn();
            Maridaje = new DataGridViewTextBoxColumn();
            Varietal = new DataGridViewTextBoxColumn();
            Bodega = new DataGridViewTextBoxColumn();
            vinosActDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)vinosDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vinosActDataGridView).BeginInit();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(891, 59);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 11;
            label2.Text = "Bodega Actualizada";
            // 
            // button2
            // 
            button2.Location = new Point(616, 417);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            // vinosActDataGridView
            // 
            vinosActDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vinosActDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            vinosActDataGridView.Location = new Point(664, 128);
            vinosActDataGridView.Name = "vinosActDataGridView";
            vinosActDataGridView.RowHeadersWidth = 51;
            vinosActDataGridView.RowTemplate.Height = 29;
            vinosActDataGridView.Size = new Size(646, 259);
            vinosActDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Aniada";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "ImagenEtiqueta";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "NotaDeCataBodega";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "PrecioArs";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Maridaje";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Varietal";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Bodega";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // InterfazAPIBodega
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 505);
            Controls.Add(vinosActDataGridView);
            Controls.Add(vinosDataGridView);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InterfazAPIBodega";
            Text = "VerBodega";
            ((System.ComponentModel.ISupportInitialize)vinosDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)vinosActDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button button2;
        private DataGridView vinosDataGridView;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Aniada;
        private DataGridViewTextBoxColumn ImagenEtiqueta;
        private DataGridViewTextBoxColumn NotaDeCataBodega;
        private DataGridViewTextBoxColumn PrecioArs;
        private DataGridViewTextBoxColumn Maridaje;
        private DataGridViewTextBoxColumn Varietal;
        private DataGridViewTextBoxColumn Bodega;
        private DataGridView vinosActDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}