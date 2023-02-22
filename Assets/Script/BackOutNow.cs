using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackOutNow : MonoBehaviour
{
    [SerializeField] GameObject Light;
    [SerializeField] GameObject disableCanvas;

    public void GoBack()
    {
        gameObject.SetActive(false);
    }

    public void EnableOtherCanvas()
    {
        gameObject.SetActive(false);
    }

    public void TurnOnLight()
    {
        Light.SetActive(true);
        disableCanvas.SetActive(false);
    }
}
