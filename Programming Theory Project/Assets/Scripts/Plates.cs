using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plates : MonoBehaviour

{
    [SerializeField] public string kindPet;
    [SerializeField] public bool fullPlate;
    [SerializeField] public GameObject foodGameObjets;




    // Start is called before the first frame update
    void Start()
    {
        
        fullPlate = false;
    }

    
    //by left clicking it is checked if the plate is full, if it is full it does nothing, but if it is empty(plateFull == false)
    //    the food appears on the plate and changes the value plate full to true.
    public void OnMouseDown()
    {
        Debug.Log(kindPet);
        if (fullPlate == false)
        {
            SpawnFood(foodGameObjets);
            fullPlate = true;
        }

    }

    //this method makes the food appear on each different plate
    public void SpawnFood(GameObject foodPrefab)
    {
        Vector3 positionFood = gameObject.transform.position + new Vector3(0f, 0.35f, 0f);
        Instantiate(foodPrefab, positionFood, foodPrefab.transform.rotation);
    }


}
