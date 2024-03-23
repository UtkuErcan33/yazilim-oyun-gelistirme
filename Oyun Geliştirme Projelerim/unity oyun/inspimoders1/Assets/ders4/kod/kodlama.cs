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
    public Dropdown se�im;
    public Image resimler;
    public Sprite utku;
    public Sprite birlikte;
    public Sprite esma;



    void Start()
    {
         ac�l�s();

    }
    void Update()
    {
        fotogetirme();
    }

   

    public void ac�l�s()
    {
      
        degisenmetin.text = "Merhabalar ";
        telefonmetni.text = "TELEFON NUMARAM";
        emailmetni.text = "E-mail";
        konummetni.text = "Ya�ad���m Yer";
        linkedinmetni.text = "linkedin adresi";
        
    }

      





    public void utkunun()
    {
        telefonmetni.text = "05345442440";
        emailmetni.text = "utku.ercan.3368@gmail.com";
        konummetni.text = "Mersin/Erdemli";
        linkedinmetni.text = "utku.ercan.3368";
        degisenmetin.text = "F�rat �nisinde Yaz�l�m m�hendisli�inde okuyorum 1. s�n�f�m ilk senemde kazand�m ve ilk senemde haz�rl�k okudum oyun geli�tiricisi olmak istiyorum";
        
            }


    public void esman�n()
    {
        telefonmetni.text = "05367970904";
        emailmetni.text = "esmaberfin4114@gmail.com";
        konummetni.text = "Kocaeli/�zmit";
        linkedinmetni.text = "esma.berfin.4114";
        degisenmetin.text = "F�rat �nisinde Yaz�l�m m�hendisli�inde okuyorum 1. s�n�f�m 1 sene mezuna kald�m ve yapay zeka alan�nda ilerlemek istiyorum yan� s�ra grafik tasra�m�da yapmay� istiyorum"; 


    }
    public void fotogetirme()
    {
        if (se�im.value==0)
        {
            resimler.sprite = birlikte;
            ac�l�s();
        }
        else if (se�im.value == 1)
        {
            resimler.sprite = utku;

            utkunun();
        }
        else
        {
            resimler.sprite = esma;
            esman�n();
        }
    }
}
