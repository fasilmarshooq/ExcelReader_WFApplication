using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using System.Configuration;

namespace RawDataProcessor.DAL
{
    struct RawDataCollection
    {
        public string RawData { get; set; }
        public string ProcessedData { get; set; }
    }

    class ExcelReader
    {
        public static string excelFilePath = ConfigurationManager.AppSettings["Path"];
        public static List<RawDataCollection> PutExcelToList(string excelPath, string sheetName)
        {
            Application excelApp = new Application();

            Workbook excelBook = excelApp.Workbooks.Open(excelPath);
            _Worksheet excelSheet = excelBook.Sheets[sheetName];
            Range excelRange = excelSheet.UsedRange;
            List<RawDataCollection> workSheetData = new List<RawDataCollection>();

            for (int i = 1; i <= excelRange.Rows.Count; i++)
            {
                RawDataCollection rdc = new RawDataCollection();

                if (excelRange.Cells[i, 1] != null && excelRange.Cells[i, 1].Value2 != null)
                    rdc.RawData = excelRange.Cells[i, 1].Value2.ToString();
                if (excelRange.Cells[i, 2] != null && excelRange.Cells[i, 2].Value2 != null)
                    rdc.ProcessedData = excelRange.Cells[i, 2].Value2.ToString();
                workSheetData.Add(rdc);
            }
            //after reading, relaase the excel project
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            return workSheetData;
        }

        public static List<RawDataCollection> workSheetData_CAN = new List<RawDataCollection>();
        public static List<RawDataCollection> workSheetData_US = new List<RawDataCollection>();

        public static void Preload()
        {
            workSheetData_CAN = PutExcelToList(excelFilePath, "CAN");
            workSheetData_US = PutExcelToList(excelFilePath, "US");
        }

    }
}
