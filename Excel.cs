
using GemBox.Spreadsheet;

namespace Learn
{
    public class Excel
    {
        public void CreateExcel()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var excel = new ExcelFile();
            excel.Worksheets.Add("Sheet1");
            excel.Save("SampleExcel.xls");
        }
        public static void ExcelMain()
        {
            Excel excelHandling = new Excel();
            excelHandling.CreateExcel();
        }
    }
}