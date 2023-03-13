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

            var running = true;
            var stopwatch = new Stopwatch();
            double targetFrameTime = 1.0 / 60.0; // 60 FPS

            while (running)
            {
                stopwatch.Start();
                running = game.Update();
                game.Render();
                stopwatch.Stop();

                if (stopwatch.Elapsed.TotalSeconds < targetFrameTime)
                {
                    var remainingSecondsToWait = targetFrameTime - stopwatch.Elapsed.TotalSeconds;
                    Thread.Sleep(TimeSpan.FromSeconds(remainingSecondsToWait));
                }
                stopwatch.Reset();
            }
        }
    }
}

