using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YAxisDisplay : MonoBehaviour
{
    public Transform player;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        ScoreText.text = player.position.y.ToString("0");

    }
}
