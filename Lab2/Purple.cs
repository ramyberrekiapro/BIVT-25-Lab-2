using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
            int nPrevPrev = 1, dPrevPrev = 2;
            int nPrev = 3, dPrev = 2;

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
            int n = 0;
            double current = b;
            // code here
            while (Math.Abs(current) >= E)
            {
                current *= q;
                n++;
                }

            answer = n; 
            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;
            // code here
            
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
        decimal tons = grams / 1000000m;
        answer = (long)Math.Floor(tons);

            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            int months = 0;
            double currentAmount = S;
            double monthlyRate = d / 12.0 / 100.0; // Monthly interest rate

            while (currentAmount < 2 * S)
            {
                currentAmount *= (1 + monthlyRate);
                months++;
            }

            answer = months;
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
                    
                    if (Math.Abs(term) < E)
                        break;
                        
                    seriesSum += term;
                    i++;
                }

                SS += seriesSum;
                SY += Math.Cos(x);
            }

            // end

            return (SS, SY);
        }
    }
}
