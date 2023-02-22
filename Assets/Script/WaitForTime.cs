using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForTime : MonoBehaviour
{
    public float duration = 5.0f;

    void Start()
    {
        StartCoroutine(DisableAfterDuration());
    }

    IEnumerator DisableAfterDuration()
    {
        yield return new WaitForSeconds(duration);
        gameObject.SetActive(false);
    }
}
