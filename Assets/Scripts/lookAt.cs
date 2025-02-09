using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAt : MonoBehaviour
{

  public Transform Target1;










    // Start is called before the first frame update
    void Start()
    {
        




    }

    // Update is called once per frame
    void Update()
    {

        // Rotate the camera every frame so it keeps looking at the target
        transform.LookAt(Target1);





    }
}
