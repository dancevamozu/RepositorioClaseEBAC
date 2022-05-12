using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulaColor : MonoBehaviour
{
    Color ColorVerdadero = new Color(250f / 255f, 250f / 255f, 250f / 255f);
    Color ColorFalso = new Color(0f / 255f, 0f / 255f, 0f / 255f);
    public bool VariableCapsula;


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
        CuboColor CuboInfo;
        EsferaColor EsferaInfo;
        CuboInfo = GameObject.Find("Cubo").GetComponent<CuboColor>();
        //Debug.LogWarning("El valor del Cubo es " + CuboInfo.VariableCubo);

        EsferaInfo = GameObject.Find("Esfera").GetComponent<EsferaColor>();
        //Debug.LogWarning("El valor de la Esfera es " + EsferaInfo.VariableEsfera);

        VariableCapsula = CuboInfo.VariableCubo && EsferaInfo.VariableEsfera;
        //Debug.Log(VariableCapsula);

        if (CuboInfo.VariableCubo && EsferaInfo.VariableEsfera)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = ColorVerdadero;
            //Debug.LogError(CuboInfo.VariableCubo + " y " + EsferaInfo.VariableEsfera);
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material.color = ColorFalso;
            //Debug.LogError(CuboInfo.VariableCubo + " y " + EsferaInfo.VariableEsfera);

        }



    //Color Rndm = new Color(Random.value, Random.value, Random.value);
    //GetComponent<MeshRenderer>().material.color = Rndm;

}
}
