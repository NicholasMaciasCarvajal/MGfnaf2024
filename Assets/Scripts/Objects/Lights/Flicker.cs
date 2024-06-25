using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    // Variables Publicas
    public float minFlickInterval, maxFlickInterval;
    public float minLightIntensity;
    public float minFlickDuration, maxFlickDuration;


    // Variables Privadas
    private Light lightComponent;
    private float intervalTime, originalLightIntensity;
    private float flickDuration;


    // Start is called before the first frame update
    void Start()
    {
        // Inicializacion de Variables
        lightComponent = GetComponent<Light>();
        originalLightIntensity = lightComponent.intensity;
        intervalTime = Random.Range(minFlickInterval, maxFlickInterval);
    }

    // Update is called once per frame
    void Update()
    {
        Flick();
    }

    // Funcion de Parpadeo
    void Flick()
    {
        // Si se acabo el intevalo de tiempo entonces comenzamos el parpadeo
        if (intervalTime <= 0f)
        {
            // Atenuamos la luz, reseateamos el intervalo de tiempo y damos una duracion al parpadeo
            lightComponent.intensity = Random.Range(minLightIntensity, originalLightIntensity);
            intervalTime = Random.Range(minFlickInterval, maxFlickInterval);
            flickDuration = Random.Range(minFlickDuration, maxFlickDuration);
        }
        else
        {
            // Si aun queda tiempo de parpadeo seguimos esperando
            if(flickDuration > 0f)
            {
                flickDuration -= 1f * Time.deltaTime;
            }
            // Si ya termino el tiempo de parpadeo comenzamos el intervalo y reseteamos la intensidad de la luz
            else
            {
                intervalTime -= 1f * Time.deltaTime;
                lightComponent.intensity = originalLightIntensity;
            }
        }
    }


}