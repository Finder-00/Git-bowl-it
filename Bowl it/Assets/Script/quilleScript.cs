using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quilleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision infosCollision)
    {
        if(infosCollision.gameObject.tag == "boulle")
        {
            // on active la gravite
            GetComponent<Rigidbody>().useGravity = true;

            // on ajoutes les points

            // on detruit la quille
        }
    }
}
