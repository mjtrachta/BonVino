namespace VinoApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            bodegasToolStripMenuItem = new ToolStripMenuItem();
            actualizarToolStripMenuItem = new ToolStripMenuItem();
            vinosToolStripMenuItem = new ToolStripMenuItem();
            rankingToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, bodegasToolStripMenuItem, vinosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // bodegasToolStripMenuItem
            // 
            bodegasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { actualizarToolStripMenuItem });
            bodegasToolStripMenuItem.Name = "bodegasToolStripMenuItem";
            bodegasToolStripMenuItem.Size = new Size(81, 24);
            bodegasToolStripMenuItem.Text = "Bodegas";
            bodegasToolStripMenuItem.Click += bodegasToolStripMenuItem_Click;
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(283, 26);
            actualizarToolStripMenuItem.Text = "Importar Actualizacion Vinos";
            actualizarToolStripMenuItem.Click += actualizarToolStripMenuItem_Click;
            // 
            // vinosToolStripMenuItem
            // 
            vinosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rankingToolStripMenuItem });
            vinosToolStripMenuItem.Name = "vinosToolStripMenuItem";
            vinosToolStripMenuItem.Size = new Size(59, 24);
            vinosToolStripMenuItem.Text = "Vinos";
            // 
            // rankingToolStripMenuItem
            // 
            rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            rankingToolStripMenuItem.Size = new Size(145, 26);
            rankingToolStripMenuItem.Text = "Ranking";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem bodegasToolStripMenuItem;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem vinosToolStripMenuItem;
        private ToolStripMenuItem rankingToolStripMenuItem;
    }
}