using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kodlama : MonoBehaviour
{
    public Text degisenmetin;
    public Text telefonmetni;
    public Text emailmetni;
    public Text konummetni;
    public Text linkedinmetni;
    public Dropdown seçim;
    public Image resimler;
    public Sprite utku;
    public Sprite birlikte;
    public Sprite esma;



    void Start()
    {
         acýlýs();

    }
    void Update()
    {
        fotogetirme();
    }

   

    public void acýlýs()
    {
      
        degisenmetin.text = "Merhabalar ";
        telefonmetni.text = "TELEFON NUMARAM";
        emailmetni.text = "E-mail";
        konummetni.text = "Yaþadýðým Yer";
        linkedinmetni.text = "linkedin adresi";
        
    }

      





    public void utkunun()
    {
        telefonmetni.text = "05345442440";
        emailmetni.text = "utku.ercan.3368@gmail.com";
        konummetni.text = "Mersin/Erdemli";
        linkedinmetni.text = "utku.ercan.3368";
        degisenmetin.text = "Fýrat ünisinde Yazýlým mühendisliðinde okuyorum 1. sýnýfým ilk senemde kazandým ve ilk senemde hazýrlýk okudum oyun geliþtiricisi olmak istiyorum";
        
            }


    public void esmanýn()
    {
        telefonmetni.text = "05367970904";
        emailmetni.text = "esmaberfin4114@gmail.com";
        konummetni.text = "Kocaeli/Ýzmit";
        linkedinmetni.text = "esma.berfin.4114";
        degisenmetin.text = "Fýrat ünisinde Yazýlým mühendisliðinde okuyorum 1. sýnýfým 1 sene mezuna kaldým ve yapay zeka alanýnda ilerlemek istiyorum yaný sýra grafik tasraýmýda yapmayý istiyorum"; 


    }
    public void fotogetirme()
    {
        if (seçim.value==0)
        {
            resimler.sprite = birlikte;
            acýlýs();
        }
        else if (seçim.value == 1)
        {
            resimler.sprite = utku;

            utkunun();
        }
        else
        {
            resimler.sprite = esma;
            esmanýn();
        }
    }
}
