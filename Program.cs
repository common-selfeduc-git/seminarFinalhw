/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 int Initialize(){
    Console.Write("Введите N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
 }

 void ShowNaturalRec(int N){
    if (N > 0) {Console.Write(N);}
    if (N <= 1) {
        return;
    }
    else{
        ShowNaturalRec(N-1);
    }
 }
 ShowNaturalRec(Initialize());*/

 /*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
(int N, int M) Initialize() {
    Console.Write("Введите N(N > M): ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите M(M < N): ");
    int M = Convert.ToInt32(Console.ReadLine());
    var result = (N:N, M:M);
    return result;
 }
 void ShowNaturalRec(int N, int M, int Sum){
    if (M >= N) {
        if (M>0) {Console.WriteLine(Sum+=M);}
        else{Console.WriteLine(Sum);}
        return;
    }
    else{
        if (M > 0) {ShowNaturalRec(N,M+1,Sum += M);;}
        else{ShowNaturalRec(N,M+1,Sum);}
        
    }
 }
 var tuple = Initialize();
 Console.WriteLine(tuple.N);
 Console.WriteLine(tuple.M);
 ShowNaturalRec(tuple.N, tuple.M, 0);*/
 /*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(A(n, m));           
int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return A(m - 1, 1);
    if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
    return A(m,n);
}
