﻿using LibraryHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectHelper
{
  [TestClass]
  public class UnitTestGetNextLetter
  {
    [TestMethod]
    [DataRow('a', 'b')]
    [DataRow('b', 'c')]
    [DataRow('c', 'd')]
    [DataRow('d', 'e')]
    [DataRow('e', 'f')]
    [DataRow('f', 'g')]
    [DataRow('g', 'h')]
    [DataRow('h', 'i')]
    [DataRow('i', 'j')]
    [DataRow('j', 'k')]
    [DataRow('k', 'l')]
    [DataRow('l', 'm')]
    [DataRow('m', 'n')]
    [DataRow('n', 'o')]
    [DataRow('o', 'p')]
    [DataRow('p', 'q')]
    [DataRow('q', 'r')]
    [DataRow('r', 's')]
    [DataRow('s', 't')]
    [DataRow('t', 'u')]
    [DataRow('u', 'v')]
    [DataRow('v', 'w')]
    [DataRow('w', 'x')]
    [DataRow('x', 'y')]
    [DataRow('y', 'z')]
    [DataRow('z', '0')]
    [DataRow('A', 'B')]
    [DataRow('B', 'C')]
    [DataRow('C', 'D')]
    [DataRow('D', 'E')]
    [DataRow('E', 'F')]
    [DataRow('F', 'G')]
    [DataRow('G', 'H')]
    [DataRow('H', 'I')]
    [DataRow('I', 'J')]
    [DataRow('J', 'K')]
    [DataRow('K', 'L')]
    [DataRow('L', 'M')]
    [DataRow('M', 'N')]
    [DataRow('N', 'O')]
    [DataRow('O', 'P')]
    [DataRow('P', 'Q')]
    [DataRow('Q', 'R')]
    [DataRow('R', 'S')]
    [DataRow('S', 'T')]
    [DataRow('T', 'U')]
    [DataRow('U', 'V')]
    [DataRow('V', 'W')]
    [DataRow('W', 'X')]
    [DataRow('X', 'Y')]
    [DataRow('Y', 'Z')]
    [DataRow('Z', '0')]
    [DataRow('0', '1')]
    [DataRow('1', '2')]
    [DataRow('2', '3')]
    [DataRow('3', '4')]
    [DataRow('4', '5')]
    [DataRow('5', '6')]
    [DataRow('6', '7')]
    [DataRow('7', '8')]
    [DataRow('8', '9')]
    [DataRow('9', 'A')]
    public void TestMethod_Get_Next_Letter_all(char source, char expected)
    {
      char result = HelperClass.GetNextLetter(source);
      Assert.AreEqual(expected, result);
    }
  }
}
