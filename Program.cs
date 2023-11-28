namespace FirstclassExercise
{


    internal class Program
    {
        static bool IsSameForwardAndbackwards(string frontback)

        { string backwardString = frontback;

            
            return false;
        }
        public static string reverseString(string forwardtext)
        {
            // Just for notes
            for (int index = forwardtext.Length - 1; index > -1; index--) {
                Console.Write(forwardtext[index]);
            }
            return "";
        }

        static void Main(string[] args)
        {  
            string reversedString = reverseString("racecar.");
            Console.WriteLine(reversedString);
        }
    }

}       