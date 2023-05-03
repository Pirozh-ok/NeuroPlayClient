namespace NeuroPlayClient.Forms {
    partial class FiguresExperimentSettings {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiguresExperimentSettings));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCountIterations = new System.Windows.Forms.NumericUpDown();
            this.nudDurationShow = new System.Windows.Forms.NumericUpDown();
            this.numDurationPause = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationPause)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.label2.Font = new System.Drawing.Font("Roboto", 12F);
            this.label2.Location = new System.Drawing.Point(33, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(729, 72);
            this.label2.TabIndex = 3;
            this.label2.Text = "    В случайной последовательности показывается \nзелёный или красный круг. При по" +
    "явлении зелёного круга следует нажать \nклавишу «пробел». При появлении красного " +
    "круга ничего делать не надо.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Эксперимент \"Геометрическая фигура\"";
            // 
            // nudCountIterations
            // 
            this.nudCountIterations.Font = new System.Drawing.Font("Roboto", 12F);
            this.nudCountIterations.Location = new System.Drawing.Point(45, 110);
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
            this.nudCountIterations.TabIndex = 4;
            this.nudCountIterations.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudDurationShow
            // 
            this.nudDurationShow.DecimalPlaces = 2;
            this.nudDurationShow.Font = new System.Drawing.Font("Roboto", 12F);
            this.nudDurationShow.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudDurationShow.Location = new System.Drawing.Point(45, 160);
            this.nudDurationShow.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDurationShow.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudDurationShow.Name = "nudDurationShow";
            this.nudDurationShow.Size = new System.Drawing.Size(120, 32);
            this.nudDurationShow.TabIndex = 5;
            this.nudDurationShow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDurationPause
            // 
            this.numDurationPause.DecimalPlaces = 2;
            this.numDurationPause.Font = new System.Drawing.Font("Roboto", 12F);
            this.numDurationPause.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDurationPause.Location = new System.Drawing.Point(80, 290);
            this.numDurationPause.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDurationPause.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numDurationPause.Name = "numDurationPause";
            this.numDurationPause.Size = new System.Drawing.Size(120, 32);
            this.numDurationPause.TabIndex = 6;
            this.numDurationPause.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(192, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество итераций";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(192, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Продолжительность показа картинки (сек)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(192, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(584, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Продолжительсность паузы между показами картинок (сек)";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(571, 281);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(189, 63);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Начать эксперимент";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nudCountIterations);
            this.panel1.Controls.Add(this.nudDurationShow);
            this.panel1.Location = new System.Drawing.Point(35, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 382);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(870, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FiguresExperimentSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numDurationPause);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FiguresExperimentSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка параметров для \"Геометрическая фигура\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FiguresExperimentSettings_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudCountIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationPause)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCountIterations;
        private System.Windows.Forms.NumericUpDown nudDurationShow;
        private System.Windows.Forms.NumericUpDown numDurationPause;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}