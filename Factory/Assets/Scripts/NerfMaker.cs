using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// All assets used to create Nerf were created by Lillian Leung
namespace Arcanum
{
    public class NerfMaker : MonoBehaviour, IFactorySpell
    {
        [SerializeField] private GameObject prefab;

        public GameObject Make()
        {
            GameObject newGameObject = (GameObject)Instantiate(this.prefab);
            return newGameObject;
        }
    }
}