using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancerEspadon : MonoBehaviour
{
    public bool enContact;
    // Update is called once per frame
    void Update()
    {
        if(!enContact)
        {
            GetComponent<Rigidbody>().velocity = transform.forward * 4;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        enContact = true;
    }

    public void LancerEspadonMain()
    {
        enContact = false;
    }


}
