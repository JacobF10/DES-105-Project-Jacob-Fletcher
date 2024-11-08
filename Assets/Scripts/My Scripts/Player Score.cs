using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Text MyScoreText;
    private int ScoreNumber;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNumber = 0;
        MyScoreText.text = "Score : " + ScoreNumber;
    }
    private void OnTriggerEnter2D(Collider2D Collectable)
    {
        if (Collectable.tag == "MyCollectable")
        {
            ScoreNumber+= 1;
            Destroy(Collectable.gameObject);
            MyScoreText.text = "Score" + ScoreNumber;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
