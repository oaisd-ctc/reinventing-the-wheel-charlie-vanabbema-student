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

        // public static double SquareRoot(double x)
        // {
        //     x = 64;

        //     if (x > 0)
        //     {
        //         double root = x / 3;
        //         double i;
        //         for (i = 0; i < 32; i++)
        //             root = (root + x / root) / 2;
        //         Console.WriteLine("Squareroot:{0}", root);
        //         return root;
        //     }
        //     else
        //     {
        //         Console.WriteLine(Double.NaN);
        // return root;
        //     }
        // }

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
            if (x>y)
            {
                int min = y;
                return min;
            }
            else{
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
            else{
                double min = x;
                return min;
            }
        }





    }
}