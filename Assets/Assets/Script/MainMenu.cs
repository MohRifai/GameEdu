using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Main Menu Panel List")]
    public GameObject MainPanel;
    public GameObject InfoPanel;
    public GameObject PilihPanel;
    public GameObject Kali;
    public GameObject Bagi;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        MainPanel.SetActive(true);
        InfoPanel.SetActive(false);
        PilihPanel.SetActive(false);
        Kali.SetActive(false);
        Bagi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KaliButton()
    {
        MainPanel.SetActive(true);
        InfoPanel.SetActive(false);
        PilihPanel.SetActive(true);
        Kali.SetActive(true);
        Bagi.SetActive(false);
        
    }
    public void BagiButton()
    {
        MainPanel.SetActive(true);
        InfoPanel.SetActive(false);
        PilihPanel.SetActive(true);
        Kali.SetActive(false);
        Bagi.SetActive(true);
        
    }
    public void BackButton()
    {
        MainPanel.SetActive(true);
        InfoPanel.SetActive(false);
        PilihPanel.SetActive(false);
        Kali.SetActive(false);
        Bagi.SetActive(false);
    }
    public void BackPilihButton()
    {
        MainPanel.SetActive(true);
        InfoPanel.SetActive(false);
        PilihPanel.SetActive(true);
        Kali.SetActive(false);
        Bagi.SetActive(false);
    }
    public void PilihButton()
    {
        MainPanel.SetActive(true);
        InfoPanel.SetActive(false);
        PilihPanel.SetActive(true);
        Kali.SetActive(false);
        Bagi.SetActive(false);
    }
    public void InfoButton()
    {
        MainPanel.SetActive(true);
        InfoPanel.SetActive(true);
        PilihPanel.SetActive(false);
        Kali.SetActive(false);
        Bagi.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
