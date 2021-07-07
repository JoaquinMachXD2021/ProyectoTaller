
namespace proyecto2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.paneltop = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nuevoform = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.abrir = new FontAwesome.Sharp.IconButton();
            this.repuestos = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.maxim = new System.Windows.Forms.PictureBox();
            this.minim = new System.Windows.Forms.PictureBox();
            this.rest = new System.Windows.Forms.PictureBox();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.ayuda = new FontAwesome.Sharp.IconButton();
            this.paneltop.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rest)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.paneltop.Controls.Add(this.rest);
            this.paneltop.Controls.Add(this.minim);
            this.paneltop.Controls.Add(this.maxim);
            this.paneltop.Controls.Add(this.cerrar);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(978, 27);
            this.paneltop.TabIndex = 0;
            this.paneltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.nuevoform);
            this.flowLayoutPanel1.Controls.Add(this.abrir);
            this.flowLayoutPanel1.Controls.Add(this.repuestos);
            this.flowLayoutPanel1.Controls.Add(this.ayuda);
            this.flowLayoutPanel1.Controls.Add(this.iconButton4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(133, 634);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // nuevoform
            // 
            this.nuevoform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nuevoform.FlatAppearance.BorderSize = 0;
            this.nuevoform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.nuevoform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoform.ForeColor = System.Drawing.SystemColors.Window;
            this.nuevoform.IconChar = FontAwesome.Sharp.IconChar.File;
            this.nuevoform.IconColor = System.Drawing.Color.White;
            this.nuevoform.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.nuevoform.IconSize = 30;
            this.nuevoform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevoform.Location = new System.Drawing.Point(3, 84);
            this.nuevoform.Name = "nuevoform";
            this.nuevoform.Size = new System.Drawing.Size(128, 30);
            this.nuevoform.TabIndex = 0;
            this.nuevoform.Text = "Nuevo";
            this.nuevoform.UseVisualStyleBackColor = false;
            this.nuevoform.Click += new System.EventHandler(this.nuevoform_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 75);
            this.panel1.TabIndex = 2;
            // 
            // abrir
            // 
            this.abrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.abrir.FlatAppearance.BorderSize = 0;
            this.abrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abrir.ForeColor = System.Drawing.SystemColors.Window;
            this.abrir.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.abrir.IconColor = System.Drawing.Color.White;
            this.abrir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.abrir.IconSize = 30;
            this.abrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abrir.Location = new System.Drawing.Point(3, 120);
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(128, 30);
            this.abrir.TabIndex = 3;
            this.abrir.Text = "Abrir";
            this.abrir.UseVisualStyleBackColor = false;
            // 
            // repuestos
            // 
            this.repuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.repuestos.FlatAppearance.BorderSize = 0;
            this.repuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.repuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repuestos.ForeColor = System.Drawing.SystemColors.Window;
            this.repuestos.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.repuestos.IconColor = System.Drawing.Color.White;
            this.repuestos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.repuestos.IconSize = 30;
            this.repuestos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.repuestos.Location = new System.Drawing.Point(3, 156);
            this.repuestos.Name = "repuestos";
            this.repuestos.Size = new System.Drawing.Size(128, 30);
            this.repuestos.TabIndex = 4;
            this.repuestos.Text = "Repuestos";
            this.repuestos.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.SystemColors.Window;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(3, 228);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(128, 30);
            this.iconButton4.TabIndex = 5;
            this.iconButton4.Text = "Salir";
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 264);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(130, 367);
            this.flowLayoutPanel2.TabIndex = 6;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(954, 3);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(19, 19);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 0;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // maxim
            // 
            this.maxim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maxim.Image = ((System.Drawing.Image)(resources.GetObject("maxim.Image")));
            this.maxim.Location = new System.Drawing.Point(929, 3);
            this.maxim.Name = "maxim";
            this.maxim.Size = new System.Drawing.Size(19, 19);
            this.maxim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxim.TabIndex = 1;
            this.maxim.TabStop = false;
            this.maxim.Click += new System.EventHandler(this.maxim_Click);
            // 
            // minim
            // 
            this.minim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minim.Image = ((System.Drawing.Image)(resources.GetObject("minim.Image")));
            this.minim.Location = new System.Drawing.Point(904, 3);
            this.minim.Name = "minim";
            this.minim.Size = new System.Drawing.Size(19, 19);
            this.minim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minim.TabIndex = 2;
            this.minim.TabStop = false;
            this.minim.Click += new System.EventHandler(this.minim_Click);
            // 
            // rest
            // 
            this.rest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rest.Image = ((System.Drawing.Image)(resources.GetObject("rest.Image")));
            this.rest.Location = new System.Drawing.Point(929, 3);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(19, 19);
            this.rest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rest.TabIndex = 3;
            this.rest.TabStop = false;
            this.rest.Visible = false;
            this.rest.Click += new System.EventHandler(this.rest_Click);
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(133, 27);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(845, 634);
            this.panelcontenedor.TabIndex = 2;
            // 
            // ayuda
            // 
            this.ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ayuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.ayuda.FlatAppearance.BorderSize = 0;
            this.ayuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayuda.ForeColor = System.Drawing.SystemColors.Window;
            this.ayuda.IconChar = FontAwesome.Sharp.IconChar.LifeRing;
            this.ayuda.IconColor = System.Drawing.Color.White;
            this.ayuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ayuda.IconSize = 30;
            this.ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ayuda.Location = new System.Drawing.Point(3, 192);
            this.ayuda.Name = "ayuda";
            this.ayuda.Size = new System.Drawing.Size(128, 30);
            this.ayuda.TabIndex = 6;
            this.ayuda.Text = "Ayuda";
            this.ayuda.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 661);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.paneltop.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton nuevoform;
        private FontAwesome.Sharp.IconButton abrir;
        private FontAwesome.Sharp.IconButton repuestos;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox rest;
        private System.Windows.Forms.PictureBox minim;
        private System.Windows.Forms.PictureBox maxim;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Panel panelcontenedor;
        private FontAwesome.Sharp.IconButton ayuda;
    }
}

