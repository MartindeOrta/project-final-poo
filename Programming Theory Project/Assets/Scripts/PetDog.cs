using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetDog : pet
{
    public Plates plate;
    // Start is called before the first frame update
    void Start()
    {
        plate = GameObject.Find("PlateDog").GetComponent<Plates>();
        myFood = "Dog";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (plate.transform.position - transform.position).normalized;
        Eat(lookDirection, plate.fullPlate);
    }
}
