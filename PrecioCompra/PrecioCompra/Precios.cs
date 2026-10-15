class Precios
{
    public static void Main()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("      CALCULAR PRECIOS");
        Console.WriteLine("=================================");
        Console.WriteLine("Ingrese el precio del producto:");
        decimal precio = decimal.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Ingrese la cantidad a pagar:");
        Console.WriteLine("---------------------------------");
        int cantidad = int.Parse(Console.ReadLine());

        if (precio > 0 && cantidad > 0)
        {
            decimal subtotal = precio * cantidad;
            decimal descuento = 0;

            if (subtotal > 25000)
            {
                descuento = subtotal * 0.10m;
            }

            decimal total = subtotal - descuento;
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("Subtotal: " + subtotal);
            Console.WriteLine("Descuento: " + descuento);
            Console.WriteLine("Total a pagar: " + total);
            Console.WriteLine("=================================");
        }
        else
        {
            Console.WriteLine("El precio o la cantidad son incorrectos");
        }
    }
}