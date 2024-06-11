using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    // Variables publicas
    public Transform cube;
    public float rotationSpeedy;
    public float rotationSpeedx;
    public float rotationSpeedz;
    public float rotationSpeed;

    // Variables privadas
    private float yRotation;



    // Start is called before the first frame update
    void Start()
    {
        yRotation = 0f;   
    }

    // Update is called once per frame
    void Update()
    {
        RotateObject(cube);
        Camera.main.transform.LookAt(cube);
    }

    void RotateObject(Transform _object)
    {
        //_object.Rotate(new Vector3(rotationSpeedx * Time.deltaTime, rotationSpeedy * Time.deltaTime, rotationSpeedz * Time.deltaTime), Space.World);
        yRotation += rotationSpeed * Time.deltaTime;
        _object.rotation = Quaternion.Euler(new Vector3(_object.rotation.eulerAngles.x, yRotation, _object.rotation.eulerAngles.z));
    }
}
