using System;
using System.Collections.Generic;

List<DispositivosTec> dispositivos = new List<DispositivosTec>();

Console.Write("cuantos dispositivos desea agregar ? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
  DispositivosTec disp = new DispositivosTec();
    Console.WriteLine($" Dispositivo {i+1}");
    Console.WriteLine($" Nombre del dispositivo: "); disp.Nombre=Console.ReadLine();
    Console.WriteLine($"prueba de rendimiento 1: "); disp.resultadoPrueba1 =int.Parse(Console.ReadLine());
    Console.WriteLine($"prueba de rendimiento 2: "); disp.resultadoPrueba2 =int.Parse(Console.ReadLine());
    Console.WriteLine($"prueba de rendimiento 3: "); disp.resultadoPrueba3 =int.Parse(Console.ReadLine());
    dispositivos.Add(disp);
}

double SumaPromedios = 0;
DispositivosTec prueba = dispositivos[0];
Console.WriteLine(" \n Listado de los dispoditivos ");
foreach (DispositivosTec disp in dispositivos)
{
    disp.MostarDatos();
    SumaPromedios += disp.CalcularPromedio();
    if (disp.CalcularPromedio() > prueba.CalcularPromedio()) { prueba = disp; } ;
}


class DispositivosTec
{
    public string Nombre;
    public int resultadoPrueba1;
    public int resultadoPrueba2;
    public int resultadoPrueba3;
    public double CalcularPromedio()
    {
        return (resultadoPrueba1 + resultadoPrueba2 + resultadoPrueba3) / 3;
    }

    public string ObtenerEstado()
    {
        if (CalcularPromedio() >= 80) return "Optimo";
        else return "Nesecita Mantenimiento";
    }

    public void MostarDatos()
    {
        Console.WriteLine( $"Nombre:{Nombre} | Promedio de rendimiento: {CalcularPromedio()} | Estado: {ObtenerEstado()}  ");
    }
}