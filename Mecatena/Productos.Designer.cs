
namespace Mecatena
{
    partial class Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_tipo = new System.Windows.Forms.Label();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.l_productos = new System.Windows.Forms.Label();
            this.l_cantidad = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.l_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_precioU = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.l_precioU = new System.Windows.Forms.Label();
            this.l_total = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.l_idprod = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, -7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(867, 38);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // l_tipo
            // 
            this.l_tipo.AutoSize = true;
            this.l_tipo.BackColor = System.Drawing.Color.Transparent;
            this.l_tipo.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_tipo.Location = new System.Drawing.Point(66, 249);
            this.l_tipo.Name = "l_tipo";
            this.l_tipo.Size = new System.Drawing.Size(66, 34);
            this.l_tipo.TabIndex = 6;
            this.l_tipo.Text = "Tipo";
            // 
            // txt_tipo
            // 
            this.txt_tipo.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo.Location = new System.Drawing.Point(278, 246);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(389, 38);
            this.txt_tipo.TabIndex = 8;
            // 
            // l_productos
            // 
            this.l_productos.AutoSize = true;
            this.l_productos.BackColor = System.Drawing.Color.White;
            this.l_productos.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_productos.Location = new System.Drawing.Point(356, 80);
            this.l_productos.Name = "l_productos";
            this.l_productos.Size = new System.Drawing.Size(167, 34);
            this.l_productos.TabIndex = 9;
            this.l_productos.Text = "PRODUCTOS";
            this.l_productos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_cantidad
            // 
            this.l_cantidad.AutoSize = true;
            this.l_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.l_cantidad.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_cantidad.Location = new System.Drawing.Point(66, 345);
            this.l_cantidad.Name = "l_cantidad";
            this.l_cantidad.Size = new System.Drawing.Size(126, 34);
            this.l_cantidad.TabIndex = 10;
            this.l_cantidad.Text = "Cantidad";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(278, 342);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(389, 38);
            this.txt_cantidad.TabIndex = 11;
            // 
            // l_descripcion
            // 
            this.l_descripcion.AutoSize = true;
            this.l_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.l_descripcion.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_descripcion.Location = new System.Drawing.Point(66, 444);
            this.l_descripcion.Name = "l_descripcion";
            this.l_descripcion.Size = new System.Drawing.Size(160, 34);
            this.l_descripcion.TabIndex = 12;
            this.l_descripcion.Text = "Descripción";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(278, 441);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(389, 38);
            this.txt_descripcion.TabIndex = 13;
            // 
            // txt_precioU
            // 
            this.txt_precioU.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioU.Location = new System.Drawing.Point(278, 538);
            this.txt_precioU.Name = "txt_precioU";
            this.txt_precioU.Size = new System.Drawing.Size(389, 38);
            this.txt_precioU.TabIndex = 14;
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(278, 635);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(389, 38);
            this.txt_total.TabIndex = 15;
            // 
            // l_precioU
            // 
            this.l_precioU.AutoSize = true;
            this.l_precioU.BackColor = System.Drawing.Color.Transparent;
            this.l_precioU.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_precioU.Location = new System.Drawing.Point(66, 541);
            this.l_precioU.Name = "l_precioU";
            this.l_precioU.Size = new System.Drawing.Size(196, 34);
            this.l_precioU.TabIndex = 16;
            this.l_precioU.Text = "Precio Unitario";
            // 
            // l_total
            // 
            this.l_total.AutoSize = true;
            this.l_total.BackColor = System.Drawing.Color.Transparent;
            this.l_total.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_total.Location = new System.Drawing.Point(66, 637);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(75, 34);
            this.l_total.TabIndex = 17;
            this.l_total.Text = "Total";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 51);
            this.panel2.TabIndex = 21;
            // 
            // dgv_datos
            // 
            this.dgv_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_datos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_datos.GridColor = System.Drawing.Color.DarkBlue;
            this.dgv_datos.Location = new System.Drawing.Point(131, 52);
            this.dgv_datos.MultiSelect = false;
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_datos.Size = new System.Drawing.Size(608, 241);
            this.dgv_datos.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dgv_datos);
            this.panel3.Location = new System.Drawing.Point(0, 720);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 336);
            this.panel3.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 34);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tabla Productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.Transparent;
            this.btn_save.Location = new System.Drawing.Point(732, 171);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 90);
            this.btn_save.TabIndex = 25;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.Color.Transparent;
            this.btn_search.Location = new System.Drawing.Point(732, 561);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(90, 90);
            this.btn_search.TabIndex = 26;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_edit.BackgroundImage")));
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_edit.Location = new System.Drawing.Point(732, 304);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(90, 90);
            this.btn_edit.TabIndex = 27;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.Transparent;
            this.btn_delete.Location = new System.Drawing.Point(732, 433);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 90);
            this.btn_delete.TabIndex = 28;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_producto
            // 
            this.txt_producto.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_producto.Location = new System.Drawing.Point(278, 162);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.ReadOnly = true;
            this.txt_producto.Size = new System.Drawing.Size(389, 38);
            this.txt_producto.TabIndex = 30;
            // 
            // l_idprod
            // 
            this.l_idprod.AutoSize = true;
            this.l_idprod.BackColor = System.Drawing.Color.Transparent;
            this.l_idprod.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_idprod.Location = new System.Drawing.Point(66, 165);
            this.l_idprod.Name = "l_idprod";
            this.l_idprod.Size = new System.Drawing.Size(41, 34);
            this.l_idprod.TabIndex = 29;
            this.l_idprod.Text = "ID";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(867, 1031);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.l_idprod);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.l_total);
            this.Controls.Add(this.l_precioU);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_precioU);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.l_descripcion);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.l_cantidad);
            this.Controls.Add(this.l_productos);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.l_tipo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_tipo;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Label l_productos;
        private System.Windows.Forms.Label l_cantidad;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label l_descripcion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_precioU;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label l_precioU;
        private System.Windows.Forms.Label l_total;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        public System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label l_idprod;
    }
}