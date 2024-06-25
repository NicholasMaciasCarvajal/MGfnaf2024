using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Variables Publicas

    // Variables Privadas
    private bool isOpen;
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        // Inicializacion de Variables
        animator = GetComponent<Animator>();
        isOpen = true;
        UpdateAnimation();
    }

    // Funcion para cambiar el estado de la puerta
    public void SetIsOpen(bool _state)
    {
        isOpen = _state;
        UpdateAnimation();
    }

    // Funcion para regresar el estado de la puerta
    public bool IsOpen()
    {
        return isOpen;
    }

    // Funcion para actualizar el parametro del controller
    void UpdateAnimation()
    {
        animator.SetBool("isOpen", isOpen);    
    }

}