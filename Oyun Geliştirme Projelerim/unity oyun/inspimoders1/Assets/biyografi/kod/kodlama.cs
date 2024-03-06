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
    public Text hakkýmdametni;

    void Start()
    {
         acýlýs();

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
    public void hakkýmda(string hakkýmda)
    {
        degisenmetin.text = "Fýrat ünisinde Yazýlým mühendisliðinde okuyorum 1. sýnýfým ilk senemde kazandým ve ilk senemde hazýrlýk okudum oyun geliþtiricisi olmak istiyorum";
    }


    public void acýlýs()
    {
        isimmetni.text = "UTKU MUSTAFA ERCAN";
        degisenmetin.text = "Merhabalar ";
        telefonmetni.text = "TELEFON NUMARAM";
        emailmetni.text = "E-mail";
        konummetni.text = "Yaþadýðým Yer";
        hakkýmdametni.text = "Hakkýmda";
    }
}
