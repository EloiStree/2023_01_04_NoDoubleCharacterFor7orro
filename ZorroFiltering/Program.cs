using System;
using System.IO;

namespace ZorroFiltering
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello 7orro !");

            //Console.WriteLine("Do you allow uppercase (y)?");
            //string upperCaseAllowString = Console.ReadLine();
            //bool isUpperCaseAllow = upperCaseAllowString == "y";



            Console.WriteLine("Can you give me the path of the file to filter:");
            string filePath = Console.ReadLine();
            Console.WriteLine("Can you give me the export file name :");
            string fileExportName = Console.ReadLine();
            if (fileExportName.IndexOf(".") < 0)
                fileExportName += ".txt";

            string fileExport = Path.GetDirectoryName(filePath) + "/" + fileExportName;

            TestZorro zorro = new TestZorro();
            zorro.m_fileImportPath = filePath;
            zorro.m_fileExportPath = fileExport;
            zorro.ProcessWords();
        }


}
}
