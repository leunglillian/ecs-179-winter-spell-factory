using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arcanum
{
    public class NerfMotion : MonoBehaviour
    {
        [SerializeField] private float speed;

        void Update()
        {
            var nerfPosition = this.transform.position;

            // Destroy nerf once it off screen
            if (nerfPosition.z > 100f)
            {
                Destroy(gameObject);
            }

            nerfPosition.z += speed * Time.deltaTime;
            this.transform.position = nerfPosition;
        }
    }
}