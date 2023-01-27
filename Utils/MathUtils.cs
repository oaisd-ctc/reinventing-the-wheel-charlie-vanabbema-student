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
            // Console.WriteLine(z);
            return z;
        }
        public static double Power(double x, double y)
        {
            double z = x;
            for (double i = y; i > 1; i--)
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

            while (MathUtils.AbsoluteValue(y - z) >= 0.000000000000000000001)
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

            while (MathUtils.AbsoluteValue(y - z) >= 0.000000000000000000001)
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

        public static int Sign(int x)
        {
    
            if (x > 0)
            {
                int y = 1;
                return y;
            }
            else if(x < 0)
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
            else if(x < 0)
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

        public static double CubeRoot(int x)
        {
            if (x == 1)
                return x;

            double y = x;
            double z = (y + (x / y)) / 3;

            while (MathUtils.AbsoluteValue(y - z) >= 0.000000000000000000001)
            {
                y = z;
                z = (y + (x / y)) / 3;
                Console.WriteLine(z);
            }
            return z;
        }

        

    
    }
}