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

        public static double SquareRoot(double x)
        {
            float precision = 0.0001f;
            float min = 0;
            float max = (float)x;
            float result = 0;
            while (max - min > precision)
            {
                result = (min + max) / 2;
                if ((result * result) >= x)
                {
                    max = result;
                }
                else
                {
                    min = result;
                }
            }
            return x;
        }




    }
}