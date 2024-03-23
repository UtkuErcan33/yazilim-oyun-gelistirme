using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeminyanması : MonoBehaviour
{

  

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("zemin"))
        {
            Debug.Log("oyun bitti");
            besinciders.kopya.skor = 0;
            besinciders.kopya.karakter.transform.position = new Vector3(0, 6, -3);
        }
        if (other.gameObject.CompareTag("başarılıengel"))
        {
            besinciders.kopya.skor ++;

        }
        if (other.gameObject.CompareTag("başadön"))
        {
            besinciders.kopya.karakter.transform.position = new Vector3(0, 6, -3);
            
        }
    }
}
