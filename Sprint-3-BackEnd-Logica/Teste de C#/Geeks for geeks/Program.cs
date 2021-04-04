// C# program to illustrate  
// foreach loop  
using System; 
  
class For_Each      
{ 
      
    // Main Method 
    public static void Main(String[] arg)  
    {  
        {  
            int[] marks = { 125, 132, 95, 116, 110 };  
              
            int highest_marks = maximum(marks);  
              
            Console.WriteLine("The highest score is " + highest_marks);  
        }  
    }  
      
    // method to find maximum 
    public static int maximum(int[] numbers)  
    {  
        int maxSoFar = numbers[0];  
          
        // for each loop  
        foreach (int num in numbers)  
        {  
            if (num > maxSoFar)  
            {  
                maxSoFar = num;  
            }  
        }  
    return maxSoFar;  
    }  
}  
