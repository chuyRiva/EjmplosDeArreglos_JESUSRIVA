using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploDeArray : MonoBehaviour
{

    public GameObject[] balls;
    public string[] balls2 = new string[1];
    private List<string> ballsCatch = new List<string>();
    private int balln;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            balln = Random.Range(0, balls.Length);
            GameObject ball = Instantiate(balls[balln]) as GameObject;
            if (balln != 2) {
                balls2[balls2.Length + 1] = ball.name;
                ballsCatch.Add(ball.name);
                Debug.Log(ball.name);
                Debug.Log(ballsCatch.ToArray().Length);
            }
            
        }
    }
}
