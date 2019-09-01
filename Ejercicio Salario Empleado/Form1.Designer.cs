namespace Ejercicio_Salario_Empleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txthorastrabajadas = new System.Windows.Forms.TextBox();
            this.txtvalorhora = new System.Windows.Forms.TextBox();
            this.btncalcularsalario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltotalsalario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa Para Calcular Salario de Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese las horas trabajadas por el empleado: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese el valor de cada hora: ";
            // 
            // txthorastrabajadas
            // 
            this.txthorastrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorastrabajadas.Location = new System.Drawing.Point(414, 117);
            this.txthorastrabajadas.Name = "txthorastrabajadas";
            this.txthorastrabajadas.Size = new System.Drawing.Size(100, 29);
            this.txthorastrabajadas.TabIndex = 3;
            // 
            // txtvalorhora
            // 
            this.txtvalorhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorhora.Location = new System.Drawing.Point(282, 164);
            this.txtvalorhora.Name = "txtvalorhora";
            this.txtvalorhora.Size = new System.Drawing.Size(232, 29);
            this.txtvalorhora.TabIndex = 4;
            // 
            // btncalcularsalario
            // 
            this.btncalcularsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcularsalario.Location = new System.Drawing.Point(184, 214);
            this.btncalcularsalario.Name = "btncalcularsalario";
            this.btncalcularsalario.Size = new System.Drawing.Size(134, 66);
            this.btncalcularsalario.TabIndex = 5;
            this.btncalcularsalario.Text = "Calcular salario";
            this.btncalcularsalario.UseVisualStyleBackColor = true;
            this.btncalcularsalario.Click += new System.EventHandler(this.btncalcularsalario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total:";
            // 
            // lbltotalsalario
            // 
            this.lbltotalsalario.AutoSize = true;
            this.lbltotalsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalsalario.Location = new System.Drawing.Point(86, 324);
            this.lbltotalsalario.Name = "lbltotalsalario";
            this.lbltotalsalario.Size = new System.Drawing.Size(135, 24);
            this.lbltotalsalario.TabIndex = 7;
            this.lbltotalsalario.Text = "Salario a pagar";
            this.lbltotalsalario.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltotalsalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncalcularsalario);
            this.Controls.Add(this.txtvalorhora);
            this.Controls.Add(this.txthorastrabajadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthorastrabajadas;
        private System.Windows.Forms.TextBox txtvalorhora;
        private System.Windows.Forms.Button btncalcularsalario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltotalsalario;
    }
}

