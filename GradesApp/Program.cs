namespace GradesApp
{  
    /// <summary>
    /// λαμβανει ως εισοδο το αθροισμα της βαθμολογιας
    /// και το πληθος των μαθηματων και εκτυπωνει τον μεσο ορο
    /// και ενα χαρακτηρισμο τυπου "αριστα", "πολυ καλα" κτλπ
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            double average = 0;

            Console.WriteLine("Παρακαλώ εισάγετε το άθροισμα της βαθμολογίας και το πλήθος των μαθημάτων");

            if(!int.TryParse(Console.ReadLine(), out int gradesSum) || gradesSum < 0)
            {
                Console.WriteLine("Λάθος στην εισαγωγή");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out int numberOfCourses) || numberOfCourses < 0)
            {
                Console.WriteLine("Λάθος στην εισαγωγή");
                return;
            }

            average = gradesSum / (double) numberOfCourses;

            if(average > 10)
            {
                Console.WriteLine("Ο μέσος όρος δεν μπορεί να είναι μεγαλύτερος απο το 10");
                return;
            }

            Console.WriteLine($"Μέσος όρος: {average} : ");
            switch (average)
            {
                case >= 8: Console.WriteLine("Άριστα!"); break;
                case >= 6: Console.WriteLine("Λίαν καλώς"); break;
                case >= 5: Console.WriteLine("Καλώς"); break;
                default: Console.WriteLine("Αποτυχία"); break;
            }
        }
    }
}
