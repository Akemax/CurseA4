
namespace ExpSystem
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDomen = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnVar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExplain = new System.Windows.Forms.Button();
            this.btnGoal = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(18, 21);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(110, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Створити файл";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(18, 51);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(110, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Відкрити файл";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файл";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDomen);
            this.groupBox2.Controls.Add(this.btnRules);
            this.groupBox2.Controls.Add(this.btnVar);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(164, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 119);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Налаштування системи";
            // 
            // btnDomen
            // 
            this.btnDomen.Location = new System.Drawing.Point(18, 21);
            this.btnDomen.Name = "btnDomen";
            this.btnDomen.Size = new System.Drawing.Size(185, 23);
            this.btnDomen.TabIndex = 0;
            this.btnDomen.Text = "Домени";
            this.btnDomen.UseVisualStyleBackColor = true;
            this.btnDomen.Click += new System.EventHandler(this.btnDomen_Click);
            // 
            // btnRules
            // 
            this.btnRules.Location = new System.Drawing.Point(18, 81);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(185, 23);
            this.btnRules.TabIndex = 2;
            this.btnRules.Text = "Правила";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnVar
            // 
            this.btnVar.Location = new System.Drawing.Point(18, 51);
            this.btnVar.Name = "btnVar";
            this.btnVar.Size = new System.Drawing.Size(185, 23);
            this.btnVar.TabIndex = 1;
            this.btnVar.Text = "Змінні";
            this.btnVar.UseVisualStyleBackColor = true;
            this.btnVar.Click += new System.EventHandler(this.btnVar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExplain);
            this.groupBox3.Controls.Add(this.btnGoal);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 119);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Експертна система";
            // 
            // btnExplain
            // 
            this.btnExplain.Location = new System.Drawing.Point(209, 21);
            this.btnExplain.Name = "btnExplain";
            this.btnExplain.Size = new System.Drawing.Size(146, 83);
            this.btnExplain.TabIndex = 2;
            this.btnExplain.Text = "Пояснення";
            this.btnExplain.UseVisualStyleBackColor = true;
            this.btnExplain.Click += new System.EventHandler(this.btnExplain_Click);
            // 
            // btnGoal
            // 
            this.btnGoal.Location = new System.Drawing.Point(18, 21);
            this.btnGoal.Name = "btnGoal";
            this.btnGoal.Size = new System.Drawing.Size(185, 24);
            this.btnGoal.TabIndex = 0;
            this.btnGoal.Text = "Встановити ціль";
            this.btnGoal.UseVisualStyleBackColor = true;
            this.btnGoal.Click += new System.EventHandler(this.btnGoal_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(18, 51);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(185, 53);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Запуск системи";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 265);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Системи штучного інтелекту";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDomen;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnVar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGoal;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExplain;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

