using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class PetCat : pet
{
    void Update()
    {

        Eat(plate.fullPlate);
        Move();

    }

}
