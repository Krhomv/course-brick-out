using System.Diagnostics;

namespace course_brick_out // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var game = new Game();
            game.Init();

            var stopwatch = new Stopwatch();
            double targetFrameTime = 1.0 / 60.0; // 60 FPS

            while (!game.ShouldTerminate())
            {
                stopwatch.Start();
                game.Update();
                game.Render();
                stopwatch.Stop();

                if (stopwatch.Elapsed.TotalSeconds < targetFrameTime)
                {
                    var remainingSecondsToWait = targetFrameTime - stopwatch.Elapsed.TotalSeconds;
                    var timeSpan = TimeSpan.FromSeconds(remainingSecondsToWait);
                    Thread.Sleep(timeSpan);
                }
                stopwatch.Reset();
            }
        }
    }
}

