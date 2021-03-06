using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quilleScript : MonoBehaviour
{
    float lesPoints;
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
        if(infosCollision.gameObject.layer == 6 || infosCollision.gameObject.tag == "quille")
        {
            // Si la gravit? n'est pas activ?e
            if (!GetComponent<Rigidbody>().useGravity)
            {
                if (infosCollision.gameObject.tag == "pieuvre" || infosCollision.gameObject.tag == "quille")
                {
                    // on ajoutes les points
                    JoueurScript.points += 1;
                }

                if (infosCollision.gameObject.tag == "pufferfish")
                {
                    JoueurScript.points += 3;
                }

                if (infosCollision.gameObject.tag == "espadon")
                {
                    JoueurScript.points += 5;
                }
            }    
            // on active la gravit?
            GetComponent<Rigidbody>().useGravity = true;

        }
    }
}
