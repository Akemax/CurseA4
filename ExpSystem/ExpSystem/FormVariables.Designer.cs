
namespace ExpSystem
{
    partial class FormVariables
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.btnEditRule = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddDomain = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteRule);
            this.groupBox1.Controls.Add(this.btnEditRule);
            this.groupBox1.Controls.Add(this.btnAddRule);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лістинг змінних:";
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDeleteRule.Location = new System.Drawing.Point(297, 281);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(159, 29);
            this.btnDeleteRule.TabIndex = 17;
            this.btnDeleteRule.Text = "Видалити змінну";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            this.btnDeleteRule.Click += new System.EventHandler(this.btnDelVar_Click);
            // 
            // btnEditRule
            // 
            this.btnEditRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditRule.Location = new System.Drawing.Point(154, 281);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(137, 29);
            this.btnEditRule.TabIndex = 16;
            this.btnEditRule.Text = "Змінити змінну";
            this.btnEditRule.UseVisualStyleBackColor = true;
            this.btnEditRule.Click += new System.EventHandler(this.btnEditVar_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddRule.Location = new System.Drawing.Point(15, 281);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(133, 29);
            this.btnAddRule.TabIndex = 15;
            this.btnAddRule.Text = "Додати змінну";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddVar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(15, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(441, 244);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancel.Location = new System.Drawing.Point(786, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(201, 29);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOk.Location = new System.Drawing.Point(12, 340);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(768, 29);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Готово";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox4.Location = new System.Drawing.Point(786, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(201, 322);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Питання:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 289);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddDomain);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox3.Location = new System.Drawing.Point(489, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 55);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Домен:";
            // 
            // btnAddDomain
            // 
            this.btnAddDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAddDomain.Location = new System.Drawing.Point(255, 21);
            this.btnAddDomain.Name = "btnAddDomain";
            this.btnAddDomain.Size = new System.Drawing.Size(25, 23);
            this.btnAddDomain.TabIndex = 1;
            this.btnAddDomain.Text = "+";
            this.btnAddDomain.UseVisualStyleBackColor = true;
            this.btnAddDomain.Click += new System.EventHandler(this.btnAddDomain_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(489, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 104);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(73, 70);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(167, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Виведений-запитуваний";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(73, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Запитуваний";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(73, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Виведений";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAddValue);
            this.groupBox5.Controls.Add(this.listBox2);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox5.Location = new System.Drawing.Point(489, 70);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(291, 161);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Значення:";
            // 
            // btnAddValue
            // 
            this.btnAddValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAddValue.Location = new System.Drawing.Point(11, 131);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(269, 23);
            this.btnAddValue.TabIndex = 2;
            this.btnAddValue.Text = "+";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddVal_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(11, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(269, 109);
            this.listBox2.TabIndex = 0;
            // 
            // FormVariables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 377);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVariables";
            this.Text = "FormVariables";
            this.Load += new System.EventHandler(this.FormVariables_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDeleteRule;
        private System.Windows.Forms.Button btnEditRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddDomain;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.ListBox listBox2;
    }
}