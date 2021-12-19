using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetDog : pet
{
    void Update()
    {

        Eat(plate.fullPlate);
        Move();

    }
    public override void Eat(bool fullPlate)

    {
        if (fullPlate)
        {


            transform.Translate(Vector3.forward * 3 * Time.deltaTime);


        }
    }


}
