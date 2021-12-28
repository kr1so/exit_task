int[] RandomNumber(int[] array){
    for (int i = 0; i < array.Length; i++){
        array[i]= new Random().Next(-10, 10);
    }
    return array;
}
int[] PrintArray(int[] array){
     for (int i = 0; i < array.Length; i++){
        System.Console.Write($"{array[i]} ");
    }
    return array;
}
int[] array1 = new int [5];
RandomNumber(array1);
PrintArray(array1);

int count = 0;
int[] array2 = new int [count];
int[] SelectArray(int[] arrayA, int[] arrayB){
  int j = 0;
    for (int i = 0; i < arrayA.Length; i++){
            if (arrayA[i]%2 == 0){
                arrayB[j] = arrayA[i];
                j++;
            }
        }
        
            return array2;
}
SelectArray(array1, array2);
System.Console.WriteLine();
PrintArray(array2);
System.Console.WriteLine();
