using LeetCode;


//int[] myArray1 = { 21,32,44,22,67,32,98,65,31 };
//int myNumber = 12345;

//Exercitiul_3 exercitiul_3 = new Exercitiul_3();
//exercitiul_3.ArrayIterator(myArray1);
//Console.WriteLine("Reverse array");
//exercitiul_3.reverseArray(myArray1);
//Console.WriteLine("Int to array: ");
//Console.WriteLine();
//exercitiul_3.intoArray(myNumber);
//Console.WriteLine("Exercitiul 4");
//Console.WriteLine();
//Exercitiul_4 exercitiul_4 = new Exercitiul_4();
//exercitiul_4.returnMaxNum(myArray1);
//Console.WriteLine();
//exercitiul_4.returnMinNum(myArray1);
//Console.WriteLine();
//exercitiul_4.evenNumber(myArray1);
//Console.WriteLine();
//exercitiul_4.averageOfArray(myArray1);
//exercitiul_4.drawing(14);
//exercitiul_4.reverseArray(myArray1);
//Console.WriteLine();
//exercitiul_4.incrementArray(myArray1, 2);

//int[,,] threeDArray = {
//            {
//                { 1, 2, 3 },
//                { 4, 5, 6 }
//            },
//            {
//                { 7, 8, 9 },
//                { 10, 11, 12 }
//            } };

//Exercitiul_5 exercitiul_5 = new Exercitiul_5();
//exercitiul_5.displayMatrix(threeDArray);
//int numRows = 3;
//int numCols = 4;

//double[] values = { 1.5, 2.7, 3.2, 4.9 };
//int[] rowIndices = { 0, 1, 1, 2 };
//int[] colIndices = { 1, 0, 2, 3 };

//SparseMatrix sparseMatrix = new SparseMatrix(numRows, numCols, values, rowIndices, colIndices);

//Console.WriteLine("Sparse Matrix (CSR format):");
//sparseMatrix.Display();

//Console.ReadKey();

//List<List<int>> matrix = new List<List<int>>
//{
//    new List<int>{ 1,2,3},
//    new List<int>{ 4,5,6},
//    new List<int>{7 ,8, 9}
//};
//LIL newLIL = new LIL();
//newLIL.DisplayMatrix(matrix);

//Console.WriteLine();

//matrix[1][2] = 20;


//newLIL.DisplayMatrix(matrix);
//Console.WriteLine();

//newLIL.DisplayMainDiagonal(matrix);
//Console.WriteLine();

//newLIL.DisplaySparse(matrix);
//Console.WriteLine();

//Func<int, int> doubleNumber = x => x * 2;

//int result = doubleNumber(5);
//Console.WriteLine("Result: " + result);

using static System.Console;

WriteLine("Using an imperative style of coding.");
List<int> numbers = new() { 10, 20, 30, 40, 50 };

WriteLine("The list includes the following: ");
foreach (int number in numbers)
{
    Write(number + "\t");
}

WriteLine("\nAges that are more than 30: ");
foreach (int number in numbers)
{
    if(number > 30)
    {
        Write(number + "\t");
    }
}


WriteLine("\n\nUsing the declarative style of coding.");
List<int> numbers2 = new() { 10, 20, 30, 40, 50 };
WriteLine("The list includes the following: ");
numbers2.ForEach(x => Write(x + "\t"));
WriteLine("\nAges that are more than 30:");
numbers2.Where(x => x > 30)
    .Select(x => x)
    .ToList()
    .ForEach(x => Write(x + "\t"));

