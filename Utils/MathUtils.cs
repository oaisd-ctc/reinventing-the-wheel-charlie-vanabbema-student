namespace MyUtilities
{

    public static class MathUtils
    {
        public static int Power(int x, int y)
        {
            int z = x;
            for (int i = y; i > 1; i--)
            {
                z *= x;
            }
            return z;
        }
        public static double Power(double x, double y)
        {
            double z = x;
            for (double i = y; i > 1; i--)
            {
                z *= x;
            }
            return z;
        }

        public static decimal Power(decimal x, decimal y)
        {
            decimal z = x;
            for (decimal i = y; i > 1; i--)
            {
                z *= x;
            }
            // Console.WriteLine(z);
            return z;
        }

        public static double SquareRoot(double x)
        {
            if (x < 2)
                return x;

            double y = x;
            double z = (y + (x / y)) / 2;

            while (MathUtils.AbsoluteValue(y - z) > 0)
            {
                y = z;
                z = (y + (x / y)) / 2;

            }
            return z;
        }

        public static int SquareRoot(int x)
        {
            if (x < 2)
                return x;

            int y = x;
            int z = (y + (x / y)) / 2;

            while (MathUtils.AbsoluteValue(y - z) > 0)
            {
                y = z;
                z = (y + (x / y)) / 2;

            }
            return z;
        }

        public static decimal SquareRoot(decimal x)
        {
            if (x < 2)
                return x;

            decimal y = x;
            decimal z = (y + (x / y)) / 2;

            while (MathUtils.AbsoluteValue(y - z) > 0)
            {
                y = z;
                z = (y + (x / y)) / 2;

            }
            return z;
        }

        public static int AddNumbers(int x, int y)
        {
            int z = x + y;
            return z;
        }
        public static double AddNumbers(double x, double y)
        {
            double z = x + y;
            return z;
        }

        public static decimal AddNumbers(decimal x, decimal y)
        {
            decimal z = x + y;
            return z;
        }

        public static int SubtractNum(int x, int y)
        {
            int z = x - y;
            return z;
        }

        public static double SubtractNum(double x, double y)
        {
            double z = x - y;
            return z;
        }

        public static decimal SubtractNum(decimal x, decimal y)
        {
            decimal z = x - y;
            return z;
        }

        public static int DivideNums(int x, int y)
        {
            int z = x / y;
            return z;
        }
        public static double DivideNums(double x, double y)
        {
            double z = x / y;
            return z;
        }

        public static decimal DivideNums(decimal x, decimal y)
        {
            decimal z = x / y;
            return z;
        }

        public static double MultiplyNums(int x, int y)
        {
            int z = x * y;
            return z;
        }

        public static double MultiplyNums(double x, double y)
        {
            double z = x * y;
            return z;
        }

        public static decimal MultiplyNums(decimal x, decimal y)
        {
            decimal z = x * y;
            return z;
        }


        public static int FindMax(int x, int y)
        {
            if (x > y)
            {
                int max = x;
                return max;
            }
            else
            {
                int max = y;
                return max;
            }
        }

        public static double FindMax(double x, double y)
        {
            if (x > y)
            {
                double max = x;
                return max;
            }
            else
            {
                double max = y;
                return max;
            }
        }

        public static decimal FindMax(decimal x, decimal y)
        {
            if (x > y)
            {
                decimal max = x;
                return max;
            }
            else
            {
                decimal max = y;
                return max;
            }
        }

        public static int FindMin(int x, int y)
        {
            if (x > y)
            {
                int min = y;
                return min;
            }
            else
            {
                int min = x;
                return min;
            }
        }

        public static double FindMin(double x, double y)
        {
            if (x > y)
            {
                double min = y;
                return min;
            }
            else
            {
                double min = x;
                return min;
            }
        }
        public static decimal FindMin(decimal x, decimal y)
        {
            if (x > y)
            {
                decimal min = y;
                return min;
            }
            else
            {
                decimal min = x;
                return min;
            }
        }

        public static int AbsoluteValue(int x)
        {
            if (x < 0)
            {
                x = x * -1;
                return x;
            }
            else
            {
                return x;
            }
        }

        public static double AbsoluteValue(double x)
        {
            if (x < 0)
            {
                x = x * -1;
                return x;
            }
            else
            {
                return x;
            }
        }

        public static decimal AbsoluteValue(decimal x)
        {
            if (x < 0)
            {
                x = x * -1;
                return x;
            }
            else
            {
                return x;
            }
        }

        public static int Sign(int x)
        {

            if (x > 0)
            {
                int y = 1;
                return y;
            }
            else if (x < 0)
            {
                int y = -1;
                return y;
            }
            else
            {
                int y = 0;
                return y;
            }
        }

        public static double Sign(double x)
        {
            if (x > 0)
            {
                double y = 1;
                return y;
            }
            else if (x < 0)
            {
                double y = -1;
                return y;
            }
            else
            {
                double y = 0;
                return y;
            }
        }

        public static decimal Sign(decimal x)
        {
            if (x > 0)
            {
                var y = 1;
                return y;
            }
            else if (x < 0)
            {
                var y = -1;
                return y;
            }
            else
            {
                var y = 0;
                return y;
            }
        }

        public static int AreaOfRect(int length, int width)
        {
            int ans = length * width;
            return ans;
        }

        public static double AreaOfRect(double length, double width)
        {
            double ans = length * width;
            return ans;
        }

        public static decimal AreaOfRect(decimal length, decimal width)
        {
            decimal ans = length * width;
            return ans;
        }



        public static int AreaOfRhombus(int x, int y)
        {
            int math = x * y;
            int answer = math / 2;
            return answer;
        }

        public static double AreaOfRhombus(double x, double y)
        {
            double math = x * y;
            double answer = math / 2;
            return answer;
        }

         public static decimal AreaOfRhombus(decimal x, decimal y)
        {
            decimal math = x * y;
            decimal answer = math / 2;
            return answer;
        }

        public static int SurfaceAreaOfCube(int x)
        {
            int math = MathUtils.Power(x, 2);
            int answer = (int)MathUtils.MultiplyNums(math, 6);

            return answer;
        }

        public static double SurfaceAreaOfCube(double x)
        {
            double math = MathUtils.Power(x, 2);
            double answer = MathUtils.MultiplyNums(math, 6);
            return answer;
        }

        public static decimal SurfaceAreaOfCube(decimal x)
        {
            decimal math = MathUtils.Power(x, 2);
            decimal answer = MathUtils.MultiplyNums(math, 6);
            return answer;
        }

        // public static void Random()
        // {
        //     int M = 45864;
        //     int A = 6783;

        //     int Q = M / A;
        //     int R = M % A;

        //     number = (A * (number mod Q)    ) -
        //              (R * floor(number / Q));

        //     if (number is negative)
        //         number = number + M;
        //     end
        // }




    }
}