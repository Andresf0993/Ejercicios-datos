using System;

public class Ejercicio_3
{
    public static void Main(string[] args)
    {
         double valor, total, hora;
         
         
          Console.WriteLine ("Cuantas horas de desarrollo?");
               double.TryParse(Console.ReadLine(), out hora);
               
           valor = 5000;
           total = hora*valor;
           Console.WriteLine ("el costo acumulado es de " + total);
         
    
         
        
        
    }
}
