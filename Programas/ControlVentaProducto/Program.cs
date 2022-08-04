// See https://aka.ms/new-console-template for more information
Console.WriteLine("control de venta de producto");
Console.WriteLine(" ");

double p,cantidad;

Console.WriteLine("Ingrese la cantidad del producto");
cantidad = int.Parse(Console.ReadLine());

double ic = cantidad * p;
double id = 11/100 * ic;
double ip = ic - id;

Console.WriteLine("__________________________");
Console.WriteLine("Compra:   " +ic.ToString("0.00"));
Console.WriteLine("Descuento:" +id.ToString("0.00"));
Console.WriteLine("Pago:     " +ip.ToString("0.00"));



