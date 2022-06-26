using Ejercicio_clase_13.Model;

var Billetera1 = new Billetera()
{
    BilletesDe100 = 5,
    BilletesDe20 = 6,
    BilletesDe10 = 2,
    BilletesDe1000 = 1,
    BilletesDe200 = 2,
    BilletesDe50 = 4,
    BilletesDe500 = 1
    
};

var Billetera2 = new Billetera()
{
    BilletesDe10 = 1,
    BilletesDe20 = 3,
    BilletesDe50 = 1,
    BilletesDe100 = 5,
    BilletesDe200 = 1,
    BilletesDe500 = 1,
    BilletesDe1000 = 5
    
};

Console.WriteLine($"Billetera 1 tiene {Billetera1.Total()} pesos");
Console.WriteLine($"Billetera 2 tiene {Billetera2.Total()} pesos");

var Billetera3 = Billetera1.Combinar(Billetera2);

Console.WriteLine($"La nueva Billetera tiene {Billetera3.Total()} pesos");

Console.WriteLine($"billetera 1 quedó en {Billetera1.Total()}");
Console.WriteLine($"billetera 2 quedó en {Billetera2.Total()}");

