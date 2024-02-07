using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arcanum
{
    public class RollingBombMaker : MonoBehaviour, IFactorySpell
    {
        [SerializeField] private GameObject prefab;

        public GameObject Make()
        {
            GameObject newGameObject = (GameObject)Instantiate(this.prefab);
            return newGameObject;
        }
    }

}
