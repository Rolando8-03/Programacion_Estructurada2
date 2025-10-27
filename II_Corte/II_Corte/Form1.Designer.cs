namespace II_Corte
{
    partial class Form1
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUrgente = new System.Windows.Forms.ListBox();
            this.lbRegular = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEliminarRegular = new System.Windows.Forms.Button();
            this.btnEliminarUrgente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(934, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Una empresa de mensajería (como FedEx o Amazon) gestiona miles de paquetes cada d" +
    "ía.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(21, 133);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(325, 22);
            this.tbNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el tipo de envio:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Regular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 299);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 5;
            // 
            // lbUrgente
            // 
            this.lbUrgente.FormattingEnabled = true;
            this.lbUrgente.ItemHeight = 16;
            this.lbUrgente.Location = new System.Drawing.Point(384, 227);
            this.lbUrgente.Name = "lbUrgente";
            this.lbUrgente.Size = new System.Drawing.Size(566, 132);
            this.lbUrgente.TabIndex = 6;
            // 
            // lbRegular
            // 
            this.lbRegular.FormattingEnabled = true;
            this.lbRegular.ItemHeight = 16;
            this.lbRegular.Location = new System.Drawing.Point(384, 94);
            this.lbRegular.Name = "lbRegular";
            this.lbRegular.Size = new System.Drawing.Size(566, 100);
            this.lbRegular.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(214, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "Urgente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnEliminarRegular
            // 
            this.btnEliminarRegular.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRegular.Location = new System.Drawing.Point(21, 282);
            this.btnEliminarRegular.Name = "btnEliminarRegular";
            this.btnEliminarRegular.Size = new System.Drawing.Size(132, 81);
            this.btnEliminarRegular.TabIndex = 9;
            this.btnEliminarRegular.Text = "Eliminar Regular";
            this.btnEliminarRegular.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUrgente
            // 
            this.btnEliminarUrgente.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUrgente.Location = new System.Drawing.Point(214, 282);
            this.btnEliminarUrgente.Name = "btnEliminarUrgente";
            this.btnEliminarUrgente.Size = new System.Drawing.Size(132, 81);
            this.btnEliminarUrgente.TabIndex = 10;
            this.btnEliminarUrgente.Text = "Eliminar Urgente";
            this.btnEliminarUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1124, 554);
            this.Controls.Add(this.btnEliminarUrgente);
            this.Controls.Add(this.btnEliminarRegular);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbRegular);
            this.Controls.Add(this.lbUrgente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Gestión de envios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbUrgente;
        private System.Windows.Forms.ListBox lbRegular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEliminarRegular;
        private System.Windows.Forms.Button btnEliminarUrgente;
    }
}

