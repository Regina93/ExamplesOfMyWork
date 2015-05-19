using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {       
        int questionNum = 1;
        int clmnNum = 2;
        int maxQNum = 0;

        StreamReader questionsFile = new StreamReader(Application.StartupPath + "\\" + "questions.txt", System.Text.Encoding.Default);
        StreamReader answersFile = new StreamReader(Application.StartupPath + "\\" + "answers.txt", System.Text.Encoding.Default);

        Excel.Workbooks setOfWrkbooks;
        Excel.Workbook wrkbook;
        Excel.Sheets setOfSheets;
        Excel.Worksheet wrksheet;
        Excel.Range excelCellA1;
        Excel.Application excelApp = new Excel.Application();
        
        public Form1()
        {
            InitializeComponent();  
        }

        private void uncheck()
        {
            foreach (Control control in panel1.Controls)
                if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
        }

        private void readNewQuestionFromFile()
        {            
            if (!questionsFile.EndOfStream)
                lblQuestion.Text = questionsFile.ReadLine(); 
        }

        private void readNewAnswersFromFile()
        {
            string line = "";

            foreach (Control control1 in panel1.Controls)
                if (control1 is RadioButton)
                    ((RadioButton)control1).Visible = false;

            foreach (Control control2 in panel1.Controls)
            {
                if (control2 is RadioButton)
                {
                    line = answersFile.ReadLine();

                    if (line != "" && line != null)
                    {
                        ((RadioButton)control2).Text = line;

                        if (((RadioButton)control2).Visible == false)
                            ((RadioButton)control2).Visible = true;
                    }
                    else
                        break;
                }
            }
        }

        private void openingExcelWrkbook()
        {
            //Get the set of references on Workbooks
            setOfWrkbooks = excelApp.Workbooks;

            //Opening the workbook and get the reference on it
            excelApp.Workbooks.Open(Application.StartupPath + "\\" + "matrix.xlsx");

            wrkbook = setOfWrkbooks[1];

            //Get the set of references on lists selecting Workbook
            setOfSheets = wrkbook.Worksheets;

            //Select a sheet №1
            wrksheet = (Excel.Worksheet)setOfSheets.get_Item(1);

            //Select a cell A1
            excelCellA1 = wrksheet.get_Range("A1");
        }

        private void correctCompletionSurvey()
        {
            excelCellA1 = wrksheet.get_Range("A1");
            excelCellA1.Cells.Value2 += 1;

            wrkbook.Save();
            wrkbook.Close();

            questionsFile.Close();
            answersFile.Close();

            panel1.Visible = false;
            lblThanks.Visible = true;
            pictureBox2.Visible = true;
            closeBtn.Visible = true;
        }

        private void writeExcelWrkbook()
        {
            string rbName = "";

            foreach (Control control in panel1.Controls)
            {
                if (control is RadioButton)
                {
                    if (((RadioButton)control).Checked)
                    {
                        rbName = ((RadioButton)control).Name;
                        excelCellA1 = (Excel.Range)wrksheet.Cells[excelCellA1.Cells.Value2, clmnNum];
                        excelCellA1.Value2 = rbName[2] - '0';
                        clmnNum++;
                        break;
                    }
                }
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            maxQNum = Convert.ToInt32(questionsFile.ReadLine());

            lblQuestion.Visible = true;
            startBtn.Visible = false;
            nextBtn.Visible = true;

            readNewQuestionFromFile();
            readNewAnswersFromFile();
            uncheck();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            readNewQuestionFromFile();
            readNewAnswersFromFile();
            openingExcelWrkbook();

            if (questionNum != maxQNum)
            {
                writeExcelWrkbook();
                wrkbook.Save();                
            }
            else
            {
                writeExcelWrkbook();
                correctCompletionSurvey();
            }

            uncheck();

            ++questionNum;          
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
