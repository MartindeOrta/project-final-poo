using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// INHERITANCE
public class PetParrot : pet
{  
    void Update()
    {    

        Eat(plate.fullPlate);
        Move();
    }

   

}
