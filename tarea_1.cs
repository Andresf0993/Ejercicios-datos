// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    int cantidad,stock;
    double precio, subtotal;
    string producto;
    bool  productovalido;
    
        Console.WriteLine ("indique el nombre del producto");
        producto = Console.ReadLine ();
        productovalido = (producto == "carro" ||  producto == "lapiz");
        
         Console.WriteLine ("Cuantos productos");
         cantidad = Convert.ToInt32(Console.ReadLine ());
         
          Console.WriteLine ("indique el precio unitario");
          double.TryParse(Console.ReadLine(), out precio);
          
    
  
          stock >=0;
          stock = 100;
          subtotal = cantidad*precio;
          stock -= cantidad;
          
           Console.WriteLine ("nombre del producto: " + producto);
           Console.WriteLine ("¿Producto valido?" + productovalido);
           Console.WriteLine (" cantidad comprada : "+ cantidad);
           Console.WriteLine ("valor unidad:  " + precio +"pesos " );
           Console.WriteLine ("subtotal compra: " + subtotal +"pesos ");
           Console.WriteLine ("quedan disponibles en stock:  " + stock);
          
