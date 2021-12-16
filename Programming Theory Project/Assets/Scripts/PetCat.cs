using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetCat :pet
{
    private Animation ani;
    public Plates plate;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animation>();

        plate = GameObject.Find("PlateDog").GetComponent<Plates>();
        myFood = "Cat";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (plate.transform.position - transform.position).normalized;
        Eat(lookDirection, plate.fullPlate);
    }
}

