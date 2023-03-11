using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreContoroller : MonoBehaviour
{
    int score = 0;
    Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        this.textComponent = GameObject.Find("Text").GetComponent<Text>();
        this.textComponent.text = "score" + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Addscore()
    {
        this.score += 10;
        this.textComponent.text = "score" + score.ToString();
    }

}
