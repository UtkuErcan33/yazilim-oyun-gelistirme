using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kodlama : MonoBehaviour
{
    public Text degisenmetin;
    public Text isimmetni;
    public Text telefonmetni;
    public Text emailmetni;
    public Text konummetni;
    public Text hakk�mdametni;

    void Start()
    {
         ac�l�s();

    }
    void Update()
    {

    }
    public void telefon(string telefon)
    {
        telefonmetni.text = telefon;
        degisenmetin.text = "05345442440";
    }
    public void email(string email)
    {
        degisenmetin.text = "utku.ercan.3368@gmail.com";
    }
    public void konum(string konum)
    {
        degisenmetin.text = "Mersin/Erdemli";
    }
    public void hakk�mda(string hakk�mda)
    {
        degisenmetin.text = "F�rat �nisinde Yaz�l�m m�hendisli�inde okuyorum 1. s�n�f�m ilk senemde kazand�m ve ilk senemde haz�rl�k okudum oyun geli�tiricisi olmak istiyorum";
    }


    public void ac�l�s()
    {
        isimmetni.text = "UTKU MUSTAFA ERCAN";
        degisenmetin.text = "Merhabalar ";
        telefonmetni.text = "TELEFON NUMARAM";
        emailmetni.text = "E-mail";
        konummetni.text = "Ya�ad���m Yer";
        hakk�mdametni.text = "Hakk�mda";
    }
}
