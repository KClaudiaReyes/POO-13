using System;
using System.Collections.Generic;


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
        else return 
    }
}