Console.Clear();
int numeroUm;
int numeroDois;
int aux;
do

 {
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
 