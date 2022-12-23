namespace Asincronia{
internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.Clear();
        using (var barra = new ProgressBar())
        {
        Task<Huevo> tareaFritarHuevo = FritarHuevo(3);
        Task<Tocineta> tareaFreirTocino = FreirTocineta(3);
        Task<Cafe> tareaPrepararCafe = PrepararCafe();
        Cafe posillo = await tareaPrepararCafe;
        //barra.Report(0.05);
        //Huevo Huevos = await FritarHuevo(3);
        //Tocineta Tocino = await FreirTocineta(3);
        //barra.Report(0.05);
        Task<Tostada> tareaTostar = TostarPan(3); 
        Tostada tostada = await tareaTostar;
        //barra.Report(0.5);
        PonerMantequilla(tostada);
        PonerMermelada(tostada);
        Console.WriteLine($"Listas las tostadas en el plato ");
        Jugo jugo = PrepararJugo("Corozo"); 
        //barra.Report(1.0);
        Thread.Sleep(50);

            /* for(int i = 0; i < 100; i++)
            {
                barra.Report((double)i/100);
                Thread.Sleep(50);
            } */
        }
     
    }

    public class Cafe{}
    public class Huevo{}
    public class Tostada{}
    public class Tocineta{}
    public class Jugo{}

    private static async Task<Cafe> PrepararCafe()
    {
        Console.WriteLine($"Preparando el Cafe ");
        await Task.Delay(3000);
        Console.WriteLine($"Listo el Cafe ");
        return new Cafe();
    }
    private static async Task<Huevo> FritarHuevo(ushort cant)
    {
        Console.WriteLine($"Calentar Sarten ...");
        Task.Delay(1000).Wait();
        Console.WriteLine($"Fritando {cant} Huevos ");
        await Task.Delay(3000);
        Console.WriteLine($"Los Huevos estan listos");
        return new Huevo();
    }
    private static async Task<Tostada> TostarPan(ushort cant)
    {
        for(ushort i = 0; i< cant; i ++)
        {
        Console.WriteLine($"Tostando la rebanada # {i} de pan ");
        await Task.Delay(2000);
        }
        
        return new Tostada();
    }
    private static Jugo PrepararJugo( string tipo)
    {
        Console.WriteLine($"Preparando el jugo de tipo {tipo} ");
        Task.Delay(3000).Wait();
        Console.WriteLine($"Listo el Jugo ");

        return new Jugo();
    }

     private static async Task<Tocineta> FreirTocineta(ushort cant)
    {
        for(ushort i = 0; i< cant; i ++)
        {
        Console.WriteLine($"Friendo la tocineta # {i}");
        await Task.Delay(2000);
        }
        Console.WriteLine($"Listas las {cant} tocinetas");
        return new Tocineta();
    }
    private static void PonerMermelada(Tostada tostada) =>
            Console.WriteLine("Putting jam on the toast");

 
    private static void PonerMantequilla(Tostada tostada) =>
            Console.WriteLine("Putting jam on the toast");
     
    
}
}