namespace Persik
{
    partial class Pattern
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)){ components.Dispose(); }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        private void InitializeComponent(double[] dsd, string Naz)
        {
            this.Nazvanie = new System.Windows.Forms.Label();
            this.ImaMimi = new System.Windows.Forms.Panel();
            this.Pixel = new System.Windows.Forms.Panel[100];
            for (int i = 0; i < 100; this.Pixel[i] = new System.Windows.Forms.Panel(), i++ ) ;
            this.DeleteBut = new System.Windows.Forms.Button();
            this.ImaMimi.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nazvanie
            // 
            this.Nazvanie.Dock = System.Windows.Forms.DockStyle.Top;
            this.Nazvanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazvanie.Location = new System.Drawing.Point(0, 0);
            this.Nazvanie.Name = "Nazvanie";
            this.Nazvanie.Size = new System.Drawing.Size(218, 13);
            this.Nazvanie.TabIndex = 0;
            this.Nazvanie.Text = Naz;
            this.Nazvanie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ImaMimi
            // 
            this.ImaMimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImaMimi.Location = new System.Drawing.Point(9, 20);
            this.ImaMimi.Name = "ImaMimi";
            this.ImaMimi.Size = new System.Drawing.Size(42, 42);
            this.ImaMimi.TabIndex = 1;
            // 
            // Pixel
            //
            for (int i = 0; i < 100; i++)
            {
                this.Pixel[i] = new System.Windows.Forms.Panel();
                switch (dsd[i]+"") {
                    case "1" : { this.Pixel[i].BackColor = System.Drawing.Color.Black; break; }
                    case "0,8": { this.Pixel[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))); break; }
                    case "0,6": { this.Pixel[i].BackColor = System.Drawing.Color.Gray; break; }
                    case "0,4": { this.Pixel[i].BackColor = System.Drawing.Color.Silver; break; }
                    case "0,2": { this.Pixel[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))); break; }
                    case "0": { this.Pixel[i].BackColor = System.Drawing.Color.White; break; }
                    default: { this.Pixel[i].BackColor = System.Drawing.Color.Red; break; }
                }
                this.Pixel[i].Location = new System.Drawing.Point(4 * (i % 10), 4 * (i / 10));
                this.Pixel[i].Name = "RisPol";
                this.Pixel[i].Size = new System.Drawing.Size(4, 4);
                this.Pixel[i].TabIndex = i;
                this.ImaMimi.Controls.Add(this.Pixel[i]);
            }

            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(140, 41);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(75, 23);
            this.DeleteBut.TabIndex = 2;
            this.DeleteBut.Text = "Удалить";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // Pattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.ImaMimi);
            this.Controls.Add(this.Nazvanie);
            this.Name = "Pattern";
            this.Size = new System.Drawing.Size(200, 67);
            this.ImaMimi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label Nazvanie;
        private System.Windows.Forms.Panel ImaMimi;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Panel[] Pixel;
    }
}
