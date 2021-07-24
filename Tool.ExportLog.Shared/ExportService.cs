using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tool.ExportLog.Shared
{
    public class ExportService : IExportService
    {
        private const string AUTHOR = "BTS-2021";

        private const string BKS_search = @"EXEC [dbo].[VIB_CMX_Collateral_Search] @LicensePlateNum=N";

        private IEnumerable<string> AllLines;

        private string fileName = "_output_";

        public ExportService()
        {
        }

        // https://www.codegrepper.com/code-examples/csharp/c%23+get+files+in+directory+matching+pattern
        public int GetAllLines(string path, string searchPattern, bool includingSubdirectories = false)
        {
            fileName = searchPattern;
            // https://stackoverflow.com/questions/32614610/read-text-file-row-after-a-certain-string
            //AllFiles = Directory.EnumerateFiles(path, searchPattern, SearchOption.AllDirectories);
            AllLines = from file in Directory.EnumerateFiles(path, $"*{searchPattern}*", SearchOption.AllDirectories)
                       from line in file.AsLines()
                       select line;
            return AllLines.Count();
        }

        public string ReadLines(string output)
        {
            if (AllLines == null || (AllLines != null && AllLines.Count() == 0))
            {
                //Console.WriteLine("File Not Found");
                return "File Not Found";
            }

            var listIndexs = AllLines.Select((line, index) => new { index = index, line }).ToList();

            var listBKS = listIndexs.Where(item => item.line.Contains(BKS_search)).Select(item => item);

            // BKS = EXEC [dbo].[VIB_CMX_Collateral_Search] @LicensePlateNum=N
            // currentDate = rowBKS - 1
            // lastEmployeeId = rowBKS - 2
            // status = rowBKS + 3

            var result = listBKS.Select(x => new Result
            {
                BksNo = x.line.Replace("[20101]", "").Trim().Split('N')[2],
                CurrentDate = listIndexs[x.index - 1].line.Replace("INFO", "").Replace("ERROR", "").Trim(),
                //LastEmployeeId = listIndexs[x.index - 2].line.Replace("[20101]", "").Trim(),
                Status = listIndexs[x.index + 3].line
            }).ToList();

            var resultTrack = result.Select(x => new Result
            {
                BksNo = x.BksNo != null ? x.BksNo.Split(' ')[0] : "",
                CurrentDate = x.CurrentDate != null ? $"{ x.CurrentDate.Split(' ')[0] } {x.CurrentDate.Split(' ')[1]}" : "",
                //LastEmployeeId = x.LastEmployeeId != null ? x.LastEmployeeId.Split("=")[1] : "",
                Status = x.Status != null && x.Status.Contains("200") ? "200 - success" : "404 Not found"
            }).ToList();

            // writetoexcel
            var outputPath = WriteToExcel(resultTrack, fileName, output);
            return outputPath;
            // writetojson
        }

        private string WriteToExcel(List<Result> resultTrack, string fileName, string output)
        {
            var workbook = new XLWorkbook();
            IXLWorksheet worksheet = workbook.Worksheets.Add($"{Helper.list_search_bks}_{fileName}");
            worksheet.ColumnWidth = 25;

            worksheet.Cell(1, 1).Style.Font.Bold = true;
            worksheet.Cell(1, 1).Style.Font.FontSize = 17;           
            worksheet.Cell(1, 1).Value = $"Ngày {resultTrack[0].CurrentDate.Split(' ')[0]}";

            worksheet.Cell(2, 1).Style.Font.Bold = true;
            worksheet.Cell(2, 1).Style.Font.FontSize = 14;
            worksheet.Cell(2, 1).Value = $"Tổng số BKS đã tìm kiếm = {resultTrack.Count}";

            worksheet.Cell(3, 1).Style.Font.Bold = true;
            worksheet.Cell(3, 1).Style.Font.FontSize = 14;
            worksheet.Cell(3, 1).Value = $"Success";

            worksheet.Cell(3, 2).Style.Font.Bold = true;
            worksheet.Cell(3, 2).Style.Font.FontSize = 14;
            worksheet.Cell(3, 2).Value = $"Not Found";

            worksheet.Cell(4, 1).Value = $"{resultTrack.Where(x => x.Status.Contains("200")).Count()}";
            worksheet.Cell(4, 2).Value = $"{resultTrack.Where(x => x.Status.Contains("404")).Count()}";

            worksheet.Cell(5, 1).Value = $"Danh sách BKS";

            worksheet.Cell(6, 1).Value = "Ngày";
            worksheet.Cell(6, 1).Style.Font.Bold = true;
            worksheet.Cell(6, 1).Style.Border.TopBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(6, 1).Style.Border.BottomBorder = XLBorderStyleValues.Dashed;
            worksheet.Cell(6, 2).Value = "Biển Kiểm Soát";
            worksheet.Cell(6, 2).Style.Font.Bold = true;
            worksheet.Cell(6, 2).Style.Border.TopBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(6, 2).Style.Border.BottomBorder = XLBorderStyleValues.Dashed;
            worksheet.Cell(6, 3).Value = "Trạng thái tìm kiếm";
            worksheet.Cell(6, 3).Style.Border.TopBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(6, 3).Style.Border.BottomBorder = XLBorderStyleValues.Dashed;
            worksheet.Cell(6, 3).Style.Font.Bold = true;
            //worksheet.Cell(2, 4).Value = "Last EmployeeId";
            //worksheet.Cell(2, 4).Style.Border.BottomBorder = XLBorderStyleValues.Dashed;
            //worksheet.Cell(2, 4).Style.Font.Bold = true;
            for (int index = 1; index <= resultTrack.Count(); index++)
            {
                // worksheet.Cell(row,column).Style.NumberFormat.Format = "mm/dd/yyyy";
                worksheet.Cell(index + 6, 1).Style.DateFormat.Format = "m/d/yyyy hh:mm:ss";
                worksheet.Cell(index + 6, 1).Value = resultTrack[index - 1].CurrentDate;
                worksheet.Cell(index + 6, 2).Value = resultTrack[index - 1].BksNo;
                worksheet.Cell(index + 6, 3).Value = resultTrack[index - 1].Status;
                //worksheet.Cell(index + 6, 4).Value = resultTrack[index - 1].LastEmployeeId;
            }

            try
            {
                string path = $"{output}/{Helper.list_search_bks}_{fileName}.xlsx";
                workbook.SaveAs(path);
                return path;
            }
            catch
            {
                return $"error {fileName}";
            }
        }

    }
}
