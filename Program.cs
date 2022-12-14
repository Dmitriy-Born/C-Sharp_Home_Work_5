//Задание №1
//Задайте массив, заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2 
Console.WriteLine("Введите номер задания (1, 2 или 3):");
int Zadanie = int.Parse(Console.ReadLine()!);

switch (Zadanie){
    case 1:
Console.WriteLine("----------Задание №1----------");
int Num1 = Message1();
int minValue1 = Message2();
int maxValue1 = Message3();
int[] array1 = GetArray(Num1, minValue1, maxValue1);
Console.WriteLine($"{String.Join(", ", array1)}");

int count = 0;
int S = 0;
while(S < Num1){
    if (array1[S]%2 == 0){
        count++;
    }
    S++;
}
Console.WriteLine($"Количество четных элементов в массиве = {count}");
        break;

case 2:
// //Задание №2
//  //Задайте одномерный массив, заполненный случайными числами. 
//  //Найдите сумму элементов, стоящих на нечётных позициях.
// //[3, 7, 23, 12] -> 19
// //[-4, -6, 89, 6] -> 0
Console.WriteLine("----------Задание №2----------");
int Num2 = Message1();
int minValue2 = Message2();
int maxValue2 = Message3();
int[] array2 = GetArray(Num2, minValue2, maxValue2);
Console.WriteLine($"{String.Join(", ", array2)}");

int odd = 0;

for(int i = 1; i < array2.Length; i = i + 2){
    odd += array2[i];
}
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях = " + odd);
        break;

    case 3:
//Задание №3
//Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.WriteLine("----------Задание №3----------");
int Num3 = Message1();
int minValue3 = Message2();
int maxValue3 = Message3();
int[] array3 = GetArray(Num3, minValue3, maxValue3);
Console.WriteLine($"{String.Join(", ", array3)}");

int max = array3[0];
int min = array3[0];

for(int i = 1; i < array3.Length; i++){
    if(array3[i] > max){
        max = array3[i];
        i++;
    }
    else{
        i++;
    }
    if(array3[i] < min){
        min = array3[i];
        i++;
    }
    else{
        i++;
}
}
Console.WriteLine($"Максимальный элемент массива равен {max}");
Console.WriteLine($"Минимальный элемент массива равен {min}");
Console.WriteLine($"Сумма минимального и максимального элемента массива равна {min + max}");
        break;
        
    default:
    Console.WriteLine("Нет такого задания");
        break;
}



//Методы задания начальных значений
int Message1(){
Console.WriteLine("Введите кол-во элементов массива: ");
int Num = int.Parse(Console.ReadLine()!);
return Num;
}

int Message2(){
Console.WriteLine("Введите нижнюю грань рандома массива: ");
int minValue = int.Parse(Console.ReadLine()!);
return minValue;
}

int Message3(){
    Console.WriteLine("Введите верхнюю грань рандома массива: ");
int maxValue = int.Parse(Console.ReadLine()!);
return maxValue;
}

//Метод создания массива рандома
int[] GetArray(int size, int minValue, int maxValue){
    
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

