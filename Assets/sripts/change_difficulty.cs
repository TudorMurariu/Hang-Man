using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change_difficulty : MonoBehaviour
{
    public Image background;
    public Sprite therock;
    public Sprite pitbull;
    public void DarkMode()
    {
        int x = PlayerPrefs.GetInt("darkmode");
        if (x == 1)
        {
            background.sprite = pitbull;
            x = 0;
        }
        else
        {
            background.sprite = therock;
            x = 1;
        }

        PlayerPrefs.SetInt("darkmode", x);
        Debug.Log(x);
    }
    public void Change_Dificulty(int val)
    {
        switch (val)
        {
            case 0:
                PlayerPrefs.SetString("dificultate","easy");
                Debug.Log(val.ToString());
                break;
            case 1:
                PlayerPrefs.SetString("dificultate", "medium");
                Debug.Log(val.ToString());
                break;
            case 2:
                PlayerPrefs.SetString("dificultate", "hard");
                Debug.Log(val.ToString());
                break;
            case 3:
                PlayerPrefs.SetString("dificultate", "fun");
                Debug.Log(val.ToString());
                break;
        }
    }
}
