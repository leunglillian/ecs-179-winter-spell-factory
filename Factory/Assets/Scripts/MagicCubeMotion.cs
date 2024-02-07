using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arcanum
{
    public class MagicCubeMotion : MonoBehaviour
    {
        [SerializeField] private float Speed = 5.0f;

        void Update()
        {
            var pos = this.transform.position;
            pos += this.Speed * Time.deltaTime * this.transform.forward;
            this.transform.position = pos;
            
            //Rotation
            Vector3 rotationMovement = new Vector3(0f, 0f, -70f);

            // Rotate around the y-axis in local space
            this.transform.Rotate(rotationMovement * Time.deltaTime*1);
        }
    }
}