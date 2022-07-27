using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PremierScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Bonjour !");

        //Translation
        //gameObject.transform.Translate(new Vector3(0,0,0.01f));

        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        if (Input.GetAxis("Horizontal"))
        {
            
        }
    }
}
