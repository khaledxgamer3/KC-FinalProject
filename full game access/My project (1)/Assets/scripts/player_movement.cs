using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 move = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        }
           
    }
}
