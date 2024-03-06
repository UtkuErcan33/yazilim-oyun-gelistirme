using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sayac: MonoBehaviour
{
    public Text hello;
    public Text sayactext;

    public Image sayacresmi;

    public float sayac1 = 10;
    void Start()
    {
       
    }

   
    void Update()
    {
        sayac1 = sayac1 - Time.deltaTime;
        if(sayac1>0)
        {
            sayactext.text = sayac1.ToString();
            hello .text = " ders baþladý";
        }
        else if(sayac1<=0)
        {
            sayac1 = 0;
            hello .text = " ders bitti";
            sayacresmi.gameObject.SetActive(false);
            sayactext.text = "";
        }
    }
}
