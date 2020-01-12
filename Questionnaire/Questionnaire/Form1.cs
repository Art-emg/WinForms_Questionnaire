using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire
{
    public partial class Form1 : Form
    {
        Dictionary<Panel, bool> EnablePanelsDictionary = new Dictionary<Panel, bool>();
        List<Panel> QuestionPanelsList = new List<Panel>();

        //Dictionary<Panel, List<Control>> QuestionAndAnswersDictionary = new Dictionary<Panel, List<Control>>();

        Panel currentQuestionPanel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QuestionPanelsList.Add(Q1panel);
            QuestionPanelsList.Add(Q2panel);
            QuestionPanelsList.Add(Q3panel);
            QuestionPanelsList.Add(FinishPanel);

            foreach (Panel panel in QuestionPanelsList)
            {
                panel.Visible = false;
                EnablePanelsDictionary.Add(panel, true);
            }
           
            previousButton.Visible = false;
            nextButton.Visible = false;

            Q1textBoxOtherColor.Enabled = false;
            Q2textBoxOther.Enabled = false;

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Q1panel.Visible = true;
            startButton.Visible = false;
            nextButton.Visible = true;

            currentQuestionPanel = Q1panel;
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            ShowPreviousQuestionPanel();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (ValidationQuestionPanel())
                ShowNextQuestionPanel();
            else
                MessageBox.Show("Заполните необходимые данные");
        }

        void ShowNextQuestionPanel()
        {
            int nextIndex = QuestionPanelsList.IndexOf(currentQuestionPanel) + 1;
            if ((nextIndex) >= QuestionPanelsList.Count-1) // если последний вопрос был
            {
                ShowFinishPanel();
            }
            else
            {
                previousButton.Visible = true;

                currentQuestionPanel.Visible = false;

                currentQuestionPanel = QuestionPanelsList.ElementAt(nextIndex);
                if (!EnablePanelsDictionary[currentQuestionPanel])
                {
                    ShowNextQuestionPanel();
                    return;
                }

                currentQuestionPanel.Visible = true;



                if (nextIndex == QuestionPanelsList.Count-2)
                {
                    nextButton.Text = "Завершить";
                }
                
            }
        }

        void ShowPreviousQuestionPanel()
        {
            int previousIndex = QuestionPanelsList.IndexOf(currentQuestionPanel) - 1;
            if (previousIndex < 0) // если первый вопрос был
            {
                MessageBox.Show("Это первый вопрос");
            }
            else
            {
                if(previousIndex == 0)
                {
                    previousButton.Visible = false;
                }
                currentQuestionPanel.Visible = false;
                nextButton.Visible = true;

                currentQuestionPanel = QuestionPanelsList.ElementAt(previousIndex);
                if (!EnablePanelsDictionary[currentQuestionPanel])
                {
                    ShowPreviousQuestionPanel();
                    return;
                }

                currentQuestionPanel.Visible = true;


                if (previousIndex == QuestionPanelsList.Count - 2)
                    nextButton.Text = "Завершить";              
                else
                    nextButton.Text = "Следующий";
            }
        }

        void ShowFinishPanel()
        {
            currentQuestionPanel = FinishPanel;

            currentQuestionPanel.Visible = false;
            nextButton.Visible = false;
            currentQuestionPanel.Visible = true;
        }

        bool ValidationQuestionPanel()
        {
            IEnumerable<RadioButton> validationRadioButtons = currentQuestionPanel.Controls.OfType<RadioButton>();
            IEnumerable<CheckBox> validationCheckBoxes = currentQuestionPanel.Controls.OfType<CheckBox>();

            if (Q1radioButtonOtherColor.Checked && Q1textBoxOtherColor.Text == "")
                return false;

            if (Q2checkBoxOther.Checked && Q2textBoxOther.Text == "")
                return false;

            foreach (RadioButton radioButton in validationRadioButtons)
            {
                if (radioButton.Checked == true)
                    return true;
            }

            foreach (CheckBox checkBoxes in validationCheckBoxes)
            {
                if (checkBoxes.Checked == true)
                    return true;
            }

            return false;
        }

    #region Q1 panel events
        private void Q1radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Q1textBoxOtherColor.Enabled = Q1radioButtonOtherColor.Checked;
            EnablePanelsDictionary[Q2panel] = Q1radioButtonNoColor.Checked ? false : true;
        }

    #endregion

    #region Q2 panel events

        private void Q2checkBox_CheckedChanged(object sender, EventArgs e)
        {         

                Q2checkBoxNoAnswer.Checked = false;

                Q2textBoxOther.Enabled = Q2checkBoxOther.Checked;
               
        }
        private void Q2checkBoxNoAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (Q2checkBoxNoAnswer.Checked)
            {
                foreach (CheckBox checkBox in Q2panel.Controls.OfType<CheckBox>())
                {
                    if(checkBox!= Q2checkBoxNoAnswer)
                        checkBox.Checked = false;
                }
                Q2checkBoxNoAnswer.Checked = true;
            }
        }
        #endregion

    #region Q3 panel events
        private void Q3checkBox_CheckedChanged(object sender, EventArgs e)
        {
            IEnumerable<CheckBox> checkBoxes = Q3panel.Controls.OfType<CheckBox>();
            int countChecked = checkBoxes.Where(cb => cb.Checked == true)
                                         .Count();

                foreach (CheckBox checkBox in checkBoxes.Where(cb => cb.Checked == false))
                {
                    checkBox.Enabled = countChecked >= 3 ? false : true;
                }

                                    
        }

        #endregion

    #region save panel
        private void SaveCSVbutton_Click(object sender, EventArgs e)
        {
            string fileName = "answers.csv";
            SaveAnswersInCsv(fileName);
        }
        private void SaveCSVasButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "CSV files(*.csv)|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string fileName = saveFileDialog1.FileName;
            SaveAnswersInCsv(fileName);
        }
    #endregion


        void SaveAnswersInCsv(string fileName)
        {
            List<string> csvStrings = new List<string>();
            csvStrings.Add(Q1text.Text);
            foreach (RadioButton radioButton in Q1panel.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    csvStrings[0] += radioButton == Q1radioButtonOtherColor ?
                                                        ";" + Q1textBoxOtherColor.Text
                                                        : ";" + radioButton.Text;
                }
            }

            csvStrings.Add(Q2text.Text);
            foreach (CheckBox checkBox in Q2panel.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    csvStrings[1] += checkBox == Q2checkBoxOther ?
                                                        ";" + Q2textBoxOther.Text
                                                        : ";" + checkBox.Text;
                }
            }


            csvStrings.Add(Q3text.Text);
            foreach (CheckBox checkBox in Q3panel.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                    csvStrings[2] += ";" + checkBox.Text;
            }
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                using (StreamWriter sw = new StreamWriter(File.Open(fileName, FileMode.Create), Encoding.Default))
                {
                    foreach (string str in csvStrings)
                        sw.WriteLine(str);
                }
                MessageBox.Show("Файл " + fileName + " сохранен.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
