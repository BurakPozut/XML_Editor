using Ganss.Excel;
using XML_Editor.Models;

public class ExcelReader
{
    private MazeretModel[] mazeretModels;
    public MazeretModel[] ReadExcelFile(string filePath)
    {
        var mazeretIenumerable = new ExcelMapper(filePath).Fetch<MazeretModel>();
        mazeretModels = mazeretIenumerable.ToArray();
        return mazeretModels;
    }
}