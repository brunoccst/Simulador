using Simulator.Exercises;

namespace Simulator
{
    public class Program
    {
        public static IExercise exercise { get; set; }

        static void Main(string[] args)
        {
            exercise = new Exercise1();
            exercise.Run();
        }
    }
}
