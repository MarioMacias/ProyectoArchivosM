namespace Archivos
{
    partial class FormIndiceHash
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
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_Indice = new System.Windows.Forms.Label();
            this.btn_regresaEntidad = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgv_Direcciones = new System.Windows.Forms.DataGridView();
            this.dgv_IndiceHash = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_funcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Direcciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IndiceHash)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.BackColor = System.Drawing.Color.DimGray;
            this.lbl_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_direccion.Location = new System.Drawing.Point(487, 5);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(173, 24);
            this.lbl_direccion.TabIndex = 18;
            this.lbl_direccion.Text = "DIRECCIÓN  DE: ";
            // 
            // lbl_Indice
            // 
            this.lbl_Indice.AutoSize = true;
            this.lbl_Indice.BackColor = System.Drawing.Color.DimGray;
            this.lbl_Indice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Indice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Indice.Location = new System.Drawing.Point(116, 5);
            this.lbl_Indice.Name = "lbl_Indice";
            this.lbl_Indice.Size = new System.Drawing.Size(140, 24);
            this.lbl_Indice.TabIndex = 17;
            this.lbl_Indice.Text = "INDICE HASH";
            // 
            // btn_regresaEntidad
            // 
            this.btn_regresaEntidad.AutoSize = true;
            this.btn_regresaEntidad.BackColor = System.Drawing.Color.Black;
            this.btn_regresaEntidad.FlatAppearance.BorderSize = 0;
            this.btn_regresaEntidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresaEntidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_regresaEntidad.Location = new System.Drawing.Point(739, 446);
            this.btn_regresaEntidad.Margin = new System.Windows.Forms.Padding(1);
            this.btn_regresaEntidad.Name = "btn_regresaEntidad";
            this.btn_regresaEntidad.Size = new System.Drawing.Size(127, 23);
            this.btn_regresaEntidad.TabIndex = 16;
            this.btn_regresaEntidad.Text = "Tabla de entidades";
            this.btn_regresaEntidad.UseVisualStyleBackColor = false;
            this.btn_regresaEntidad.Click += new System.EventHandler(this.btn_regresaEntidad_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgv_Direcciones
            // 
            this.dgv_Direcciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Direcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Direcciones.Location = new System.Drawing.Point(442, 35);
            this.dgv_Direcciones.Name = "dgv_Direcciones";
            this.dgv_Direcciones.ReadOnly = true;
            this.dgv_Direcciones.Size = new System.Drawing.Size(424, 407);
            this.dgv_Direcciones.TabIndex = 14;
            // 
            // dgv_IndiceHash
            // 
            this.dgv_IndiceHash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_IndiceHash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IndiceHash.Location = new System.Drawing.Point(12, 35);
            this.dgv_IndiceHash.Name = "dgv_IndiceHash";
            this.dgv_IndiceHash.ReadOnly = true;
            this.dgv_IndiceHash.Size = new System.Drawing.Size(424, 407);
            this.dgv_IndiceHash.TabIndex = 13;
            this.dgv_IndiceHash.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_IndiceHash_CellMouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Numero de cajones a utilizar: 7";
            // 
            // lbl_funcion
            // 
            this.lbl_funcion.AutoSize = true;
            this.lbl_funcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_funcion.ForeColor = System.Drawing.Color.White;
            this.lbl_funcion.Location = new System.Drawing.Point(363, 449);
            this.lbl_funcion.Name = "lbl_funcion";
            this.lbl_funcion.Size = new System.Drawing.Size(73, 20);
            this.lbl_funcion.TabIndex = 20;
            this.lbl_funcion.Text = "Funcion";
            // 
            // FormIndiceHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(879, 473);
            this.Controls.Add(this.lbl_funcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_Indice);
            this.Controls.Add(this.btn_regresaEntidad);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgv_Direcciones);
            this.Controls.Add(this.dgv_IndiceHash);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "FormIndiceHash";
            this.Text = "FormIndiceHash";
            this.Load += new System.EventHandler(this.FormIndiceHash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Direcciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IndiceHash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_Indice;
        private System.Windows.Forms.Button btn_regresaEntidad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgv_Direcciones;
        private System.Windows.Forms.DataGridView dgv_IndiceHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_funcion;
    }
}