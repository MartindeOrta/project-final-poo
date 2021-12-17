using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plates : MonoBehaviour

{
    [SerializeField] public string kindPet;
    public bool fullPlate;
    public string NameFood;
    public bool prueva;
    public GameObject foodGameObjets;



    // Start is called before the first frame update
    void Start()
    {
        fullPlate = false;
    }

    // Update is called once per frame
    void Update()
    { 
    }


    private void selectFood()
    {

    }
    public void OnMouseDown()
    {
        Debug.Log(kindPet);
        if (fullPlate == false)
        {
            SpawnFood(foodGameObjets);
            fullPlate = true;
        }

    }
    public void SpawnFood(GameObject foodPrefab)
    {
        Vector3 positionFood = gameObject.transform.position + new Vector3(0f, 0.35f, 0f );
        Instantiate(foodPrefab,positionFood, foodPrefab.transform.rotation);
    }

    //public void OnCollisionEnter(Collision collision)
    //{

    //    if (collision.gameObject.name)
    //        Destroy(foodGameObjets);
    //        fullPlate = false;
    //        Debug.Log("colliciono");

    //    }
    //}
    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Pet"))
    //    {
    //        Destroy(foodGameObjets);
    //        fullPlate = false;
    //    }
    //}
 
}
