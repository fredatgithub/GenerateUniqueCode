using LibraryHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectHelper
{
    [TestClass]
    public class UnitTestGetNextLetter
    {
        [TestMethod]
        public void TestMethod_GetNextLetter_a()
        {
            char source = 'a';
            char expected = 'b';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_b()
        {
            char source = 'b';
            char expected = 'c';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_c()
        {
            char source = 'c';
            char expected = 'd';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_d()
        {
            char source = 'd';
            char expected = 'e';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_e()
        {
            char source = 'e';
            char expected = 'f';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_f()
        {
            char source = 'f';
            char expected = 'g';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_g()
        {
            char source = 'g';
            char expected = 'h';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_h()
        {
            char source = 'h';
            char expected = 'i';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_i()
        {
            char source = 'i';
            char expected = 'j';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_j()
        {
            char source = 'j';
            char expected = 'k';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_k()
        {
            char source = 'k';
            char expected = 'l';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_l()
        {
            char source = 'l';
            char expected = 'm';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_m()
        {
            char source = 'm';
            char expected = 'n';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_n()
        {
            char source = 'n';
            char expected = 'o';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_o()
        {
            char source = 'o';
            char expected = 'p';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_p()
        {
            char source = 'p';
            char expected = 'q';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_q()
        {
            char source = 'q';
            char expected = 'r';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_r()
        {
            char source = 'r';
            char expected = 's';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_s()
        {
            char source = 's';
            char expected = 't';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_t()
        {
            char source = 't';
            char expected = 'u';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_u()
        {
            char source = 'u';
            char expected = 'v';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_v()
        {
            char source = 'v';
            char expected = 'w';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_w()
        {
            char source = 'w';
            char expected = 'x';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_x()
        {
            char source = 'x';
            char expected = 'y';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_y()
        {
            char source = 'y';
            char expected = 'z';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_z()
        {
            char source = 'z';
            char expected = '0';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_A()
        {
            char source = 'A';
            char expected = 'B';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_B()
        {
            char source = 'B';
            char expected = 'C';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_C()
        {
            char source = 'C';
            char expected = 'D';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_D()
        {
            char source = 'D';
            char expected = 'E';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_E()
        {
            char source = 'E';
            char expected = 'F';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_F()
        {
            char source = 'F';
            char expected = 'G';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_G()
        {
            char source = 'G';
            char expected = 'H';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_H()
        {
            char source = 'H';
            char expected = 'I';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_I()
        {
            char source = 'I';
            char expected = 'J';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_J()
        {
            char source = 'J';
            char expected = 'K';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_K()
        {
            char source = 'K';
            char expected = 'L';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_L()
        {
            char source = 'L';
            char expected = 'M';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_M()
        {
            char source = 'M';
            char expected = 'N';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_N()
        {
            char source = 'N';
            char expected = 'O';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_O()
        {
            char source = 'O';
            char expected = 'P';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_P()
        {
            char source = 'P';
            char expected = 'Q';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_Q()
        {
            char source = 'Q';
            char expected = 'R';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_R()
        {
            char source = 'R';
            char expected = 'S';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_S()
        {
            char source = 'S';
            char expected = 'T';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_T()
        {
            char source = 'T';
            char expected = 'U';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_U()
        {
            char source = 'U';
            char expected = 'V';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_V()
        {
            char source = 'V';
            char expected = 'W';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_W()
        {
            char source = 'W';
            char expected = 'X';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_X()
        {
            char source = 'X';
            char expected = 'Y';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_Y()
        {
            char source = 'Y';
            char expected = 'Z';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_Z()
        {
            char source = 'Z';
            char expected = '0';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_0()
        {
            char source = '0';
            char expected = '1';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_1()
        {
            char source = '1';
            char expected = '2';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_2()
        {
            char source = '2';
            char expected = '3';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_3()
        {
            char source = '3';
            char expected = '4';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_4()
        {
            char source = '4';
            char expected = '5';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }


        [TestMethod]
        public void TestMethod_GetNextLetter_5()
        {
            char source = '5';
            char expected = '6';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_6()
        {
            char source = '6';
            char expected = '7';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_7()
        {
            char source = '7';
            char expected = '8';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_8()
        {
            char source = '8';
            char expected = '9';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GetNextLetter_9()
        {
            char source = '9';
            char expected = ':';
            char result = HelperClass.GetNextLetter(source);
            Assert.AreEqual(result, expected);
        }
    }
}
