using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_menu_button : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
    }
}
