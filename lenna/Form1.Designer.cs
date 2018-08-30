namespace lenna
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
            this.components = new System.ComponentModel.Container();
            this.btnimagen = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.btngtis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnimagen
            // 
            this.btnimagen.Location = new System.Drawing.Point(13, 12);
            this.btnimagen.Name = "btnimagen";
            this.btnimagen.Size = new System.Drawing.Size(110, 23);
            this.btnimagen.TabIndex = 0;
            this.btnimagen.Text = "Cargar Imgen";
            this.btnimagen.UseVisualStyleBackColor = true;
            this.btnimagen.Click += new System.EventHandler(this.btnimagen_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(13, 53);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(322, 188);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(361, 53);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(322, 188);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            this.imageBox2.Click += new System.EventHandler(this.imageBox2_Click);
            // 
            // btngtis
            // 
            this.btngtis.Location = new System.Drawing.Point(129, 12);
            this.btngtis.Name = "btngtis";
            this.btngtis.Size = new System.Drawing.Size(105, 23);
            this.btngtis.TabIndex = 3;
            this.btngtis.Text = "Imagen Gris";
            this.btngtis.UseVisualStyleBackColor = true;
            this.btngtis.Click += new System.EventHandler(this.btngtis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Histograma color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(13, 247);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(670, 254);
            this.histogramBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 530);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btngtis);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.btnimagen);
            this.Name = "Form1";
            this.Text = "Lenna";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnimagen;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button btngtis;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.HistogramBox histogramBox1;
    }
}

