
using UnityEngine;

public class Docente : Persona
{
    public string Materia;

    public void MuestrameMateria()
    {
        Debug.Log($"Materia: {Materia}");
    }
}
