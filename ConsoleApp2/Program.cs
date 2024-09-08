namespace ConsoleApp2
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        
        static void Main(string[] args)
        {
            //№1
            /*/// <summary> 
            ///  Одномерный массив A (5 элементов)
            /// </summary>
            double[] A = new double[5];

            /// <summary>
            /// Ввод элементов массива A с клавиатуры
            /// </summary>
            
            Console.WriteLine("Введите 5 элементов для массива A:");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    A[i] = Convert.ToDouble(Console.ReadLine());
                }
            /// <summary>
            /// Двумерный массив B (3 строки, 4 столбца)
            /// </summary>
            
            double[,] B = new double[3, 4];

            /// <summary>
            /// Заполнение массива B случайными числами
            /// </summary>
            
            Random random = new Random();
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        B[i, j] = random.NextDouble() * 100; 
                }
            }
            /// <summary>
            /// Вывод массива A
            /// </summary>
            
            Console.WriteLine("\nМассив A:");
                
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write($"{A[i]}");
                    if (i < A.Length - 1)
                    {
                        Console.Write("  ");
                    }
                }
                

            /// <summary>
            /// Вывод массива B в виде матрицы
            /// </summary> 
            Console.WriteLine("\nМассив B:");
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        Console.Write($"{B[i, j],6:F2} ");
                    }
                    Console.WriteLine();
                }
            /// <summary>
            /// Вычисление общих максимального и минимального элементов
            /// </summary>
            double maxElement = double.MinValue;
                double minElement = double.MaxValue;
                foreach (double element in A)
                {
                    if (element > maxElement)
                    {
                        maxElement = element;
                    }
                    if (element < minElement)
                    {
                        minElement = element;
                    }
                }

                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        if (B[i, j] > maxElement)
                        {
                            maxElement = B[i, j];
                        }
                        if (B[i, j] < minElement)
                        {
                            minElement = B[i, j];
                        }
                    }
                }
            /// <summary>
            /// Вычисление общей суммы и произведения элементов
            /// </summary>
             
            double sumAllElements = 0;
                double productAllElements = 1;
                foreach (double element in A)
                {
                    sumAllElements += element;
                    productAllElements *= element;
                }

                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        sumAllElements += B[i, j];
                        productAllElements *= B[i, j];
                    }
                }
            /// <summary>
            /// Вычисление суммы четных элементов массива A
            /// </summary>
            
            double sumEvenElements = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumEvenElements += A[i];
                    }
                }

            /// <summary>
            ///  Вычисление суммы нечетных столбцов массива B
            /// </summary> 
            double sumOddColumns = 0;
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        if (j % 2 != 0)
                        {
                            sumOddColumns += B[i, j];
                        }
                    }
                }
            /// <summary>
            ///  Вывод результатов
            /// </summary>
           
            Console.WriteLine($"\nОбщий максимальный элемент: {maxElement}");
                Console.WriteLine($"Общий минимальный элемент: {minElement}");
                Console.WriteLine($"Общая сумма всех элементов: {sumAllElements}");
                Console.WriteLine($"Общее произведение всех элементов: {productAllElements}");
                Console.WriteLine($"Сумма четных элементов массива A: {sumEvenElements}");
                Console.WriteLine($"Сумма нечетных столбцов массива B: {sumOddColumns}");
*/
            //№2
            /* /// <summary>
             ///  Создание двумерного массива 5x5
             /// </summary
             int[,] array = new int[5, 5];

             /// <summary>
             ///  Заполнение массива случайными числами от -100 до 100
             /// </summary>
             // 
             Random random = new Random();
             for (int i = 0; i < array.GetLength(0); i++)
             {
                 for (int j = 0; j < array.GetLength(1); j++)
                 {
                     array[i, j] = random.Next(-100, 101); 
                 }
             }
             /// <summary>
             /// Вывод массива на консоль
             /// </summary>
             Console.WriteLine("Двумерный массив:");
             for (int i = 0; i < array.GetLength(0); i++)
             {
                 for (int j = 0; j < array.GetLength(1); j++)
                 {
                     Console.Write($"{array[i, j],4} ");
                 }
                 Console.WriteLine();
             }
             /// <summary>
             ///  Нахождение минимального и максимального элементов
             /// </summary>

             int minElement = int.MaxValue;
             int maxElement = int.MinValue;
             int minRow = 0;
             int minCol = 0;
             int maxRow = 0;
             int maxCol = 0;

             for (int i = 0; i < array.GetLength(0); i++)
             {
                 for (int j = 0; j < array.GetLength(1); j++)
                 {
                     if (array[i, j] < minElement)
                     {
                         minElement = array[i, j];
                         minRow = i;
                         minCol = j;
                     }
                     if (array[i, j] > maxElement)
                     {
                         maxElement = array[i, j];
                         maxRow = i;
                         maxCol = j;
                     }
                 }
             }

             Console.WriteLine($"\nМинимальный элемент: {minElement} (строка {minRow + 1}, столбец {minCol + 1})");
             Console.WriteLine($"Максимальный элемент: {maxElement} (строка {maxRow + 1}, столбец {maxCol + 1})");
             /// <summary>
             /// Вычисление суммы элементов между минимальным и максимальным
             /// </summary>
             int sum = 0;
             for (int i = 0; i < array.GetLength(0); i++)
             {
                 for (int j = 0; j < array.GetLength(1); j++)
                 {
                     /// <summary>
                     ///  Проверка, находится ли элемент между минимальным и максимальным
                     /// </summary>
                     if (
                         (i == minRow && j > minCol && j < maxCol) ||
                         (i == maxRow && j > minCol && j < maxCol) ||
                         (i > minRow && i < maxRow && j == minCol) ||
                         (i > minRow && i < maxRow && j == maxCol) ||
                         (i == minRow && j == maxCol) ||
                         (i == maxRow && j == minCol) ||
                         (i > minRow && i < maxRow && j > minCol && j < maxCol)
                     )
                     {
                         sum += array[i, j];
                     }
                 }
             }

             Console.WriteLine($"\nСумма элементов между минимальным и максимальным элементами: {sum}");
 */
            //№3
            /*            Console.Write("Введите строку: ");
                        string text = Console.ReadLine();

                        Console.Write("Введите сдвиг (целое число): ");
                        int shift = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"\nЗашифрованный текст: {Encrypt(text, shift)}");
                        Console.WriteLine($"Расшифрованный текст: {Decrypt(text, shift)}");

                        Console.ReadLine();
                    }
                    /// <summary>
                    ///  Метод шифрования
                    /// </summary>

                    static string Encrypt(string text, int shift)
                    {
                        string result = "";
                        foreach (char c in text)
                        {
                            if (char.IsLetter(c))
                            {
                                char baseChar = char.IsLower(c) ? 'a' : 'A';
                                int shiftedChar = ((c - baseChar + shift) % 26 + 26) % 26 + baseChar;
                                result += (char)shiftedChar;
                            }
                            else
                            {
                                result += c; 
                            }
                        }
                        return result;
                    }
                    /// <summary>
                    /// Метод расшифрования
                    /// </summary>

                    static string Decrypt(string text, int shift)
                    {
                        return Encrypt(text, -shift); 
            */
            //№4
            /*/// <summary>
            /// Запрашиваем размерность первой матрицы
            /// </summary>

            
            Console.Write("Введите количество строк для первой матрицы: ");
            int rows1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов для первой матрицы: ");
            int cols1 = Convert.ToInt32(Console.ReadLine());
            /// <summary>
            ///Создаем первую матрицу
            /// </summary>

            
            double[,] matrix1 = new double[rows1, cols1];
            /// <summary>
            /// Заполняем первую матрицу
            /// </summary>

             
            Console.WriteLine("Введите элементы первой матрицы:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    matrix1[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            /// <summary>
            /// Запрашиваем размерность второй матрицы
            /// </summary>

            
            Console.Write("Введите количество строк для второй матрицы: ");
            int rows2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов для второй матрицы: ");
            int cols2 = Convert.ToInt32(Console.ReadLine());

            /// <summary>
            /// Создаем вторую матрицу
            /// </summary>
           
            double[,] matrix2 = new double[rows2, cols2];

              /// <summary>
            /// Заполняем вторую матрицу
            /// </summary>
            Console.WriteLine("Введите элементы второй матрицы:");
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    matrix2[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            /// <summary>
            ///Вывод матриц на консоль
            /// </summary>
           
            Console.WriteLine("\nПервая матрица:");
            PrintMatrix(matrix1);
            Console.WriteLine("\nВторая матрица:");
            PrintMatrix(matrix2);
            /// <summary>
            ///  Меню операций
            /// </summary>
            
            while (true)
            {
                Console.WriteLine("\nВыберите операцию:");
                Console.WriteLine("1. Умножение матрицы на число");
                Console.WriteLine("2. Сложение матриц");
                Console.WriteLine("3. Произведение матриц");
                Console.WriteLine("4. Выход");

                Console.Write("Введите номер операции: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        /// <summary>
                        /// Умножение матрицы на число
                        /// </summary>
                        
                        Console.Write("Введите число для умножения: ");
                        double multiplier = Convert.ToDouble(Console.ReadLine());
                        double[,] result1 = MultiplyByScalar(matrix1, multiplier);
                        Console.WriteLine("\nРезультат умножения:");
                        PrintMatrix(result1);
                        break;

                    case 2:
                        /// <summary>
                        ///Сложение матриц (проверка совместимости)
                        /// </summary>
                        
                        if (rows1 == rows2 && cols1 == cols2)
                        {
                            double[,] result2 = AddMatrices(matrix1, matrix2);
                            Console.WriteLine("\nРезультат сложения:");
                            PrintMatrix(result2);
                        }
                        else
                        {
                            Console.WriteLine("Невозможно сложить матрицы, так как они несовместимы по размерности.");
                        }
                        break;

                    case 3:
                        /// <summary>
                        /// Произведение матриц (проверка совместимости)
                        /// </summary>
                        
                        if (cols1 == rows2)
                        {
                            double[,] result3 = MultiplyMatrices(matrix1, matrix2);
                            Console.WriteLine("\nРезультат умножения:");
                            PrintMatrix(result3);
                        }
                        else
                        {
                            Console.WriteLine("Невозможно умножить матрицы, так как количество столбцов первой матрицы не равно количеству строк второй матрицы.");
                        }
                        break;

                    case 4:
                        /// <summary>
                        /// Выход
                        /// </summary>
                        // 
                        Console.WriteLine("Выход из программы.");
                        return;

                    default:
                        Console.WriteLine("Неверный выбор операции.");
                        break;
                }
            }
        }
        /// <summary>
        /// Метод для вывода матрицы на консоль
        /// </summary>
        static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],6:F2} ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Метод умножения матрицы на число
        /// </summary>
        static double[,] MultiplyByScalar(double[,] matrix, double scalar)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[,] result = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }
            return result;
        }
        /// <summary>
        ///Метод сложения матриц
        /// </summary>
        
        static double[,] AddMatrices(double[,] matrix1, double[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            double[,] result = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }
        /// <summary>
        /// Метод умножения матриц
        /// </summary>
        // 
        static double[,] MultiplyMatrices(double[,] matrix1, double[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);
            double[,] result = new double[rows1, cols2];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return result;*/



            //№5
            /*Console.Write("Введите арифметическое выражение (+ или -): ");
            string expression = Console.ReadLine();

            try
            {
                double result = CalculateExpression(expression);
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadLine();
        }

        static double CalculateExpression(string expression)
        {
            /// <summary>
            /// Проверка на пустоту и валидность выражения
            /// </summary>
             
            if (string.IsNullOrEmpty(expression) || !expression.Contains('+') && !expression.Contains('-'))
            {
                throw new ArgumentException("Некорректное выражение.");
            }
            /// <summary>
            /// Разделяем выражение на операнды и оператор
            /// </summary>
             
            string[] parts = expression.Split('+', '-');
            if (parts.Length != 2)
            {
                throw new ArgumentException("Некорректное выражение.");
            }

            double operand1 = Convert.ToDouble(parts[0].Trim());
            double operand2 = Convert.ToDouble(parts[1].Trim());
            char operation = expression[parts[0].Length];

            /// <summary>
            /// Выполняем операцию
            /// </summary> 
            if (operation == '+')
            {
                return operand1 + operand2;
            }
            else if (operation == '-')
            {
                return operand1 - operand2;
            }
            else
            {
                throw new ArgumentException("Неподдерживаемая операция.");
            }*/
            //№6
            /*Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            string capitalizedText = CapitalizeFirstLetters(text);
            Console.WriteLine($"\nТекст с заглавными буквами в начале каждого предложения:\n{capitalizedText}");

            Console.ReadLine();
        }

        static string CapitalizeFirstLetters(string text)
        {
            string result = "";
            bool newSentence = true; 

            foreach (char c in text)
            {
                if (newSentence)
                {
                    result += char.ToUpper(c); 
                    newSentence = false; 
                }
                else
                {
                    result += c; 
                }
                /// <summary>
                /// Проверка на конец предложения
                /// summary> 
               
                if (c == '.' || c == '!' || c == '?')
                {
                    newSentence = true;
                }
            }

            return result;*/
            //№7
            /*/// <summary>
            /// Список недопустимых слов
            /// summary> 
            List<string> forbiddenWords = new List<string> { "die" };

            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            /// <summary>
            ///  Подсчет замен
            /// summary> 
            int replacementsCount = 0;

            /// <summary>
            /// Замена недопустимых слов на '*'
            /// summary>  
            string censoredText = text;
            foreach (string forbiddenWord in forbiddenWords)
            {
                censoredText = censoredText.Replace(forbiddenWord, new string('*', forbiddenWord.Length));
                replacementsCount += censoredText.Split(new string[] { forbiddenWord }, StringSplitOptions.None).Length - 1;
            }

            /// <summary>
            /// Вывод результата
            /// summary>  
            Console.WriteLine("\nОтцензурированный текст:");
            Console.WriteLine(censoredText);
            Console.WriteLine($"\nСтатистика: {replacementsCount} замен слова 'die'.");

            */
        }
    }
}
       

    

