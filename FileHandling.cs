using System.IO;
namespace learnings;

public class FileHandling
{
    public void CreateFile()
    {
        File.Create("./temp.txt");
    }
    public void AddText()
    {
        File.WriteAllText("./temp.txt","Hello This is a content");
    }
    public void ReadText()
    {
        File.ReadAllText("./temp.txt");
    }
}