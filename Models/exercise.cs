namespace Learning_1.Models;

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
    public string ExerciseName { get; set; } = "";
    public int Reps { get; set; }
    public bool Advanced { get; set; }
    public bool Home { get; set; }
    public int RestInSec { get; set; }
}
