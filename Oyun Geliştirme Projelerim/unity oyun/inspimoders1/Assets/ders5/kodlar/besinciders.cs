using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class besinciders : MonoBehaviour
{
    

    public Text skortutucu;
  
    
    public int skor;
    public int harekethýzý;
    public int zýplamahýzý;

    public bool oyundevamediyormu = true;


    public GameObject karakter;
    
    Vector3 eksenler;

    public Rigidbody fizik;

    public AudioSource zýplamasesi;
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
         zýplama();
        skortutucu.text = "Skorun: " + skor;
    }
    public void hareketet()
    {
     
        
            eksenler = karakter.transform.position;
            eksenler.z += Time.deltaTime*harekethýzý * 0.1f ;
            karakter.transform.position = eksenler;
        
    }

    public void zýplama()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            fizik.AddForce(Vector3.up * zýplamahýzý, ForceMode.Impulse);
            zýplamasesi.PlayOneShot(fonsesi);
        }

    }
    
}
