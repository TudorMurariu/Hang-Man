using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class STart_Game : MonoBehaviour
{
    public GameObject Main_Panel;
    public GameObject Option_Panel;
    public GameObject darkmode;
    public Text trademark2;
    public GameObject drop_down;
    public GameObject drop_down_dificulty;
    public Text t1;
    public Text t2;

    public void Start_Game()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Game_Ended()
    {
        SceneManager.LoadScene("Choose_Type");
    }

    public void Options()
    {
        Option_Panel.SetActive(true);
        trademark2.enabled = true;
        darkmode.SetActive(true);
        drop_down.SetActive(true);
        drop_down_dificulty.SetActive(true);
        t1.enabled = true;
        t2.enabled = true;
    }

    public void Close_Options()
    {
        trademark2.enabled = false;
        darkmode.SetActive(false);
        drop_down.SetActive(false);
        Option_Panel.SetActive(false);
        drop_down_dificulty.SetActive(false);
        t1.enabled = false;
        t2.enabled = false;
    }

    public void Back_To_Main_Menu()
    {
        SceneManager.LoadScene("Choose_Type");
    }
}
