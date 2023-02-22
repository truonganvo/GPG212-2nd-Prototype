using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickToInteract : MonoBehaviour
{
    private Renderer render;
    [SerializeField] GameObject objects;

    private void Start()
    {
        render= GetComponent<Renderer>();
        objects.SetActive(false);
    }

    private void OnMouseDown()
    {
        Debug.Log("Click");
        objects.SetActive(true);
    }

    private void Update()
    {

    }
}
