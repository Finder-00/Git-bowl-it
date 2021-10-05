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
        if(infosCollision.gameObject.layer == 6 || infosCollision.gameObject.tag == "quille")
        {
            // Si la gravité n'est pas activée
            if (!GetComponent<Rigidbody>().useGravity)
            {
                if (infosCollision.gameObject.tag == "pieuvre" || infosCollision.gameObject.tag == "quille")
                {
                    // on ajoutes les points
                    JoueurScript.points += 1;
                    Debug.Log(JoueurScript.points);
                    //this.gameObject.tag = "Untagged";
                }

                if (infosCollision.gameObject.tag == "pufferfish")
                {
                    JoueurScript.points += 3;
                    //this.gameObject.tag = "Untagged";
                }

                if (infosCollision.gameObject.tag == "espadon")
                {
                    JoueurScript.points += 5;
                    //this.gameObject.tag = "Untagged";
                }
            }    
            // on active la gravité
            GetComponent<Rigidbody>().useGravity = true;

        }
    }
}
