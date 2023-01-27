// // Собрать строку с числами от a до b,a <=b

// string NumbersFors(int a,int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i}";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a<=b) return $"{a} " + NumbersRec (a +1, b);
//     else return string.Empty;
// }
// Console.WriteLine(NumbersFors(1, 10)); // 1 2 3 4 5 6 7 8 9 10
// Console.WriteLine(NumbersFors(1, 10)); // 1 2 3 4 5 6 7 8 9 10




// // Задача: Сумма чисел от 1 до n

// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i < n; i++) result += i;
//     return result;
// }
// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n-1);
// }
// Console.WriteLine(SumFor(10)); // 45
// Console.WriteLine(SumRec(10)); // 55


// Задача: Факториал числа

// int FactorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= i;
//     return result;
// }
// int FactorialRec (int n)
// {
//    if (n == 1) return 1;
//    else return n * FactorialRec(n-1);
// }
// Console.WriteLine(FactorialFor(10)); // 3628800
// Console.WriteLine(FactorialRec(10)); // 3628800


// Задача вычислить a в степени n

// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *=a;
//     return result;
// }
// int PowerRec(int a, int n)
// {   
//     //return n == 0 ? 1 : PowerRec(a, n - 1) * a; // две нижние строчки в одной
//     if (n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }
// int PowerRecMath(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath (a*a, n / 2);
//     else return PowerRecMath(a, n - 1) * a;
// }
// Console.WriteLine(PowerFor(2,10)); // 1024
// Console.WriteLine(PowerRec(2,10)); // 1024
// Console.WriteLine(PowerRecMath(2,10)); // 1024


// Задача: Перебор слов 
// В машинном алфавите имеются четыре буквы а, и, с, и.
// Покажите все слова состоящие из Т букв, 
//которые можно построить из букв этого алфавита.

//char[] s = { 'а', 'и', 'с','в'};
//int count = s.Length;
//int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {  
//         for (int k = 0; k < count; k++)
//         {
//             for (int l = 0; l < count; l++)
//             {
//                 for (int m = 0; m < count; m++)
//                 {  
//                 Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
//                 }
//             }
//         }
//     }       
// }


// // Решение2
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//  if (length == word.Length)
//  {
//  Console.WriteLine($"{n++} {new String(word)}"); return;
//  }
//  for (int i = 0; i < alphabet.Length; i++)
//  {
//  word[length] = alphabet[i];
//  FindWords(alphabet, word, length + 1);
//  }
// }
// FindWords(“аисв”, new char[5]);



// // Решение 3
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {  
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
// }

// FindWords(“аисв”, new char[5]);



// Задача: Что находится в папке CatalogInfo   DirectoryInfo

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalogs = new DirectoryInfo(path);
//     foreach (var currentCatalog in catalogs.GetDirectories())
//     {
//         Console.WriteLine($"{indent}{currentCatalog.Name}");
//         CatalogInfo(currentCatalog.FullName, indent + " ");
//     }
//     foreach (var item in catalogs.GetFiles())
//     {
//         Console.WriteLine($"{indent}{item.Name}");
//     }
// }
// string path = @"/Users/sergejkamaneckij/Projects/HelloCode";
// CatalogInfo(path);



// // Задача:  игра припамидки из блинов разного диаметра есть 3 шпиля 
// // перекладываем кольца чтобы собрать пирамидку 
// // количество блинов и шпилей можно менять

// void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }

// Towers();


// Решение некоторых задачь
// Обход разных структур ( обход дерева )

// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// //                 0    1    2     3    4    5    6    7    8    9    10   11
// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }