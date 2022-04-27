using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color Rndm = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = Rndm;
    }
}
