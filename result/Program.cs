// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символам.

int countStrInArray (string[] arr, int N){

    int count = 0;

    for (int i = 0; i < arr.Length; i++){
        if(arr[i].Length <= N) count++;
    }

    return count;
}

string[] GetNewArray(string[] arr){

    int N = 3;

    string[] changeArr = new string[countStrInArray(arr, N)];

    int j = 0;
    for (int i = 0; i < arr.Length; i++){
        if(arr[i].Length <= N) changeArr[j++] = arr[i];
    }

    return changeArr;
}

void PrintArray(string[] arr){

    for (int i = 0; i < arr.Length; i++){
        
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}


string[] arrStr = {"hello", "2", "word", "1234", "-2", ":-)"};

Console.Clear();
PrintArray(arrStr);
string[] changArr= GetNewArray(arrStr);
PrintArray(changArr);
