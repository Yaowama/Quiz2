using System;
class Program {
    static void Main (string[] args) {
        double sum = 0;
        double max = double.MinValue;
        double min = double.MaxValue;
        int count = 0;
    
    while(true) {
        Console.Write("Please enter a number (or 'End' to stop): ");
        string input = Console.ReadLine();
        if (input == "End"){
                break;
            }
         Console.Write("Enter the mode ('FindMax', 'FindMin', or 'FindMean'): ");
        string mode = Console.ReadLine();

        }
    }
}