namespace NeuroPlayClient.Forms.Settings {
    partial class CalculationExperimentSettings {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculationExperimentSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.nudCoundIteration = new System.Windows.Forms.NumericUpDown();
            this.nudDurationShow = new System.Windows.Forms.NumericUpDown();
            this.nudDurationPause = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoundIteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationPause)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // nudCoundIteration
            // 
            this.nudCoundIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudCoundIteration.Location = new System.Drawing.Point(52, 174);
            this.nudCoundIteration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCoundIteration.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCoundIteration.Name = "nudCoundIteration";
            this.nudCoundIteration.Size = new System.Drawing.Size(120, 30);
            this.nudCoundIteration.TabIndex = 1;
            this.nudCoundIteration.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudDurationShow
            // 
            this.nudDurationShow.DecimalPlaces = 2;
            this.nudDurationShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudDurationShow.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudDurationShow.Location = new System.Drawing.Point(52, 238);
            this.nudDurationShow.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudDurationShow.Name = "nudDurationShow";
            this.nudDurationShow.Size = new System.Drawing.Size(120, 30);
            this.nudDurationShow.TabIndex = 2;
            this.nudDurationShow.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudDurationPause
            // 
            this.nudDurationPause.DecimalPlaces = 2;
            this.nudDurationPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudDurationPause.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudDurationPause.Location = new System.Drawing.Point(52, 299);
            this.nudDurationPause.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudDurationPause.Name = "nudDurationPause";
            this.nudDurationPause.Size = new System.Drawing.Size(120, 30);
            this.nudDurationPause.TabIndex = 3;
            this.nudDurationPause.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(263, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество итераций";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(263, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Продолжительность отображения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(263, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Продолжительность паузы";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(563, 365);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 73);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Начать эксперимент";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // CalculationExperimentSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudDurationPause);
            this.Controls.Add(this.nudDurationShow);
            this.Controls.Add(this.nudCoundIteration);
            this.Controls.Add(this.label1);
            this.Name = "CalculationExperimentSettings";
            this.Text = "Арифметические вычисления";
            ((System.ComponentModel.ISupportInitialize)(this.nudCoundIteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCoundIteration;
        private System.Windows.Forms.NumericUpDown nudDurationShow;
        private System.Windows.Forms.NumericUpDown nudDurationPause;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
    }
}