using DiakApp;

Diak parameternelkul = new Diak();
Diak egyparameteres = new Diak("Nagy jános");
Diak ketparameteres = new Diak("Kovács Anna",3.8);
Console.WriteLine($"Paraméter nélküli konstruktor{parameternelkul.nev}" + " atlag: " + parameternelkul.atlag);
Console.WriteLine($"Egy Paraméteres  konstruktor{egyparameteres.nev}" + " atlag: " + egyparameteres.atlag);
Console.WriteLine($"Két Paraméteres  konstruktor{ketparameteres.nev}" + " atlag: " + ketparameteres.atlag);