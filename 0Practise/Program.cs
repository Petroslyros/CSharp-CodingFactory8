using LinqPrac;
using System.Buffers;
using System.Text;

namespace _0Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashMatrix(5);

            var games = new List<Game>
            {
                new Game {Title = "The legend of Zelda", Genre = "Adventure", ReleaseYear = 1986, Rating = 9.5, Price = 60},
                new Game {Title = "Super Mario Bros.", Genre = "Plaformer", ReleaseYear = 1965, Rating = 9.2, Price = 50},
                new Game {Title = "Elden Ring", Genre = "RPG", ReleaseYear = 2022, Rating = 9.8, Price = 60},
                new Game {Title = "Stardew Valley", Genre = "Simulation", ReleaseYear = 2016, Rating = 9.5, Price = 60},
                new Game {Title = "Tetris", Genre = "Puzzle", ReleaseYear = 1984, Rating = 9.5, Price = 60},
            };

            //var allGames = games.Select(game => game.Title);
            var rgpGames = games.Where(g => g.Genre == "RPG");
            foreach (var game in rgpGames)
            {
                Console.WriteLine(game.Title);
            }
            //ANY
            var modernGamesExist = games.Any(g => g.ReleaseYear > 2007);
            Console.WriteLine($"Are there any modern games? : {modernGamesExist}");

            //ORDER BY 
            var sortedByYear = games.OrderByDescending(g => g.ReleaseYear);
            foreach (var game in sortedByYear)
            {
                Console.WriteLine(game.Title);
            }
            //AVERAGE
            var averagePrice = games.Average(g => g.Price);
            Console.WriteLine($"Average game price : {averagePrice}");
            //MAX
            var highestRating = games.Max(g => g.Rating);
            //FIRST OR DEFAULT
            var bestGame = games.First(g => g.Rating > highestRating);
            Console.WriteLine($"Best game : {bestGame.Title} {bestGame.Rating}");

            //Grouping
            var gamesByGroup = games.GroupBy(g => g.Genre);
            foreach (var group in gamesByGroup)
            {
                Console.WriteLine($"Genre: {group.Key}");

                foreach (var game in group)
                {
                    Console.WriteLine(game.Title);
                }
            }
            //FILTER BY GENRE && PRICE
            var budgetAdventureGame = games
                .Where(g => g.Genre == "RPG" && g.Price <= 30)
                .OrderByDescending(g => g.Rating)
                .Select(g => $"{g.Title} - {g.Price}");

            var paginatedGames = games.Skip(2).Take(2);

            //STARTS WITH 
            // var namesStartingWIthA = names.Where(name => name.StartsWith("A"));

            //MOST EXPENSIVE PRODUCT
            //var mostExpensiveProduct = products.OrderByDescending(p => p.Price).FirstOrDefautl();

            //SECOND LARGEST NUMBER OF ARRAY
            //var secondLargest = digits.OrderByDescending(x => x).Skip(1);

            Console.ReadLine();
        }


        public static int BinarySearch(int[] arr, int key)
        {
            if (arr == null || arr.Length == 0) return -1;

            int result = -1;
            int left = 0;
            int middle = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                middle = (left + right) / 2;
                if (arr[middle] == key)
                {
                    result = middle;
                }
                else if (arr[middle] < key)
                {
                    left = middle + 1;
                }
                else if (arr[middle] > key)
                {
                    right = middle - 1;
                }
            }

            return result;
        }
        public static string CeazarEncrypt(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == 'z')
                {
                    sb.Append('c');
                }
                else
                {
                    sb.Append((char)(c + 3));
                }
            }
            return sb.ToString();
        }

        public static int ParkingLot(int[,] arr)
        {// 1. Δημιουργία του πίνακα γεγονότων (events)
         // Στη C#, για να δουλέψει το swap σειρών όπως το έκανες (temp = arr[j]), 
         // πρέπει να χρησιμοποιήσουμε Jagged Array: int[][]
            int[][] parkedCars = new int[arr.GetLength(0) * 2][];
            int row = 0;

            // arr.GetLength(0) είναι το arr.length της Java
            // arr.GetLength(1) είναι το arr[0].length της Java
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    parkedCars[row] = new int[2]; // Αρχικοποίηση κάθε σειράς
                    parkedCars[row][0] = arr[i, j];
                    parkedCars[row][1] = (j == 0) ? 1 : 0; // 1 για είσοδο, 0 για έξοδο
                    row++;
                }
            }

            // 2. Bubble Sort (Η δική σου λογική)
            for (int i = 0; i < parkedCars.Length; i++)
            {
                for (int j = parkedCars.Length - 1; j > i; j--)
                {
                    if (parkedCars[j - 1][0] > parkedCars[j][0])
                    {
                        int[] temp = parkedCars[j];
                        parkedCars[j] = parkedCars[j - 1];
                        parkedCars[j - 1] = temp;
                    }
                }
            }

            // 3. Υπολογισμός Max
            int count = 0;
            int maxParkedCars = 0;

            for (int i = 0; i < parkedCars.Length; i++)
            {
                if (parkedCars[i][1] == 1)
                {
                    count++;
                }
                else
                {
                    count--;
                }

                if (count > maxParkedCars)
                {
                    maxParkedCars = count;
                }
            }

            return maxParkedCars;
        }

        public static int StockMoves(int[] arr)
        {
            int count = 0;
            int level = 0;
            bool belowBase = false;

            for (int i = 0; i < arr.Length; i++)
            {
                level += arr[i];

                if (level < 0 && !belowBase)
                {
                    count++;
                    belowBase = true;
                }
                if (level > 0)
                {
                    belowBase = false;
                }

            }

            return count;
        }
        public static int ArrSum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static int[] CompareGrades(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                Console.WriteLine("Arrays must be of equal size");
            }

            int bobPoint = 0;
            int alicePoint = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    bobPoint++;
                }
                else if (arr1[i] < arr2[i])
                {
                    alicePoint++;
                }
            }

            return [bobPoint, alicePoint];

        }

        public static int MatrixDiagonal(int[,] arr)
        {
            int mainDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                mainDiagonal += arr[i, i];
                secondaryDiagonal += arr[i, arr.Length - 1 - i];
            }

            return Math.Abs(mainDiagonal - secondaryDiagonal);

        }

        public static void HashMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" #");
                    //Thread.Sleep(1000);
                }
                Console.WriteLine();

            }
        }

        public static void OppositeHashMatrix(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(' ', n - i);
                sb.Append('#', i);
                Console.WriteLine(sb.ToString());
            }
        }
        public static void Percentages(int[] arr)
        {
            int positives = 0;
            int negatives = 0;
            int zeroes = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) zeroes++;
                else if (arr[i] > 0) positives++;
                else negatives++;
            }

            Console.WriteLine($"The percentage of positive numbers are {(positives * 100.0) / arr.Length}");
            Console.WriteLine($"The percentage of negatve numbers are {(negatives * 100.0) / arr.Length}");
            Console.WriteLine($"The percentage of zero numbers are {(zeroes * 100.0) / arr.Length}");
        }

        public static void MinAndMaxSum(int[] arr)
        {
            int minNum = arr[0];
            int maxNum = arr[0];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i] < minNum)
                {
                    minNum = arr[i];
                }
                if (arr[i] > maxNum)
                {
                    maxNum = arr[i];
                }
            }

            Console.WriteLine($"The sum of the 4 biggest numbers is {sum - minNum}");
            Console.WriteLine($"The sum of the 4 smallest numbers is {sum - maxNum}");
        }

        public static int CandleHeight(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;


            int maxHeight = arr[0];
            int count = 0;
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > maxHeight)
                {
                    maxHeight = arr[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == maxHeight)
                    count++;
            }

            return count;

        }

        public static int[] MaxAndMinHighScore(int[] arr)
        {
            int countMin = 0;
            int countMax = 0;
            int highScore = 0;
            int lowScore = 0;
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > highScore)
                {
                    highScore = arr[i];
                    countMax++;
                }
                else if (arr[i] < lowScore)
                {
                    lowScore = arr[i];
                    countMin++;
                }
            }
            return [countMax, countMin];

        }

        public static int GetMaxIndex(int[] arr)
        {
            int n = arr.Length;
            int maxVal = arr[0];
            int maxIndex = 0;

            for (int i = 1; n > 0; i++)
            {
                if (arr[i] > maxVal)
                {
                    maxVal = arr[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public static int GetMaxInt(int[] arr)
        {
            int n = arr.Length;
            int maxVal = arr[0];

            for (int i = 1; n > 0; i++)
            {
                if (arr[i] > maxVal)
                    maxVal = arr[i];
            }

            return maxVal;
        }

        public static string Reverse(string s)
        {
            char[] result = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                result[i] = s[s.Length - 1 - i];
            }

            return new string(result);
        }

        public static void Fibonacci(int n)
        {
            int num1 = 0;
            int num2 = 1;

            while (num1 <= n)
            {
                Console.WriteLine(num1 + " ");

                int nextNum = num1 + num2;
                num1 = num2;
                num2 = nextNum;
            }

        }

        public static bool IsAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;

            char[] arr1 = s1.ToCharArray();
            char[] arr2 = s2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            return arr1.SequenceEqual(arr2);
        }

        public static string RemoveDuplicates(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            // Το HashSet κρατάει τους χαρακτήρες που έχουμε ήδη συναντήσει
            HashSet<char> seen = new HashSet<char>();
            StringBuilder sb = new StringBuilder();

            foreach (char c in s)
            {
                // Αν ο χαρακτήρας προστεθεί με επιτυχία (σημαίνει ότι δεν υπήρχε)
                if (seen.Add(c))
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        public static char MostFrequentChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                throw new ArgumentException("Το string δεν μπορεί να είναι άδειο.");

            // Dictionary για να αποθηκεύουμε: Χαρακτήρας -> Πλήθος εμφανίσεων
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts[c] = 1;
            }

            // Βρίσκουμε το κλειδί (char) που έχει τη μεγαλύτερη τιμή (count)
            char mostFrequent = s[0];
            int maxCount = 0;

            foreach (var pair in counts)
            {
                if (pair.Value > maxCount)
                {
                    maxCount = pair.Value;
                    mostFrequent = pair.Key;
                }
            }

            return mostFrequent;
        }

        public static string ReplaceSpaces(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == ' ')
                {
                    sb.Append("%20");
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
        public static int[] TwoSum(int[] arr, int target)
        {
            if (arr.Length == 0) return arr;
            if (target == -1) return arr;

            int[] arrToReturn = new int[2];
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        arrToReturn[0] = i;
                        arrToReturn[1] = j;
                    }
                }
            }
            return arrToReturn;
        }
        public static string ReverseString(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;

            StringBuilder sb = new StringBuilder(str.Length);

            // Διαβάζουμε το αρχικό string από το τέλος προς την αρχή
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }
        public static bool HasDuplicates(int[] nums)
        {
            if (nums.Length == 0) return false;

            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i])) return true;
                set.Add(nums[i]);
            }

            return false;
        }
        public static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                // we first check both to not lose fizzbuzz
                if (i % 3 == 0 && i % 5 == 0) // Ή i % 15 == 0
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static bool IsPalindrome(string str)
        {
            // Αν το string είναι null ή κενό, θεωρείται (συνήθως) παλίνδρομο
            if (string.IsNullOrEmpty(str)) return true;

            int left = 0;
            int right = str.Length - 1;

            // Μετατρέπουμε σε πεζά για να μην έχουμε θέμα με το 'A' vs 'a'
            str = str.ToLower();

            while (left < right)
            {
                // Αν οι χαρακτήρες στις δύο άκρες διαφέρουν, δεν είναι παλίνδρομο
                if (str[left] != str[right])
                {
                    return false;
                }

                // Μετακινούμε τους δείκτες προς το κέντρο
                left++;
                right--;
            }

            // Αν φτάσαμε εδώ, σημαίνει ότι όλοι οι χαρακτήρες ταίριαξαν
            return true;
        }
        public static bool isPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            // Αντιστρέφουμε τους χαρακτήρες και φτιάχνουμε νέο string
            string reversed = new string(s.Reverse().ToArray());

            return s.Equals(reversed);
        }


    }
}
