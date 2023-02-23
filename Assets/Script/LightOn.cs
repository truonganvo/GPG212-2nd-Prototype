using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOn : MonoBehaviour
{
    [SerializeField] int pointsToUnlock;
    [SerializeField] int currentPoint;
    [SerializeField] GameObject unlockButton;


    // Update is called once per frame
    void Update()
    {
        if(currentPoint == pointsToUnlock)
        {
            unlockButton.SetActive(true);
        }
    }

    public void AddPoint()
    {
        currentPoint++;
    }
}
