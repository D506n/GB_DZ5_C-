//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void PrintArray(int[] PrintAr){//метод который будет выводить созданный массив для наглядности работы программы
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
step = 1;
int OddSum = 0;
while (step < array.Length) {//нахожу сумму элементов, стоящих на нечётных позициях
  if (step % 2 != 0){
    OddSum = OddSum + array[step];
  }
  step = step + 2;
}
Console.WriteLine($"Сумма чисел на нечётных позициях: {OddSum}");