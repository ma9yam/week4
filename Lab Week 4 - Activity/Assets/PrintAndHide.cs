using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    public int i;
    int randomNumber;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        randomNumber = Random.Range(200, 250);
   
        
            
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + i);
        i++;

        if (gameObject.tag =="red" && i ==100)
        {
            gameObject.SetActive(false);
           }
        if (gameObject.tag == "blue" && i == randomNumber)
            rend.enabled = false;
    }
}
