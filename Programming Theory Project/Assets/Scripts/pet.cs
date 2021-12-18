using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pet : MonoBehaviour
{
    public string myFood;
    public string seleccionFood;
    public bool full;
    public Plates plate;
    // Start is called before the first frame update
    void Start()
    {
        full = true;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   public void  Eat(Vector3 positionPlate, bool fullPlate)

    {       if (fullPlate)
        {
          
            transform.Translate(positionPlate * 1 * Time.deltaTime);

         
        }
           }
    public void OnCollisionEnter(Collision other)
    {
        full = true;
        if (other.gameObject.CompareTag("food"))
        {
            Destroy(other.gameObject);
            transform.Translate(Vector3.zero);
            plate.fullPlate = false;

        }

    
    }
}

