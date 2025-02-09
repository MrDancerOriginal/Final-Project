using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    //Коли телепортувати? (дія) - Виконано
    //Куди телепортувати? (властивість) - Виконано
    //Кого телепортувати? - Виконано
    //Як телепортувати? 

    //public Тип_даних Назва;
    public GameObject Teleport1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = Teleport1.transform.position;
    }
}
