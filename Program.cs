// Первый вариант:
/* int[] array1 = new int[10];
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
} */

// Второй вариант:
int[] RandomNumber(int[] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}
int[] PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        System.Console.Write($"{array[i]} ");
    }
    return array;
}
int[] array1 = new int[5];
RandomNumber(array1);
PrintArray(array1);
int[] array2 = new int[array1.Length];
int count = 0;
int[] SelectArray(int[] arrayA, int[] arrayB){
    for (int i = 0; i < arrayA.Length; i++){
        if (arrayA[i] % 2 == 0){
            arrayB[count] = arrayA[i];
            count++;
        }
    }
    return arrayB;
}
SelectArray(array1, array2);
int[] array3 = new int [count];
int j = 0;
for (int i = 0; i < count; i++){
    array3[i]=array2[j];
    j++;
}
System.Console.WriteLine();
PrintArray(array3);
