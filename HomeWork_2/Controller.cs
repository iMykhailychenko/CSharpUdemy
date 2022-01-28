using System;
using System.Timers;

namespace HomeWork_2
{
    public class Controller
    {
        private int rows;
        private int cols;

        private Timer timer;
        private GameField field;
 
        public Controller(int ms, int cols, int rows)
        {
            this.rows = rows;
            this.cols = cols;

            timer = new Timer(ms);
            field = new GameField(cols, rows, GenereteActiveDots());
        }

        public void StartGame()
        {
            timer.Elapsed += UpdateGameField;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        public void StopGame()
        {
            timer.Stop();
            timer.Dispose();
        }

        private void UpdateGameField(object sender, ElapsedEventArgs e)
        {
            field.Dots = GenereteActiveDots();
            field.Render();
        }

        private Cell[] GenereteActiveDots()
        {
            int square = rows * cols;

            Random rnd = new Random();
            int length = rnd.Next(square / 2, square);

            var activeDots = new Cell[length];

            for (int i = 0; i < length; i++)
            {
                activeDots[i] = new Cell(rnd.Next(0, rows), rnd.Next(0, cols));
            }

            return activeDots;
        }
    }
}
