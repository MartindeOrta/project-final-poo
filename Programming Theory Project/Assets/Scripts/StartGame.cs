using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    

    private void Start()
    {
       

    }
    //takes you to the game scene
    public void StartGameButton()
    {
        SceneManager.LoadScene(1);
    }


    //takes you to the menu scene
    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }

    
}


