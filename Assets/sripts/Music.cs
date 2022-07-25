using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip[] AC = new AudioClip[6];
    public AudioSource AS;

    // Start is called before the first frame update
    void Start()
    {
        int x = Random.Range(0, 5);
        AS.clip = AC[x];
        AS.Play();
        PlayerPrefs.SetInt("numar_vieti", 11);
        PlayerPrefs.SetInt("vieti_ramase", 11);
        PlayerPrefs.SetInt("Dark-Mode", 0);
        PlayerPrefs.SetString("dificultate", "easy");
        PlayerPrefs.SetInt("darkmode", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
