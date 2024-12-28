using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.MajdQadhi.Sprint5.Task7.V6.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestLoadDataAndSave()
    {
        DataService ds = new DataService();
        string tempInputPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V6.txt");
        string tempOutputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V6.txt");

        // ������� �������� ������� ����
        File.WriteAllText(tempInputPath, "Hello World! ������ ���!");

        // ��������� ������ � ����������
        string outputPath = ds.LoadDataAndSave(tempInputPath);

        // ���������, ��� ���� � ����� ����������
        Assert.AreEqual(tempOutputPath, outputPath);

        // ��������� ���������� ��������� �����
        string expectedContent = "##### #####! ������ ���!";
        string actualContent = File.ReadAllText(outputPath);

        Assert.AreEqual(expectedContent, actualContent);
    }
}
