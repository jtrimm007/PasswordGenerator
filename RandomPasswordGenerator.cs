using System;
using System.Text;

namespace PasswordGenerator
{
    public static class RandomPasswordGenerator
    {
        private static string LowerCaseAlpha = "abcdefghijklmnopqrstuvwxyz";
        private static string UpperCaseAlpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string SpecialChar = "!@#$%^&*()_+-={}<>";
        private static string Integers = "1234567890";
        private static string[] passBuilderDictionary = new string[4];
        public static string GeneratePassword(int length)
        {
            passBuilderDictionary[0] = LowerCaseAlpha;
            passBuilderDictionary[1] = UpperCaseAlpha;
            passBuilderDictionary[2] = SpecialChar;
            passBuilderDictionary[3] = Integers;

            Random rand = new Random();

            var lowerRand = passBuilderDictionary[0].ToCharArray()[rand.Next(passBuilderDictionary[0].Length)];
            var upperRand = passBuilderDictionary[1].ToCharArray()[rand.Next(passBuilderDictionary[1].Length)];
            var specialRand = passBuilderDictionary[2].ToCharArray()[rand.Next(passBuilderDictionary[2].Length)];
            var intRand = passBuilderDictionary[3].ToCharArray()[rand.Next(passBuilderDictionary[3].Length)];

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(lowerRand);
            stringBuilder.Append(upperRand);
            stringBuilder.Append(specialRand);
            stringBuilder.Append(intRand);

            for (var i = 0; i < length; i++)
            {


                var catigory = passBuilderDictionary[rand.Next(4)];

                var randomNumberByCatigoryLength = rand.Next(catigory.Length);

                var characterArray = catigory.ToCharArray();

                var charaterSelected = characterArray[randomNumberByCatigoryLength];

                stringBuilder.Append(charaterSelected);
            }


            return stringBuilder.ToString();
        }

    }
}
