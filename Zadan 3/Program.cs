//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void PrintArray(double[] PrintAr){//метод который будет выводить созданный массив для наглядности работы программы
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
double difference(double NumA, double NumB){//метод который находит разницу между двумя числами
  NumA = NumA * 10;
  NumB = NumB * 10;
  double dif = NumA - NumB;
  dif = dif / 10;
  return dif;
}
double FindMin(double[] ArrayMin){//метод который находит минимальное число в массиве
  int StepMin = 1;
  double MinNum = ArrayMin[StepMin - 1];
  while (StepMin < ArrayMin.Length){
    if (ArrayMin[StepMin] < MinNum){
      MinNum = ArrayMin[StepMin];
    }
  StepMin++;
  }
  return MinNum;
}
double FindMax(double[] ArrayMax){//метод который находит максимальное число в массиве
  int StepMax = 1;
  double MaxNum = ArrayMax[StepMax - 1];
  while (StepMax < ArrayMax.Length){
    if (ArrayMax[StepMax] > MaxNum){
      MaxNum = ArrayMax[StepMax];
    }
  StepMax++;
  }
  return MaxNum;
}
Random rnd = new Random();
int step = 0;
double[] array = new double[rnd.Next(10,20)];
while (step < array.Length){//заполняю массив случайными числами
  array[step] = rnd.Next(-1000, 1000);
  array[step] = array[step] / 10;
  step++;
}
PrintArray(array);
Console.WriteLine();
double MaxNumArray = FindMax(array);
double MinNumArray = FindMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference(MaxNumArray, MinNumArray)};");