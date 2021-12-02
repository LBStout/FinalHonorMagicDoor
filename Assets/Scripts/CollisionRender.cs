using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionRender : MonoBehaviour
{
    bool isCollided;
    GameObject[] inside;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter(Collider other)
    {

        //isCollided = true;
        if (other.CompareTag("Wall") && isCollided == false)
        {
            isCollided = true;
            inside = GameObject.FindGameObjectsWithTag("Inside");
            for (int i = 0; i <= inside.Length; i++)
            {
                inside[i].SetActive(false);
            }
            //Debug.Log("Hitting a wall");
        }

        if (other.CompareTag("Wall") && isCollided == true)
        {
            isCollided = false;
            for (int i = 0; i <= inside.Length; i++)
            {
                inside[i].SetActive(true);
            }
            //Debug.Log("Leaving a wall");
        }

    }
}
