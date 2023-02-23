using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelapEnable : MonoBehaviour
{
    public float duration = 9.0f;
    [SerializeField] GameObject enableObject;

    void Start()
    {
        StartCoroutine(EnableAfterDuration());
    }

    IEnumerator EnableAfterDuration()
    {
        yield return new WaitForSeconds(duration);
        enableObject.SetActive(true);
    }
}
