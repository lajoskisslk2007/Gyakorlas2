using System;
using Homerseklet;

homersekletAtvalto peldany = new homersekletAtvalto();
peldany.Celsius = 25;
Console.WriteLine(peldany.toFarenheit());

double kapott = 30;
Console.WriteLine(homersekletAtvalto.CelsiusToFarenheit(kapott));