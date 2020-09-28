namespace Ejercicios09Punto03.Windows
{
    partial class FrmRectangulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRectangulos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OrdenarToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AscXladomayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DescXLadomayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ActualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.cmnLadoMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnLadoMenor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnPerimeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnSuperficie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.BorrarToolStripButton,
            this.EditarToolStripButton,
            this.toolStripSeparator1,
            this.OrdenarToolStripDropDownButton,
            this.FiltrarToolStripButton,
            this.ActualizarToolStripButton,
            this.toolStripSeparator2,
            this.SalirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(908, 58);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoToolStripButton.Image")));
            this.NuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 55);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarToolStripButton.Image")));
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(43, 55);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditarToolStripButton.Image")));
            this.EditarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(41, 55);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarToolStripButton.Click += new System.EventHandler(this.EditarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // OrdenarToolStripDropDownButton
            // 
            this.OrdenarToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AscXladomayorToolStripMenuItem,
            this.DescXLadomayorToolStripMenuItem});
            this.OrdenarToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("OrdenarToolStripDropDownButton.Image")));
            this.OrdenarToolStripDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OrdenarToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenarToolStripDropDownButton.Name = "OrdenarToolStripDropDownButton";
            this.OrdenarToolStripDropDownButton.Size = new System.Drawing.Size(63, 55);
            this.OrdenarToolStripDropDownButton.Text = "Ordenar";
            this.OrdenarToolStripDropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // AscXladomayorToolStripMenuItem
            // 
            this.AscXladomayorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AscXladomayorToolStripMenuItem.Image")));
            this.AscXladomayorToolStripMenuItem.Name = "AscXladomayorToolStripMenuItem";
            this.AscXladomayorToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.AscXladomayorToolStripMenuItem.Text = "Asc x Lado mayor";
            this.AscXladomayorToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AscXladomayorToolStripMenuItem.Click += new System.EventHandler(this.AscXladomayorToolStripMenuItem_Click);
            // 
            // DescXLadomayorToolStripMenuItem
            // 
            this.DescXLadomayorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DescXLadomayorToolStripMenuItem.Image")));
            this.DescXLadomayorToolStripMenuItem.Name = "DescXLadomayorToolStripMenuItem";
            this.DescXLadomayorToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.DescXLadomayorToolStripMenuItem.Text = "Desc x Lado mayor";
            this.DescXLadomayorToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DescXLadomayorToolStripMenuItem.Click += new System.EventHandler(this.DescXLadomayorToolStripMenuItem_Click);
            // 
            // FiltrarToolStripButton
            // 
            this.FiltrarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FiltrarToolStripButton.Image")));
            this.FiltrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiltrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarToolStripButton.Name = "FiltrarToolStripButton";
            this.FiltrarToolStripButton.Size = new System.Drawing.Size(40, 55);
            this.FiltrarToolStripButton.Text = "Filtro";
            this.FiltrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FiltrarToolStripButton.Click += new System.EventHandler(this.FiltrarToolStripButton_Click);
            // 
            // ActualizarToolStripButton
            // 
            this.ActualizarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ActualizarToolStripButton.Image")));
            this.ActualizarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarToolStripButton.Name = "ActualizarToolStripButton";
            this.ActualizarToolStripButton.Size = new System.Drawing.Size(63, 55);
            this.ActualizarToolStripButton.Text = "Actualizar";
            this.ActualizarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ActualizarToolStripButton.Click += new System.EventHandler(this.ActualizarToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // SalirToolStripButton
            // 
            this.SalirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SalirToolStripButton.Image")));
            this.SalirToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(40, 55);
            this.SalirToolStripButton.Text = "Salir";
            this.SalirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DatosDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 451);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CantidadTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 81);
            this.panel2.TabIndex = 1;
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CantidadTextBox.Location = new System.Drawing.Point(160, 27);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(100, 23);
            this.CantidadTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de registros:";
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnLadoMayor,
            this.cmnLadoMenor,
            this.cmnPerimeto,
            this.cmnSuperficie});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(908, 451);
            this.DatosDataGridView.TabIndex = 0;
            this.DatosDataGridView.Text = "dataGridView1";
            // 
            // cmnLadoMayor
            // 
            this.cmnLadoMayor.HeaderText = "L. Mayor";
            this.cmnLadoMayor.Name = "cmnLadoMayor";
            this.cmnLadoMayor.ReadOnly = true;
            this.cmnLadoMayor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmnLadoMayor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmnLadoMenor
            // 
            this.cmnLadoMenor.HeaderText = "L. Menor";
            this.cmnLadoMenor.Name = "cmnLadoMenor";
            this.cmnLadoMenor.ReadOnly = true;
            this.cmnLadoMenor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmnLadoMenor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmnPerimeto
            // 
            this.cmnPerimeto.HeaderText = "Perímetro";
            this.cmnPerimeto.Name = "cmnPerimeto";
            this.cmnPerimeto.ReadOnly = true;
            this.cmnPerimeto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmnPerimeto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmnSuperficie
            // 
            this.cmnSuperficie.HeaderText = "Superficie";
            this.cmnSuperficie.Name = "cmnSuperficie";
            this.cmnSuperficie.ReadOnly = true;
            this.cmnSuperficie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmnSuperficie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmRectangulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRectangulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRectangulos";
            this.Load += new System.EventHandler(this.FrmRectangulos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripDropDownButton OrdenarToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem AscXladomayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DescXLadomayorToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnLadoMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnLadoMenor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnPerimeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnSuperficie;
        private System.Windows.Forms.ToolStripButton ActualizarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton FiltrarToolStripButton;
    }
}