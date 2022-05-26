using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    Color ColorVerdadero = new Color(250f / 255f, 250f / 255f, 250f / 255f);
    Color ColorFalso = new Color(0f / 255f, 0f / 255f, 0f / 255f);

    int valorEntero = 1;
    float valorFloat = 1;

    float valorFloatB = 2.65f;
    float valorFloatC = 5.89f;

    int valorModulo;

    string nombreCompleto = "Daniel Cevallos Amozurrutia";

    string numericoA = "2789";
    string numericoB = "76838";

    string oracion = "Que onda";

    string otraOracion = "Último ejercicio";


    // Start is called before the first frame update
    void Start()
    {
        // Parte 1: Ejercicio 2

        float valorOperacion = valorFloatB + valorFloatC;
        int valorResultado = (int)valorOperacion;
        Debug.LogError(valorResultado);


        // Parte 1: Ejercicio 5

        string valorConvertido = valorFloatB.ToString("0.0000");
        Debug.LogError(valorConvertido);


        // Parte 1: Ejercicio 6

        string nombre = nombreCompleto.Substring(0, 6);
        string apellidoParterno = nombreCompleto.Substring(7, 8);
        string apellidoMaterno = nombreCompleto.Substring(16);

        Debug.Log(nombre);
        Debug.LogWarning(apellidoParterno);
        Debug.LogError(apellidoMaterno);

        string[] separar = nombreCompleto.Split();

        foreach(string lista in separar)
        {
            Debug.Log(lista);
        }


        // Parte 2: Ejercicio 1

        if (int.TryParse(numericoA, out int ValA))
        {
            Debug.Log(ValA);
        }
        else
        {
            Debug.LogWarning("no sirvió");
        }


        if (int.TryParse(numericoB, out int ValB))
        {
            Debug.Log(ValB);
        }
        else
        {
            Debug.LogWarning("no sirvió");
        }

        int resulTryParse = ValA + ValB;

        Debug.LogWarning($"El resultado utilizando TryParse es {resulTryParse} porque es la suma de {ValA} y {ValB}");


        // Parte 2: Ejercicio 2

        string numChar = oracion.Substring(1, 1) + ", " + oracion.Substring(3, 1) + ", " + oracion.Substring(5, 1) + ", " + oracion.Substring(7, 1);
        Debug.Log(numChar);


        // Parte 2: Ejercicio 3

        string restaOracion = otraOracion.Substring(5);
        Debug.Log(restaOracion);

    }

    // Update is called once per frame
    void Update()
    {
        // Parte 1: Ejercicio 1

        valorEntero += 1;
        Debug.Log(valorEntero);
    }

    private void FixedUpdate()
    {
        // Parte 1: Ejercicio 1

        valorFloat *= 2;
        Debug.LogWarning(valorFloat);


        // Parte 1: Ejercicio 3

        valorModulo = Random.Range(1, 30);

        if (valorModulo % 2 == 0)
        {
            Debug.Log("El número " + valorModulo + " es par");
        }
        else
        {
            Debug.LogWarning("El número " + valorModulo + " es impar");
        }


        // Parte 1: Ejercicio 4

        switch (valorModulo % 2)
        {
            case 0:

                gameObject.GetComponent<MeshRenderer>().material.color = ColorVerdadero;
                break;

            case 1:

                gameObject.GetComponent<MeshRenderer>().material.color = ColorFalso;
                break;
        }

    }
}
