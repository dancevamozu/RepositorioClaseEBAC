using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilindroColor : MonoBehaviour
{
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
        CapsulaColor CapsulaInfo;
        CapsulaColorB CapsulaBInfo;
        CapsulaInfo = GameObject.Find("Capsula").GetComponent<CapsulaColor>();
        //Debug.LogWarning("El valor de la Capsula es " + CapsulaInfo.VariableCapsula);

        CapsulaBInfo = GameObject.Find("CapsulaB").GetComponent<CapsulaColorB>();
        //Debug.LogWarning("El valor de la Capsula B es " + CapsulaBInfo.VariableCapsulaB);


        if (CapsulaInfo.VariableCapsula || CapsulaBInfo.VariableCapsulaB)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = ColorVerdadero;
            Debug.LogWarning(CapsulaInfo.VariableCapsula + " y " + CapsulaBInfo.VariableCapsulaB);

        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material.color = ColorFalso;
            Debug.LogError(CapsulaInfo.VariableCapsula + " y " + CapsulaBInfo.VariableCapsulaB);

        }

    }

}
