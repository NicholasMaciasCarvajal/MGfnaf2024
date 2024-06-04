using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    // Variables publicas
    public GameObject mylight;
    public Light myLightComponent;

    // Variable privada 
    private bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        isOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        SwitchLight();
    }

    void SwitchLight()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            if (isOn) 
            {
                //mylight.SetActive(false);
                //mylight.GetComponent<Light>().enabled = false;
                //mylight.GetComponent<Light>().intensity = 1F;
                myLightComponent.enabled = false;
                isOn = false;
            }
            else 
            {
                //mylight.SetActive(true);
                //mylight.GetComponent<Light>().enabled = true;
                //mylight.GetComponent<Light>().intensity = 1F;
                myLightComponent.enabled = true;
                isOn = true;
            }
        }
    }
}
