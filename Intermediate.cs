using System;
using System.Data;
using System.Text.RegularExpressions;
using Dapper;
using Learning_1.Models;
using Microsoft.Data.SqlClient;

namespace SecondCode
{
    // Models -- source mapping
    // NameSpaces
    // Database connection

    public class inter
    {
        public static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=ExerciseDatabase;TrustServerCertificate=true;" +
                                      "Trusted_Connection=true";

            IDbConnection dbConnection = new SqlConnection(connectionString);

            string sqlCommand = "SELECT GETDATE()";

            DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);
            Console.WriteLine(rightNow);


            Exercise myExercise = new Exercise()
            {
                ExerciseName = "Bench",
                Reps = 8,
                Advanced = true,
                Home = false,
                Rest = 60
            };

            // can aslo be changed after
            myExercise.Reps = 10;

            string sql = @"INSERT INTO TutorialAppSchema.Exercise (
                ExerciseName,
                Reps,
                Advanced,
                Home,
                Rest
            )   VALUES('"+ myExercise.ExerciseName 
                         + "','" + myExercise.Reps
                         + "','" + myExercise.Advanced
                         + "','" + myExercise.Home
                         + "','" + myExercise.Rest
                         +"')";
            
            Console.WriteLine(sql);
            int result = dbConnection.Execute(sql);

            string sqlSelect = @"
            SELECT 
                Exercise.ExerciseName,
                Exercise.Reps,
                Exercise.Advanced,
                Exercise.Home,
                Exercise.Rest
            FROM TutorialAppSchema.Exercise";

            IEnumerable<Exercise> exercises = dbConnection.Query<Exercise>(sqlSelect);

            foreach (Exercise singleExercise in exercises)
            {
                Console.WriteLine
                    ("'"+ myExercise.ExerciseName 
                       + "','" + myExercise.Reps
                       + "','" + myExercise.Advanced
                       + "','" + myExercise.Home
                       + "','" + myExercise.Rest
                       +"'" + "\n" );
            }
            
            //Console.WriteLine("Num. of rows " + result);
            // Console.WriteLine("myExercise.ExerciseName: " + myExercise.ExerciseName);
            // Console.WriteLine("myExercise.Reps: " + myExercise.Reps);
            // Console.WriteLine("myExercise.Advanced: " + myExercise.Advanced);
            // Console.WriteLine("myExercise.Home: " + myExercise.Home);
            // Console.WriteLine("myExercise.RestInSec: " + myExercise.RestInSec + "\n");
        }
    }
}