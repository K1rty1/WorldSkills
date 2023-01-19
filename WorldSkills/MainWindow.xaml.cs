using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace WorldSkills
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void ReportOutputWorld_Click(object sender, RoutedEventArgs e)
        {
            List<string> arrayStudent = new List<string>();
            Word.Application application = new Word.Application();
            Word.Document document = application.Documents.Add();
            application.Visible = true;
            Word.Paragraph titleParagraf = document.Paragraphs.Add();
            Word.Range titleRange = titleParagraf.Range;
            titleRange.Text = "МИНИСТЕРСТВО ОБРАЗОВАНИЯ И МОЛОДЕЖНОЙ ПОЛИТИКИ СВЕРДЛОВСКОЙ ОБЛАСТИ ГОСУДАРСТВЕННОЕ АВТОНОМНОЕ ПРОФЕССИОНАЛЬНОЕ ОБРАЗОВАТЕЛЬНОЕ УЧРЕЖДЕНИЕ СВЕРДЛОВСКОЙ ОБЛАСТИ";
            titleRange.Font.Size = 12;
            titleRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
           
            titleRange.InsertParagraphAfter();

            Word.Paragraph titleParagraf2 = document.Paragraphs.Add();
            Word.Range titleRange2 = titleParagraf2.Range;
            titleRange2.Text = "«ЕКАТЕРИНБУРГСКИЙ МОНТАЖНЫЙ КОЛЛЕДЖ»";
            titleRange2.Font.Size = 12;
            titleRange2.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            titleRange2.Bold = 1;
            titleRange2.InsertParagraphAfter();

            Word.Paragraph titleParagraf3 = document.Paragraphs.Add();
            Word.Range titleRange3 = titleParagraf3.Range;
            titleRange3.Text = "ВЕДОМОСТЬ ";
            titleRange3.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            titleRange3.Bold = 1;
            titleRange3.InsertParagraphAfter();

            Word.Paragraph titleParagraf4 = document.Paragraphs.Add();
            Word.Range titleRange4 = titleParagraf4.Range;
            titleRange4.Text = "итоговой аттестации";
            titleRange4.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            titleRange4.Bold = 1;
            titleRange4.Font.Size = 14;
            titleRange4.InsertParagraphAfter();

            Word.Paragraph tableParagraf = document.Paragraphs.Add();
            Word.Range tableRange = tableParagraf.Range;
            Word.Table titleTable = document.Tables.Add(tableRange,1,3);
            Word.Range cellRange;
            cellRange = titleTable.Cell(1, 1).Range;
            cellRange.Text = "«_____» _________ 20_____ Г.";
            cellRange = titleTable.Cell(1, 3).Range;
            cellRange.Text = "№___________________________";
            cellRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            cellRange.InsertParagraphAfter();

            Word.Paragraph titleParagrafGroup = document.Paragraphs.Add();
            Word.Range titleRangeGroup = titleParagrafGroup.Range;
            titleRangeGroup.Text = "Группа №: ";
            titleRangeGroup.Font.Size = 14;
            titleRangeGroup.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            titleRangeGroup.InsertParagraphAfter();

            Word.Paragraph titleParagrafTeacher = document.Paragraphs.Add();
            Word.Range titleRangeTeacher = titleParagrafTeacher.Range;
            titleRangeTeacher.Text = "Преподаватель:";
            titleRangeTeacher.Font.Size = 14;
            titleRangeTeacher.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            titleRangeTeacher.InsertParagraphAfter();

            Word.Paragraph studentsParagraph = document.Paragraphs.Add();
            Word.Range studentRange = tableParagraf.Range;
            Word.Table studentTable = document.Tables.Add(studentRange, arrayStudent.Count() + 1, 3);
            Word.Range cellStudent;
            cellStudent = titleTable.Cell(1, 1).Range;
            cellStudent.Text = "№ п/п";
            cellStudent = titleTable.Cell(1, 2).Range;
            cellStudent.Text = "Фамилия, имя, отчество слушателя";
            cellStudent = titleTable.Cell(1, 3).Range;
            cellStudent.Text = "Результат аттестации";
            studentTable.Rows[1].Range.Bold = 1;


            //Сохранение
            document.SaveAs2($"{Directory.GetCurrentDirectory()}\\Docs\\Test.docx");
            document.SaveAs2($"{Directory.GetCurrentDirectory()}\\Docs\\Test.pdf",Word.WdExportFormat.wdExportFormatPDF);


        }
    }
}
