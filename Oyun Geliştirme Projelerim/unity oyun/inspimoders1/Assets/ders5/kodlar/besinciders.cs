using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class besinciders : MonoBehaviour
{
    

    public Text skortutucu;
  
    
    public int skor;
    public int hareketh�z�;
    public int z�plamah�z�;

    public bool oyundevamediyormu = true;


    public GameObject karakter;
    
    Vector3 eksenler;

    public Rigidbody fizik;

    public AudioSource z�plamasesi;
    public AudioClip fonsesi;



    public static besinciders kopya{ get; private set; }

    private void Awake()
    {
        if(kopya != null && kopya != this)
        {
            Destroy(this);
            return;
        }
        kopya= this;
        DontDestroyOnLoad(this.gameObject);
        
    }

    void Start()
    {
       
        skor = 0;
        skortutucu.text = "Skorun: "+skor;
        oyundevamediyormu=true;
    }

    void Update()
    {
         
         hareketet();
         z�plama();
        skortutucu.text = "Skorun: " + skor;
    }
    public void hareketet()
    {
     
        
            eksenler = karakter.transform.position;
            eksenler.z += Time.deltaTime*hareketh�z� * 0.1f ;
            karakter.transform.position = eksenler;
        
    }

    public void z�plama()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            fizik.AddForce(Vector3.up * z�plamah�z�, ForceMode.Impulse);
            z�plamasesi.PlayOneShot(fonsesi);
        }

    }
    
}
