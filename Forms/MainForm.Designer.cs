namespace NeuroPlayClient.Forms {
    partial class MainForm {
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
            this.tcMethodsResearch = new System.Windows.Forms.TabControl();
            this.tabPictureMethod = new System.Windows.Forms.TabPage();
            this.btnStart = new System.Windows.Forms.Button();
            this.nudDelay = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCountIteration = new System.Windows.Forms.TextBox();
            this.tcMethodsResearch.SuspendLayout();
            this.tabPictureMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMethodsResearch
            // 
            this.tcMethodsResearch.Controls.Add(this.tabPictureMethod);
            this.tcMethodsResearch.Controls.Add(this.tabPage2);
            this.tcMethodsResearch.Controls.Add(this.tabPage3);
            this.tcMethodsResearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.tcMethodsResearch.Location = new System.Drawing.Point(0, 0);
            this.tcMethodsResearch.Name = "tcMethodsResearch";
            this.tcMethodsResearch.SelectedIndex = 0;
            this.tcMethodsResearch.Size = new System.Drawing.Size(635, 450);
            this.tcMethodsResearch.TabIndex = 0;
            // 
            // tabPictureMethod
            // 
            this.tabPictureMethod.Controls.Add(this.tbCountIteration);
            this.tabPictureMethod.Controls.Add(this.btnStart);
            this.tabPictureMethod.Controls.Add(this.nudDelay);
            this.tabPictureMethod.Controls.Add(this.label6);
            this.tabPictureMethod.Controls.Add(this.label5);
            this.tabPictureMethod.Controls.Add(this.nudTime);
            this.tabPictureMethod.Controls.Add(this.label4);
            this.tabPictureMethod.Controls.Add(this.label3);
            this.tabPictureMethod.Controls.Add(this.label2);
            this.tabPictureMethod.Controls.Add(this.label1);
            this.tabPictureMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPictureMethod.Location = new System.Drawing.Point(4, 25);
            this.tabPictureMethod.Name = "tabPictureMethod";
            this.tabPictureMethod.Padding = new System.Windows.Forms.Padding(3);
            this.tabPictureMethod.Size = new System.Drawing.Size(627, 421);
            this.tabPictureMethod.TabIndex = 0;
            this.tabPictureMethod.Text = "Первый сценарий";
            this.tabPictureMethod.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(502, 340);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(119, 45);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Начать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nudDelay
            // 
            this.nudDelay.DecimalPlaces = 2;
            this.nudDelay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDelay.Location = new System.Drawing.Point(251, 262);
            this.nudDelay.Name = "nudDelay";
            this.nudDelay.Size = new System.Drawing.Size(120, 30);
            this.nudDelay.TabIndex = 8;
            this.nudDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDelay.ValueChanged += new System.EventHandler(this.nudDelay_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(22, 248);
            this.label6.MaximumSize = new System.Drawing.Size(215, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 44);
            this.label6.TabIndex = 7;
            this.label6.Text = "Время показа изображения (сек)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 318);
            this.label5.MaximumSize = new System.Drawing.Size(215, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Количество повторений";
            // 
            // nudTime
            // 
            this.nudTime.Location = new System.Drawing.Point(251, 202);
            this.nudTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(120, 30);
            this.nudTime.TabIndex = 4;
            this.nudTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTime.ValueChanged += new System.EventHandler(this.nudTimeOrCountIteration_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 188);
            this.label4.MaximumSize = new System.Drawing.Size(215, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "Продолжительность эксперимента (сек)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 43);
            this.label3.MaximumSize = new System.Drawing.Size(500, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 88);
            this.label3.TabIndex = 2;
            this.label3.Text = "После начала эксперимента будет появлять зелённый или красный круг. При появлении" +
    " зелёного следует нажать клавишу \"пробел\", при красном же ничего не делать";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(578, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Формирование внешних стимулов при помощи изображений";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки эксперимента";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(627, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Второй сценарий";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(627, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Третий сценарий";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(641, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 434);
            this.panel1.TabIndex = 1;
            // 
            // tbCountIteration
            // 
            this.tbCountIteration.Location = new System.Drawing.Point(251, 318);
            this.tbCountIteration.Name = "tbCountIteration";
            this.tbCountIteration.ReadOnly = true;
            this.tbCountIteration.Size = new System.Drawing.Size(120, 30);
            this.tbCountIteration.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcMethodsResearch);
            this.Name = "MainForm";
            this.Text = "NeuroPlayClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tcMethodsResearch.ResumeLayout(false);
            this.tabPictureMethod.ResumeLayout(false);
            this.tabPictureMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMethodsResearch;
        private System.Windows.Forms.TabPage tabPictureMethod;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown nudDelay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbCountIteration;
    }
}