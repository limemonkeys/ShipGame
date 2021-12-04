using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BowHitbox : MonoBehaviour
{
    public TextMeshProUGUI HealthText;
    public int maxHealth;
    public int currentHealth;

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

            if (other.gameObject.name == "Bow" || other.gameObject.name == "Stern")
            {
                Destroy(other.transform.parent.gameObject);
            }
        }
        
    }

}
