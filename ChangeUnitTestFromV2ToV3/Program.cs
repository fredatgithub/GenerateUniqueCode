using System;
using System.Collections.Generic;
using System.IO;

namespace ChangeUnitTestFromV2ToV3
{
  internal class Program
  {
    static void Main()
    {
      string unitTestClassFilename = "UnitTestGetNextLetter.cs";
      string filename = $@"..\..\..\UnitTestProjectHelper\{unitTestClassFilename}";
      char separator = '\'';
      var fileContent = new List<string>();
      fileContent = ReadFile(filename);
      fileContent = KeepPattern(fileContent, "char source = ", separator);
      var listOfTests = new List<string>();
      listOfTests = GenerateUnitTests(fileContent, separator);
      WriteFile(listOfTests, "UnitTests-letter.txt");
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

    private static List<string> GenerateUnitTests(List<string> fileContent, char separator)
    {
      var result = new List<string>();
      for (int i = 0; i < fileContent.Count; i += 2)
      {
        //[DataRow("AZZ", "AZ0")]
        result.Add($"[DataRow({separator}{fileContent[i]}{separator}, {separator}{fileContent[i + 1]}{separator})]");
      }

      return result;
    }

    private static List<string> KeepPattern(List<string> fileContent, string pattern, char separator)
    {
      var result = new List<string>();
      for (int i = 0; i < fileContent.Count; i++)
      {
        if (fileContent[i].Trim().StartsWith(pattern))
        {
          string lineA = fileContent[i];
          string lineB = fileContent[i + 1];
          string line1 = fileContent[i].Trim().Split(separator)[1];
          string line2 = fileContent[i + 1].Trim().Split(separator)[1];
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
