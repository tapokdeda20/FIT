namespace FIT.Models
{
    class Workouts
    
    {
        public class Workout
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<Exercise> Exercises { get; set; } = new List<Exercise>();
        }
    }

}

