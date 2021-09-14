using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{

    Vector3 blep, blep2;
    Transform item;
    bool get;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        blep = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        blep2 = new Vector3(blep.x, blep.y, blep.z + 10);

        RaycastHit2D hit = Physics2D.Raycast(blep, blep2); 

        

        if(item != null)
        {
            if (Input.GetMouseButtonDown(0) && !get)
            {
                //do the animation
                get = true;
            }
            else if(Input.GetMouseButtonUp(0) && get)
            {
                //stops the animation  
                get = false;
            }

            if (get && Input.GetMouseButton(0))
            {
                item.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                item.transform.position = new Vector3(item.transform.position.x, item.transform.position.y, 0);

                //Debug.Log("eita");
            }

        }

        if (hit)
        {
            if (hit.transform.CompareTag("Grab"))
            {
                item = hit.transform;

            }
            else if(!get)
            {
                item = null;
            }
        }
        else if (!get)
        {
            item = null;
        }

    }
}
