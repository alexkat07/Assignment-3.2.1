namespace Assignment_3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] my2DArray = { {2,3,4}, {1,4,6} };
            int L = 0;
            int R = 1;
            for (int i = 0; i < my2DArray.GetLength(1); i++) 
            {
                Console.Write($"| {my2DArray[L, i]} |");
                
                
            }

            Console.WriteLine();
            
            for (int i = 0; i < my2DArray.GetLength(1); i++)
            {
                Console.Write($"| {my2DArray[R, i]} |");
            }

        }
    }
}
