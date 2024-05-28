namespace SecondCode
{
    // Models -- source mapping
    // NameSpaces
    // Database connection

    public class Exercise
    {
        /* 
        private string _exerciseName;
        private string ExerciseName
        {
            get { return _exerciseName;}
            set { _exerciseName = value; }
        }
        */ 
        //The upper text is the same as
        public string ExerciseName { get; set; }
        public int Reps { get; set; }
        public bool Advanced { get; set; }
        public bool Home { get; set; }
        public int RestInSec { get; set; }

        public Exercise()
        {
            if (ExerciseName == null)
            {
                ExerciseName = "";
            }
        }
    }

    public class inter
    {
        public static void Main(string[] args)
        {
            Exercise myExercise = new Exercise()
            {
                ExerciseName = "Bench",
                Reps = 8, 
                Advanced = true,
                Home = false,
                RestInSec = 60
            };
            
            // can aslo be changed after
            myExercise.Reps = 10; 
            Console.WriteLine("myExercise.ExerciseName: " +myExercise.ExerciseName);
            Console.WriteLine("myExercise.Reps: " +myExercise.Reps);
            Console.WriteLine("myExercise.Advanced: " +myExercise.Advanced);
            Console.WriteLine("myExercise.Home: " +myExercise.Home);
            Console.WriteLine("myExercise.RestInSec: " +myExercise.RestInSec + "\n");
        }
    }
}