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
        int[] arregloUni = new int[3] { 10, 11, 12 };
        int[] resultadoArreglo = new int[arregloBi.GetLength(0)];


        for (int i = 0; i < arregloUni.Length; i++)
        {
            for (int j = 0; j < arregloBi.GetLength(0); j++)
            {
                resultadoArreglo[j] += (arregloBi[j, i] * arregloUni[i]);
                Debug.LogError(resultadoArreglo[j]);
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
