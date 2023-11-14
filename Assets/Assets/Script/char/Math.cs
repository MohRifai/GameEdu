using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Math : MonoBehaviour
{
    [Header("Petunjuk Panel List")]
    public GameObject Slide1;
    public GameObject Slide2;
    public GameObject Slide3;
    public GameObject Slide4;
    public GameObject Slide5;
    public GameObject Slide6;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        Slide1.SetActive(true);
        Slide2.SetActive(false);
        Slide3.SetActive(false);
        Slide4.SetActive(false);
        Slide5.SetActive(false);
        Slide6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Slide1Button()
    {
        Slide1.SetActive(false);
        Slide2.SetActive(true);
        Slide3.SetActive(false);
        Slide4.SetActive(false);
        Slide5.SetActive(false);
        Slide6.SetActive(false);
    }
    public void Slide2Button()
    {
        Slide1.SetActive(false);
        Slide2.SetActive(false);
        Slide3.SetActive(true);
        Slide4.SetActive(false);
        Slide5.SetActive(false);
        Slide6.SetActive(false);
    }
    public void Slide3Button()
    {
        Slide1.SetActive(false);
        Slide2.SetActive(false);
        Slide3.SetActive(false);
        Slide4.SetActive(true);
        Slide5.SetActive(false);
        Slide6.SetActive(false);
    }
    public void Slide4Button()
    {
        Slide1.SetActive(false);
        Slide2.SetActive(false);
        Slide3.SetActive(false);
        Slide4.SetActive(false);
        Slide5.SetActive(true);
        Slide6.SetActive(false);
    }

    public void Slide5Button()
    {
        Slide1.SetActive(false);
        Slide2.SetActive(false);
        Slide3.SetActive(false);
        Slide4.SetActive(false);
        Slide5.SetActive(false);
        Slide6.SetActive(true);
    }
}
