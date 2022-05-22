using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string contraCorrecta;
    string ContraUsu;
    public Text ingreso;
    public Text textoMsj;
    public GameObject cartel;
    
    void Start()
    {
        contraCorrecta = "123";
        cartel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void valdiarContrasenia()
    {
        ContraUsu = ingreso.text;
        if (ContraUsu == contraCorrecta)
        {
            textoMsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            textoMsj.text = "Contraseña incorrect";
            cartel.SetActive(true);
            Debug.Log("Contraseña incorrecta");
        }
    }
}
