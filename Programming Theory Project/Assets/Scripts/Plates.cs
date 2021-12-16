using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plates : MonoBehaviour

{
    [SerializeField] public string kindPet;
    public bool fullPlate;
    public string NameFood;
    
    public List<GameObject> foodGameObjets;



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
            SpawnFood(foodGameObjets[0]);
            fullPlate = true;
        }

    }
    public void SpawnFood(GameObject foodPrefab)
    {
        Vector3 positionFood = gameObject.transform.position + new Vector3(0f, 0.35f, 0f );
        Instantiate(foodPrefab,positionFood, foodPrefab.transform.rotation);
    }
}
