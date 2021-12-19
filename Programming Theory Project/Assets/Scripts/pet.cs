using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pet : MonoBehaviour
{


    [SerializeField] public Plates plate;
    [SerializeField] public static Animator ani;
    [SerializeField] private  int runAnima;
    [SerializeField] public int run
    {
        get 
    }

        [SerializeField] public static float speed { get; } = 1;
   


    // Start is called before the first frame update
    void Start()
    {

        ani = GetComponent<Animator>();
    }


    //This method is triggered when the variable of the platefull class class is true, 
    //    causing the objects with the pet class to slide forward, to be able to find their respective food
    public virtual void Eat(bool fullPlate)

    {
        if (fullPlate)
        {


            transform.Translate(Vector3.forward * speed * Time.deltaTime);


        }
    }

    //this method is triggered when the pet object collides with its food.causing the food object to be destroyed, 
    //stop the pet object and make the plate full variable of the plates class false
    public void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("food"))
        {
            Destroy(other.gameObject);
            transform.Translate(Vector3.zero);
            plate.fullPlate = false;

        }


    }
    //This class controls the animations of pet objects, if the plate full variable is false the pets will be stationary, 
    //    but if plate full is true it will change the animation from stationary to running.
    public void Move()
    {
        if (plate.fullPlate)
        
        {
            ani.SetFloat("VelX", 1);
        }
        else
        {
            ani.SetFloat("VelX", 0);

        }


    }

   
}

