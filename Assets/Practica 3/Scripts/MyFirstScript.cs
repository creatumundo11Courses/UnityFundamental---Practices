using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Docente docente = new Docente();
        Estudiante estudiante = new Estudiante();
        Estudiante estudiante3 = new Estudiante();
        Estudiante estudiante2 = new Estudiante();
        Estudiante estudiante6 = new Estudiante();
        Estudiante estudiante1 = new Estudiante();
        //Creacion del docente
        docente.Edad = 45;
        docente.Nombre = "Pancho";
        docente.Materia = "Matematicas";
        docente.MuestrameEdadYNombre();
        docente.MuestrameMateria();
        //Creacion del estudiante
        estudiante.Nombre = "Pedro";
        estudiante.Edad = 14;
        estudiante.CodigoEstudiante = 1234;
        estudiante.MuestrameEdadYNombre();
        estudiante.MuestrameCodigoEstudiante();

        estudiante1.CodigoEstudiante = 8969;


    }
   
}
