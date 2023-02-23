using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSLot : MonoBehaviour, IDropHandler
{
    [SerializeField] LightOn switchToTurnOn;

    private void Awake()
    {
        switchToTurnOn.GetComponent<LightOn>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            switchToTurnOn.AddPoint();
        }
    }
}
