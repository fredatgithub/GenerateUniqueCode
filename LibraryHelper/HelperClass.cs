using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace LibraryHelper
{
    public static class HelperClass
    {
        public static string GenerateNextItem(string letters)
        {
            if (letters.Trim() == string.Empty || letters.Length == 0)
            {
                return string.Empty;
            }

            int numberOfLetter = letters.Length;
            string result = string.Empty;
            char firstChar = letters[letters.Length - 1];
            char nextFirstChar = GetNextSymbol(firstChar);
            result = letters.Substring(0, letters.Length - 1) + GetNextSymbol(firstChar);
            // test if GetNextSymbol(firstChar) == '0' or 'a' or 'A' then GetNextSymbol(secondChar)
            // nextFirstChar.ToString().ToUpper()[0] == 'A' ||
            if (letters.Length >= 2 && ( nextFirstChar == '0'))
            {
                char secondCharacter = letters.Reverse().ToArray()[1];
                char nextSecondCharacter = GetNextSymbol(secondCharacter);
                result = letters.Substring(0, letters.Length - 2) + nextSecondCharacter + nextFirstChar;
            }

            if (letters.Length >= 3 && (nextFirstChar.ToString().ToUpper()[0] == 'A' || nextFirstChar == '0'))
            {
                char characterNumberThree = letters.Reverse().ToArray()[2];
                char secondCharacter = letters.Reverse().ToArray()[1];
                char nextSecondCharacter = GetNextSymbol(secondCharacter);
                result = letters.Substring(0, letters.Length - 2) + nextSecondCharacter + nextFirstChar;
            }

            return result;
        }

        public static char GetNextSymbol(char firstChar)
        {
            char result;
            if (char.IsLetter(firstChar))
            {
                result = GetNextLetter(firstChar);
            }
            else if (char.IsNumber(firstChar))
            {
                result = GetNextNumber(firstChar);
            }
            else
            {
                result = firstChar;
            }

            return result;
        }

        public static char GetNextLetter(char letter)
        {
            char nextChar;
            if (letter == 'z')
            {
                nextChar = '0';
            }
            else if (letter == 'Z')
            {
                nextChar = '0';
            }
            else if (letter == '9')
            {
                nextChar = 'A';
            }
            else
            {
                nextChar = (char)(letter + 1);
            }

            return nextChar;
        }

        public static char GetNextNumber(char number)
        {
            char nextNumber;
            if (number == '9')
            {
                nextNumber = '0';
            }
            else
            {
                nextNumber = (char)(number + 1);
            }

            return nextNumber;
        }

        public static string GenerateSequence()
        {
            string result = string.Empty;
            List<string> voyelles = new List<string> { "a", "e", "i", "o", "u", "y" };
            List<string> consonnes = new List<string> { "a", "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "u", "v", "w", "x", "z" };
            List<string> forbiddenCaracteres = new List<string> { "0", "1", "l", "I" };
            do
            {
                result += GenerateRandomCharacters(2, consonnes);
            } while (!IsAcceptable(result, 1, 8, forbiddenCaracteres));

            do
            {
                result += GenerateRandomCharacters(2, voyelles);
            } while (!IsAcceptable(result, 1, 8, forbiddenCaracteres));

            do
            {
                result += GenerateRandomCharacters(2, consonnes);
            } while (!IsAcceptable(result, 1, 8, forbiddenCaracteres));

            return result;
        }

        public static string GenerateCode(int numberOfCharacters, List<string> listOfCharacters, List<string> forbiddenCharacters)
        {
            string result = string.Empty;

            do
            {
                result = GenerateRandomCharacters(numberOfCharacters, listOfCharacters);
            } while (!IsAcceptable(result, 1, numberOfCharacters, forbiddenCharacters));

            return result;
        }

        public static string GenerateRandomCharacters(int numberOfCharacter, List<string> authorizedCharacters)
        {
            string result = string.Empty;
            for (int i = 0; i < numberOfCharacter; i++)
            {
                result += authorizedCharacters[GenerateRandomNumberUsingCrypto(0, authorizedCharacters.Count)];
            }

            return result;
        }

        public static IEnumerable<string> AddNumbers()
        {
            List<string> nombres = new List<string>();
            for (int i = 0; i <= 9; i++)
            {
                nombres.Add(i.ToString());
            }

            return nombres;
        }

        public static IEnumerable<string> AddCharacters()
        {
            List<string> caracteres = new List<string>();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                caracteres.Add(i.ToString());
            }

            return caracteres;
        }

        public static bool IsAcceptable(string mot, int min, int max, List<string> forbiddenCharacters)
        {
            bool resultAcceptable = true;
            if (mot.Length < min)
            {
                return false;
            }

            if (mot.Length > max)
            {
                return false;
            }

            for (int i = 0; i < forbiddenCharacters.Count; i++)
            {
                if (mot.Contains(forbiddenCharacters[i]))
                {
                    resultAcceptable = false;
                    break;
                }
            }

            return resultAcceptable;
        }

        public static string GenerateRandomLongString(char[] forbiddenCharacters, bool hasForbiddenCharacters = false, RandomCharacters rdnCharacters = RandomCharacters.LowerCase, int length = 8, bool isWindowsFileName = false)
        {
            if (length < byte.MaxValue)
            {
                return GenerateRandomString(forbiddenCharacters, hasForbiddenCharacters, rdnCharacters, (byte)length, isWindowsFileName);
            }

            string result = string.Empty;
            int leftOver = length % 254;
            for (int i = 1; i <= Math.Floor((decimal)(length / 254)); i++)
            {
                result += GenerateRandomString(forbiddenCharacters, hasForbiddenCharacters, rdnCharacters, 254, isWindowsFileName);
            }

            if (leftOver != 0)
            {
                result += GenerateRandomString(forbiddenCharacters, hasForbiddenCharacters, rdnCharacters, (byte)leftOver, isWindowsFileName);
            }

            return result;
        }

        public static string GenerateRandomString(char[] forbiddenCharacters, bool hasForbiddenCharacters = false, RandomCharacters rdnCharacters = RandomCharacters.LowerCase, byte length = 8,
        bool isWindowsFileName = false)
        {
            if (length > byte.MaxValue)
            {
                length = byte.MaxValue;
            }

            char[] forbiddenWindowsFilenameCharacters = { '\\', '/', ':', '*', '?', '\"', '<', '>', '|' };
            char[] upperCaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] lowerCaseCharacters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] digitCharacters = "0123456789".ToCharArray();
            char[] specialCharacters = ",.;:?!/@#$%^&()=+*-_{}[]|~".ToCharArray();
            char[] searchedCharacters = new char[26 + 26 + 10 + 26]; // max size

            // int numberOfCharactersToPickFrom = (int)rdnCharacters;
            if (isWindowsFileName)
            {
                forbiddenCharacters = AddCharArray(forbiddenCharacters, forbiddenWindowsFilenameCharacters, new[] { ' ' });
                char[] badWindowsFileName = { ',', '!', '.', ';', '@', '#', '$', '%', '^', '&', '(', ')', '=', '+', '{', '}', '~' };
                forbiddenCharacters = AddCharArray(forbiddenCharacters, badWindowsFileName, new[] { ' ' });
            }

            switch (rdnCharacters)
            {
                case RandomCharacters.LowerCase:
                    searchedCharacters = FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters).ToCharArray();
                    break;

                case RandomCharacters.UpperCase:
                    searchedCharacters = FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters).ToCharArray();
                    break;

                case RandomCharacters.Digit:
                    searchedCharacters = FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters).ToCharArray();
                    break;

                case RandomCharacters.SpecialCharacter:
                    searchedCharacters = FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters).ToCharArray();
                    break;

                case RandomCharacters.UpperLower:
                    searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
                    FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters)).ToCharArray();
                    break;

                case RandomCharacters.DigitSpecialChar:
                    searchedCharacters = (FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters) +
                    FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters)).ToCharArray();
                    break;

                case RandomCharacters.LowerDigit:
                    searchedCharacters = (FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters) +
                    FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters)).ToCharArray();
                    break;

                case RandomCharacters.LowerSpecialChar:
                    searchedCharacters = (FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters) +
                    FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters)).ToCharArray();
                    break;

                case RandomCharacters.UpperDigit:
                    searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
                    FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters)).ToCharArray();
                    break;

                case RandomCharacters.UpperLowerDigit:
                    searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
                    FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters) +
                    FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters)).ToCharArray();
                    break;

                case RandomCharacters.UpperSpecialChar:
                    searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
                    FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters)).ToCharArray();
                    break;

                case RandomCharacters.UpperLowerSpecial:
                    searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
                    FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters) +
                    FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters)).ToCharArray();
                    break;

                case RandomCharacters.UpperDigitSpecial:
                    searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
                    FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters) +
                    FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters)).ToCharArray();
                    break;

                case RandomCharacters.UpperLowerDigitSpecial:
                    searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
                    FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters) +
                    FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters) +
                    FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters)).ToCharArray();
                    break;

                default:
                    searchedCharacters = FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters).ToCharArray();
                    break;
            }

            // once we have the SearchedCharacters filled out, we can select random characters from it
            string result = string.Empty;
            for (int i = 0; i < length; i++)
            {
                result += searchedCharacters[GenerateRandomNumberUsingCrypto(0, searchedCharacters.Length - 1)];
            }

            return result;
        }

        public static char[] AddCharArray(char[] source, char[] toBeAdded, char[] forbiddenCharacters)
        {
            List<char> tmpSource = source.ToList();
            List<char> tmpToBeAdded = toBeAdded.ToList();
            List<char> tmpforbiddenChar = forbiddenCharacters.ToList();
            foreach (char item in tmpToBeAdded)
            {
                if (!tmpforbiddenChar.Contains(item))
                {
                    tmpSource.Add(item);
                }
            }

            return tmpSource.ToArray();
        }

        public static int GenerateRandomNumberUsingCrypto(int min, int max)
        {
            if (max >= 255)
            {
                return 0;
            }

            int result;
            var crypto = new RNGCryptoServiceProvider();
            byte[] randomNumber = new byte[1];
            do
            {
                crypto.GetBytes(randomNumber);
                result = randomNumber[0];
            }
            while (result <= min || result >= max);

            return result;
        }

        public static string FillSearchedCharWithoutForbiddenChar(char[] source, char[] forbiddenCharacters)
        {
            string result = string.Empty;
            foreach (char item in source)
            {
                if (forbiddenCharacters != null)
                {
                    if (!forbiddenCharacters.Contains(item))
                    {
                        result += item.ToString();
                    }
                }
                else
                {
                    result += item.ToString();
                }
            }

            return result;
        }

        public enum RandomCharacters
        {
            LowerCase = 1,
            UpperCase = 2,
            Digit = 3,
            SpecialCharacter = 4,
            UpperLower = 5, //LowerCase & UpperCase,
            LowerDigit = 6, //LowerCase & Digit,
            UpperDigit = 7, //UpperCase & Digit,
            UpperLowerDigit = 8, //UpperLower & Digit,
            LowerSpecialChar = 9, //LowerCase & SpecialCharacter,
            UpperSpecialChar = 10, //UpperCase & SpecialCharacter,
            DigitSpecialChar = 11, //Digit & SpecialCharacter
            UpperLowerSpecial = 12,
            UpperDigitSpecial = 13,
            UpperLowerDigitSpecial = 14 // kept numbering because of a possible future change
        }
    }
}
