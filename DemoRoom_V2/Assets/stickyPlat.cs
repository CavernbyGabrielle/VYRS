using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickyPlat : MonoBehaviour
{
    public GameObject Player;
    bool isTouch;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Player)
        {
            isTouch = true;

            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isTouch = false;
        
    }

    void FixedUpdate()
    {
        if (isTouch == true)
        {
            Player.transform.parent = transform;
        }

        else
        {
            Player.transform.parent = null;
        }

    }

}

