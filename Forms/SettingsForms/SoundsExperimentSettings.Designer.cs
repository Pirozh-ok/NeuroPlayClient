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
            ((System.ComponentModel.ISupportInitialize)(this.nudCountIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPauseDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // nudCountIterations
            // 
            this.nudCountIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudCountIterations.Location = new System.Drawing.Point(68, 152);
            this.nudCountIterations.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCountIterations.Name = "nudCountIterations";
            this.nudCountIterations.Size = new System.Drawing.Size(120, 30);
            this.nudCountIterations.TabIndex = 1;
            this.nudCountIterations.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // nudPauseDuration
            // 
            this.nudPauseDuration.DecimalPlaces = 2;
            this.nudPauseDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudPauseDuration.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudPauseDuration.Location = new System.Drawing.Point(68, 203);
            this.nudPauseDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPauseDuration.Name = "nudPauseDuration";
            this.nudPauseDuration.Size = new System.Drawing.Size(120, 30);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(237, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество итераций";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(237, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Продолжительность паузы";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(527, 305);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(170, 75);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Начать эксперимент";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // SoundsExperimentSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudPauseDuration);
            this.Controls.Add(this.nudCountIterations);
            this.Controls.Add(this.label1);
            this.Name = "SoundsExperimentSettings";
            this.Text = "Род существительного";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SoundsExperimentSettings_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SoundsExperimentSettings_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudCountIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPauseDuration)).EndInit();
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
    }
}