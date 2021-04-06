using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimap : MonoBehaviour
{
    public GameObject Blackscreen;
    public GameObject cameraminimap;

    // Start is called before the first frame update
    void Start()
    {
        Blackscreen.SetActive(false);
        cameraminimap.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.B)){
            if(cameraminimap.activeSelf){
                Blackscreen.SetActive(false);
                cameraminimap.SetActive(false);
                return;
            } else {
                Blackscreen.SetActive(true);
                cameraminimap.SetActive(true);
                return;
            }
        }
    }
}
