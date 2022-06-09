using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosdeCiclosyarreglos : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

        //Ejercicio 1

        int[] arregloA = new int[3];
        int[] arregloB = new int[3];
        int[] arregloC = new int[3];

        for (int i = 0; i < arregloA.Length; i++)
        {
            Debug.Log(arregloA[i] = Random.Range(1, 30));
        }

        for (int i = 0; i < arregloB.Length; i++)
        {
            Debug.LogWarning(arregloB[i] = Random.Range(1, 30));
        }

        for (int i = 0; i < arregloC.Length; i++)
        {
            arregloC[i] = arregloA[i] + arregloB[i];

            Debug.LogError(arregloC[i]);
        }


        //Ejercicio 2

        string[] oracion = new string[] { "Hola", "que", "hace", "?" };

        foreach (string oracionCompleta in oracion)
        {
            Debug.Log(oracionCompleta);
        }

        string todoJunto = string.Join(" ", oracion);

        Debug.LogWarning(todoJunto);


        //Ejercicio 3

        int[,] arregloBi = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[] arregloUni = new int[2] { 10, 20 };
        int resultado = 0;


            for (int k = 0; k < arregloBi.GetLength(0); k++)
            {
                for (int l = 0; l < arregloBi.GetLength(1); l++)
                {
                    Debug.Log(arregloBi[k, l]);
                    for (int m = 0; m < arregloUni.GetLength(0); m++)
                    {
                        Debug.LogWarning(arregloUni[m]);
                        resultado = arregloBi[k, l] * arregloUni[m];
                        Debug.LogError(resultado);
                    }
                }
            }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
