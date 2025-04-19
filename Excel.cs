
using GemBox.Spreadsheet;

namespace Learn
{
    public class Excel
    {
        private string fileName = "SampleExcel.xls";
        private GemBox.Spreadsheet.ExcelFile File;
        public Excel()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            File = ExcelFile.Load(fileName);
        }
        public void CreateExcel()
        {
            var excel = new ExcelFile();
            excel.Worksheets.Add("Sheet1");
            excel.Save(fileName);
        }
        public void CreateNewSheet(string sheetName)
        {
            var excel = ExcelFile.Load(fileName);
            File.Worksheets.Add(sheetName);
            File.Save(fileName);
        }

        public void AddValues()
        {
            var excel = new ExcelFile(); //To create a new excel file
            var WS = excel.Worksheets.Add("New"); //To add a new sheet
            WS.Cells["A1"].Value = "EmployeeID"; // Inserting a value in specified place
            WS.Columns["A"].AutoFit(); //To auto fit the column

            var employees = new object[,]{
                {"Employee ID","Name","Country","Mobile Number"},
                {1001,"Alex","India",876542210},
                {1002,"Barley","India",876243210},
                {1003,"Charles","India",872543210},
                {1004,"David","India",876523210},
                {1005,"Eve","India",876543210},
                {1006,"Frank","India",876523210},
                {1007,"Gill","India",876512210},
            };

            //To insert multiple values from the array
            for (int row = 0; row < employees.GetLength(0); row++)
            {
                for (int col = 0; col < employees.GetLength(1); col++)
                {
                    WS.Cells[row, col].Value = employees[row, col];
                }
                WS.Columns[row].AutoFit();
            }


            excel.Save(fileName); //To save the excel file

        }
        public static void ExcelMain()
        {
            Excel excelHandling = new Excel();
            // excelHandling.CreateExcel();
            // excelHandling.CreateNewSheet("Employee");
            excelHandling.AddValues();

        }
    }
}