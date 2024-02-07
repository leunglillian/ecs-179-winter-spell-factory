using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanging : MonoBehaviour
{
        public Material material;
        public Color[] colors;
        private int currentColor = 0;
        private int targetColor = 1;
        private float targetPoint;

        [SerializeField] private float magicTime;

    // Start is called before the first frame update
    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        targetPoint+= Time.deltaTime/ magicTime;
        material.color = Color.Lerp(colors[currentColor], colors[targetColor], targetPoint);
        if (targetPoint>=1.0f)
        {
            targetPoint = 0.0f;
            currentColor = targetColor;
            targetColor++;
            if (targetColor == colors.Length)
            {
                targetColor = 0;
            }
        }
        
    }
}
