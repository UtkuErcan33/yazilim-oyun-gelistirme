using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haftaaltı : MonoBehaviour
{
  
    public float hız = 10f;

    public Animator animasyon;





    void Update()
    {
        objehareketi();
        karakterhareketleri();


    }

    public void objehareketi()
    {
        //x ve z ekseninde hareket sağlıcaz
        float xekseni = Input.GetAxis("Horizontal");
        float zekseni = Input.GetAxis("Vertical");
       
        //yukardaki verileri  vectöre atadık
        Vector3 harekersistemi = new Vector3(xekseni, 0.0f, zekseni);
        
       //almış olduğumuz vektör deeğerlerini karaktere atadık
        this.transform.position += harekersistemi*hız*Time.deltaTime;

    }

    public void karakterhareketleri()
    {
        
      if (Input.GetKey(KeyCode.W))
        {
            animasyon.SetBool("ileri yürüme", true);
        }
        else
        {
            animasyon.SetBool("ileri yürüme", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animasyon.SetBool("sola yürüme", true);
        }
        else
        {
            animasyon.SetBool("sola yürüme", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animasyon.SetBool("sağa yürüme", true);
        }
        else
        {
            animasyon.SetBool("sağa yürüme", false);
        }


    }
}
