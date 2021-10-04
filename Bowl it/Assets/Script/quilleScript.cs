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
        if(infosCollision.gameObject.layer == LayerMask.NameToLayer("ObjetInteractif"))
        {
            if (gameObject.tag == "quille") {
                // on active la gravite
                GetComponent<Rigidbody>().useGravity = true;

                if (infosCollision.gameObject.tag == "pieuvre")
                {
                    // on ajoutes les points
                    GetComponent<JoueurScript>().points += 1;
                    this.gameObject.tag = "Untagged";
                }

                if (infosCollision.gameObject.tag == "pufferfish")
                {
                    GetComponent<JoueurScript>().points += 3;
                    this.gameObject.tag = "Untagged";
                }

                if (infosCollision.gameObject.tag == "espadon")
                {
                    GetComponent<JoueurScript>().points += 5;
                    this.gameObject.tag = "Untagged";
                }
            }
        }
    }
}
