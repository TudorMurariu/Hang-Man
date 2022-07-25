using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guess : MonoBehaviour
{
    public AudioClip[] AC = new AudioClip[6];
    public AudioClip TheRock;
    public AudioSource AS;
    public Text guess;
    public Image background;
    public Sprite[] white_pictures  = new Sprite[11];
    public Sprite[] dark_pictures = new Sprite[11];

    public Text cuvant_ascuns_ui;

    public GameObject Lose_Panel;
    public GameObject Lose_button;
    public Text Lose_Text;

    public GameObject Win_Panel;
    public GameObject Win_button;
    public Text Win_Text;

    public GameObject afisare_cuvant;
    public GameObject aux_afisare;
    public void IsCorect()
    {
        string cuvant_ascuns = PlayerPrefs.GetString("cuvant_ascuns");
        string cuvant_ascuns_nou = "";
        int vieti_maxime = PlayerPrefs.GetInt("numar_vieti");
        int nr_vieti_actuale = PlayerPrefs.GetInt("vieti_ramase");

        bool ok = false; 
        string cuvant_de_ghicit = PlayerPrefs.GetString("cuvant");
        string text = guess.text;
        if (text == "")
            return;
        else if (text == cuvant_de_ghicit)
        {
            ok = true;
            Debug.Log("YAY");
            Win_Panel.SetActive(true);
            Win_button.SetActive(true);
            Win_Text.enabled = true;
            aux_afisare.SetActive(true);
            afisare_cuvant.SetActive(true);
        }
        else if (text.Length == 1)
        {
            string aux = "";
            for (int i = 0; i < cuvant_de_ghicit.Length; i++)
                if (text[0] == cuvant_de_ghicit[i])
                {
                    aux += text[0];
                    cuvant_ascuns_nou += text[0];
                    cuvant_ascuns_nou += " ";
                    Debug.Log("yay");
                    ok = true;
                }
                else
                {
                    aux += cuvant_ascuns[i * 2];
                    cuvant_ascuns_nou += cuvant_ascuns[i * 2];
                    cuvant_ascuns_nou += cuvant_ascuns[i * 2 + 1];
                }
            PlayerPrefs.SetString("cuvant_ascuns", cuvant_ascuns_nou);
            cuvant_ascuns_ui.text = cuvant_ascuns_nou;

            if (cuvant_de_ghicit == aux)
            {
                Win_Panel.SetActive(true);
                Win_button.SetActive(true);
                Win_Text.enabled = true;
                aux_afisare.SetActive(true);
                afisare_cuvant.SetActive(true);
            }
        }

        if (!ok)
        {
            background.color = Color.white;
            Debug.Log("naw");
            int x = PlayerPrefs.GetInt("darkmode");
            if(x == 0)
                Manage_Background(vieti_maxime, nr_vieti_actuale, white_pictures);
            else
                Manage_Background(vieti_maxime, nr_vieti_actuale, dark_pictures);
        }
    }

    void Manage_Background(int vieti_maxime,int nr_vieti_actuale,Sprite[] pictures)
    {
        switch (vieti_maxime)
        {
            case 11:
                if (nr_vieti_actuale == 2)
                {
                    if (PlayerPrefs.GetInt("darkmode") == 0)
                    {
                        int x = Random.Range(0, 5);
                        AS.clip = AC[x];
                        AS.Play();
                    }
                    else
                    {
                        AS.clip = TheRock;
                        AS.Play();
                    }
                }
                else if (nr_vieti_actuale == 1)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[vieti_maxime - nr_vieti_actuale - 1];
                    Debug.Log("ended");
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);

                    Lose_Panel.SetActive(true);
                    Lose_button.SetActive(true);
                    Lose_Text.enabled = true;
                    aux_afisare.SetActive(true);
                    afisare_cuvant.SetActive(true);
                    return;
                }
                nr_vieti_actuale--;
                background.sprite = pictures[vieti_maxime - nr_vieti_actuale - 1];
                PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                break;
            case 10:
                if (nr_vieti_actuale == 10)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[0];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 9)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[1];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 8)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[2];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 7)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[3];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 6)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[4];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 5)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[5];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 4)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[6];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 3)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[8];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 2)
                {
                    if (PlayerPrefs.GetInt("darkmode") == 0)
                    {
                        int x = Random.Range(0, 5);
                        AS.clip = AC[x];
                        AS.Play();
                    }
                    else
                    {
                        AS.clip = TheRock;
                        AS.Play();
                    }
                    nr_vieti_actuale--;
                    background.sprite = pictures[9];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 1)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[10];
                    Debug.Log("ended");
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);

                    Lose_Panel.SetActive(true);
                    Lose_button.SetActive(true);
                    Lose_Text.enabled = true;
                    aux_afisare.SetActive(true);
                    afisare_cuvant.SetActive(true);
                    return;
                }
                break;
            case 9:
                if (nr_vieti_actuale == 9)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[0];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 8)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[1];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 7)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[2];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 6)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[3];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 5)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[4];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 4)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[6];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 3)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[8];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 2)
                {
                    if (PlayerPrefs.GetInt("darkmode") == 0)
                    {
                        int x = Random.Range(0, 5);
                        AS.clip = AC[x];
                        AS.Play();
                    }
                    else
                    {
                        AS.clip = TheRock;
                        AS.Play();
                    }
                    nr_vieti_actuale--;
                    background.sprite = pictures[9];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 1)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[10];
                    Debug.Log("ended");
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);

                    Lose_Panel.SetActive(true);
                    Lose_button.SetActive(true);
                    Lose_Text.enabled = true;
                    aux_afisare.SetActive(true);
                    afisare_cuvant.SetActive(true);
                    return;
                }
                break;
            case 7:
                if (nr_vieti_actuale == 7)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[0];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 6)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[1];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 5)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[2];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 4)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[6];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 3)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[8];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 2)
                {
                    if (PlayerPrefs.GetInt("darkmode") == 0)
                    {
                        int x = Random.Range(0, 5);
                        AS.clip = AC[x];
                        AS.Play();
                    }
                    else
                    {
                        AS.clip = TheRock;
                        AS.Play();
                    }
                    nr_vieti_actuale--;
                    background.sprite = pictures[9];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 1)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[10];
                    Debug.Log("ended");
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);

                    Lose_Panel.SetActive(true);
                    Lose_button.SetActive(true);
                    Lose_Text.enabled = true;
                    aux_afisare.SetActive(true);
                    afisare_cuvant.SetActive(true); 
                    return;
                }
                break;
            case 5:
                if (nr_vieti_actuale == 5)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[2];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 4)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[6];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 3)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[8];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 2)
                {
                    if (PlayerPrefs.GetInt("darkmode") == 0)
                    {
                        int x = Random.Range(0, 5);
                        AS.clip = AC[x];
                        AS.Play();
                    }
                    else
                    {
                        AS.clip = TheRock;
                        AS.Play();
                    }
                    nr_vieti_actuale--;
                    background.sprite = pictures[9];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 1)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[10];
                    Debug.Log("ended");
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);

                    Lose_Panel.SetActive(true);
                    Lose_button.SetActive(true);
                    Lose_Text.enabled = true;
                    aux_afisare.SetActive(true);
                    afisare_cuvant.SetActive(true);
                    return;
                }
                break;
            case 4:
                if (nr_vieti_actuale == 4)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[2];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 3)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[8];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 2)
                {
                    if (PlayerPrefs.GetInt("darkmode") == 0)
                    {
                        int x = Random.Range(0, 5);
                        AS.clip = AC[x];
                        AS.Play();
                    }
                    else
                    {
                        AS.clip = TheRock;
                        AS.Play();
                    }
                    nr_vieti_actuale--;
                    background.sprite = pictures[9];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 1)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[10];
                    Debug.Log("ended");
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);

                    Lose_Panel.SetActive(true);
                    Lose_button.SetActive(true);
                    Lose_Text.enabled = true;
                    aux_afisare.SetActive(true);
                    afisare_cuvant.SetActive(true);
                    return;
                }
                break;
            case 3:
                if(nr_vieti_actuale == 3)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[8];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 2)
                {
                    if(PlayerPrefs.GetInt("darkmode") == 0)
                    {
                        int x = Random.Range(0, 5);
                        AS.clip = AC[x];
                        AS.Play();
                    }
                    else
                    {
                        AS.clip = TheRock;
                        AS.Play();
                    }
                    nr_vieti_actuale--;
                    background.sprite = pictures[9];
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);
                }
                else if (nr_vieti_actuale == 1)
                {
                    nr_vieti_actuale--;
                    background.sprite = pictures[10];
                    Debug.Log("ended");
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);

                    Lose_Panel.SetActive(true);
                    Lose_button.SetActive(true);
                    Lose_Text.enabled = true;
                    aux_afisare.SetActive(true);
                    afisare_cuvant.SetActive(true);
                    return;
                }
                break;
            case 1:
                if(nr_vieti_actuale == 1)
                {
                    if (PlayerPrefs.GetInt("darkmode") == 0)
                    {
                        int x = Random.Range(0, 5);
                        AS.clip = AC[x];
                        AS.Play();
                    }
                    else
                    {
                        AS.clip = TheRock;
                        AS.Play();
                    }
                    nr_vieti_actuale--;
                    background.sprite = pictures[10];
                    Debug.Log("ended");
                    PlayerPrefs.SetInt("vieti_ramase", nr_vieti_actuale);

                    Lose_Panel.SetActive(true);
                    Lose_button.SetActive(true);
                    Lose_Text.enabled = true;
                    aux_afisare.SetActive(true);
                    afisare_cuvant.SetActive(true);
                }
                break;
        }

    }

}
