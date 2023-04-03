using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCubeScript : MonoBehaviour
{
    public GameObject sphere;
   
    

   

    public void Awake()
    {
      
        sphere = GameObject.Find("Sphere");
    }

    public void Damage()
    {
        Destroy(gameObject);
        Debug.Log("Wrong");
        

    }

    public void transformIntoSphere()
    {
        Debug.Log("Correct");
        
        Instantiate(sphere, transform.position, transform.rotation);
        Destroy(gameObject);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Red")
        {
            Destroy(collision.gameObject);
            Damage();
        }
        else
        {
            Destroy(collision.gameObject);
            transformIntoSphere();
        }
    }
}