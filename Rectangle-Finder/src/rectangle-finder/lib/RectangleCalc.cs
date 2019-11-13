namespace rectangle_finder.lib
{
    public class RectangleCalc
    {
        public int CountInMatrix(int[,] inputMatrix)
        {
            int result = RegularWay(inputMatrix);
            return result;
        }
        private int RegularWay(int[,] inputMatrix)
        {
            int result = 0;
            int x = inputMatrix.GetLength(0);
            int y = inputMatrix.GetLength(1);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    result += (x - i) * (y - j);
                }
            }
            return result;
        }
   }
}