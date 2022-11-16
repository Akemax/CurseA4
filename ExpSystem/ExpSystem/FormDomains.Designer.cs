
namespace ExpSystem
{
    partial class FormDomains
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
            this.btnEditDomain = new System.Windows.Forms.Button();
            this.btnDelDomain = new System.Windows.Forms.Button();
            this.btnAddDomain = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditValue = new System.Windows.Forms.Button();
            this.btnDelValue = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditDomain);
            this.groupBox1.Controls.Add(this.btnDelDomain);
            this.groupBox1.Controls.Add(this.btnAddDomain);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 271);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Домени";
            // 
            // btnEditDomain
            // 
            this.btnEditDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnEditDomain.Location = new System.Drawing.Point(198, 240);
            this.btnEditDomain.Name = "btnEditDomain";
            this.btnEditDomain.Size = new System.Drawing.Size(24, 23);
            this.btnEditDomain.TabIndex = 3;
            this.btnEditDomain.Text = "$";
            this.btnEditDomain.UseVisualStyleBackColor = true;
            this.btnEditDomain.Click += new System.EventHandler(this.btnEditDomain_Click);
            // 
            // btnDelDomain
            // 
            this.btnDelDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelDomain.Location = new System.Drawing.Point(228, 240);
            this.btnDelDomain.Name = "btnDelDomain";
            this.btnDelDomain.Size = new System.Drawing.Size(24, 23);
            this.btnDelDomain.TabIndex = 2;
            this.btnDelDomain.Text = "-";
            this.btnDelDomain.UseVisualStyleBackColor = true;
            this.btnDelDomain.Click += new System.EventHandler(this.btnDelDomain_Click);
            // 
            // btnAddDomain
            // 
            this.btnAddDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDomain.Location = new System.Drawing.Point(168, 240);
            this.btnAddDomain.Name = "btnAddDomain";
            this.btnAddDomain.Size = new System.Drawing.Size(24, 23);
            this.btnAddDomain.TabIndex = 1;
            this.btnAddDomain.Text = "+";
            this.btnAddDomain.UseVisualStyleBackColor = true;
            this.btnAddDomain.Click += new System.EventHandler(this.btnAddDomain_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditValue);
            this.groupBox2.Controls.Add(this.btnDelValue);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.btnAddValue);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(276, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 271);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Значення";
            // 
            // btnEditValue
            // 
            this.btnEditValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnEditValue.Location = new System.Drawing.Point(198, 240);
            this.btnEditValue.Name = "btnEditValue";
            this.btnEditValue.Size = new System.Drawing.Size(24, 23);
            this.btnEditValue.TabIndex = 4;
            this.btnEditValue.Text = "$";
            this.btnEditValue.UseVisualStyleBackColor = true;
            this.btnEditValue.Click += new System.EventHandler(this.btnEditValue_Click);
            // 
            // btnDelValue
            // 
            this.btnDelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelValue.Location = new System.Drawing.Point(228, 240);
            this.btnDelValue.Name = "btnDelValue";
            this.btnDelValue.Size = new System.Drawing.Size(24, 23);
            this.btnDelValue.TabIndex = 4;
            this.btnDelValue.Text = "-";
            this.btnDelValue.UseVisualStyleBackColor = true;
            this.btnDelValue.Click += new System.EventHandler(this.btnDelValue_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(6, 22);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(246, 212);
            this.listBox2.TabIndex = 1;
            // 
            // btnAddValue
            // 
            this.btnAddValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddValue.Location = new System.Drawing.Point(168, 240);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(24, 23);
            this.btnAddValue.TabIndex = 3;
            this.btnAddValue.Text = "+";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddValue_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(12, 292);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(387, 29);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Готово";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(405, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormDomains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 327);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDomains";
            this.Text = "Домени";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelDomain;
        private System.Windows.Forms.Button btnAddDomain;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDelValue;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.Button btnEditDomain;
        private System.Windows.Forms.Button btnEditValue;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}