using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCuboUpdate : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> ListaDeCubos;
    public float FactorDeEscalamiento;
    public int NumCubos = 0;

    // Start is called before the first frame update
    void Start()
    {
        ListaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        NumCubos++;
        GameObject GameObjectTemp = Instantiate<GameObject>(PrefabCubo);
        GameObjectTemp.name = "Cubo numero" + NumCubos;
        Color c = new Color(Random.value,Random.value,Random.value);
        GameObjectTemp.GetComponent<MeshRenderer>().material.color = c;
        GameObjectTemp.transform.position = Random.insideUnitSphere;

        ListaDeCubos.Add(GameObjectTemp);
        List<GameObject> ObjetosParaEliminar = new List<GameObject>();
        foreach(GameObject go in ListaDeCubos)
        {
            float escala = go.transform.localScale.x;
            escala *= FactorDeEscalamiento;
            go.transform.localScale = Vector3.one * escala;

            if(escala <= 0.1)
            {
                ObjetosParaEliminar.Add(go);
            }

        }

        foreach(GameObject go in ObjetosParaEliminar)
        {
            ListaDeCubos.Remove(go);
            Destroy(go);
        }

    }
}
