using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string poll, dateofbirth, placeofbirth, name, education, marriage, badbeh;

        private void chlbxEdu_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chlbxEdu.Items.Count; i++)
            {
                if (i == chlbxEdu.SelectedIndex)
                    continue;
                if (chlbxEdu.GetItemChecked(i)) //возвращает значение, указывающее отмечен ли элемент
                    chlbxEdu.SetItemChecked(i, false); //убирает флажок у элемента с индексом i
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            rtxtbxInfo.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            dtpDOB.Value = new DateTime(2015, 08, 27);
            txtbxPoB.Text = "";
            txtbxFIO.Text = "";
            if (chlbxEdu.SelectedIndex != -1)
                chlbxEdu.SetItemChecked(chlbxEdu.SelectedIndex, false);
            chbxNoBad.Checked = false;
            if (cmbxMarriage.SelectedIndex != -1)
                cmbxMarriage.SelectedIndex = -1;
        }

        private void chbxNoBad_CheckedChanged(object sender, EventArgs e)
        {
             lbxBad.Enabled = !chbxNoBad.Checked;
        }

        private void lbxBad_SelectedIndexChanged(object sender, EventArgs e)
        {
            badbeh += lbxBad.SelectedItem + ", ";
        }

        private void cmbxMarriage_SelectedIndexChanged(object sender, EventArgs e)
        {
            placeofbirth = txtbxPoB.Text;
            if (cmbxMarriage.SelectedIndex == 0)
                marriage = "зарегестрированный брак";
            if (cmbxMarriage.SelectedIndex == 1)
                marriage = "незарегестрированный брак";
            if (cmbxMarriage.SelectedIndex == 2)
                marriage = "разведен(а)";
            if (cmbxMarriage.SelectedIndex == 3)
                marriage = "разошелся(лась)";
            if (cmbxMarriage.SelectedIndex == 4)
                marriage = "вдова, вдовец";
            if ((cmbxMarriage.SelectedIndex == 5)&&(rbMale.Checked))
                marriage = "не был женат";
            if ((cmbxMarriage.SelectedIndex == 5) && (rbFemale.Checked))
                marriage = "не была замужем";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveInfo = new SaveFileDialog();
            SaveInfo.InitialDirectory = "C:\\";
            SaveInfo.Filter = "Rich text file (*.rtf)|*.rtf|All files(*.*)|*.*";
            SaveInfo.FilterIndex = 1;
            SaveInfo.FileName = "Анкета";
            SaveInfo.RestoreDirectory = true;
            if (SaveInfo.ShowDialog() == DialogResult.OK)
                rtxtbxInfo.SaveFile(SaveInfo.FileName);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenInfo = new OpenFileDialog();
            OpenInfo.InitialDirectory = "C:\\";
            OpenInfo.Filter = "Rich text file (*.rtf)|*.rtf|All files(*.*)|*.*";
            OpenInfo.FilterIndex = 1;
            OpenInfo.RestoreDirectory = false;
            if (OpenInfo.ShowDialog() == DialogResult.OK)
                rtxtbxInfo.LoadFile(OpenInfo.FileName);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked)
                pol = "мужской";
            if (rbFemale.Checked)
                pol = "женский";
            dateofbirth = dtpDOB.Value.ToShortDateString();
            name = txtbxFIO.Text;
            if (chlbxEdu.SelectedIndex != -1)
                education = chlbxEdu.SelectedItem.ToString();
            if (chbxNoBad.Checked) badbeh = "Нету";
            rtxtbxInfo.SelectionAlignment = HorizontalAlignment.Center;
            rtxtbxInfo.SelectionFont = new Font("Times New Roman", 24, FontStyle.Bold);
            rtxtbxInfo.SelectedText += "Анкета.\n\n";
            rtxtbxInfo.SelectionAlignment = HorizontalAlignment.Left;
            rtxtbxInfo.SelectionFont = new Font("Times New Roman", 18, FontStyle.Regular);
            rtxtbxInfo.SelectedText += "ФИО: " + name + ".\n" + "Пол: " + pol + ".\n" + "Дата рождения: " + dateofbirth + ".\n" + "Место рождения: " + placeofbirth + ".\n" + "Состояние в браке: " + marriage + ".\n" + "Образование: " + education + ".\n" + "Вредные привычки: " + badbeh + ".\n";

        }
    }
}
