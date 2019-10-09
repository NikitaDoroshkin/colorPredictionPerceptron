namespace ColorPredictionPerceptron
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
            this.ColorDispayBox = new System.Windows.Forms.PictureBox();
            this.rTrackBar = new System.Windows.Forms.TrackBar();
            this.gTrackBar = new System.Windows.Forms.TrackBar();
            this.bTrackBar = new System.Windows.Forms.TrackBar();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.trueColorCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trainBtn = new System.Windows.Forms.Button();
            this.autotrainBtn = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ColorDispayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorDispayBox
            // 
            this.ColorDispayBox.BackColor = System.Drawing.Color.Black;
            this.ColorDispayBox.Location = new System.Drawing.Point(12, 25);
            this.ColorDispayBox.Name = "ColorDispayBox";
            this.ColorDispayBox.Size = new System.Drawing.Size(67, 98);
            this.ColorDispayBox.TabIndex = 0;
            this.ColorDispayBox.TabStop = false;
            // 
            // rTrackBar
            // 
            this.rTrackBar.Location = new System.Drawing.Point(97, 25);
            this.rTrackBar.Maximum = 1000;
            this.rTrackBar.Name = "rTrackBar";
            this.rTrackBar.Size = new System.Drawing.Size(535, 45);
            this.rTrackBar.TabIndex = 1;
            this.rTrackBar.Scroll += new System.EventHandler(this.rTrackBar_Scroll);
            // 
            // gTrackBar
            // 
            this.gTrackBar.Location = new System.Drawing.Point(97, 64);
            this.gTrackBar.Maximum = 1000;
            this.gTrackBar.Name = "gTrackBar";
            this.gTrackBar.Size = new System.Drawing.Size(535, 45);
            this.gTrackBar.TabIndex = 2;
            this.gTrackBar.Scroll += new System.EventHandler(this.gTrackBar_Scroll);
            // 
            // bTrackBar
            // 
            this.bTrackBar.Location = new System.Drawing.Point(97, 101);
            this.bTrackBar.Maximum = 1000;
            this.bTrackBar.Name = "bTrackBar";
            this.bTrackBar.Size = new System.Drawing.Size(535, 45);
            this.bTrackBar.TabIndex = 3;
            this.bTrackBar.Scroll += new System.EventHandler(this.bTrackBar_Scroll);
            // 
            // trueColorCombo
            // 
            this.trueColorCombo.FormattingEnabled = true;
            this.trueColorCombo.Location = new System.Drawing.Point(12, 138);
            this.trueColorCombo.Name = "trueColorCombo";
            this.trueColorCombo.Size = new System.Drawing.Size(67, 21);
            this.trueColorCombo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "True color";
            // 
            // trainBtn
            // 
            this.trainBtn.Location = new System.Drawing.Point(180, 137);
            this.trainBtn.Name = "trainBtn";
            this.trainBtn.Size = new System.Drawing.Size(100, 23);
            this.trainBtn.TabIndex = 6;
            this.trainBtn.Text = "Train";
            this.trainBtn.UseVisualStyleBackColor = true;
            this.trainBtn.Click += new System.EventHandler(this.trainBtn_Click);
            // 
            // autotrainBtn
            // 
            this.autotrainBtn.Location = new System.Drawing.Point(286, 137);
            this.autotrainBtn.Name = "autotrainBtn";
            this.autotrainBtn.Size = new System.Drawing.Size(100, 23);
            this.autotrainBtn.TabIndex = 7;
            this.autotrainBtn.Text = "Autotrain";
            this.autotrainBtn.UseVisualStyleBackColor = true;
            this.autotrainBtn.Click += new System.EventHandler(this.autotrainBtn_Click);
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(86, 30);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(15, 13);
            this.R.TabIndex = 8;
            this.R.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "B";
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridView.Location = new System.Drawing.Point(15, 192);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(617, 228);
            this.gridView.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 432);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.R);
            this.Controls.Add(this.autotrainBtn);
            this.Controls.Add(this.trainBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trueColorCombo);
            this.Controls.Add(this.bTrackBar);
            this.Controls.Add(this.gTrackBar);
            this.Controls.Add(this.rTrackBar);
            this.Controls.Add(this.ColorDispayBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ColorDispayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ColorDispayBox;
        private System.Windows.Forms.TrackBar rTrackBar;
        private System.Windows.Forms.TrackBar gTrackBar;
        private System.Windows.Forms.TrackBar bTrackBar;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ComboBox trueColorCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button trainBtn;
        private System.Windows.Forms.Button autotrainBtn;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridView;
    }
}

