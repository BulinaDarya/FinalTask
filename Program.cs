//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 //длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
 //либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
 // лучше обойтись исключительно массивами.
 //Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string Prompt(string message) {
    System.Console.Write(message);
    string input = Console.ReadLine ();
    return input;
}
void ShowArray(string[] array) {
    for (int i = 0; i < array.Length; i++) {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}
string[] CreateArray() {   
    int count = 0;
    string value = String.Empty;
    string[] secondArray = new string[50];
    System.Console.WriteLine($"Enter 'exit' to complete input");
    for (count = 0; value != "exit"; count++) {
        value = Prompt($"Enter {count+1} meaning ");
        if (value != "exit") {
            secondArray[count] = value;
        }
    }
    string[] array = new string[count-1];
    for (int i = 0; i < array.Length; i++) {
         array[i] = secondArray[i];
    }
    return array;
}
string[] CheckArray(string[] array) {   
    int count = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++) { 
        if (array[i].Length < 4) count++;
    }
    string[] finalArray = new string[count];
    for (int j = 0; j < array.Length; j++) { 
        if (array[j].Length < 4) {
            finalArray[index] = array[j];
            index++;
        }
    }
    return finalArray;
}

string[] array = CreateArray();
System.Console.Write("Data received: ");
ShowArray(array);
System.Console.Write("Result: ");
ShowArray(CheckArray(array));
