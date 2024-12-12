using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TodaLaJerarquia : MonoBehaviour
{
    public void EscenaCargando() 
    {
        SceneManager.LoadScene("EscenaCargando");
    }
    public void EscenaInicio()
    {
        SceneManager.LoadScene("EscenaInicio");
    }
    public void EscenaNoWifi()
    {
        SceneManager.LoadScene("EscenaNoWifi");
    }
    public void LoginEscena()
    {
        SceneManager.LoadScene("LoginEscena");
    }
    public void AsignarEjercicios()
    {
        SceneManager.LoadScene("AsignarEjercicios");
    }
    public void ClaseX()
    {
        SceneManager.LoadScene("ClaseX");
    }
    public void EleccionRoles()
    {
        SceneManager.LoadScene("EleccionRoles");
    }
    public void Teoria()
    {
        SceneManager.LoadScene("Teoria");
    }
    public void InicioProfesor()
    {
        SceneManager.LoadScene("InicioProfesor");
    }
    public void Resultados()
    {
        SceneManager.LoadScene("Resultados");
    }
    public void Temas()
    {
        SceneManager.LoadScene("Temas");
    }
    public void Ejercicios()
    {
        SceneManager.LoadScene("Ejercicios");
    }
    public void InicioAlumno()
    {
        SceneManager.LoadScene("InicioAlumno");
    }
    public void EjercicioN()
    {
        SceneManager.LoadScene("EjercicioN");
    }

}
