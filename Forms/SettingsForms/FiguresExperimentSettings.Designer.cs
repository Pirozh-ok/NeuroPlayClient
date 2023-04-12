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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCountIterations = new System.Windows.Forms.NumericUpDown();
            this.nudDurationShow = new System.Windows.Forms.NumericUpDown();
            this.numDurationPause = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationPause)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(713, 75);
            this.label2.TabIndex = 3;
            this.label2.Text = "    «В случайной последовательности показывается \nзелёный или красный круг. При п" +
    "оявлении зелёного круга следует нажать \nклавишу «пробел». При появлении красного" +
    " круга ничего делать не надо».";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(160, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Эксперимент \"Геометрическая фигура\"";
            // 
            // nudCountIterations
            // 
            this.nudCountIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudCountIterations.Location = new System.Drawing.Point(62, 173);
            this.nudCountIterations.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudCountIterations.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCountIterations.Name = "nudCountIterations";
            this.nudCountIterations.Size = new System.Drawing.Size(120, 30);
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
            this.nudDurationShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudDurationShow.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudDurationShow.Location = new System.Drawing.Point(62, 231);
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
            this.nudDurationShow.Size = new System.Drawing.Size(120, 30);
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
            this.numDurationPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numDurationPause.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDurationPause.Location = new System.Drawing.Point(62, 291);
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
            this.numDurationPause.Size = new System.Drawing.Size(120, 30);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(211, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество итераций";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(211, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Продолжительность показа картинки (сек)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(211, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(588, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Продолжительсность паузы между показами картинок (сек)";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStart.Location = new System.Drawing.Point(550, 358);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(189, 63);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Начать эксперимент";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FiguresExperimentSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numDurationPause);
            this.Controls.Add(this.nudDurationShow);
            this.Controls.Add(this.nudCountIterations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FiguresExperimentSettings";
            this.Text = "Настройка параметров для \"Геометрическая фигура\"";
            ((System.ComponentModel.ISupportInitialize)(this.nudCountIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationPause)).EndInit();
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
    }
}