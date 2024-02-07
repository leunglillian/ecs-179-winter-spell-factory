using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arcanum
{
    public class EnergyOrbMotion : MonoBehaviour
    {
        [SerializeField] private float speed = 7.0f;

        void Update()
        {
            var position = this.transform.position;
            Vector3 dir = new Vector3(-1, 0, 1);
            position += dir * this.speed * Time.deltaTime;
            this.transform.position = position;
        }
    }
}