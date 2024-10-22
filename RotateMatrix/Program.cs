internal class Program
{
    static int[,] RotationMatriceA(int[,] oldMatrix)
    {
        int[,] newMatrix = new int[oldMatrix.GetLength(1), oldMatrix.GetLength(0)];
        int newCol = 0;
        int newRow = 0;

        for( int i = oldMatrix.GetLength(1) - 1; i >=0 ; i --)
        {
            newCol = 0;
            for (int j =0; j <= oldMatrix.GetLength(0) - 1 ; j ++)
            {
                newMatrix[newRow, newCol] = oldMatrix[j, i];
                newCol++;
            }
            newRow++;
        }
       
        return newMatrix;
    }

    static int[,] RotationMatriceC(int[,] oldMatrix)
    {
        int[,] newMatrix = new int[oldMatrix.GetLength(1), oldMatrix.GetLength(0)];
        int newCol = 0;
        int newRow = 0;

        for( int i = 0; i <= oldMatrix.GetLength(1) - 1; i ++)
        {
            newCol = 0;
            for (int j = oldMatrix.GetLength(0) - 1; j >=0 ; j --)
            {
                newMatrix[newRow, newCol] = oldMatrix[j, i];
                newCol++;
            }
            newRow++;
        }
       
        return newMatrix;
    }

    private static void Main(string[] args)
    {

        int[,] matrice = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };


        Console.WriteLine("Entrer votre sequence C et A");
        string str = Console.ReadLine();
        int numC = 0;
        int numA = 0;
        int A = 0;
        int C = 0;

        for (int i = 0; i < str.Count(); i++)
        {
            if(str[i].ToString() == "A")
            {
                numA += 1;
            }
            else
            {
                numC += 1;
            }
        }

        if (numA > numC)
        {
            A = (numA - numC) % 4;
            for (int i = 0; i < A; i++)
            {
                matrice = RotationMatriceA(matrice);
            }

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Write(matrice[i, j] + " ");
                }
                Console.WriteLine();
            }

        }



        else if (numA < numC)
        {
            C = (numC - numA) % 4;
            for (int i = 0; i < C; i++)
            {
                matrice = RotationMatriceC(matrice);
            }

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Write(matrice[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
        else
        {
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Write(matrice[i, j] + " ");
                }
                Console.WriteLine();
            }

        }




        


    }
}