using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;

public class AuthScript : MonoBehaviour
{
    public TMP_InputField netWorth;
    public GameObject welcomeScreen;
    public GameObject loginScreen;
    public GameObject warningScreen;
    private float networthvalue;
    public Camera cam;
    public int camDisplay;
    public Vector3 insideRotatedPosition;
    public Vector3 insideMovedPosition;
    public bool CityHouse;
    public bool VillageHouse;
    public TMP_Text outputText;
    public float onFocusDistance;
    // Start is called before the first frame update
    void Start()
    {
        cam.targetDisplay = camDisplay;
    }

    public void ClickToLogin()
    {
        welcomeScreen.SetActive(false);
        loginScreen.SetActive(true);
        warningScreen.SetActive(false);
        cam.transform.DOMoveX(onFocusDistance, 0.5f);
    }

    public void BackToLoginScreen()
    {
        welcomeScreen.SetActive(false);
        loginScreen.SetActive(true);
        warningScreen.SetActive(false);
    }

    public void Authentication()
    {
        networthvalue = float.Parse(netWorth.text);

        if (string.IsNullOrWhiteSpace(netWorth.text))
        {
            outputText.text = "Please enter Your NetWorth Value!";
            Debug.Log("invalid input");
        } 
        else
        {
            if (networthvalue >= 1 && networthvalue <= 4.5 && VillageHouse)
            {
                LoginUserVillageHouse();
            }
            else if (networthvalue > 4.5 && CityHouse)
            {
                LoginUserCityHouse();
            }
            else
            {
                NotEligible();
            }
        }
       

       
    }

    private void LoginUserVillageHouse()
    {
        //cam.transform.DOMoveX(60.2f, 0.8f);
        //cam.transform.DOMoveY(-3.5f, 0.5f);
        //cam.transform.DOMoveZ(164.4f, 0.5f);
        cam.transform.DORotate(insideRotatedPosition, 2f);
        cam.transform.DOMove(insideMovedPosition, 1f);
    }

    private void LoginUserCityHouse()
    {
        cam.transform.DOMoveX(13f, 0.8f);
        cam.transform.DOMoveY(7.8f, 0.5f);
        cam.transform.DORotate(insideRotatedPosition, 2f);
        cam.transform.DOMove(insideMovedPosition, 1f);
    }

    private void NotEligible()
    {
        welcomeScreen.SetActive(false);
        loginScreen.SetActive(false);
        warningScreen.SetActive(true);
    }
}
