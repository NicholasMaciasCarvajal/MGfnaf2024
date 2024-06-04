using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // Variables publicas
    public float number1, number2;
    public float[] numbers;

    // Variables privadas
    private float[] pNumbers = {1f,2f,3f,4f,5f };


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Numeber 1: " + number1 + "Number 2: " + number2);
        Debug.Log("Suma: " + Add(number1, number2));
        float _multiplicacion = Multiplicacion(number1, number2);
        Debug.Log("Multiplicacion " + Multiplicacion(number1, number2));
        Debug.Log("La sumatoria: " + Summation(numbers));
        Debug.Log("La sumatoria: " + Summation(pNumbers));

    }

    float Add(float _number1, float _number2)
    {
        return _number1 + _number2;
    }
    float Multiplicacion(float _number1, float _number2)
    {
        return _number1 * _number2;
    }

    float Summation(float[] _array)
    {
        float _summation = 0f;
        
        for (int i = 0; i < _array.Length; i++)
        {
            _summation += _array[i];
        }
        /*
        foreach (float _number in _array)
        {
            _summation += _number;
        }
        */
        return _summation;

    }
}
