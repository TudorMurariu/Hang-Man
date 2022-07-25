using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class On_Game_Started : MonoBehaviour
{
    public Image Background;
    void Start()
    {
        int vieti_maxime = PlayerPrefs.GetInt("numar_vieti");
        PlayerPrefs.SetInt("vieti_ramase", vieti_maxime);
        if (PlayerPrefs.GetInt("darkmode") == 1)
            Background.color = Color.black;
    }

}
