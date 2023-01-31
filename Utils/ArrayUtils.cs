namespace MyUtilities
{
    public static class ArrayUtils
    {
        public static int FindAverage(int[] x)
        {
            int length = 0;

            int result = 0;
            foreach (var y in x)
            {
                result += y;
                length = length++;
            }
            length = ArrayUtils.FindLength(x);
            result = result / length;


            return result;
        }

        public static double FindAverage(double[] x)
        {
            double length = 0;

            double result = 0;
            foreach (double y in x)
            {
                result += y;
                length = length++;
            }
            length = ArrayUtils.FindLength(x);
            result = result / length;


            return result;
        }

        public static int FindLength(int[] x)
        {
            var length = 0;
            foreach (var y in x)
            {
                length++;
            }
            return length;
        }

        public static double FindLength(double[] x)
        {
            double length = 0;
            foreach (double y in x)
            {
                length++;
            }
            return length;
        }

        public static int FindMax(int[] x)
        {
            int max = 0;
            int min = 0;
            foreach (int y in x)
                if (y > max)
                    max = y;
                else
                    min = y;
            return max;
        }

        public static double FindMax(double[] x)
        {
            double max = 0;
            double min = 0;
            foreach (int y in x)
                if (y > max)
                    max = y;
                else
                    min = y;
            return max;
        }

        public static int FindMin(int[] x)
        {
            int[] testArray = { 3, 6, 4 };
            int i = 0;
            int small = 0;

            small = testArray[0];
            for (i = 1; i< ArrayUtils.FindLength(x); i++)
            {
                if(small > x[i])
                    small = x[i];
            }
            return small;
        }

        public static double FindMin(double[] x)
        {
            // double[] testArray = { 3, 6, 4 };
            double i = 0;
            double small = 0;

            small = x[0];
            for (i = 1; i< ArrayUtils.FindLength(x); i++)
            {
                if(small > x[(int)i])
                    small = x[(int)i];
            }
            return small;
        }


    }
}