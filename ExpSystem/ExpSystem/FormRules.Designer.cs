
namespace ExpSystem
{
    partial class FormRules
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.lstRules = new ExpSystem.DragListBox();
            this.btnEditRule = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteReason = new System.Windows.Forms.Button();
            this.lstReasons = new ExpSystem.DragListBox();
            this.btnEditReason = new System.Windows.Forms.Button();
            this.btnAddReason = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteResult = new System.Windows.Forms.Button();
            this.lstResult = new ExpSystem.DragListBox();
            this.btnAddResult = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancel.Location = new System.Drawing.Point(589, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(298, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOk.Location = new System.Drawing.Point(12, 389);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(571, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Готово";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteRule);
            this.groupBox1.Controls.Add(this.lstRules);
            this.groupBox1.Controls.Add(this.btnEditRule);
            this.groupBox1.Controls.Add(this.btnAddRule);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 371);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лістинг правил системи:";
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDeleteRule.Location = new System.Drawing.Point(422, 332);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(138, 29);
            this.btnDeleteRule.TabIndex = 14;
            this.btnDeleteRule.Text = "Видалити правило";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            this.btnDeleteRule.Click += new System.EventHandler(this.btnDeleteRule_Click);
            // 
            // lstRules
            // 
            this.lstRules.FormattingEnabled = true;
            this.lstRules.ItemHeight = 15;
            this.lstRules.Location = new System.Drawing.Point(12, 22);
            this.lstRules.Name = "lstRules";
            this.lstRules.Size = new System.Drawing.Size(548, 304);
            this.lstRules.TabIndex = 10;
            this.lstRules.AfterDrop += new ExpSystem.AfterDropEventHandler(this.lstRules_AfterDrop);
            this.lstRules.SelectedIndexChanged += new System.EventHandler(this.lstRules_SelectedIndexChanged);
            // 
            // btnEditRule
            // 
            this.btnEditRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditRule.Location = new System.Drawing.Point(242, 332);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(174, 29);
            this.btnEditRule.TabIndex = 13;
            this.btnEditRule.Text = "Змінити правило";
            this.btnEditRule.UseVisualStyleBackColor = true;
            this.btnEditRule.Click += new System.EventHandler(this.btnEditRule_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddRule.Location = new System.Drawing.Point(12, 332);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(224, 29);
            this.btnAddRule.TabIndex = 12;
            this.btnAddRule.Text = "Додати правило";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteReason);
            this.groupBox2.Controls.Add(this.lstReasons);
            this.groupBox2.Controls.Add(this.btnEditReason);
            this.groupBox2.Controls.Add(this.btnAddReason);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(589, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 188);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Якщо:";
            // 
            // btnDeleteReason
            // 
            this.btnDeleteReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDeleteReason.Location = new System.Drawing.Point(204, 137);
            this.btnDeleteReason.Name = "btnDeleteReason";
            this.btnDeleteReason.Size = new System.Drawing.Size(85, 29);
            this.btnDeleteReason.TabIndex = 14;
            this.btnDeleteReason.Text = "-";
            this.btnDeleteReason.UseVisualStyleBackColor = true;
            this.btnDeleteReason.Click += new System.EventHandler(this.btnDeleteReason_Click);
            // 
            // lstReasons
            // 
            this.lstReasons.FormattingEnabled = true;
            this.lstReasons.ItemHeight = 15;
            this.lstReasons.Location = new System.Drawing.Point(12, 22);
            this.lstReasons.Name = "lstReasons";
            this.lstReasons.Size = new System.Drawing.Size(277, 109);
            this.lstReasons.TabIndex = 10;
            this.lstReasons.AfterDrop += new ExpSystem.AfterDropEventHandler(this.lstReasons_AfterDrop);
            // 
            // btnEditReason
            // 
            this.btnEditReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditReason.Location = new System.Drawing.Point(113, 137);
            this.btnEditReason.Name = "btnEditReason";
            this.btnEditReason.Size = new System.Drawing.Size(85, 29);
            this.btnEditReason.TabIndex = 13;
            this.btnEditReason.Text = "$";
            this.btnEditReason.UseVisualStyleBackColor = true;
            this.btnEditReason.Click += new System.EventHandler(this.btnEditReason_Click);
            // 
            // btnAddReason
            // 
            this.btnAddReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddReason.Location = new System.Drawing.Point(12, 137);
            this.btnAddReason.Name = "btnAddReason";
            this.btnAddReason.Size = new System.Drawing.Size(95, 29);
            this.btnAddReason.TabIndex = 12;
            this.btnAddReason.Text = "+";
            this.btnAddReason.UseVisualStyleBackColor = true;
            this.btnAddReason.Click += new System.EventHandler(this.btnAddReason_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteResult);
            this.groupBox3.Controls.Add(this.lstResult);
            this.groupBox3.Controls.Add(this.btnAddResult);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox3.Location = new System.Drawing.Point(589, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 183);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тоді:";
            // 
            // btnDeleteResult
            // 
            this.btnDeleteResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnDeleteResult.Location = new System.Drawing.Point(163, 137);
            this.btnDeleteResult.Name = "btnDeleteResult";
            this.btnDeleteResult.Size = new System.Drawing.Size(126, 29);
            this.btnDeleteResult.TabIndex = 14;
            this.btnDeleteResult.Text = "-";
            this.btnDeleteResult.UseVisualStyleBackColor = true;
            this.btnDeleteResult.Click += new System.EventHandler(this.btnDeleteResult_Click);
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 15;
            this.lstResult.Location = new System.Drawing.Point(12, 22);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(277, 109);
            this.lstResult.TabIndex = 10;
            // 
            // btnAddResult
            // 
            this.btnAddResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAddResult.Location = new System.Drawing.Point(12, 137);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(145, 29);
            this.btnAddResult.TabIndex = 12;
            this.btnAddResult.Text = "+";
            this.btnAddResult.UseVisualStyleBackColor = true;
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);
            // 
            // FormRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 431);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "FormRules";
            this.Text = "Правила";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private DragListBox lstRules;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteRule;
        private System.Windows.Forms.Button btnEditRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteReason;
        private DragListBox lstReasons;
        private System.Windows.Forms.Button btnEditReason;
        private System.Windows.Forms.Button btnAddReason;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteResult;
        private DragListBox lstResult;
        private System.Windows.Forms.Button btnAddResult;
    }
}