using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackOutNow : MonoBehaviour
{
    [SerializeField] GameObject Light;
    [SerializeField] GameObject disableCanvas;
    [SerializeField] AudioSource SFX;
    [SerializeField] AudioClip SFXClip;

    private void Awake()
    {
        SFXClip = SFX.clip;
    }
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
        SFX.Play();
    }
}
