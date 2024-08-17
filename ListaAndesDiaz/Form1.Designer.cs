namespace ListaAndesDiaz
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
            this.Titulo = new System.Windows.Forms.TextBox();
            this.statustarea = new System.Windows.Forms.CheckBox();
            this.vencimiento = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(290, 51);
            this.Titulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(175, 20);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Ingrese la Tarea";
            this.Titulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // statustarea
            // 
            this.statustarea.AutoSize = true;
            this.statustarea.Location = new System.Drawing.Point(601, 384);
            this.statustarea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statustarea.Name = "statustarea";
            this.statustarea.Size = new System.Drawing.Size(92, 19);
            this.statustarea.TabIndex = 1;
            this.statustarea.Text = "statustarea";
            this.statustarea.UseVisualStyleBackColor = true;
            this.statustarea.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // vencimiento
            // 
            this.vencimiento.Location = new System.Drawing.Point(247, 116);
            this.vencimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vencimiento.Name = "vencimiento";
            this.vencimiento.Size = new System.Drawing.Size(266, 20);
            this.vencimiento.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(172, 181);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(507, 195);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(604, 129);
            this.Agregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Agregar.Name = "Agregar";
            this.Agregar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Agregar.Size = new System.Drawing.Size(75, 26);
            this.Agregar.TabIndex = 4;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.vencimiento);
            this.Controls.Add(this.statustarea);
            this.Controls.Add(this.Titulo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.CheckBox statustarea;
        private System.Windows.Forms.DateTimePicker vencimiento;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Agregar;
    }
}

