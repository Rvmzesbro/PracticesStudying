using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practic8
{
    public class Game
    {

        public int Width { get; private set; }
        public int Height { get; private set; }
        private Snake snake;
        private Food food;
        private bool gameOver;
        private int score;


        private Position positionToClear = null;


        public Game(int width = 60, int height = 20)
        {
            Width = width;
            Height = height;
            Console.CursorVisible = false;


            try
            {

                int maxWidth = Console.LargestWindowWidth > 0 ? Console.LargestWindowWidth : width + 1;
                int maxHeight = Console.LargestWindowHeight > 0 ? Console.LargestWindowHeight : height + 2;

                int consoleWidth = Math.Min(Width, maxWidth);
                int consoleHeight = Math.Min(Height + 1, maxHeight);

                Console.SetWindowSize(consoleWidth, consoleHeight);
                Console.SetBufferSize(consoleWidth, consoleHeight);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Предупреждение: Не удалось установить размер консоли ({ex.GetType().Name}).");

                Console.WriteLine("Игра продолжится, но отображение может быть не идеальным.");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();

                Width = Console.WindowWidth;
                Height = Console.WindowHeight - 1;
            }
        }


        private void DrawBorders()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("#");
                Console.SetCursorPosition(i, Height - 1);
                Console.Write("#");
            }
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("#");
                Console.SetCursorPosition(Width - 1, i);
                Console.Write("#");
            }
            Console.ResetColor();
        }


        public void Run()
        {
            DrawBorders();

            snake = new Snake(Width / 2, Height / 2);

            food = new Food(Width, Height, new List<Position>(snake.Body));
            gameOver = false;
            score = 0;
            positionToClear = null;


            DrawFood();
            DrawSnake();
            DrawScore();

            while (!gameOver)
            {

                Thread.Sleep(100);

                Input();

                if (!gameOver)
                {
                    Update();
                    Draw();
                }
            }

            GameOver();
        }


        private void Draw()
        {

            if (positionToClear != null)
            {
                Console.SetCursorPosition(positionToClear.X, positionToClear.Y);
                Console.Write(" ");
                positionToClear = null;
            }


            DrawSnakeHeadAndFirstSegment();


        }


        private void DrawSnake()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Position head = snake.GetHead();
            if (head != null)
            {
                Console.SetCursorPosition(head.X, head.Y);
                Console.Write("O");
            }

            for (int i = 1; i < snake.Body.Count; i++)
            {
                Position segment = snake.Body[i];
                Console.SetCursorPosition(segment.X, segment.Y);
                Console.Write("o");
            }
            Console.ResetColor();
        }


        private void DrawSnakeHeadAndFirstSegment()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Position head = snake.GetHead();
            if (head != null)
            {
                Console.SetCursorPosition(head.X, head.Y);
                Console.Write("O");
            }

            if (snake.Body.Count > 1)
            {
                Position firstSegment = snake.Body[1];
                Console.SetCursorPosition(firstSegment.X, firstSegment.Y);
                Console.Write("o");
            }
            Console.ResetColor();
        }


        private void DrawFood()
        {
            Console.SetCursorPosition(food.Position.X, food.Position.Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("*");
            Console.ResetColor();
        }


        private void DrawScore()
        {
            Console.SetCursorPosition(0, Height);
            Console.Write($"Score: {score}   ");
        }



        private void Input()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: snake.ChangeDirection(0, -1); break;
                    case ConsoleKey.DownArrow: snake.ChangeDirection(0, 1); break;
                    case ConsoleKey.LeftArrow: snake.ChangeDirection(-1, 0); break;
                    case ConsoleKey.RightArrow: snake.ChangeDirection(1, 0); break;
                    case ConsoleKey.Escape: gameOver = true; break;
                }
            }
        }


        private void Update()
        {

            bool willGrow = snake.GetHead()?.Equals(food.Position) ?? false;
            positionToClear = null;

            if (!willGrow && snake.Body.Count > 0)
            {

                Position currentTail = snake.Body.Last();
                positionToClear = new Position(currentTail.X, currentTail.Y);
            }


            snake.Move();


            if (snake.GetHead().Equals(food.Position))
            {
                score++;
                snake.Grow();

                food.Generate(Width, Height, new List<Position>(snake.Body));
                DrawFood();
                DrawScore();
            }


            if (snake.CollidesWithWall(Width, Height) || snake.CollidesWithSelf())
            {
                gameOver = true;
            }
        }


        private void GameOver()
        {
            Console.Clear();
            Console.SetCursorPosition(Width / 2 - 10, Height / 2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("G A M E   O V E R !");
            Console.ResetColor();
            Console.SetCursorPosition(Width / 2 - 10, Height / 2 + 1);
            Console.WriteLine($"Your final score: {score}");
            Console.SetCursorPosition(Width / 2 - 15, Height / 2 + 3);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Console.CursorVisible = true;
        }
    }
}
