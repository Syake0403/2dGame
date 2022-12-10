using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameObject SpawnPoint;
    // Start is called before the first frame update
    

    // Update is called once per frame
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag =="Player")
        {
            SpawnPoint.transform.position = this.gameObject.transform.position;
        }
    }
}
