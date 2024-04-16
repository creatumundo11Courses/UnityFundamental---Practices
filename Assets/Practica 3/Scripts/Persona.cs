using UnityEngine;

public class Persona 
{
    public string Nombre;
    public int Edad;

    public void MuestrameEdadYNombre()
    {
        Debug.Log($"Nombre: {Nombre} Edad: {Edad}");
    }
}
