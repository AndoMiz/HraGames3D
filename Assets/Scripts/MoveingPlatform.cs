using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveingPlatform : MonoBehaviour
{

    public float distance;
    public float speed;
    public Vector3 startPos;
    int mult = 1;
    public GameObject[] childs;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
       if(transform.position.x > startPos.x + distance && mult == 1)
       {
            mult = -1;
       }
       if (transform.position.x < startPos.x - distance && mult == -1)
       {
            mult = 1;
       }

        transform.position = new Vector3(transform.position.x + speed* Time.deltaTime* mult,transform.position.y,transform.position.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            foreach (GameObject i in childs)
            {
                i.transform.parent = null;
                speed = 0;
            }
        }
    }
}
