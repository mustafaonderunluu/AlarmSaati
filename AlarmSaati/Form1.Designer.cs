namespace AlarmSaati
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelzaman = new Label();
            numericUpDownsaat = new NumericUpDown();
            numericUpDowndakika = new NumericUpDown();
            numericUpDownsaniye = new NumericUpDown();
            button1baslat = new Button();
            button1dur = new Button();
            timerzaman = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownsaat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDowndakika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownsaniye).BeginInit();
            SuspendLayout();
            // 
            // labelzaman
            // 
            labelzaman.AutoSize = true;
            labelzaman.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelzaman.Location = new Point(203, 28);
            labelzaman.Name = "labelzaman";
            labelzaman.Size = new Size(365, 106);
            labelzaman.TabIndex = 0;
            labelzaman.Text = "00:00:00";
            // 
            // numericUpDownsaat
            // 
            numericUpDownsaat.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            numericUpDownsaat.Location = new Point(227, 160);
            numericUpDownsaat.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownsaat.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownsaat.Name = "numericUpDownsaat";
            numericUpDownsaat.Size = new Size(73, 57);
            numericUpDownsaat.TabIndex = 1;
            numericUpDownsaat.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDowndakika
            // 
            numericUpDowndakika.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            numericUpDowndakika.Location = new Point(341, 160);
            numericUpDowndakika.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDowndakika.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDowndakika.Name = "numericUpDowndakika";
            numericUpDowndakika.Size = new Size(73, 57);
            numericUpDowndakika.TabIndex = 2;
            numericUpDowndakika.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownsaniye
            // 
            numericUpDownsaniye.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            numericUpDownsaniye.Location = new Point(451, 160);
            numericUpDownsaniye.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownsaniye.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownsaniye.Name = "numericUpDownsaniye";
            numericUpDownsaniye.Size = new Size(73, 57);
            numericUpDownsaniye.TabIndex = 3;
            numericUpDownsaniye.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1baslat
            // 
            button1baslat.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1baslat.Location = new Point(179, 286);
            button1baslat.Name = "button1baslat";
            button1baslat.Size = new Size(170, 47);
            button1baslat.TabIndex = 4;
            button1baslat.Text = "Başlat";
            button1baslat.UseVisualStyleBackColor = true;
            button1baslat.Click += button1baslat_Click;
            // 
            // button1dur
            // 
            button1dur.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1dur.Location = new Point(412, 286);
            button1dur.Name = "button1dur";
            button1dur.Size = new Size(170, 47);
            button1dur.TabIndex = 5;
            button1dur.Text = "Durdur";
            button1dur.UseVisualStyleBackColor = true;
            button1dur.Click += button1dur_Click;
            // 
            // timerzaman
            // 
            timerzaman.Interval = 1000;
            timerzaman.Tick += timerzaman_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1dur);
            Controls.Add(button1baslat);
            Controls.Add(numericUpDownsaniye);
            Controls.Add(numericUpDowndakika);
            Controls.Add(numericUpDownsaat);
            Controls.Add(labelzaman);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownsaat).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDowndakika).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownsaniye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelzaman;
        private NumericUpDown numericUpDownsaat;
        private NumericUpDown numericUpDowndakika;
        private NumericUpDown numericUpDownsaniye;
        private Button button1baslat;
        private Button button1dur;
        private System.Windows.Forms.Timer timerzaman;
    }
}
