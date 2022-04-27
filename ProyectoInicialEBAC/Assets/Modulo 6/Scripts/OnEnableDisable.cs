using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnableDisable : MonoBehaviour
{
    public GameObject PrefabCubo;

    void OnDisable()
    {
        GameObject GameObjectTemp = Instantiate<GameObject>(PrefabCubo);
        GameObjectTemp.name = "Cubo rojo";
        Color c = new Color(192f / 255f, 0f / 255f, 0f / 255f);
        GameObjectTemp.GetComponent<MeshRenderer>().material.color = c;
        GameObjectTemp.GetComponent<Rigidbody>();
        GameObjectTemp.transform.position = new Vector3(6, 0, 0);
        Debug.Log("Se creó un cubo rojo en Disable");
    }

    void OnEnable()
    {
        GameObject GameObjectTemp = Instantiate<GameObject>(PrefabCubo);
        GameObjectTemp.name = "Cubo Azul";
        Color c = new Color(65f / 255f, 118f / 255f, 175f / 255f);
        GameObjectTemp.GetComponent<MeshRenderer>().material.color = c;
        GameObjectTemp.GetComponent<Rigidbody>();
        GameObjectTemp.transform.position = new Vector3(4, 0, 0);
        Debug.Log("Se creó un cubo azul en Enable");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
