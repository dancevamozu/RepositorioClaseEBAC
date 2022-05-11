using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaColor : MonoBehaviour
{
    public bool VariableEsfera = false;
    Color ColorVerdadero = new Color(250f / 255f, 250f / 255f, 250f / 255f);
    Color ColorFalso = new Color(0f / 255f, 0f / 255f, 0f / 255f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Color Rndm = new Color(Random.value, Random.value, Random.value);
        //GetComponent<MeshRenderer>().material.color = Rndm;
    }
    private void FixedUpdate()
    {
        if (VariableEsfera == true)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = ColorVerdadero;
            //Debug.LogWarning("la variable de la esfera era verdadera, ahora es falsa");
            VariableEsfera = false;

        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material.color = ColorFalso;
            //Debug.LogWarning("la variable de la esfera era falsa, ahora es verdadera");
            VariableEsfera = true;

        }

    }
}
