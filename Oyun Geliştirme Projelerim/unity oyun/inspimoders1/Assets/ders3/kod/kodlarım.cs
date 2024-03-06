using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class kodlarım : MonoBehaviour
{
    public Text sorununsayisi;
    public Text sorununbasligi;
    public Text sorununmetni;
    public Text sayacmetni;
    public Text aşıkkımetni;
    public Text bşıkkımetni;
    

    public Image sayacresmi;


    public float sayac = 10;


    public string dogrucevap = "Zafer";




    void Start()
    {
        soruüret();
    }
    
    
    void Update()
    {
        if (sayac > 0)
        {
            sayac = sayac - Time.deltaTime;
            sayacmetni.text = sayac.ToString();
            


        }
        else if(sayac<=0)
        {
            sayacmetni.text = "";
            sayacresmi.gameObject.SetActive(false);
            sorununmetni.text = "ÜZGÜNÜM SÜRE BİTTİ";

        }
    }public void soruüret()
    {
        sorununsayisi.text = "1";
        sorununbasligi.text = "Genel/KÜltür";
        sorununmetni.text = "UTKU isminin anlamı nedir ?";
        aşıkkımetni.text = "Zafer";
        bşıkkımetni.text = "Zarafet";
    }


    public void DogrulukKontrol(string cevap)
    {
        dogrucevap = "Zafer";
        if (dogrucevap == cevap)
        {
            sorununmetni.text = "Tebrikler doğru bildiniz";
            sayacmetni.text = "0";
            sayacresmi.gameObject.SetActive(false);
        }
        else
        {
            sorununmetni.text = "Üzgünüm yanlış cevap";
            sayacmetni.text = "0";
            sayacresmi.gameObject.SetActive(false);
        }

    }
}
