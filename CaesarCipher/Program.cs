namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = caesarCipher(s, k);

            Console.WriteLine("\n");
            Console.WriteLine(result);
        }

        public static string caesarCipher(string s, int k)
        {
            List<char> alphabet = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            List<char> alphabetMay = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' }; // 25

            int lastIndex = alphabet.Count - 1, possibleIndex = -1;
            string caesarString = "";

            switch (k)
            {
                case > 26:
                    k %= 26;
                    break;
            }

            foreach (char letter in s)
            {
                int idxMin = alphabet.IndexOf(letter);
                int idxMay = alphabetMay.IndexOf(letter);

                if (idxMin == -1 && idxMay == -1)
                    caesarString += letter;

                else if (idxMin > -1)
                {
                    possibleIndex = idxMin + k;
                    if (possibleIndex > lastIndex)
                    {
                        int x = possibleIndex - lastIndex;
                        caesarString += alphabet[x - 1];
                    }
                    else
                    {
                        caesarString += alphabet[possibleIndex];
                    }
                }
                else
                {
                    possibleIndex = idxMay + k;
                    if (possibleIndex > lastIndex)
                    {
                        int x = possibleIndex - lastIndex;
                        caesarString += alphabetMay[x - 1];
                    }
                    else
                    {
                        caesarString += alphabetMay[possibleIndex];
                    }
                }
            }

            return caesarString;
        }
    }
}
