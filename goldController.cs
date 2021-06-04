using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldController : MonoBehaviour
{
    AudioSource audio;
    MeshRenderer display;
    static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        display = GetComponent<MeshRenderer>();
        audio.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        audio.Play();
        display.enabled = false;
        score = score + 1;
        print(score);
        print("Попал!");
        if(score > 3){
           print("Ты выиграл!");
        }
    }
}
