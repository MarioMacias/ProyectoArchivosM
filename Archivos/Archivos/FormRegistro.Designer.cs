﻿namespace Archivos
{
    partial class FormRegistro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            this.dgv_Registro = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebaArbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerArbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secuencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secuencialIndexadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_regresaEntidad = new System.Windows.Forms.Button();
            this.btn_Foranea = new System.Windows.Forms.Button();
            this.cb_foraneo = new System.Windows.Forms.ComboBox();
            this.lbl_Foranea = new System.Windows.Forms.Label();
            this.conClavePrimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registro)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Registro
            // 
            this.dgv_Registro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Registro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Registro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Registro.Location = new System.Drawing.Point(12, 37);
            this.dgv_Registro.Name = "dgv_Registro";
            this.dgv_Registro.Size = new System.Drawing.Size(806, 342);
            this.dgv_Registro.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.pruebaArbolToolStripMenuItem,
            this.leerArbolToolStripMenuItem,
            this.secuencialToolStripMenuItem,
            this.secuencialIndexadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Guardar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conClavePrimToolStripMenuItem,
            this.otroToolStripMenuItem});
            this.modificarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // pruebaArbolToolStripMenuItem
            // 
            this.pruebaArbolToolStripMenuItem.Name = "pruebaArbolToolStripMenuItem";
            this.pruebaArbolToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.pruebaArbolToolStripMenuItem.Text = "prueba arbol";
            this.pruebaArbolToolStripMenuItem.Visible = false;
            this.pruebaArbolToolStripMenuItem.Click += new System.EventHandler(this.pruebaArbolToolStripMenuItem_Click);
            // 
            // leerArbolToolStripMenuItem
            // 
            this.leerArbolToolStripMenuItem.Name = "leerArbolToolStripMenuItem";
            this.leerArbolToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.leerArbolToolStripMenuItem.Text = "Leer arbol";
            this.leerArbolToolStripMenuItem.Visible = false;
            this.leerArbolToolStripMenuItem.Click += new System.EventHandler(this.leerArbolToolStripMenuItem_Click);
            // 
            // secuencialToolStripMenuItem
            // 
            this.secuencialToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.secuencialToolStripMenuItem.Name = "secuencialToolStripMenuItem";
            this.secuencialToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.secuencialToolStripMenuItem.Text = "Secuencial";
            this.secuencialToolStripMenuItem.Visible = false;
            this.secuencialToolStripMenuItem.Click += new System.EventHandler(this.secuencialToolStripMenuItem_Click);
            // 
            // secuencialIndexadoToolStripMenuItem
            // 
            this.secuencialIndexadoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.secuencialIndexadoToolStripMenuItem.Name = "secuencialIndexadoToolStripMenuItem";
            this.secuencialIndexadoToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.secuencialIndexadoToolStripMenuItem.Text = "Secuencial Indexado";
            this.secuencialIndexadoToolStripMenuItem.Visible = false;
            this.secuencialIndexadoToolStripMenuItem.Click += new System.EventHandler(this.secuencialIndexadoToolStripMenuItem_Click);
            // 
            // btn_regresaEntidad
            // 
            this.btn_regresaEntidad.AutoSize = true;
            this.btn_regresaEntidad.BackColor = System.Drawing.Color.Black;
            this.btn_regresaEntidad.FlatAppearance.BorderSize = 0;
            this.btn_regresaEntidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresaEntidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_regresaEntidad.Location = new System.Drawing.Point(691, 383);
            this.btn_regresaEntidad.Margin = new System.Windows.Forms.Padding(1);
            this.btn_regresaEntidad.Name = "btn_regresaEntidad";
            this.btn_regresaEntidad.Size = new System.Drawing.Size(127, 23);
            this.btn_regresaEntidad.TabIndex = 8;
            this.btn_regresaEntidad.Text = "Tabla de entidades";
            this.btn_regresaEntidad.UseVisualStyleBackColor = false;
            this.btn_regresaEntidad.Click += new System.EventHandler(this.btn_regresaEntidad_Click);
            // 
            // btn_Foranea
            // 
            this.btn_Foranea.AutoSize = true;
            this.btn_Foranea.BackColor = System.Drawing.Color.Black;
            this.btn_Foranea.FlatAppearance.BorderSize = 0;
            this.btn_Foranea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Foranea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Foranea.Location = new System.Drawing.Point(553, 383);
            this.btn_Foranea.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Foranea.Name = "btn_Foranea";
            this.btn_Foranea.Size = new System.Drawing.Size(127, 23);
            this.btn_Foranea.TabIndex = 9;
            this.btn_Foranea.Text = "Ver Registros Foraneos";
            this.btn_Foranea.UseVisualStyleBackColor = false;
            this.btn_Foranea.Visible = false;
            this.btn_Foranea.Click += new System.EventHandler(this.btn_Foranea_Click);
            // 
            // cb_foraneo
            // 
            this.cb_foraneo.FormattingEnabled = true;
            this.cb_foraneo.Location = new System.Drawing.Point(413, 385);
            this.cb_foraneo.Name = "cb_foraneo";
            this.cb_foraneo.Size = new System.Drawing.Size(121, 21);
            this.cb_foraneo.TabIndex = 10;
            this.cb_foraneo.Visible = false;
            // 
            // lbl_Foranea
            // 
            this.lbl_Foranea.AutoSize = true;
            this.lbl_Foranea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Foranea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Foranea.Location = new System.Drawing.Point(275, 386);
            this.lbl_Foranea.Name = "lbl_Foranea";
            this.lbl_Foranea.Size = new System.Drawing.Size(132, 20);
            this.lbl_Foranea.TabIndex = 11;
            this.lbl_Foranea.Text = "Registro foraneo:";
            this.lbl_Foranea.Visible = false;
            // 
            // conClavePrimToolStripMenuItem
            // 
            this.conClavePrimToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.conClavePrimToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.conClavePrimToolStripMenuItem.Name = "conClavePrimToolStripMenuItem";
            this.conClavePrimToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.conClavePrimToolStripMenuItem.Text = "Con clave prim";
            this.conClavePrimToolStripMenuItem.Click += new System.EventHandler(this.conClavePrimToolStripMenuItem_Click);
            // 
            // otroToolStripMenuItem
            // 
            this.otroToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.otroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.otroToolStripMenuItem.Name = "otroToolStripMenuItem";
            this.otroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otroToolStripMenuItem.Text = "Otro";
            this.otroToolStripMenuItem.Click += new System.EventHandler(this.otroToolStripMenuItem_Click);
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(830, 414);
            this.Controls.Add(this.lbl_Foranea);
            this.Controls.Add(this.cb_foraneo);
            this.Controls.Add(this.btn_Foranea);
            this.Controls.Add(this.btn_regresaEntidad);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgv_Registro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistro";
            this.Text = "Registros de la entidad";
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registro)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Registro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.Button btn_regresaEntidad;
        private System.Windows.Forms.ToolStripMenuItem pruebaArbolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leerArbolToolStripMenuItem;
        private System.Windows.Forms.Button btn_Foranea;
        private System.Windows.Forms.ComboBox cb_foraneo;
        private System.Windows.Forms.Label lbl_Foranea;
        private System.Windows.Forms.ToolStripMenuItem secuencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secuencialIndexadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conClavePrimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otroToolStripMenuItem;
    }
}