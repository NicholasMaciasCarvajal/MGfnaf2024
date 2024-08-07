using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    //Variables publicas
    public GameObject cube;
    public Light mylight;

    // Update is called once per frame
    void Update()
    {
        MoveCube();   
    }

    void MoveCube()
    {
        //cube.transform.position = new Vector3(cube.transform.position.x -1f * Time.deltaTime, cube.transform.position.y, cube.transform.position.z);
        cube.transform.Translate(new Vector3(1f * Time.deltaTime, 0f ,0f));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mylight.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mylight.enabled = false;
        }
    }

}
