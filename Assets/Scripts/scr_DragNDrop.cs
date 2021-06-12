using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_DragNDrop : MonoBehaviour
{
    public bool InsideComponent;

    public GameObject InstancePoint;
    private Vector3 offset;
    private Camera cam;

    private float TempX;

    private float PivotXRight;
    private float PivotXLeft;

    private float TempY;

    private float PivotYUP;
    private float PivotYDown;


    public bool InsideGrid = false;

    //private Vector3 GridOffset = new Vector3(16, -16, 0);
    void Awake()
    {
        cam = Camera.main;
        InstancePoint = GameObject.FindGameObjectWithTag("Spawnpoint");
    }

    void OnMouseUp()
    {
        //If Abfrage für position (Inventar oder Platziert)        
        if (InsideGrid == true)
        {
            if (Math.Abs(TempX - PivotXLeft) > Math.Abs(TempX - PivotXRight))
                transform.position = new Vector3(PivotXRight, transform.position.y, 0);
            else transform.position = new Vector3(PivotXLeft, transform.position.y, 0);

            if (Math.Abs(TempY - PivotYUP) > Math.Abs(TempY - PivotYDown))
                transform.position = new Vector3(transform.position.x, PivotYDown, 0);
            else transform.position = new Vector3(transform.position.x, PivotYUP, 0);

            //transform.position = new Vector3((TempX - TempX % 32 + 16), (TempY - TempY % 32 - 16), 0);        
        }

        else transform.position = InstancePoint.transform.position; 
        gameObject.GetComponent<scr_ComponentPowerCheck>().active = true;

        if(InsideComponent == true) transform.position = InstancePoint.transform.position;
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

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(collision);
        if(collision.tag == "Component")
        {
            InsideComponent = true;
        }

        if(collision.tag == "Grid")
        {
            InsideGrid = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision);
        if (collision.tag == "Component")
        {
            InsideComponent = false;
        }

        if (collision.tag == "Grid")
        {
            InsideGrid = false;
        }
    }

    Vector3 GetMousePos()
    {
        var mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }

    private void Update()
    {
        PivotXLeft = TempX - TempX % 32 -16;
        PivotXRight = TempX - TempX % 32 + 16;

        PivotYUP = TempY - TempY % 32 + 16;
        PivotYDown = TempY - TempY % 32 - 16;

        TempX = transform.position.x;
        TempY = transform.position.y;
    }

}
