using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plates : MonoBehaviour

{
    [SerializeField] public string kindPed;
   
    public string NameFood;
    public string kindPet;
    public List<GameObject> foodGameObjets;



    // Start is called before the first frame update
    void Start()
    {
        
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
        Debug.Log(kindPed);
        SpawnFood(foodGameObjets[0], gameObject.transform.position);

    }
    public void SpawnFood(GameObject foodPrefab, Vector3 positionFood)
    {

        Instantiate(foodPrefab, positionFood, foodPrefab.transform.rotation);
    }
}
