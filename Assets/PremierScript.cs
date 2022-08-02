using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PremierScript : MonoBehaviour
{
    public float Speed = 10f;
    public float rotationSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bonjour !");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Bonjour !");

        //Translation
        //gameObject.transform.Translate(new Vector3(0,0,0.01f));
       
        
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
             transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * Speed);
        }
        
            float translation = Input.GetAxis("Vertical") * Speed;
            float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

            translation *= Time.deltaTime;
            rotation *= Time.deltaTime;

            // Move translation along the object's z-axis
            transform.Translate(0, 0, translation);

            // Rotate around our y-axis
            transform.Rotate(0, rotation, 0);
        

    }
}