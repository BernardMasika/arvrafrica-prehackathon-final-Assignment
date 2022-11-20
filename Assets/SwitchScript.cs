using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    public AudioSource switchSound;
    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;
    public Light light5;
    public Light light6;
    private bool isenabled;
    // Start is called before the first frame update
    void Start()
    {
        isenabled = false;
        LightValue(isenabled);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   private void OnMouseDown()
    {
        isenabled = !isenabled;
        LightValue(isenabled);
        switchSound.Play();
    }
    private void LightValue(bool value)
    {
        light1.enabled = value;
        light2.enabled=value;
        light3.enabled=value;
        light4.enabled=value;
        light5.enabled=value;
        light6.enabled=value;
    }
}
