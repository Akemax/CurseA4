using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ExpSystem
{
    public partial class FormMain : Form
    {
        ExpertSystem tempES = null;
        string tempFile = "";
        bool saved = true;
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDomen_Click(object sender, EventArgs e)
        {
            FormDomains f = new FormDomains(tempES);
            if (f.ShowDialog() == DialogResult.OK)
            {
                saved = false;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    tempES = new ExpertSystem();
                    tempFile = saveFileDialog1.FileName;
                    if (File.Exists(tempFile))
                        File.Delete(tempFile);
                    File.Create(tempFile);
                    StartES();
                    saved = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FinishES();
            }
        }
        private void StartES()
        {
            this.Text = "Экспертная система - " + tempFile.Substring(tempFile.LastIndexOf('\\') + 1);
            // DOPISHI MAXIM CODE
        }

        private void FinishES()
        {
            this.Text = "Экспертная система";
            // DOPISHI MAXIM CODE
        }
        private void SaveES(string file)
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenWrite(file);
                bf.Serialize(fs, tempES);
                fs.Close();
                MessageBox.Show("Экспертная система успешно сохранена!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveES(tempFile);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream fs = File.OpenRead(openFileDialog1.FileName);
                    tempES = (ExpertSystem)bf.Deserialize(fs);
                    fs.Close();
                    tempFile = openFileDialog1.FileName;
                    StartES();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FinishES();
            }
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                DialogResult dr = MessageBox.Show("Сохранить перед выходом?", "Выход", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (dr)
                {
                    case DialogResult.Yes:
                        SaveES(tempFile);
                        goto case DialogResult.No;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break; ;
                }
            }
        }

        private void btnVar_Click(object sender, EventArgs e)
        {
            FormVariables f = new FormVariables(tempES);
            if (f.ShowDialog() == DialogResult.OK)
            {
                saved = false;
            }
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            FormRules f = new FormRules(tempES);
            if (f.ShowDialog() == DialogResult.OK)
            {
                saved = false;
            }
        }
        public void StartConsult()
        {
            try
            {
                if (tempES.Goal != null)
                {
                    Fact f = tempES.GoConsult();
                    if (f.Truly == Rightly.Unknown)
                        MessageBox.Show("Не удалось установить истину!");
                    else
                        MessageBox.Show(f.ToString());
                }
            }
            catch (DomainException de)
            {
                MessageBox.Show("Не удалось сделать вывод! Причина: " + de.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoal_Click(object sender, EventArgs e)
        {
            FormGoal fg = new FormGoal(tempES, this);
            fg.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartConsult();
        }

        private void btnExplain_Click(object sender, EventArgs e)
        {
            if (tempES.WorkedRules == null || tempES.WorkedRules.Count <= 0)
            {
                MessageBox.Show("Нет данных");
                return;
            }
            else
            {
               // FormExplain fe = new FormExplain(tempES);
               // fe.ShowDialog();
            }
        }
    }
}
