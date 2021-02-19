namespace Infomatik.Kml.LineAggregator
{
  partial class MainForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnExecute = new System.Windows.Forms.Button();
      this.progressBar = new System.Windows.Forms.ProgressBar();
      this.label1 = new System.Windows.Forms.Label();
      this.txtSource = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtDestination = new System.Windows.Forms.TextBox();
      this.btnSelectSource = new System.Windows.Forms.Button();
      this.btnSelectDestination = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel4 = new System.Windows.Forms.Panel();
      this.label4 = new System.Windows.Forms.Label();
      this.picColor = new System.Windows.Forms.PictureBox();
      this.label5 = new System.Windows.Forms.Label();
      this.numWidth = new System.Windows.Forms.NumericUpDown();
      this.label6 = new System.Windows.Forms.Label();
      this.rad2D = new System.Windows.Forms.RadioButton();
      this.rad3D = new System.Windows.Forms.RadioButton();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.Control;
      this.panel1.Controls.Add(this.btnExecute);
      this.panel1.Controls.Add(this.progressBar);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 149);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(448, 34);
      this.panel1.TabIndex = 0;
      // 
      // btnExecute
      // 
      this.btnExecute.Location = new System.Drawing.Point(365, 4);
      this.btnExecute.Name = "btnExecute";
      this.btnExecute.Size = new System.Drawing.Size(75, 24);
      this.btnExecute.TabIndex = 1;
      this.btnExecute.Text = "Ausführen";
      this.btnExecute.UseVisualStyleBackColor = true;
      this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
      // 
      // progressBar
      // 
      this.progressBar.Location = new System.Drawing.Point(12, 5);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(347, 23);
      this.progressBar.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(8, 52);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 19);
      this.label1.TabIndex = 1;
      this.label1.Text = "Quelle:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtSource
      // 
      this.txtSource.Location = new System.Drawing.Point(74, 52);
      this.txtSource.Name = "txtSource";
      this.txtSource.Size = new System.Drawing.Size(319, 20);
      this.txtSource.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(8, 83);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 19);
      this.label2.TabIndex = 3;
      this.label2.Text = "Ziel:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtDestination
      // 
      this.txtDestination.Location = new System.Drawing.Point(74, 82);
      this.txtDestination.Name = "txtDestination";
      this.txtDestination.Size = new System.Drawing.Size(319, 20);
      this.txtDestination.TabIndex = 4;
      // 
      // btnSelectSource
      // 
      this.btnSelectSource.Location = new System.Drawing.Point(399, 51);
      this.btnSelectSource.Name = "btnSelectSource";
      this.btnSelectSource.Size = new System.Drawing.Size(40, 20);
      this.btnSelectSource.TabIndex = 5;
      this.btnSelectSource.Text = "...";
      this.btnSelectSource.UseVisualStyleBackColor = true;
      this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
      // 
      // btnSelectDestination
      // 
      this.btnSelectDestination.Location = new System.Drawing.Point(399, 82);
      this.btnSelectDestination.Name = "btnSelectDestination";
      this.btnSelectDestination.Size = new System.Drawing.Size(40, 20);
      this.btnSelectDestination.TabIndex = 6;
      this.btnSelectDestination.Text = "...";
      this.btnSelectDestination.UseVisualStyleBackColor = true;
      this.btnSelectDestination.Click += new System.EventHandler(this.btnSelectDestination_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.panel3);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Controls.Add(this.pictureBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(448, 46);
      this.panel2.TabIndex = 7;
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.SystemColors.Control;
      this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel3.Location = new System.Drawing.Point(0, 45);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(448, 1);
      this.panel3.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
      this.label3.Location = new System.Drawing.Point(66, 4);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(374, 37);
      this.label3.TabIndex = 1;
      this.label3.Text = "Fügt alle angrenzenden Linien in der KML Datei zusammen.";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(10, 4);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(50, 37);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // panel4
      // 
      this.panel4.BackColor = System.Drawing.SystemColors.Control;
      this.panel4.Location = new System.Drawing.Point(12, 110);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(427, 1);
      this.panel4.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(10, 119);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 19);
      this.label4.TabIndex = 9;
      this.label4.Text = "Farbe:";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // picColor
      // 
      this.picColor.BackColor = System.Drawing.Color.Red;
      this.picColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.picColor.Location = new System.Drawing.Point(76, 119);
      this.picColor.Name = "picColor";
      this.picColor.Size = new System.Drawing.Size(19, 19);
      this.picColor.TabIndex = 10;
      this.picColor.TabStop = false;
      this.picColor.Click += new System.EventHandler(this.picColor_Click);
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(101, 119);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(60, 19);
      this.label5.TabIndex = 11;
      this.label5.Text = "Breite:";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // numWidth
      // 
      this.numWidth.Location = new System.Drawing.Point(167, 120);
      this.numWidth.Name = "numWidth";
      this.numWidth.Size = new System.Drawing.Size(76, 20);
      this.numWidth.TabIndex = 12;
      this.numWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(249, 121);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(60, 19);
      this.label6.TabIndex = 13;
      this.label6.Text = "Polylinie:";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // rad2D
      // 
      this.rad2D.AutoSize = true;
      this.rad2D.Location = new System.Drawing.Point(315, 122);
      this.rad2D.Name = "rad2D";
      this.rad2D.Size = new System.Drawing.Size(39, 17);
      this.rad2D.TabIndex = 14;
      this.rad2D.Text = "2D";
      this.rad2D.UseVisualStyleBackColor = true;
      // 
      // rad3D
      // 
      this.rad3D.AutoSize = true;
      this.rad3D.Checked = true;
      this.rad3D.Location = new System.Drawing.Point(357, 122);
      this.rad3D.Name = "rad3D";
      this.rad3D.Size = new System.Drawing.Size(39, 17);
      this.rad3D.TabIndex = 15;
      this.rad3D.TabStop = true;
      this.rad3D.Text = "3D";
      this.rad3D.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(448, 183);
      this.Controls.Add(this.rad2D);
      this.Controls.Add(this.rad3D);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.numWidth);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.picColor);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.btnSelectDestination);
      this.Controls.Add(this.btnSelectSource);
      this.Controls.Add(this.txtDestination);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtSource);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "KML Linien Vereinfachen";
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.Button btnSelectDestination;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.PictureBox picColor;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown numWidth;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.RadioButton rad2D;
    private System.Windows.Forms.RadioButton rad3D;
  }
}

