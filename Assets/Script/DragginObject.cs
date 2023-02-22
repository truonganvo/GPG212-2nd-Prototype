using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragginObject : MonoBehaviour
{
    [SerializeField] private Canvas draggedObject;
    public void DragHandler(BaseEventData data) 
    { 
        PointerEventData pointerData = (PointerEventData)data;

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)draggedObject.transform, pointerData.position, draggedObject.worldCamera, out position);

        transform.position = draggedObject.transform.TransformPoint(position);
    }
}
