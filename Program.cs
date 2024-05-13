// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ContarPalabrasyCalculos;

{
    StringOperations stringOperations = new StringOperations();
    MathOperations mathOperations = new MathOperations();

    // Ejemplo de uso del método CountCharacters
    string word = "Ejemplo";
    int charCount = stringOperations.CountCharacters(word);
    Console.WriteLine($"La palabra '{word}' tiene {charCount} caracteres.");

    // Ejemplo de uso del método Add
    int num1 = 5;
    int num2 = 10;
    int sum = mathOperations.Add(num1, num2);
    Console.WriteLine($"{num1} + {num2} = {sum}");

    Console.ReadLine();
}