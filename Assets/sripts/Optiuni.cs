using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Optiuni : MonoBehaviour
{
    public void Hnadle_Input_Drop_Down(int val)
    {
        switch (val)
        {
            case 0:
                PlayerPrefs.SetInt("numar_vieti", 11);
                Debug.Log("11");
                break;
            case 1:
                PlayerPrefs.SetInt("numar_vieti", 10);
                Debug.Log("10");
                break;
            case 2:
                PlayerPrefs.SetInt("numar_vieti", 9);
                Debug.Log("9");
                break;
            case 3:
                PlayerPrefs.SetInt("numar_vieti", 7);
                Debug.Log("7");
                break;
            case 4:
                PlayerPrefs.SetInt("numar_vieti", 5);
                Debug.Log("5");
                break;
            case 5:
                PlayerPrefs.SetInt("numar_vieti", 4);
                Debug.Log("4");
                break;
            case 6:
                PlayerPrefs.SetInt("numar_vieti", 3);
                Debug.Log("3");
                break;
            case 7:
                PlayerPrefs.SetInt("numar_vieti", 1);
                Debug.Log("1");
                break;
        }
    }
}
