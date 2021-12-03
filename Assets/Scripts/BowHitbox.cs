using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowHitbox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy") 
        {
            if (other.gameObject.name == "Starboard" || other.gameObject.name == "Port") 
            {
                Destroy(other.transform.parent.gameObject);
            }
        }
        
    }

}
