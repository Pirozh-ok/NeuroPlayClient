namespace NeuroPlayClient {
    partial class AuthForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbUserType = new System.Windows.Forms.ComboBox();
            this.chbRememberMe = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCase = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUserId
            // 
            this.tbUserId.BackColor = System.Drawing.Color.White;
            this.tbUserId.Enabled = false;
            this.tbUserId.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserId.Location = new System.Drawing.Point(216, 32);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(94, 32);
            this.tbUserId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "№ эксперимента";
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.White;
            this.tbUserName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserName.Location = new System.Drawing.Point(216, 78);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(259, 32);
            this.tbUserName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Возраст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип";
            // 
            // numAge
            // 
            this.numAge.BackColor = System.Drawing.Color.White;
            this.numAge.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numAge.Location = new System.Drawing.Point(216, 125);
            this.numAge.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(78, 32);
            this.numAge.TabIndex = 10;
            this.numAge.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(182, 361);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(143, 46);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Начать";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbUserType
            // 
            this.cbUserType.BackColor = System.Drawing.Color.White;
            this.cbUserType.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.Items.AddRange(new object[] {
            "Начальный",
            "Опытный",
            "Продвинутый"});
            this.cbUserType.Location = new System.Drawing.Point(216, 176);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(259, 32);
            this.cbUserType.TabIndex = 14;
            this.cbUserType.Text = "Начальный";
            // 
            // chbRememberMe
            // 
            this.chbRememberMe.AutoSize = true;
            this.chbRememberMe.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbRememberMe.Location = new System.Drawing.Point(157, 302);
            this.chbRememberMe.Name = "chbRememberMe";
            this.chbRememberMe.Size = new System.Drawing.Size(192, 28);
            this.chbRememberMe.TabIndex = 15;
            this.chbRememberMe.Text = "Запомнить меня";
            this.chbRememberMe.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Выбор сценария";
            // 
            // cbCase
            // 
            this.cbCase.AutoCompleteCustomSource.AddRange(new string[] {
            "Геометрическая фигура",
            "Арифметические вычисления",
            "Род существительного"});
            this.cbCase.BackColor = System.Drawing.Color.White;
            this.cbCase.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCase.FormattingEnabled = true;
            this.cbCase.Items.AddRange(new object[] {
            "Геометрическая фигура",
            "Арифметические вычисления",
            "Род существительного"});
            this.cbCase.Location = new System.Drawing.Point(216, 232);
            this.cbCase.Name = "cbCase";
            this.cbCase.Size = new System.Drawing.Size(259, 32);
            this.cbCase.TabIndex = 18;
            this.cbCase.Text = "Геометрическая фигура";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.tbUserId);
            this.panel1.Controls.Add(this.chbRememberMe);
            this.panel1.Controls.Add(this.cbCase);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbUserType);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbUserName);
            this.panel1.Controls.Add(this.numAge);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(40, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 435);
            this.panel1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(557, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(181, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 39);
            this.label7.TabIndex = 20;
            this.label7.Text = "Авторизация";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(587, 534);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.VisibleChanged += new System.EventHandler(this.AuthForm_VisibleChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbUserType;
        private System.Windows.Forms.CheckBox chbRememberMe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

