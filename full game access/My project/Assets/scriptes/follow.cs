using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class follow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject doctor;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, doctor.transform.position, speed*Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(12);
    }
}
