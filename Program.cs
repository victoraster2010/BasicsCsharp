// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args) {
       // int intNumber = Convert.ToInt32(valorAi);
       // Console.WriteLine(intNumber);
       for(var count = 0;count < 3;count++){
           System.Console.WriteLine("Numero: "+ count);
       }
       string[] names = new string[] {"seucreyson", "doom", "cm full mana", "rayur"};

       foreach(var name in names)  {
        System.Console.WriteLine(name);
       }
    }
}