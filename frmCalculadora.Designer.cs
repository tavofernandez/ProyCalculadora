
namespace ProyCalculadora
{
    partial class frmCalculadora
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lbloperacion = new System.Windows.Forms.Label();
            this.btncopiar = new System.Windows.Forms.Button();
            this.txtpantalla = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnmultiplicacion = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.panelnumerico = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnporcentaje = new System.Windows.Forms.Button();
            this.btnoff = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 599);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ProyCalculadora.Properties.Resources.smartphone;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.lblnum1);
            this.panel2.Controls.Add(this.lbloperacion);
            this.panel2.Controls.Add(this.btncopiar);
            this.panel2.Controls.Add(this.txtpantalla);
            this.panel2.Controls.Add(this.flowLayoutPanel3);
            this.panel2.Controls.Add(this.panelnumerico);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(154, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 599);
            this.panel2.TabIndex = 1;
            // 
            // lblnum1
            // 
            this.lblnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.ForeColor = System.Drawing.Color.Black;
            this.lblnum1.Location = new System.Drawing.Point(200, 143);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(267, 23);
            this.lblnum1.TabIndex = 5;
            this.lblnum1.Text = "0";
            this.lblnum1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbloperacion
            // 
            this.lbloperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloperacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbloperacion.Location = new System.Drawing.Point(367, 166);
            this.lbloperacion.Name = "lbloperacion";
            this.lbloperacion.Size = new System.Drawing.Size(100, 23);
            this.lbloperacion.TabIndex = 5;
            this.lbloperacion.Text = "0";
            this.lbloperacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btncopiar
            // 
            this.btncopiar.BackgroundImage = global::ProyCalculadora.Properties.Resources.copiar;
            this.btncopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncopiar.FlatAppearance.BorderSize = 0;
            this.btncopiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncopiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btncopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncopiar.ForeColor = System.Drawing.Color.White;
            this.btncopiar.Location = new System.Drawing.Point(200, 190);
            this.btncopiar.Name = "btncopiar";
            this.btncopiar.Size = new System.Drawing.Size(40, 40);
            this.btncopiar.TabIndex = 4;
            this.btncopiar.UseVisualStyleBackColor = true;
            this.btncopiar.Click += new System.EventHandler(this.btncopiar_Click);
            // 
            // txtpantalla
            // 
            this.txtpantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpantalla.Location = new System.Drawing.Point(261, 192);
            this.txtpantalla.Name = "txtpantalla";
            this.txtpantalla.ReadOnly = true;
            this.txtpantalla.Size = new System.Drawing.Size(206, 38);
            this.txtpantalla.TabIndex = 3;
            this.txtpantalla.Text = "0";
            this.txtpantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btndivision);
            this.flowLayoutPanel3.Controls.Add(this.btnmultiplicacion);
            this.flowLayoutPanel3.Controls.Add(this.btnresta);
            this.flowLayoutPanel3.Controls.Add(this.btnsuma);
            this.flowLayoutPanel3.Controls.Add(this.btnigual);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(404, 233);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(63, 312);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // btndivision
            // 
            this.btndivision.BackgroundImage = global::ProyCalculadora.Properties.Resources.circuloverde;
            this.btndivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndivision.FlatAppearance.BorderSize = 0;
            this.btndivision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btndivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivision.ForeColor = System.Drawing.Color.White;
            this.btndivision.Location = new System.Drawing.Point(3, 3);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(55, 55);
            this.btndivision.TabIndex = 3;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.btndivision_Click);
            // 
            // btnmultiplicacion
            // 
            this.btnmultiplicacion.BackgroundImage = global::ProyCalculadora.Properties.Resources.circuloverde;
            this.btnmultiplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmultiplicacion.FlatAppearance.BorderSize = 0;
            this.btnmultiplicacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnmultiplicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnmultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicacion.ForeColor = System.Drawing.Color.White;
            this.btnmultiplicacion.Location = new System.Drawing.Point(3, 64);
            this.btnmultiplicacion.Name = "btnmultiplicacion";
            this.btnmultiplicacion.Size = new System.Drawing.Size(55, 55);
            this.btnmultiplicacion.TabIndex = 4;
            this.btnmultiplicacion.Text = "x";
            this.btnmultiplicacion.UseVisualStyleBackColor = true;
            this.btnmultiplicacion.Click += new System.EventHandler(this.btnmultiplicacion_Click);
            // 
            // btnresta
            // 
            this.btnresta.BackgroundImage = global::ProyCalculadora.Properties.Resources.circuloverde;
            this.btnresta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnresta.FlatAppearance.BorderSize = 0;
            this.btnresta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnresta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnresta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.ForeColor = System.Drawing.Color.White;
            this.btnresta.Location = new System.Drawing.Point(3, 125);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(55, 55);
            this.btnresta.TabIndex = 5;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.BackgroundImage = global::ProyCalculadora.Properties.Resources.circuloverde;
            this.btnsuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsuma.FlatAppearance.BorderSize = 0;
            this.btnsuma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsuma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.ForeColor = System.Drawing.Color.White;
            this.btnsuma.Location = new System.Drawing.Point(3, 186);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(55, 55);
            this.btnsuma.TabIndex = 6;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnigual
            // 
            this.btnigual.BackgroundImage = global::ProyCalculadora.Properties.Resources.circuloverde;
            this.btnigual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnigual.FlatAppearance.BorderSize = 0;
            this.btnigual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnigual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.ForeColor = System.Drawing.Color.White;
            this.btnigual.Location = new System.Drawing.Point(3, 247);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(55, 55);
            this.btnigual.TabIndex = 7;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // panelnumerico
            // 
            this.panelnumerico.Location = new System.Drawing.Point(197, 294);
            this.panelnumerico.Name = "panelnumerico";
            this.panelnumerico.Size = new System.Drawing.Size(200, 244);
            this.panelnumerico.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnborrar);
            this.flowLayoutPanel1.Controls.Add(this.btnporcentaje);
            this.flowLayoutPanel1.Controls.Add(this.btnoff);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(197, 233);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 65);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnborrar
            // 
            this.btnborrar.BackgroundImage = global::ProyCalculadora.Properties.Resources.circulorojo;
            this.btnborrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnborrar.FlatAppearance.BorderSize = 0;
            this.btnborrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnborrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.ForeColor = System.Drawing.Color.White;
            this.btnborrar.Location = new System.Drawing.Point(3, 3);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(55, 55);
            this.btnborrar.TabIndex = 0;
            this.btnborrar.Text = "AC";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnporcentaje
            // 
            this.btnporcentaje.BackgroundImage = global::ProyCalculadora.Properties.Resources.circulorojo;
            this.btnporcentaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnporcentaje.FlatAppearance.BorderSize = 0;
            this.btnporcentaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnporcentaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnporcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnporcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnporcentaje.ForeColor = System.Drawing.Color.White;
            this.btnporcentaje.Location = new System.Drawing.Point(64, 3);
            this.btnporcentaje.Name = "btnporcentaje";
            this.btnporcentaje.Size = new System.Drawing.Size(55, 55);
            this.btnporcentaje.TabIndex = 1;
            this.btnporcentaje.Text = "%";
            this.btnporcentaje.UseVisualStyleBackColor = true;
            this.btnporcentaje.Click += new System.EventHandler(this.btnporcentaje_Click);
            // 
            // btnoff
            // 
            this.btnoff.BackgroundImage = global::ProyCalculadora.Properties.Resources.circulorojo;
            this.btnoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnoff.FlatAppearance.BorderSize = 0;
            this.btnoff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnoff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoff.ForeColor = System.Drawing.Color.White;
            this.btnoff.Location = new System.Drawing.Point(125, 3);
            this.btnoff.Name = "btnoff";
            this.btnoff.Size = new System.Drawing.Size(55, 55);
            this.btnoff.TabIndex = 2;
            this.btnoff.Text = "OFF";
            this.btnoff.UseVisualStyleBackColor = true;
            this.btnoff.Click += new System.EventHandler(this.btnoff_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(863, 599);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCalculadora";
            this.Text = "frmCalculadora";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel panelnumerico;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnporcentaje;
        private System.Windows.Forms.Button btnoff;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnmultiplicacion;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.TextBox txtpantalla;
        private System.Windows.Forms.Button btncopiar;
        private System.Windows.Forms.Label lbloperacion;
        private System.Windows.Forms.Label lblnum1;
    }
}