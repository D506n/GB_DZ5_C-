//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void PrintArray(int[] PrintAr){//метод, который будет выводить созданный массив для наглядности работы программы
  Console.Write("Числа в массиве: ");
  int StepAr = 0;
  while (StepAr < PrintAr.Length){
    if (StepAr < PrintAr.Length-1){
      Console.Write($"{PrintAr[StepAr]}; ");
    }
    else {
      Console.Write($"{PrintAr[StepAr]}.");
    }
    StepAr++;
  }
}
int step = 0;
Random rnd = new Random();
int[] array = new int[rnd.Next(10,20)];
while (step < array.Length){//заполняю массив случайными числами
  array[step] = rnd.Next(0, 1000);
  step++;
}
PrintArray(array);
Console.WriteLine();
step = 0;
int even = 0;
while (step < array.Length) {//нахожу количество чётных чисел
  if (array[step] % 2 == 0){
    even++;
  }
  step++;
}
Console.WriteLine($"Количество чётных чисел: {even}");