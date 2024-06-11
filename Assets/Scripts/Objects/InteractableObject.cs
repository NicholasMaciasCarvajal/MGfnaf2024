using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    // Variables publicas
    public UnityEvent onIntect;

    public void Interact()
    {
        onIntect.Invoke();
    }
}
