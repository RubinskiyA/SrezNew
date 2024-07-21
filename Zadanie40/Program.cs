using Zadanie40;

int[,] mas1 = {{1,2,3},
    {4,5,6 },
    {7,8,9 } };
int[,] mas2 = {{9,8,7},
    {6,5,4 },
    {3,2,1 } };
Matrix matrix = new Matrix(mas1,mas2);
matrix.SumMas();
matrix.SubMas();
matrix.MultiMas();
matrix.TransMas();
