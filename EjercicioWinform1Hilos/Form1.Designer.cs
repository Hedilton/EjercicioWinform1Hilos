
namespace EjercicioWinform1Hilos
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
            this.button1 = new System.Windows.Forms.Button();
            this.bpProgreso = new System.Windows.Forms.ProgressBar();
            this.bpProgreso1 = new System.Windows.Forms.ProgressBar();
            this.bpProgreso2 = new System.Windows.Forms.ProgressBar();
            this.che1 = new System.Windows.Forms.CheckBox();
            this.che2 = new System.Windows.Forms.CheckBox();
            this.che3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bpProgreso
            // 
            this.bpProgreso.ForeColor = System.Drawing.Color.Green;
            this.bpProgreso.Location = new System.Drawing.Point(67, 116);
            this.bpProgreso.Name = "bpProgreso";
            this.bpProgreso.Size = new System.Drawing.Size(345, 23);
            this.bpProgreso.TabIndex = 1;
            // 
            // bpProgreso1
            // 
            this.bpProgreso1.Location = new System.Drawing.Point(67, 162);
            this.bpProgreso1.Name = "bpProgreso1";
            this.bpProgreso1.Size = new System.Drawing.Size(345, 23);
            this.bpProgreso1.TabIndex = 2;
            // 
            // bpProgreso2
            // 
            this.bpProgreso2.Location = new System.Drawing.Point(67, 207);
            this.bpProgreso2.Name = "bpProgreso2";
            this.bpProgreso2.Size = new System.Drawing.Size(345, 23);
            this.bpProgreso2.TabIndex = 3;
            // 
            // che1
            // 
            this.che1.AutoSize = true;
            this.che1.Location = new System.Drawing.Point(427, 122);
            this.che1.Name = "che1";
            this.che1.Size = new System.Drawing.Size(29, 17);
            this.che1.TabIndex = 4;
            this.che1.Text = " ";
            this.che1.UseVisualStyleBackColor = true;
            // 
            // che2
            // 
            this.che2.AutoSize = true;
            this.che2.Location = new System.Drawing.Point(427, 162);
            this.che2.Name = "che2";
            this.che2.Size = new System.Drawing.Size(29, 17);
            this.che2.TabIndex = 5;
            this.che2.Text = " ";
            this.che2.UseVisualStyleBackColor = true;
            // 
            // che3
            // 
            this.che3.AutoSize = true;
            this.che3.Location = new System.Drawing.Point(427, 212);
            this.che3.Name = "che3";
            this.che3.Size = new System.Drawing.Size(32, 17);
            this.che3.TabIndex = 6;
            this.che3.Text = "  ";
            this.che3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 318);
            this.Controls.Add(this.che3);
            this.Controls.Add(this.che2);
            this.Controls.Add(this.che1);
            this.Controls.Add(this.bpProgreso2);
            this.Controls.Add(this.bpProgreso1);
            this.Controls.Add(this.bpProgreso);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar bpProgreso1;
        private System.Windows.Forms.ProgressBar bpProgreso2;
        private System.Windows.Forms.ProgressBar bpProgreso;
        private System.Windows.Forms.CheckBox che1;
        private System.Windows.Forms.CheckBox che2;
        private System.Windows.Forms.CheckBox che3;
    }
}

