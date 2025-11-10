namespace FIT.Models
{
    class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MuscleGroup { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }

        public double CalculateCaloriesBurned()
        {
            // Примерная формула — можно потом улучшить
            return Sets * Reps * Weight * 0.1;
        }
    }
}
