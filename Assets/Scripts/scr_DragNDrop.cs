using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_DragNDrop : MonoBehaviour
{
    //public GameObject InstancePoint;
    private Vector3 offset;
    private Camera cam;

    private float TempX;
    private float TempY;


    public bool InsideGrid = false;

    //private Vector3 GridOffset = new Vector3(16, -16, 0);
    void Awake()
    {
        cam = Camera.main;
    }

    void OnMouseUp()
    {
        //If Abfrage für position (Inventar oder Platziert)        
        if (InsideGrid == true)
        {
            transform.position = new Vector3((TempX - TempX % 32 + 16), (TempY - TempY % 32 - 16), 0);        
        }

        //else transform.position = InstancePoint.transform.position; 

        

        gameObject.GetComponent<scr_ComponentPowerCheck>().active = true;    
    }

    void OnMouseDown()
    {
        offset = transform.position - GetMousePos();    
    }

    void OnMouseDrag()
    {
        gameObject.GetComponent<scr_ComponentPowerCheck>().active = false;
        //transform.position = GetMousePos() + offset;
        transform.position = GetMousePos();

    }

    Vector3 GetMousePos()
    {
        var mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }

    private void Update()
    {
        TempX = transform.position.x;
        TempY = transform.position.y;
    }

}
