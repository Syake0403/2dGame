using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamestarter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("Original");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Original");
        }
    }

    
}
