
using System;
using System.Collections.Generic;
using System.IO;

namespace ChangeUnitTestFromV2ToV3
{
  internal class Program
  {
    static void Main()
    {
      string filename = @"..\..\..\UnitTestProjectHelper\UnitTestGenerateNextItem.cs";
      var fileContent = new List<string>();
      fileContent = ReadFile(filename);
      fileContent = KeepPattern(fileContent, "string source = ");
      var listOfTests = new List<string>();
      listOfTests = GenerateUnitTests(fileContent);
      WriteFile(listOfTests, "UnitTests.txt");
      Console.WriteLine("Le fichier UnitTests.txt a été écrit.");
      Console.WriteLine("Press any key to exit:");
      Console.ReadKey();
    }

    private static void WriteFile(List<string> listOfTests, string filename)
    {
      try
      {
        using (StreamWriter sw = new StreamWriter(filename))
        {
          foreach (var item in listOfTests)
          {
            sw.WriteLine(item);
          }
        }
      }
      catch (Exception)
      {
      }
    }

    private static List<string> GenerateUnitTests(List<string> fileContent)
    {
      var result = new List<string>();
      for (int i = 0; i < fileContent.Count; i += 2)
      {
        //[DataRow("AZZ", "AZ0")]
        result.Add($"[DataRow(\"{fileContent[i]}\", \"{fileContent[i + 1]}\")]");
      }

      return result;
    }

    private static List<string> KeepPattern(List<string> fileContent, string pattern)
    {
      var result = new List<string>();
      for (int i = 0; i < fileContent.Count; i++)
      {
        if (fileContent[i].Trim().StartsWith(pattern))
        {
          string lineA = fileContent[i];
          string lineB = fileContent[i+1];
          string line1 = fileContent[i].Trim().Split('"')[1];
          string line2 = fileContent[i + 1].Trim().Split('"')[1];
          result.Add(line1);
          result.Add(line2);
        }
      }
      
      return result;
    }

    private static List<string> ReadFile(string filename)
    {
      var result = new List<string>();
      try
      {
        using (StreamReader sr = new StreamReader(filename))
        {
          var line = string.Empty;
          while ((line = sr.ReadLine()) != null)
          {
            if (!string.IsNullOrEmpty(line)) 
            result.Add(line);
          }
        }
      }
      catch (Exception)
      {
      }

      return result;
    }
  }
}
