using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneManager : MonoBehaviour
{
    public Image scene1;
    public Image scene2;
    public Image scene3;
    public Image scene4;
    public Image scene5;
    public Image scene6;
    public Image scene7;
    public Image scene8;
    public Image scene9;
    public Image scene10;
    public Image scene11;
    public Image scene12;
    public Image scene13;
    public Image scene14;
    public Image scene15;
    public Image scene16;
    public Image scene17;
    public Image scene18;
    public Image scene19;
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
            }else if (cut == 1)
            {
                cut++;
                scene2.gameObject.SetActive(false);
                scene3.gameObject.SetActive(true);
            }
            else if (cut == 2)
            {
                cut++;
                scene3.gameObject.SetActive(false);
                scene4.gameObject.SetActive(true);
            }
            else if (cut == 3)
            {
                cut++;
                scene4.gameObject.SetActive(false);
                scene5.gameObject.SetActive(true);
            }
            else if (cut == 4)
            {
                cut++;
                scene5.gameObject.SetActive(false);
                scene6.gameObject.SetActive(true);
            }
            else if (cut == 5)
            {
                cut++;
                scene6.gameObject.SetActive(false);
                scene7.gameObject.SetActive(true);
            }
            else if (cut == 6)
            {
                cut++;
                scene7.gameObject.SetActive(false);
                scene8.gameObject.SetActive(true);
            }
            else if (cut == 7)
            {
                cut++;
                scene8.gameObject.SetActive(false);
                scene9.gameObject.SetActive(true);
            }
            else if (cut == 8)
            {
                cut++;
                scene9.gameObject.SetActive(false);
                scene10.gameObject.SetActive(true);
            }
            else if (cut == 9)
            {
                cut++;
                scene10.gameObject.SetActive(false);
                scene11.gameObject.SetActive(true);
            }
            else if (cut == 10)
            {
                cut++;
                scene11.gameObject.SetActive(false);
                scene12.gameObject.SetActive(true);
            }
            else if (cut == 11)
            {
                cut++;
                scene12.gameObject.SetActive(false);
                scene13.gameObject.SetActive(true);
            }
            else if (cut == 12)
            {
                cut++;
                scene13.gameObject.SetActive(false);
                scene14.gameObject.SetActive(true);
            }
            else if (cut == 13)
            {
                cut++;
                scene14.gameObject.SetActive(false);
                scene15.gameObject.SetActive(true);
            }
            else if (cut == 14)
            {
                cut++;
                scene15.gameObject.SetActive(false);
                scene16.gameObject.SetActive(true);
            }
            else if (cut == 15)
            {
                cut++;
                scene16.gameObject.SetActive(false);
                scene17.gameObject.SetActive(true);
            }
            else if (cut == 16)
            {
                cut++;
                scene17.gameObject.SetActive(false);
                scene18.gameObject.SetActive(true);
            }
            else if (cut == 17)
            {
                cut++;
                scene18.gameObject.SetActive(false);
                scene19.gameObject.SetActive(true);
            }
        }
    }
}
