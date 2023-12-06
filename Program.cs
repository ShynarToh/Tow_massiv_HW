// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.


namespace seminsr_5_HW_3{
    public class Program {
         public static void Main (string [] arg) {
            int [,] towArray = CreateTowArray(3, 5, 1, 15);
            Print(towArray);
            RowSum(towArray);
            System.Console.WriteLine("min sum rows:");
            System.Console.WriteLine(RowSum(towArray));
                    }
         public static int [,] CreateTowArray (int rows, int cols, int min, int max){
            int [,] towArray = new int [rows, cols];
            Random rand = new();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    towArray[i,j] = rand.Next(min, max+1);
                }
            } return towArray;
         } 
         public static void Print(int [,] array){
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    System.Console.Write(array[i, j]+"\t");
                } 
                System.Console.WriteLine();
            }

         }
         public static int RowSum (int[,] array){
            int sumRows= 0;
            int minSumRows=int.MaxValue;;
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sumRows=sumRows+array[i,j];
                 } 
                if (sumRows < minSumRows ) {
                    minSumRows =sumRows;
                    minSumRows++;
                }
            } return minSumRows;
                     }
    }
}