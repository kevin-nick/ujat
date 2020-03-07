namespace Conway_s_Game_of_Life
{
    partial class Conways_Game_of_Life
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
            this.Picture_Life = new System.Windows.Forms.PictureBox();
            this.StartB = new System.Windows.Forms.Button();
            this.PauseB = new System.Windows.Forms.Button();
            this.RANDOM = new System.Windows.Forms.Button();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Life)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture_Life
            // 
            this.Picture_Life.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Life.Location = new System.Drawing.Point(12, 12);
            this.Picture_Life.Name = "Picture_Life";
            this.Picture_Life.Size = new System.Drawing.Size(350, 350);
            this.Picture_Life.TabIndex = 0;
            this.Picture_Life.TabStop = false;
            // 
            // StartB
            // 
            this.StartB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartB.Location = new System.Drawing.Point(278, 382);
            this.StartB.Name = "StartB";
            this.StartB.Size = new System.Drawing.Size(84, 29);
            this.StartB.TabIndex = 1;
            this.StartB.Text = "START";
            this.StartB.UseVisualStyleBackColor = false;
            this.StartB.Click += new System.EventHandler(this.StartB_Click);
            // 
            // PauseB
            // 
            this.PauseB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PauseB.Location = new System.Drawing.Point(182, 382);
            this.PauseB.Name = "PauseB";
            this.PauseB.Size = new System.Drawing.Size(79, 29);
            this.PauseB.TabIndex = 2;
            this.PauseB.Text = "PAUSE";
            this.PauseB.UseVisualStyleBackColor = false;
            this.PauseB.Click += new System.EventHandler(this.PauseB_Click);
            // 
            // RANDOM
            // 
            this.RANDOM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RANDOM.Location = new System.Drawing.Point(12, 382);
            this.RANDOM.Name = "RANDOM";
            this.RANDOM.Size = new System.Drawing.Size(84, 29);
            this.RANDOM.TabIndex = 3;
            this.RANDOM.Text = "Random";
            this.RANDOM.UseVisualStyleBackColor = false;
            this.RANDOM.Click += new System.EventHandler(this.RANDOM_Click);
            // 
            // Tiempo
            // 
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // Conways_Game_of_Life
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 422);
            this.Controls.Add(this.RANDOM);
            this.Controls.Add(this.PauseB);
            this.Controls.Add(this.StartB);
            this.Controls.Add(this.Picture_Life);
            this.Name = "Conways_Game_of_Life";
            this.Text = "Conway\'s Game of Life";
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Life)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture_Life;
        private System.Windows.Forms.Button StartB;
        private System.Windows.Forms.Button PauseB;
        private System.Windows.Forms.Button RANDOM;
        private System.Windows.Forms.Timer Tiempo;
    }
}

