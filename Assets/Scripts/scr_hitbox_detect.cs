using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_hitbox_detect : MonoBehaviour
{

    public bool InsideComponent;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Component")
        {
            InsideComponent = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Component")
        {
            InsideComponent = false;
        }
    }
}
