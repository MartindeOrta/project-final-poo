using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// INHERITANCE
public class PetDog : pet
{
    void Update()
    {

        Eat(plate.fullPlate);
        Move();

    }// POLIMORFISMO
    public override void Eat(bool fullPlate)

    {
        if (fullPlate)
        {


            transform.Translate(Vector3.forward * 3 * Time.deltaTime);


        }
    }


}
