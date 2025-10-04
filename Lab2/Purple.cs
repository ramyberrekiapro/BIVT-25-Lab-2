using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                answer += (p + (i * h)) * (p + (i * h));
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            remainder = a;
            while (remainder >= b)
            {
                remainder -= b;
                quotient++;
            }
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            int nPrevPrev = 1, dPrevPrev = 1;
            int nPrev = 2, dPrev = 1;
            double prevValue = (double)nPrev / dPrev;
            while (true)
            {
                int nNext = nPrevPrev + nPrev;
                int dNext = dPrevPrev + dPrev;
                double nextValue = (double)nNext / dNext;
                if (Math.Abs(prevValue - nextValue) < E)
                {
                    answer = nextValue;
                    break;
                }
                nPrevPrev = nPrev;
                dPrevPrev = dPrev;
                nPrev = nNext;
                dPrev = dNext;
                prevValue = nextValue;
            }
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            // Need the minimal n such that |b * q^(n-1)| < E (n counts from 1 for term b)
            if (System.Math.Abs(b) < E)
            {
                answer = 1;
            }
            else
            {
                int n = 1;
                double current = b; // term n = 1
                while (System.Math.Abs(current) >= E)
                {
                    n++;
                    current *= q; // move to next term
                }
                answer = n;
            }
            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here
            long number = a;
            while (b > 0)
            {
                number *= b;
                b--;
            }
            while (number >= 10)
            {
                number /= 10;
                answer++;
            }
            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here
            int squaresChessBoard = 64;
            ulong grains = 1;
            ulong totalGrains = 0;
            for (int i = 0; i < squaresChessBoard; i++)
            {
                totalGrains += grains;
                grains *= 2;
            }
            decimal grams = (decimal)totalGrains / 15m;
            decimal tons = grams / 1_000_000m;
            answer = (long)System.Math.Floor(tons);
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            // “Начисляются каждый месяц, и их сумма рассчитывается как 1/12 годового процента в начале года”
            // => внутри года месячный прирост фиксирован и равен (S_на_начало_года * d/1200).
            if (S <= 0 || d <= 0)
            {
                answer = 0;
            }
            else
            {
                double current = S;
                double target = 2 * S;
                int monthsInYear = 12;

                while (current < target)
                {
                    // compute monthly increment based on balance at the *start of the year*
                    double startOfYear = current;
                    double monthlyAdd = startOfYear * (d / 1200.0);

                    for (int m = 0; m < monthsInYear && current < target; m++)
                    {
                        current += monthlyAdd;
                        answer++;
                    }
                }
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + 1e-12; x += h)
            {
                double term = 1.0;
                double seriesSum = term;
                int i = 1;
                double xSquared = x * x;
                while (true)
                {
                    term = term * (-xSquared) / ((2 * i - 1) * (2 * i));
                    if (System.Math.Abs(term) < E)
                        break;
                    seriesSum += term;
                    i++;
                }
                SS += seriesSum;
                SY += System.Math.Cos(x);
            }
            // end

            return (SS, SY);
        }
    }

}
