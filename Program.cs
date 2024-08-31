using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CodeForcesProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(BearAndBigBrother(1, 1));
            //--
            //Test One:
            //int[][] TeamViews = new int[][] { new int[] { 1, 1, 0 }, new int[] { 1, 1, 1 }, new int[] { 1, 0, 0 } };

            //Test Two:
            //int[][] TeamViews = new int[][] { new int[] { 1 ,0 ,0 }, new int[] { 0 ,1 ,1 } };
            //Console.WriteLine(Team(2, TeamViews));

            //--
            /* Test 1
            int[][] jaggedMatrix = new int[][]
            {
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 1 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 }
            };
            */

            /*
            int[][] jaggedMatrix = new int[][]
            {
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 }
            };

            Console.WriteLine(BeautifulMatrix(jaggedMatrix));
            #--

            char[][] jaggedArray = new char[][]
            {
                new char[] { '#', '.', '#', '#' },
                new char[] { '.', '#', '.', '.' },
                new char[] { '#', '.', '#', '#' },
                new char[] { '#', '.', '.', '#' }
            };
            --
            Console.WriteLine(IQTest(jaggedArray));
            int[] colors = new int[] { 7, 7, 7, 7 };
            Console.WriteLine(IsYourHorseShoeOnTheOtherHoof(colors));
            --
            string colors = "BRBG";
            int Stones = colors.Length;
            Console.WriteLine(StonesOnTheTable(Stones, colors));
            int[] Events = { -1, -1, 1};
            int[] array = { -1, -1, 2, -1, -1, -1, -1, 1 , -1 };
            Console.WriteLine(PoliceRecruits(array));

            --
            int[][] jaggedArray = new int[][]
            {
                new int[] { 3, 7 },
                new int[] { 1, 2 },
                new int[] { 3, 3 },
                new int[] { 4, 7 }
            };
            Console.WriteLine(PoloThePenguinAndSegments(jaggedArray, 7));
            int[][] jaggedArray = new int[][]
{
                new int[] { 1, 10 },
                new int[] { 9, 10 },
                new int[] { 10, 10 },
};
            Console.WriteLine(GeorgeAndAccommodation(jaggedArray));
            --
            Console.WriteLine(NightAtTheMusuem("ares"));
            Console.WriteLine(ColorfulStonesSimplifiedEdition("BRRBGBRGRBGRGRRGGBGBGBRGBRGRGGGRBRRRBRBBBGRRRGGBBB", "BBRBGGRGRGBBBRBGRBRBBBBRBRRRBGBBGBBRRBBGGRBRRBRGRB"));
            --
            int[] Numbers = new int[3];
            Numbers[0] = 7;
            Numbers[1] = 7;
            Numbers[2] = 7;

            Console.WriteLine(LeftHandersRightHandersAndAmbidexters(0 , 2 , 0));
            --
            Console.WriteLine(KseniaAndPanScales("AL|DCB", "FKZX"));
            */

        }


        static string KseniaAndPanScales(string Mezan , string Mass)
        {

            string Right = Mezan.Substring(0, Mezan.IndexOf("|"));
            string Left = Mezan.Substring(Mezan.IndexOf("|") + 1);

            foreach (char mass in Mass)
            {
                if (Right.Length <= Left.Length)
                    Right += mass;
                else
                    Left += mass;
            }

            return (Right.Length ==  Left.Length) ? Right + "|" + Left : "Impossible";
        }
        static int LeftHandersRightHandersAndAmbidexters(int Left , int Right , int Both)
        {
            if (Left == Right)
            {
                while (Both > 0)
                {
                    Left++; Both--;

                    if (Both > 0)
                    {
                        Right++;
                        Both--;

                    }
                }

                if (Right > Left)
                    return Left * 2;

                else
                    return Right * 2;
            }

            else if (Left < Right)
            {
                while (Both > 0)
                {
                    Left++;
                    Both--;
                    if (Left == Right)
                    {
                        return LeftHandersRightHandersAndAmbidexters(Left, Right, Both);


                    }
                }
                return Left * 2;
            }
            else
            {
                while (Both > 0)
                {
                    Right++;
                    Both--;
                    if (Left == Right)
                    {
                        return LeftHandersRightHandersAndAmbidexters(Left, Right, Both);
                    }
                }
                return Right * 2;
            }
        }
        static bool TritonicIridescence(string Paints)
        {

            if (Paints[0] == '?')
                return true;

            if (Paints[Paints.Length - 1] == '?')
                return true;


            bool Valid = false;

            for (int i = 1; i < Paints.Length; i++)
            {
                if (Paints[i] == '?' && Paints[i - 1] == '?')
                    Valid = true;

                else if (Paints[i] == '?' && i + 1 < Paints.Length && Paints[i - 1] == Paints[i + 1])
                    Valid = true;

                else if (Paints[i] == Paints[i - 1] )
                {
                    Valid = false;
                    break;
                }    

            }

            return Valid;


        }
        static bool YaroSlavAndPermutations(int[] Numbers)
        {
            bool HeCan = true;

            int Counter = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                for (int j = 0; j < Numbers.Length; j++)
                {
                    if (Numbers[i] == Numbers[j])
                    {
                        Counter++;
                    }
                }

                if (Numbers.Length < Counter * 2 - 1)
                {
                    HeCan = false;
                    break;
                }

                Counter = 0;
            }

            return HeCan;

        }
        static int ColorfulStonesSimplifiedEdition(string Stones , string Instructions)                                              
        {
            if (Instructions.Length > Stones.Length)
                return -1; //error

            if (Instructions.Length == 0)
                return -1; //error

            int Moves = 0;
            int StonesIndex = 0;
            for (int i = 0; i < Instructions.Length; i++)
            {
                if (Stones[StonesIndex] == Instructions[i])
                {
                    Moves++;
                    StonesIndex++;
                }
            }

            return Moves + 1; //Because we must return the 1-based position not the 0-based index
        }
        static int NightAtTheMusuem(string word)
        {
            return _NightAtTheMusuem("a" + word);
        }
        static int _NightAtTheMusuem(string word)
        {
            if (word == null)
                return 0;

            if (word.Length == 1)
                return 0;

            int Result = 0;
            int Index = 0;
            int NextIndex = 0;
            for (int i =0; i < word.Length - 1; i++)
            {
                Index = word[i] - 97;
                NextIndex = word[i + 1] - 97;
                if (Math.Abs(Index - NextIndex) > 13)
                {
                    Result += 26 - Math.Abs(Index - NextIndex);
                }
                else
                {
                    Result += Math.Abs(word[i] - word[i + 1]);
                }
            }

            return Result;
        }

        static int RaisingBacteria(int Bacteria)
        {
            int initial = 1;
            int Result = initial;
            while (initial * 2 <= Bacteria)
            {
                initial = initial * 2;
            }

            Result = Result + (Bacteria - initial);
            
            return Result;

        }
        static int GeorgeAndAccommodation(int[][] RoomsAndResidents)
        {
            int Counter = 0;
            foreach (var array in RoomsAndResidents)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i + 1] - array[i] >= 2)
                    {
                        Counter++;
                    }
                }
            }
            return Counter;
        }
        static int PoloThePenguinAndSegments(int[][] Matrix , int DividedNumber) // Matrix Must have 2 columns only
        {
            int Counter = 0 ; //Numbers in Matrix. NO Repeated Number in the same segment 'array'

            foreach (var array in Matrix)
            {
                for (int number = 0; number < array.Length - 1; number++)
                {
                    if (array[number] != array[number + 1])
                    {
                        Counter += 2;
                    }
                    else
                    {
                        Counter++;
                    }
                }
            }

            if (Counter > DividedNumber)
                if (Counter % DividedNumber == 0)
                    return 0;

            if (Counter <= DividedNumber)
                if (DividedNumber % Counter == 0)
                    return 0;

            int Counter2 = Counter;

            do
            {
                Counter2++;
            }
            while (Counter2 % DividedNumber != 0);

            return Counter2 - Counter;
        }
        
        static int PoliceRecruits(int[] Events )
        {
            int Result = 0;
            int PoliceOfficers = 0;

            for (int i = 0; i < Events.Length; i++)
            {
                if (Events[i] == -1)
                {
                    if (PoliceOfficers == 0)
                    {
                        Result++;
                    }
                    else
                    {
                        PoliceOfficers--;
                    }
                }
                else
                {
                    PoliceOfficers += Events[i];
                }
            }

            return Result;
        }
        static int StonesOnTheTable(int Stones , string Colors) // string color like 'RRB' means that the first two stones are red and the third is blue.
        {
            if (Stones != Colors.Length)
                return -1; //Something wrong.. Every Stone must have color. and every color maps to a stone.

            int Counter = 0;
            for (int i = 0; i < Colors.Length - 1; i++)
            {
                if (Colors[i] == Colors[i+1])
                    Counter++;
            }

            return Counter;

        }
        static int IsYourHorseShoeOnTheOtherHoof(int[] colors)
        {
            var distinct = colors.Distinct();

            return 4 - distinct.Count();
        }
        static bool IQTest(char[][] Matrix) //must be 4v4
        {
            if (TestAll(Matrix))
                return true;

            // -- If program reaches this position that means no 2v2 available yet so we will swap every cell and test on every swap
            for (int i = 0;i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    char Original = Matrix[i][j];

                    if (Matrix[i][j] == '#')
                    {
                        Matrix[i][j] = '.';
                    }
                    else
                    {
                        Matrix[i][j] = '#';
                    }
                    if (TestAll(Matrix))
                    {
                        return true;
                    }
                    Matrix[i][j] = Original;
                }
            }

            return false; //-- that means no 2v2 available nor possible. remember: only changing 1 cell is possible
        }

        static bool Test(char[][] Matrix,int i , int j)
        {
            if (i + 1 == 4 || j + 1 == 4)
                return false;

            return Matrix[i][j] == Matrix[i][j + 1] && Matrix[i][j] == Matrix[i+1][j] && Matrix[i][j] == Matrix[i + 1][j + 1];
        }

        static bool TestAll(char[][] Matrix)
        {

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Test(Matrix, i, j))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static int BearAndBigBrother(int LimakWeight, int BobWeight)
        {
            int Years = 0;

            while (LimakWeight <= BobWeight)
            {
                LimakWeight = LimakWeight * 3;
                BobWeight = BobWeight * 2;
                Years++;
            }

            return Years;
        }
        static int Team(int NumberOfProblems, int[][] TeamViews)
        {
            int NumberOfSolvedProblemsThatWillBeSubmitted = 0;

            foreach (int[] TeamView in TeamViews)
            {
                if (TeamView.Sum() >= 2)
                {
                    NumberOfSolvedProblemsThatWillBeSubmitted++;
                }
            }
            return NumberOfSolvedProblemsThatWillBeSubmitted;
        }

        static int BeautifulMatrix(int[][] Matrix) //This Matrix Must Be 5x5 And Only '1' One Allowed.
        {

            if (!CanBeBeautifulMatrix(Matrix))
                return -1;

            int Minimum = 0; // Minimum Swaps Until Matrix Is Beautiful.

            int Middle = Matrix[2][2]; // Middle Number Must Be One Otherwise its not Beautiful matrix.

            if (Middle == 1)
                return Minimum; // Matrix is already beautiful matrix.

            var Indecies = GetIndex(Matrix, 1); // Find Indecies Of '1'.


            if (Indecies.Item1 > 2 && Indecies.Item2 == 2) //That Means '1' Is in the same Col with middle position[2][2] But after him in that column
            {
                while (Middle != 1)
                {
                    Swap(ref Matrix[Indecies.Item1][2], ref Matrix[Indecies.Item1 - 1][2]);
                    Middle = Matrix[2][2];
                    Minimum++;
                }
            }
            else if (Indecies.Item1 < 2 && Indecies.Item2 == 2) //That Means '1' Is in the same Col with middle position[2][2] But before him in that column
            {
                while (Middle != 1)
                {
                    Swap(ref Matrix[Indecies.Item1][2], ref Matrix[Indecies.Item1 + 1][2]);
                    Middle = Matrix[2][2];
                    Minimum++;
                }
            }
            else if (Indecies.Item1 == 2 && Indecies.Item2 > 2) //That Means '1' Is In The Same Row With middle position[2][2] but after him in that row
            {
                int Col = Indecies.Item2;
                while (Middle != 1)
                {
                    Swap(ref Matrix[2][Col], ref Matrix[2][--Col]);
                    Middle = Matrix[2][2];
                    Minimum++;
                }
            }
            else if (Indecies.Item1 == 2 && Indecies.Item2 < 2) //That Means '1' Is In The Same Row With middle position[2][2] but before him in that row
            {
                while (Middle != 1)
                {
                    Swap(ref Matrix[2][Indecies.Item2], ref Matrix[2][Indecies.Item2 + 1]);
                    Middle = Matrix[2][2];
                    Minimum++;
                }
            }
            else if (Indecies.Item1 > 2 && Indecies.Item2 != 2)
            {
                int Row = Indecies.Item1;
                while (Row != 2)
                {
                    Swap(ref Matrix[Row][Indecies.Item2], ref Matrix[Row - 1][Indecies.Item2]);
                    Row--;
                    Minimum++;
                }
                Minimum += BeautifulMatrix(Matrix);
            }
            else if (Indecies.Item1 < 2 && Indecies.Item2 != 2)
            {
                int Row = Indecies.Item1;
                while (Row != 2)
                {
                    Swap(ref Matrix[Row][Indecies.Item2], ref Matrix[Row + 1][Indecies.Item2]);
                    Row++;
                    Minimum++;
                }
                Minimum += BeautifulMatrix(Matrix);
            }

            return Minimum;
        }

        static bool CanBeBeautifulMatrix(int[][] Matrix)
        {
            foreach (int[] array in Matrix)
            {
                if (array.Contains(1))
                    return true; //Matrix can be              
            }
            return false;
        }

        static (int, int) GetIndex(int[][] array, int Value)
        {
            int ColIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((ColIndex = Array.FindIndex(array[i], x => x == Value)) > 0)
                {
                    return (i, ColIndex);
                }
            }

            return (-1, -1);
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
