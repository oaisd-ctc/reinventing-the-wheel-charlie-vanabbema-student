namespace MyUtilities
{

    public static class MathUtils
    {
        public static double Power(double x, double y)
        {
            double z = x;
            for(double i = y; i > 1; i--)
            {
                z *= x;
            }
            return z;
        }




    }
}