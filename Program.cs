int[] array1 = new int[10];
for (int i = 0; i < array1.Length; i++){
    array1[i] = new Random().Next(-10, 10);
    System.Console.Write($"{array1[i]} ");
}
System.Console.WriteLine();
int count = 0;
int[] array2 = new int[array1.Length];
for (int i = 0; i < array1.Length; i++){
    if (array1[i] % 2 == 0){
        array2[count] = array1[i];
        System.Console.Write($"{array2[count]} ");
        count++;
    }
}