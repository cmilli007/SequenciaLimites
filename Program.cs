Console.Clear();
int numeroUm= Int32.MinValue;
int numeroDois= Int32.MaxValue;
int aux;
do

 {

if (numeroUm != Int32.MinValue || numeroDois != Int32.MaxValue);
    {
        Console.Clear();
        Console.WriteLine($"O fim ({numeroDois}) não pode ser menor que o inicio ({numeroUm})");
        Console.WriteLine();
    }
        Console.WriteLine("Inicio:");
    Int32.TryParse(Console.ReadLine(),out numeroUm);
    
    Console.WriteLine("Fim:");
    Int32.TryParse(Console.ReadLine(),out numeroDois);
 }
 while (numeroUm > numeroDois);
 Console.WriteLine();
 Console.WriteLine($"Sequencia de numeros {numeroUm} a {numeroDois}");

 while (numeroUm <= numeroDois)
 {
    Console.WriteLine($"{numeroUm}");
numeroUm++;

 }

 aux= numeroUm;
 {
Console.WriteLine($"{aux}");
 aux++;
 
 }
 