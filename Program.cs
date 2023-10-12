namespace XML_Editor;

class Program
{
    static void Main(string[] args)
    {
        string excelPath = @"C:\Users\Burak\XML_Editor\ExcelData\mazeret excel.xlsx";
        ExcelReader excelReader = new();
        var mazereteModels = excelReader.ReadExcelFile(excelPath);
        XmlManager xmlManager = new();
        xmlManager.UpdateXml(mazereteModels);
    }
}
