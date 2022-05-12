using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboColor : MonoBehaviour
{
    public bool VariableCubo = true;
    Color ColorVerdadero = new Color(250f / 255f, 250f / 255f, 250f / 255f);
    Color ColorFalso = new Color(0f / 255f, 0f / 255f, 0f / 255f);

    //private void Awake()
    //{
    //    Color Rndm = new Color(Random.value,Random.value,Random.value);
    //    GetComponent<MeshRenderer>().material.color = Rndm;
    //}

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
        if (VariableCubo == true)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = ColorVerdadero;
            //Debug.Log("la variable del cubo era verdadera, ahora es falsa");
            VariableCubo = false;

        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material.color = ColorFalso;
            //Debug.Log("la variable del cubo era falsa, ahora es verdadera");
            VariableCubo = true;

        }
    }

    public static implicit operator CuboColor(string v)
    {
        throw new NotImplementedException();
    }
}
