using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // biblioteca de clases que me importará los eventos para detectar el táctil.

public class Android : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool pulsado = false;

    // Estoy pulsando el botón
    public void OnPointerDown(PointerEventData eventData)
    {
        pulsado = true;
    } 

    // He levantado el dedo del botón.
    public void OnPointerUp(PointerEventData eventData)
    {
        pulsado = false;
    }
}
