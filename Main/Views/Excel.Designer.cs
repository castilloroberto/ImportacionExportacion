
namespace ImportacionExportacion
{
    partial class Excel
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_query = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre_archivoExportar = new System.Windows.Forms.TextBox();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_guardar_archivo = new System.Windows.Forms.Button();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_archivo_importar = new System.Windows.Forms.TextBox();
            this.btn_importar = new System.Windows.Forms.Button();
            this.btn_guardar_db = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_volver_insersion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(445, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exportacion de datos desde DB a Excel";
            // 
            // txt_query
            // 
            this.txt_query.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_query.Location = new System.Drawing.Point(105, 94);
            this.txt_query.Multiline = true;
            this.txt_query.Name = "txt_query";
            this.txt_query.Size = new System.Drawing.Size(319, 230);
            this.txt_query.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Query";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre Archivo Excel";
            // 
            // txt_nombre_archivoExportar
            // 
            this.txt_nombre_archivoExportar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_archivoExportar.Location = new System.Drawing.Point(450, 128);
            this.txt_nombre_archivoExportar.Name = "txt_nombre_archivoExportar";
            this.txt_nombre_archivoExportar.Size = new System.Drawing.Size(319, 34);
            this.txt_nombre_archivoExportar.TabIndex = 2;
            // 
            // btn_exportar
            // 
            this.btn_exportar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportar.Location = new System.Drawing.Point(815, 125);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(200, 37);
            this.btn_exportar.TabIndex = 3;
            this.btn_exportar.Text = "Exportar Datos";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // btn_guardar_archivo
            // 
            this.btn_guardar_archivo.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_archivo.Location = new System.Drawing.Point(1021, 125);
            this.btn_guardar_archivo.Name = "btn_guardar_archivo";
            this.btn_guardar_archivo.Size = new System.Drawing.Size(200, 37);
            this.btn_guardar_archivo.TabIndex = 3;
            this.btn_guardar_archivo.Text = "Guardar Archivo";
            this.btn_guardar_archivo.UseVisualStyleBackColor = true;
            this.btn_guardar_archivo.Click += new System.EventHandler(this.btn_guardar_archivo_Click);
            // 
            // dgv_datos
            // 
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(105, 401);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.RowHeadersWidth = 51;
            this.dgv_datos.RowTemplate.Height = 24;
            this.dgv_datos.Size = new System.Drawing.Size(1116, 235);
            this.dgv_datos.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre Archivo Excel";
            // 
            // txt_archivo_importar
            // 
            this.txt_archivo_importar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_archivo_importar.Location = new System.Drawing.Point(450, 290);
            this.txt_archivo_importar.Name = "txt_archivo_importar";
            this.txt_archivo_importar.Size = new System.Drawing.Size(319, 34);
            this.txt_archivo_importar.TabIndex = 2;
            // 
            // btn_importar
            // 
            this.btn_importar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_importar.Location = new System.Drawing.Point(815, 287);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(200, 37);
            this.btn_importar.TabIndex = 3;
            this.btn_importar.Text = "Importar Datos";
            this.btn_importar.UseVisualStyleBackColor = true;
            this.btn_importar.Click += new System.EventHandler(this.btn_importar_Click);
            // 
            // btn_guardar_db
            // 
            this.btn_guardar_db.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_db.Location = new System.Drawing.Point(1021, 287);
            this.btn_guardar_db.Name = "btn_guardar_db";
            this.btn_guardar_db.Size = new System.Drawing.Size(200, 37);
            this.btn_guardar_db.TabIndex = 3;
            this.btn_guardar_db.Text = "Guardar en DB";
            this.btn_guardar_db.UseVisualStyleBackColor = true;
            this.btn_guardar_db.Click += new System.EventHandler(this.btn_guardar_db_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(445, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Importar datos desde Excel";
            // 
            // btn_volver_insersion
            // 
            this.btn_volver_insersion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_volver_insersion.FlatAppearance.BorderSize = 0;
            this.btn_volver_insersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver_insersion.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver_insersion.ForeColor = System.Drawing.Color.White;
            this.btn_volver_insersion.Location = new System.Drawing.Point(105, 651);
            this.btn_volver_insersion.Name = "btn_volver_insersion";
            this.btn_volver_insersion.Size = new System.Drawing.Size(262, 37);
            this.btn_volver_insersion.TabIndex = 3;
            this.btn_volver_insersion.Text = "Volver Insersion Categorias";
            this.btn_volver_insersion.UseVisualStyleBackColor = false;
            this.btn_volver_insersion.Click += new System.EventHandler(this.btn_volver_insersion_Click);
            // 
            // Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 700);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.btn_volver_insersion);
            this.Controls.Add(this.btn_guardar_db);
            this.Controls.Add(this.btn_guardar_archivo);
            this.Controls.Add(this.btn_importar);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.txt_archivo_importar);
            this.Controls.Add(this.txt_nombre_archivoExportar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_query);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Excel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_query;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre_archivoExportar;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_guardar_archivo;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_archivo_importar;
        private System.Windows.Forms.Button btn_importar;
        private System.Windows.Forms.Button btn_guardar_db;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_volver_insersion;
    }
}