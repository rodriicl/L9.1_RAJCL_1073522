
internal class Program
{
    static void Main(string[] args)
    {
        Automovil objAutomovil = new Automovil(2019, 10000.00, "", false, 7.50, 0.00);

        Console.WriteLine("Ingrese el modelo");
        objAutomovil.DefinirModelo(int.Parse(Console.ReadLine()));

        Console.WriteLine("Ingrese la marca del carro");
        objAutomovil.DefinirMarca(Console.ReadLine());

        Console.WriteLine("Ingrese el precio");
        objAutomovil.DefinirPrecio(int.Parse(Console.ReadLine()));

        Console.WriteLine("Ingrese el cambio");
        objAutomovil.DefinirCambio(double.Parse(Console.ReadLine()));

        Console.WriteLine("Ingrese el descuento");
        objAutomovil.DefinirDescuento(double.Parse(Console.ReadLine()));



        Console.WriteLine("Datos Ingresados: " + objAutomovil.MostrarInfomracion());

        Console.ReadKey();
    }
}

class Automovil
{
    private int modelo;
    private double precio;
    private string marca;
    private bool disponible;
    private double cambio;
    private double descuento;

    public Automovil(int Modelo, double Precio, string Marca, bool Disponible, double Cambio, double Descuento)
    {
        modelo = Modelo;
        precio = Precio;
        marca = Marca;
        disponible = Disponible;
        cambio = Cambio;
        descuento = Descuento;
    }

    public void DefinirModelo(int unModelo)
    {
        modelo = unModelo;
    }

    public void DefinirPrecio(int unPrecio)
    {
        precio = unPrecio;
    }

    public void DefinirMarca(string unaMarca)
    {
        marca = unaMarca;
    }

    public void DefinirCambio(double unCambio)
    {
        cambio = unCambio;
    }

    public void DefinirDescuento(double unDescuento)
    {
        descuento = unDescuento;
    }

    public void CambiarDisponible()
    {
        if (disponible == true)
        {
            disponible = false;
        }
        else
        {
            disponible = true;
        }

    }

    public string MostrarDisponible()
    {
        {
            if (disponible == false)
            {
                return "disponible";
            }
            else
            {
                return "no disponible";
            }

        }
    }

    public string MostrarInfomracion()
    {
        return "Modelo: " + modelo + " Marca: " + marca + " Precio: " + precio + " El cambio es: " + cambio + " Descuento: " + descuento;
    }

}

