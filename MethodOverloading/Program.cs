namespace MethodOverloading
// 'namespace' is used to oganize and group related classes and types.
// 'MethodOverloading' is the name of the namespace for this project.
{
    public class Program
    // 'public' is the access modifier that makes the class accessible from other part of the program.
    // 'class' defines a blueprint for creeating objests.
    // 'program' is the name of the class that contains the methods and the entry point of the program.
    
    {
        public static int Add(int numOne, int numTwo)
        // 1. This method adds two integers and returns their sum.
        // 'public' makes method accessible anywhere in the program.
        // 'static' means the method belongs to the class itself rather than an instance of the class.
        // 'int' is the return type, indicating the method returns an int.
        // 'Add' is the method name, written in PascalCase.
        // 'int numOne, int numTwo' are the parematers of the type 'int', representing the two numbers to be added.
        {
            return numOne + numTwo;
            // 'return' is a keyword that sends the result of the expression back to the method's caller.
            // 'numberOne + numTwo' is the expression that calculates the sum of the two int.
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        // 2. This method adds two decimal numbers and returns their sum.
        // 'decimal' is the return type, indicating the method returns a deciaml value.
        // The method is overloaded, meaning it has the same name as the previous method but accepts different paremeters types.
        
        
        {
            return numOne + numTwo;
            // Just like the previous method, 'numOne + numTwo' calculates the sum of the two decimal numbers.
        }

        public static string Add(int numOne, int numTwo, bool isCurrenncy)
        // 3. This method over here adds two int and formats the result as a string, optionally as currency.
        // 'string' is the return type, indicating the method returns a string.
        // 'bool isCurrrency' is parameter of type 'bool' that determines whether the sum is formatted as currency.
        {
            var sum = numOne + numTwo;
            // 'var' is a keyword used to implicitly declare a variable with the type inferred by the compiler.
            // 'sum' stores the result of adding 'numOne' and 'nunmTwo'.
            

            if (isCurrenncy && sum > 1)
            // This 'if' statement checks if 'isCurrency' is true and if the sum is greater than 1.     
            {
                return $"{sum} dollar";
                // 'return' sends a formatted string like 'X dollars' to the method's caller.
                // "$"{sum} dollars"' is string interpolation, inserting the value of 'sum' into the string.
                
            }
            else if (isCurrenncy && sum == 1)
                // This 'else if' block checks if 'isCurrency' is true amd the sum equals 1.
            {
                return $"{sum} dollar";
                // 'return' sends a formatted string like '1 dollar' to the caller.
                // Adjust for singular/plural based on the sum.
            }
            else
            {
                return sum.ToString();
                // 'sum.ToString()' conversts the int 'sum' to a string.
                // This executes if 'isCurrenncy' is false.
            }
        }
        static void Main(string[] args)
        // The entry point of the program.
        // 'static' means the method belongs to the class itself.
        // 'void' indicates the method dose not return a value.
        // 'Main' is the methods name, and it is the starting point when the progam runs.
        // 'string[] args' is an array of strings that can hold command line arguments.
        {
            Console.WriteLine(Add(numOne:1, numTwo:1, isCurrenncy: false));
            // 'Console.WriteLine' outputs the result of the 'Add' method to the console.
            // 'numOne: 1, numTwo: 1, isCurrenncy: False' are named arguments passed to the methods
        }
    }
}
