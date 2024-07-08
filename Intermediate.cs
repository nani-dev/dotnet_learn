using System.Data;
using Dapper;
using Learning_1.Models;
using Microsoft.Data.SqlClient;
using SecondCode.Data;

namespace SecondCode;
// Models -- source mapping
// NameSpaces
// Database connection

public class inter
{
    public static void Main(string[] args)
    {
        DataContextDapper dapper = new DataContextDapper(); 
        
        DateTime rightNow = dapper.LoadSingleData<DateTime>("SELECT GETDATE()");
        Console.WriteLine(rightNow);


        var myExercise = new Exercise
        {
            ExerciseName = "Bench",
            Reps = 8,
            Advanced = true,
            Home = false,
            Rest = 60
        };

        // can aslo be changed after
        myExercise.Reps = 10;

        var sql = @"INSERT INTO TutorialAppSchema.Exercise (
                ExerciseName,
                Reps,
                Advanced,
                Home,
                Rest
            )   VALUES('" + myExercise.ExerciseName
                          + "','" + myExercise.Reps
                          + "','" + myExercise.Advanced
                          + "','" + myExercise.Home
                          + "','" + myExercise.Rest
                          + "')";

        //Console.WriteLine(sql);
        bool result = dapper.ExecuteSql(sql);

        var sqlSelect = @"
            SELECT 
                Exercise.ExerciseName,
                Exercise.Reps,
                Exercise.Advanced,
                Exercise.Home,
                Exercise.Rest
            FROM TutorialAppSchema.Exercise";

        IEnumerable<Exercise> exercises = dapper.LoadData<Exercise>(sqlSelect);

        foreach (var singleExercise in exercises)
            Console.WriteLine
            ("'" + myExercise.ExerciseName
                 + "','" + myExercise.Reps
                 + "','" + myExercise.Advanced
                 + "','" + myExercise.Home
                 + "','" + myExercise.Rest
                 + "'" + "\n");

        //Console.WriteLine("Num. of rows " + result);
        // Console.WriteLine("myExercise.ExerciseName: " + myExercise.ExerciseName);
        // Console.WriteLine("myExercise.Reps: " + myExercise.Reps);
        // Console.WriteLine("myExercise.Advanced: " + myExercise.Advanced);
        // Console.WriteLine("myExercise.Home: " + myExercise.Home);
        // Console.WriteLine("myExercise.RestInSec: " + myExercise.RestInSec + "\n");
    }
}