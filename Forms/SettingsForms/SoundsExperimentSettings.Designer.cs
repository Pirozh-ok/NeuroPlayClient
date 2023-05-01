namespace NeuroPlayClient.Forms.Settings {
    partial class SoundsExperimentSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundsExperimentSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.nudCountIterations = new System.Windows.Forms.NumericUpDown();
            this.nudPauseDuration = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPauseDuration)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F);
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // nudCountIterations
            // 
            this.nudCountIterations.Font = new System.Drawing.Font("Roboto", 12F);
            this.nudCountIterations.Location = new System.Drawing.Point(45, 130);
            this.nudCountIterations.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCountIterations.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCountIterations.Name = "nudCountIterations";
            this.nudCountIterations.Size = new System.Drawing.Size(120, 32);
            this.nudCountIterations.TabIndex = 1;
            this.nudCountIterations.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudPauseDuration
            // 
            this.nudPauseDuration.DecimalPlaces = 2;
            this.nudPauseDuration.Font = new System.Drawing.Font("Roboto", 12F);
            this.nudPauseDuration.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudPauseDuration.Location = new System.Drawing.Point(45, 180);
            this.nudPauseDuration.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPauseDuration.Name = "nudPauseDuration";
            this.nudPauseDuration.Size = new System.Drawing.Size(120, 32);
            this.nudPauseDuration.TabIndex = 2;
            this.nudPauseDuration.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.label2.Location = new System.Drawing.Point(192, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество итераций";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.label3.Location = new System.Drawing.Point(192, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Продолжительность паузы";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(571, 281);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(189, 63);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Начать эксперимент";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudCountIterations);
            this.panel1.Controls.Add(this.nudPauseDuration);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(35, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 382);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(160, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(621, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Эксперимент \"Род существительного\"";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(870, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SoundsExperimentSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoundsExperimentSettings";
            this.Text = "Род существительного";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SoundsExperimentSettings_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SoundsExperimentSettings_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudCountIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPauseDuration)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCountIterations;
        private System.Windows.Forms.NumericUpDown nudPauseDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}