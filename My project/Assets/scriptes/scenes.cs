using Newtonsoft.Json.Bson;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class scenes : MonoBehaviour
{
   

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {

       
      
    }
     public void rightanswer()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void wronganswer()
    {
        SceneManager.LoadScene(12);
    }
    public void true_or_false()
    {
        SceneManager.LoadScene(13);
    }
    public void return_true_or_false()
    {
        SceneManager.LoadScene(10);
    }
    public void return_to_scene()
    {
        SceneManager.LoadScene(1);
    }
   
    
}


