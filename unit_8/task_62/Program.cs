/*
Задача 62 (дополнительная). Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
/// Данная функция будет работать при любом количестве строк и столбцов
int[,] GetSpiralMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    if (column >= row)
    {
        int elementMean = 1; // Заводим переменную, значение которой буде присваивать элементам массива
        int countRow = row; // Заводим счётчик строк для прохода по столбцам.
        int countColumn = column; // Заводим счётчик столбцов для прохода по строкам.
        int value = -column; // задаём переменную, которая выступит чем-то типа коэффициента для получения индекса элемента
        int position = -1; // задаём переменную, которая выступит одним из показателе для получения индекса элемента
                           //Далее мы создаём цикл, который за проход заполняет массив по горизонтали и по вертикали. Количество проходов напрямую зависит от количества строк.
        while (countRow > 0)
        {
            value = -1 * value / column; // при проходе по строке коэффициент зависит от количества строк
            for (int i = 0; i < countColumn; i++)
            {
                position += value;
                matrix[position / column, position % column] = elementMean;
                elementMean++;
            }
            value *= column; // при проходе по столбцам коэффициент зависит от количества столбцов
            countRow--;
            for (int i = 0; i < countRow; i++)
            {
                position += value;
                matrix[position / column, position % column] = elementMean;
                elementMean++;
            }
            countColumn--;
        }
    }
    // Данная часть функци будет работать при условии, что количество столбцов меньше, чем строк количество строк
    // Для работы данной функции мы копируем содержание предыдущей части, заменяя соответственно значения коэффициента value.
    // Заполнение первой строки выносим в отдельный цикл за пределами While. Это даёт нам направление заполнения массива по часовой стрелке.
    else
    {
        int elementMean = 1;
        int countRow = row;
        int countColumn = column;
        int value = -row;
        int position = -1;
        value = -1 * value / row;
        for (int i = 0; i < countColumn; i++)
        {
            position += value;
            matrix[position / column, position % column] = elementMean;
            elementMean++;
        }
        countRow--;
        while (countColumn > 0)
        {

            value *= column;
            for (int i = 0; i < countRow; i++)
            {
                position += value;
                matrix[position / column, position % column] = elementMean;
                elementMean++;
            }
            countColumn--;
            value = -1 * value / column;
            for (int i = 0; i < countColumn; i++)
            {
                position += value;
                matrix[position / column, position % column] = elementMean;
                elementMean++;
            }
            countRow--;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] result =/* new int[rows, columns];
if (columns >= rows) result =*/ GetSpiralMatrix(rows, columns);
// else result = GetSpiralMatrixClone(rows, columns);
PrintMatrix(result);