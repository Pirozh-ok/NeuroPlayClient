namespace NeuroPlayClient.Forms.ExperimentForms {
    partial class CalculationExperiment {
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
            this.lblCalculationTask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCalculationTask
            // 
            this.lblCalculationTask.AutoSize = true;
            this.lblCalculationTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalculationTask.Location = new System.Drawing.Point(168, 138);
            this.lblCalculationTask.Name = "lblCalculationTask";
            this.lblCalculationTask.Size = new System.Drawing.Size(498, 135);
            this.lblCalculationTask.TabIndex = 0;
            this.lblCalculationTask.Text = "Пример";
            // 
            // CalculationExperiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCalculationTask);
            this.Name = "CalculationExperiment";
            this.Text = "Эксперимент \"Арифметические вычисления\"";
            this.Load += new System.EventHandler(this.CalculationExperiment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalculationExperiment_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculationTask;
    }
}