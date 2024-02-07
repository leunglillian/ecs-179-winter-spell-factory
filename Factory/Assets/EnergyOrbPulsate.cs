using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyOrbPulsate : MonoBehaviour
{
    Material mat;
    Color startingColor;
    float fadeSpeed;
    
    void Start()
    {
        this.mat = GetComponent<Renderer>().material;
        startingColor = mat.color;
        fadeSpeed = 2.0f;
    }

    void Update()
    {
        mat.color = Color.Lerp(startingColor, Color.red, Mathf.PingPong(Time.time * fadeSpeed, 1f));
    }
}
