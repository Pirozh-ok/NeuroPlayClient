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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCalculationTask
            // 
            this.lblCalculationTask.AutoSize = true;
            this.lblCalculationTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lblCalculationTask.Font = new System.Drawing.Font("Roboto Medium", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalculationTask.Location = new System.Drawing.Point(201, 178);
            this.lblCalculationTask.Name = "lblCalculationTask";
            this.lblCalculationTask.Size = new System.Drawing.Size(504, 144);
            this.lblCalculationTask.TabIndex = 0;
            this.lblCalculationTask.Text = "Пример";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.panel1.Location = new System.Drawing.Point(47, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 297);
            this.panel1.TabIndex = 1;
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
            // 
            // CalculationExperiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCalculationTask);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculationExperiment";
            this.Text = "Эксперимент \"Арифметические вычисления\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalculationExperiment_FormClosing);
            this.Load += new System.EventHandler(this.CalculationExperiment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalculationExperiment_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculationTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}