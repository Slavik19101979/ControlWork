
string[] myArray = {"sun", "8716", "admin", "!", "ball","Lo"}; 
int elementLength = 3; 
 
PrintArray(FindShortElements(myArray, elementLength)); 
int CountShortElements(string[] inputArray) 
    { 
        int result = 0; 
        for(int i = 0; i < inputArray.Length; i++) 
        { 
            if(inputArray[i].Length <= elementLength) result++; 
        } 
    return result; 
    } 
 string[] FindShortElements(string[] inputArray,int number) 
{ 
    string[] outputArray = new string[CountShortElements(inputArray)]; 
    int index = 0; 
    for(int i = 0; i < inputArray.Length; i++) 
    { 
        if(inputArray[i].Length <= number) 
        { 
            outputArray[index] = inputArray[i]; 
            index += 1; 
        } 
    } 
    return outputArray; 
}

void PrintArray(string[] array)  
{ 
   for(int i = 0; i < array.Length; i++) 
  Console.WriteLine(array[i]); 
}