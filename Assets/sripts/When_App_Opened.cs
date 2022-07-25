using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class When_App_Opened : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("numar_vieti", 11);
    }

}
