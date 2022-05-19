using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{

    public GameObject myCube;

    public bool wasPressed;

    // Start is called before the first frame update
    void Start()
    {
        wasPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myCube.SetActive(!myCube.activeInHierarchy);
            
            /*if (myCube.activeInHierarchy)
            {
                myCube.SetActive(false);
            }
            else
            {
                myCube.SetActive(true);
            }*/

            /*if(wasPressed == false)
            {
                myCube.SetActive(false);
                wasPressed = true;
            }
            else
            {
                myCube.SetActive(true);
                wasPressed = false;
            }*/
        }
    }
}
