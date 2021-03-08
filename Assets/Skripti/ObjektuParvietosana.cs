using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private RectTransform transformacijuLogs;
    public Canvas kanva;

    private void Awake()
    {
        transformacijuLogs = GetComponent<RectTransform>();

    }

    public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log("Kreisais klikšķis uz pārvietojamā objekta!");
    }

    public void OnBeginDrag(PointerEventData notikums)
    {
        Debug.Log("Uzsākta pārvietošana!");
    }

    public void OnDrag(PointerEventData notikums)
    {
        transformacijuLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;

    }

    public void OnEndDrag(PointerEventData notikums)
    {
        Debug.Log("Vilkšana pabeigta!");
    }
}
