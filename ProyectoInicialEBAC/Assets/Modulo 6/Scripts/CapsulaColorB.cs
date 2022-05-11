using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulaColorB : MonoBehaviour
{
    CuboColor CuboInfo;
    EsferaColor EsferaInfo;
    Color ColorVerdadero = new Color(250f / 255f, 250f / 255f, 250f / 255f);
    Color ColorFalso = new Color(0f / 255f, 0f / 255f, 0f / 255f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        CuboInfo = GameObject.Find("Cubo").GetComponent<CuboColor>();
        Debug.LogWarning("El valor del Cubo es " + CuboInfo.VariableCubo);

        EsferaInfo = GameObject.Find("Esfera").GetComponent<EsferaColor>();
        Debug.LogWarning("El valor de la Esfera es " + EsferaInfo.VariableEsfera);


        if (CuboInfo || EsferaInfo)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = ColorVerdadero;
            Debug.LogError("El valor es verdadero");

        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material.color = ColorFalso;
            Debug.LogError("El valor es falso");

        }

    }
}
