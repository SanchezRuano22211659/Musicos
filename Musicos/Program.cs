abstract class Musico
{
    
    public string nombre {get; set;}

    public Musico(string Nombre)
    {
        nombre = Nombre;
    }
    public void Saluda(){Console.WriteLine($"Saludos, soy {nombre}");}
    public /*virtual*/abstract void Tocar();//{Console.WriteLine($"{nombre} está tocando un instrumento");}
}
class Guitarrista
    :Musico
{
    private string guitarra {get; set;}
    public Guitarrista(string nombre, string Guitarra)
        :base(Nombre:nombre)
    {
        guitarra = Guitarra;
    }
    public override void Tocar(){Console.WriteLine($"{nombre} esta tocando usando {guitarra}");}
}
class Bajista
    :Musico
{
    private string bajo {get; set;}
    public Bajista(string nombre, string Bajo)
        :base(Nombre:nombre)
    {
        bajo = Bajo;
    }
    public override void Tocar(){Console.WriteLine($"{nombre} esta tocando usando {bajo}");}
}
internal class Program
{
    private static void Main(string[] args)
    {
        //Musico m1 = new Musico("Alexis");
        Bajista b1 = new Bajista("Miguel Angel","Bajo amarillo");
        Guitarrista g1 = new Guitarrista("Black A","Guitarron");
        List<Musico> grupo = new List<Musico>();
        grupo.Add(b1); grupo.Add(g1); //grupo.Add(m1);
        foreach(Musico m in grupo)
        {
            m.Tocar();
        }
    }
}