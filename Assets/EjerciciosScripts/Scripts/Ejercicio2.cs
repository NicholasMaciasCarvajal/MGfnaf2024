using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    [SerializeField] private int firstNumber, lastNumber, loop;

    // Start is called before the first frame update
    void Start()
    {
        switch (loop)
        {
            case 1:
                UsingForLoop();
                break;

            case 2:
                UsingWhileLoop();
                break;
            /*case 3:
                StartCoroutine(OnePersonalSecond);
                break;
            case 4:
                StartCoroutine(OnePerFrame);
                break;
            */
            default:
                Debug.Log("Numero invalido");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UsingForLoop()
    {
        for (int i = firstNumber; i <= lastNumber; i++)
        {
            Debug.Log(i);
            if (i == (int)Mathf.Lerp(firstNumber,lastNumber, 0.5f))
            {
                Debug.Log("Mitad del camino ");
            }
        }
        Debug.Log("Terminando con un ciclo for");
    }

    IEnumerator OnePersonalSecond()
    {
            for (int i = firstNumber; i <= lastNumber; i++)
            {
                Debug.Log(i);
                if (i == (int)Mathf.Lerp(firstNumber, lastNumber, 0.5f))
                {
                    Debug.Log("Mitad del camino ");
                }
                yield return new WaitForSeconds(1f);
            }
            Debug.Log("Terminando con un ciclo for");
    }

    IEnumerator OnePerFrame()
    {
        for (int i = firstNumber; i <= lastNumber; i++)
        {
            Debug.Log(i);
            if (i == (int)Mathf.Lerp(firstNumber, lastNumber, 0.5f))
            {
                Debug.Log("Mitad del camino ");
            }
            yield return null;
        }
        Debug.Log("Terminando con un ciclo for");
    }

    void UsingWhileLoop()
    {
        int _index = firstNumber;
        while (_index <= lastNumber) 
        {
            Debug.Log (_index);
            if (_index == (int)Mathf.Lerp(firstNumber, lastNumber, 0.5f))
            {
                Debug.Log("Mitad del camino ");
            }
            _index++;
        }
        Debug.Log("Se termina el ciclo while");
    }

}
