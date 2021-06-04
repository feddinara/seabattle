using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noGoldController : MonoBehaviour
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
        print("Мимо");
        if(score > 11){
           print("Ты проигарл :(");
        }
    }
}
