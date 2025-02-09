using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VOscript : MonoBehaviour
{
    public AudioSource Audiosource ;

    public AudioClip Audioclip;







    private void OnTriggerEnter(Collider other)
    {
        Audiosource.clip = Audioclip;

        Audiosource.Play();


    }



    // Start is called before the first frame update
    void Start()
    {
        







    }

    // Update is called once per frame
    void Update()
    {
      
 
        
    }
}


