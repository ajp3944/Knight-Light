using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneManager : MonoBehaviour
{
    public Image scene1;
    public Image scene2;
    int cut = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            if(cut == 0)
            {
                cut++;
                scene1.gameObject.SetActive(false);
                scene2.gameObject.SetActive(true);
            }
        }
    }
}
