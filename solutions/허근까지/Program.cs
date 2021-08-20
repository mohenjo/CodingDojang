using System;
using System.Numerics;

namespace 허근까지
{
    class Program
    {
        static void Main()
        {
            var solution = new QuadraticEquation(1, 4, 5);
            Console.WriteLine(solution);
        }
    }

    class QuadraticEquation
    {
        private readonly double quadraticCoeff, linearCoeff, constantCoeff;

        public QuadraticEquation(double quadraticCoeff, double linearCoeff, double constantCoeff)
        {
            this.quadraticCoeff = quadraticCoeff; // 2차항 계수
            this.linearCoeff = linearCoeff; // 1차항 계수
            this.constantCoeff = constantCoeff; // 상수항 계수
            this.Discriminant = Math.Pow(linearCoeff, 2.0) - 4.0 * this.quadraticCoeff * this.constantCoeff;
        }

        // 판별식
        public double Discriminant { get; }

        // 해를 문자열 표현으로 반환
        public override string ToString()
        {
            Complex solution1 = (-linearCoeff + Complex.Sqrt(Discriminant)) / (2.0 * quadraticCoeff);
            Complex solution2 = (-linearCoeff - Complex.Sqrt(Discriminant)) / (2.0 * quadraticCoeff);
            string expression1 = Complex2Expression(solution1);
            string expression2 = Complex2Expression(solution2);
            return Discriminant == 0 ? $"{expression1}" : $"{expression1}, {expression2}";
        }

        // 복소수 클래스를 문자열 표현으로 변환
        private static string Complex2Expression(Complex complex)
        {
            // 해의 정수 반올림
            int realValue = (int)Math.Round(complex.Real);
            int imagValue = (int)Math.Round(complex.Imaginary);
            // 해를 경우따른 문자열로 표현
            string first = realValue != 0 ? $"{realValue}" : "";
            string sign = imagValue < 0 ? "-" : "+";
            string second = Math.Abs(imagValue) != 1 ? $"{Math.Abs(imagValue)}i" : "i";
            if (imagValue == 0)
            {
                second = string.Empty;
                sign = string.Empty;
            }
            string expression = $"{first}{sign}{second}";
            if (expression == "")
            {
                expression = "0";
            }
            return expression;
        }
    }
}
