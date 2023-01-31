namespace MyUtilities
{

    public static class MathUtils
    {
    /// <summary>
    /// Calculates an int to the power of another int.
    /// </summary>
    /// <param name="x">The int.</param>
    /// <param name="y">The power.</param>
    /// <returns>
    /// An int answer.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
        public static int Power(int x, int y)
        {
            int z = x;
            for (int i = y; i > 1; i--)
            {
                z *= x;
            }
            return z;
        }
    /// <summary>
    /// Calculates an int to the power of another int.
    /// </summary>
    /// <param name="x">The double.</param>
    /// <param name="y">The power.</param>
    /// <returns>
    /// A double answer.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
        public static double Power(double x, double y)
        {
            double z = x;
            for (double i = y; i > 1; i--)
            {
                z *= x;
            }
            return z;
        }
    /// <summary>
    /// Calculates the square root of a double.
    /// </summary>
    /// <param name="x">The double.</param>
    /// <returns>
    /// The squareroot.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
    /// <summary>
    /// Calculates the square root of an int.
    /// </summary>
    /// <param name="x">The int.</param>
    /// <returns>
    /// The squareroot.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
    /// <summary>
    /// Calculates the sum of two ints.
    /// </summary>
    /// <param name="x">The int.</param>
    /// <param name="y">The other int.</param>
    /// <returns>
    /// The sum.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
        public static int AddNumbers(int x, int y)
        {
            int z = x + y;
            return z;
        }
    /// <summary>
    /// Calculates the sum of two doubless.
    /// </summary>
    /// <param name="x">The double.</param>
    /// <param name="y">The other double.</param>
    /// <returns>
    /// The sum.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
        public static double AddNumbers(double x, double y)
        {
            double z = x + y;
            return z;
        }
    /// <summary>
    /// Calculates the difference of two ints.
    /// </summary>
    /// <param name="x">The int.</param>
    /// <param name="y">The other int.</param>
    /// <returns>
    /// The difference.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
        public static int SubtractNum(int x, int y)
        {
            int z = x - y;
            return z;
        }
    /// <summary>
    /// Calculates the difference of two doubless.
    /// </summary>
    /// <param name="x">The double.</param>
    /// <param name="y">The other double.</param>
    /// <returns>
    /// The difference.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
        public static double SubtractNum(double x, double y)
        {
            double z = x - y;
            return z;
        }
    /// <summary>
    /// Calculates the division of two ints.
    /// </summary>
    /// <param name="x">The int.</param>
    /// <param name="y">The other int.</param>
    /// <returns>
    /// The answer.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
        public static int DivideNums(int x, int y)
        {
            int z = x / y;
            return z;
        }
    /// <summary>
    /// Calculates the division of two doubless.
    /// </summary>
    /// <param name="x">The double.</param>
    /// <param name="x">The other double.</param>
    /// <returns>
    /// The answer.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
        public static double DivideNums(double x, double y)
        {
            double z = x / y;
            return z;
        }
    /// <summary>
    /// Calculates the product of two ints.
    /// </summary>
    /// <param name="x">The int.</param>
    /// <param name="y">The other int.</param>
    /// <returns>
    /// The product.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
        public static double MultiplyNums(int x, int y)
        {
            int z = x * y;
            return z;
        }
    /// <summary>
    /// Calculates the product of two doubless.
    /// </summary>
    /// <param name="x">The double.</param>
    /// <param name="y">The other double.</param>
    /// <returns>
    /// The product.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
        public static double MultiplyNums(double x, double y)
        {
            double z = x * y;
            return z;
        }
    /// <summary>
    /// Determines the larger of two ints.
    /// </summary>
    /// <param name="x">The int.</param>
    /// <param name="y">The other int.</param>
    /// <returns>
    /// The max.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
    /// <summary>
    /// Determines the larger of two doubles.
    /// </summary>
    /// <param name="x">The double.</param>
    /// <param name="y">The other double.</param>
    /// <returns>
    /// The max.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
    /// <summary>
    /// Determines the smaller of two ints.
    /// </summary>
    /// <param name="x">The int.</param>
    /// <param name="y">The other int.</param>
    /// <returns>
    /// The min.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
    /// <summary>
    /// Determines the smaller of two doubles.
    /// </summary>
    /// <param name="x">The double.</param>
    /// <param name="y">The other double.</param>
    /// <returns>
    /// The min.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
    /// <summary>
    /// Determines the absolute value of an int.
    /// </summary>
    /// <param name="x">The int.</param>
    /// <returns>
    /// The absolutevalue.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
    /// <summary>
    /// Determines the absolute value of a double.
    /// </summary>
    /// <param name="x">The double.</param>
    /// <returns>
    /// The absolutevalue.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
    /// <summary>
    /// Determines the absolute value of a decimal.
    /// </summary>
    /// <param name="x">The decimal.</param>
    /// <returns>
    /// The absolutevalue.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
    /// <summary>
    /// Determines the sign of an int.
    /// </summary>
    /// <param name="x">The double.</param>
    /// <returns>
    /// The sign.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
    /// <summary>
    /// Determines the sign of a double.
    /// </summary>
    /// <param name="x">The double.</param>
    /// <returns>
    /// The sign.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
    /// <summary>
    /// Determines the area of a rectangle.
    /// </summary>
    /// <param name="length">The length.</param>
    /// <param name="width">The width.</param>
    /// <returns>
    /// The area.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
        public static int AreaOfRect(int length, int width)
        {
            int ans = length * width;
            return ans;
        }
    /// <summary>
    /// Determines the area of a rectangle.
    /// </summary>
    /// <param name="length">The length.</param>
    /// <param name="width">The width.</param>
    /// <returns>
    /// The area.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
        public static double AreaOfRect(double length, double width)
        {
            double ans = length * width;
            return ans;
        }
    /// <summary>
    /// Determines the area of a rhombus.
    /// </summary>
    /// <param name="x">The diagonal.</param>
    /// <param name="y">The other diagonal.</param>
    /// <returns>
    /// The area.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
        public static int AreaOfRhombus(int x, int y)
        {
            int rat = x * y;
            int answer = rat / 2;
            return answer;
        }
    /// <summary>
    /// Determines the area of a rhombus.
    /// </summary>
    /// <param name="x">The diagonal.</param>
    /// <param name="y">The other diagonal.</param>
    /// <returns>
    /// The area.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
        public static double AreaOfRhombus(double x, double y)
        {
            double rat = x * y;
            double answer = rat / 2;
            return answer;
        }
    /// <summary>
    /// Determines the surface area of a cube.
    /// </summary>
    /// <param name="x">The side length.</param>
    /// <returns>
    /// The surface area.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
        public static int SurfaceAreaOfCube(int x)
        {
            int rat = MathUtils.Power(x, 2);
            int answer = (int)MathUtils.MultiplyNums(rat, 6);

            return answer;
        }
    /// <summary>
    /// Determines the surface area of a cube.
    /// </summary>
    /// <param name="x">The side length.</param>
    /// <returns>
    /// The surface area.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
        public static double SurfaceAreaOfCube(double x)
        {
            double rat = MathUtils.Power(x, 2);
            double answer = MathUtils.MultiplyNums(rat, 6);
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