using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{

    public Camera cam;
    public Rigidbody rb;
    public float movespeed;
    public float hight;
    public bool over;
    public float overPos;
    public float move;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        if (transform.position.z < overPos)
        {

           
            Vector3 vektorGO = new Vector3(move * Time.deltaTime * movespeed, rb.velocity.y, rb.velocity.z * 2);
            if (Input.GetKeyDown(KeyCode.Return)) rb.velocity = vektorGO;

            Vector3 vektor = new Vector3(move * Time.deltaTime * movespeed, rb.velocity.y, 42);

            rb.velocity = vektor;
            cam.transform.position = new Vector3(transform.position.x, transform.position.y + hight, transform.position.z - 10);
        }
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
