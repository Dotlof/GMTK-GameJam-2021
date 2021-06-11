using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_DragNDrop : MonoBehaviour
{

    private Vector3 offset;
    private Camera cam;

    void Awake()
    {
        cam = Camera.main;
    }

    void OnMouseUp()
    {
        //If Abfrage für position (Inventar oder Platziert)
        gameObject.GetComponent<scr_ComponentPowerCheck>().active = true;    
    }

    void OnMouseDown()
    {
        offset = transform.position - GetMousePos();    
    }

    void OnMouseDrag()
    {
        gameObject.GetComponent<scr_ComponentPowerCheck>().active = false;
        transform.position = GetMousePos() + offset;
    }

    Vector3 GetMousePos()
    {
        var mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }

}
