using System;

namespace 업앤다운
{
    class Program
    {
        static void Main()
        {
            var game = new UpAndDownGame();
            game.StartGame();
        }
    }

    class UpAndDownGame
    {
        public UpAndDownGame()
        {
            Random rand = new Random();
            this.Answer = rand.Next(1, 101);
        }
        private int Answer { get; }

        public void StartGame()
        {
            Console.WriteLine("컴퓨터가 1~100 중 랜덤 숫자 하나를 정합니다.\n이 숫자를 맞춰주세요.");
            bool isCorrect = false;
            int numTry = 0;
            while (!isCorrect)
            {
                Console.Write("1~100 숫자 입력: ");
                string consoleInput = Console.ReadLine();
                numTry++;
                // Enter, null, whitespace(s)가 입력될 경우 0으로 간주
                int guessNumber = string.IsNullOrWhiteSpace(consoleInput) ? 0 : int.Parse(consoleInput);
                if (this.Answer == guessNumber)
                {
                    Console.WriteLine($"정답입니다! {numTry}회 만에 맞췄어요.");
                    break;
                }
                string message = this.Answer > guessNumber ? "UP" : "DOWN";
                Console.WriteLine(message);
            }
        }
    }
}
