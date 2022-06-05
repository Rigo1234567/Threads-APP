namespace app.forms
{
    partial class frminicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminicio));
            this.btncliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.panelformularios = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panelbarratitulo = new System.Windows.Forms.Panel();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelcontenedor.SuspendLayout();
            this.panelformularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelmenu.SuspendLayout();
            this.panelbarratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btncliente
            // 
            this.btncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.Location = new System.Drawing.Point(328, 168);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(155, 51);
            this.btncliente.TabIndex = 1;
            this.btncliente.Text = "ingresar clientes";
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "FITUNED";
            // 
            // btnmostrar
            // 
            this.btnmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.Location = new System.Drawing.Point(328, 311);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(152, 51);
            this.btnmostrar.TabIndex = 4;
            this.btnmostrar.Text = "mostrar afiliaciones";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(331, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "analizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelcontenedor.Controls.Add(this.panelformularios);
            this.panelcontenedor.Controls.Add(this.panelmenu);
            this.panelcontenedor.Controls.Add(this.panelbarratitulo);
            this.panelcontenedor.Controls.Add(this.button2);
            this.panelcontenedor.Controls.Add(this.button3);
            this.panelcontenedor.Controls.Add(this.button4);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(0, 0);
            this.panelcontenedor.MinimumSize = new System.Drawing.Size(650, 650);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(888, 650);
            this.panelcontenedor.TabIndex = 6;
            this.panelcontenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcontenedor_Paint);
            // 
            // panelformularios
            // 
            this.panelformularios.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelformularios.Controls.Add(this.label2);
            this.panelformularios.Controls.Add(this.pictureBox1);
            this.panelformularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelformularios.Location = new System.Drawing.Point(179, 25);
            this.panelformularios.Name = "panelformularios";
            this.panelformularios.Size = new System.Drawing.Size(709, 625);
            this.panelformularios.TabIndex = 11;
            this.panelformularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelformularios_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gym FITUNED";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::app.Properties.Resources.gym;
            this.pictureBox1.Location = new System.Drawing.Point(247, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 207);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelmenu.Controls.Add(this.button5);
            this.panelmenu.Controls.Add(this.button7);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 25);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(179, 625);
            this.panelmenu.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Highlight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 94);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 59);
            this.button5.TabIndex = 11;
            this.button5.Text = "analizar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Highlight;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(0, 34);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(179, 62);
            this.button7.TabIndex = 9;
            this.button7.Text = "ingresar clientes";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panelbarratitulo
            // 
            this.panelbarratitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelbarratitulo.Controls.Add(this.btnrestaurar);
            this.panelbarratitulo.Controls.Add(this.btnmaximizar);
            this.panelbarratitulo.Controls.Add(this.btnminimizar);
            this.panelbarratitulo.Controls.Add(this.btncerrar);
            this.panelbarratitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbarratitulo.Location = new System.Drawing.Point(0, 0);
            this.panelbarratitulo.Name = "panelbarratitulo";
            this.panelbarratitulo.Size = new System.Drawing.Size(888, 25);
            this.panelbarratitulo.TabIndex = 9;
            this.panelbarratitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelbarratitulo_MouseMove);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Image = global::app.Properties.Resources.maximize3;
            this.btnrestaurar.Location = new System.Drawing.Point(797, 0);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(18, 16);
            this.btnrestaurar.TabIndex = 3;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximizar.Image")));
            this.btnmaximizar.Location = new System.Drawing.Point(821, 0);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(18, 16);
            this.btnmaximizar.TabIndex = 2;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(845, -3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(18, 17);
            this.btnminimizar.TabIndex = 1;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(869, -1);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(16, 15);
            this.btncerrar.TabIndex = 0;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(370, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "analizar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(367, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 51);
            this.button3.TabIndex = 7;
            this.button3.Text = "mostrar afiliaciones";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(367, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 51);
            this.button4.TabIndex = 6;
            this.button4.Text = "ingresar clientes";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frminicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 474);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frminicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frminicio";
            this.Load += new System.EventHandler(this.frminicio_Load);
            this.panelcontenedor.ResumeLayout(false);
            this.panelformularios.ResumeLayout(false);
            this.panelformularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelmenu.ResumeLayout(false);
            this.panelbarratitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelbarratitulo;
        private System.Windows.Forms.Panel panelformularios;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnrestaurar;
    }
}