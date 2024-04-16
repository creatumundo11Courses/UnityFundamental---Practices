
using UnityEngine;

public class Estudiante : Persona
{
    public int CodigoEstudiante;

    public void MuestrameCodigoEstudiante()
    {
        Debug.Log($"Codigo estudiante {CodigoEstudiante}");
    }
}
