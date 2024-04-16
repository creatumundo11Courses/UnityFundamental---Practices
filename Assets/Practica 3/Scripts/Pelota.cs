using UnityEngine;

public class Pelota 
{
    public string Nombre;
    public string Material;
    public string Color;
    public float FactorRebote;

    public static int NumeroDeInstancias; 
    public Pelota(string nombre,string material,string color,float factorRebote) 
    {
        Nombre = nombre;
        Material = material;
        Color = color;
        FactorRebote = factorRebote;

        NumeroDeInstancias++;
    }

    public void Rebota() 
    {
        if (FactorRebote == 0) 
        {
            Debug.Log("No podemos rebotar");
        }else
        {
            Debug.Log("Estamos rebotando");
        }
    }

    public void MuestrameLasPropiedades()
    {
        string mensaje = $"Nombre: {Nombre}  Material:{Material} Color: {Color} Factor de rebote: {FactorRebote}";

        Debug.Log(mensaje);
    }

    public static void CuantasInstancias()
    {
        Debug.Log("El numero de instancias es: " + NumeroDeInstancias);
    }
    
}
