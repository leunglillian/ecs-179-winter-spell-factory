using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arcanum
{
    public enum Spells { Fireball, BlackHole, Meteor, EnergyOrb, RollingBomb, MagicCube }

    [RequireComponent(typeof(BlackHoleMaker))]
    [RequireComponent(typeof(FireballMaker))]
    [RequireComponent(typeof(MeteorMaker))]
    [RequireComponent(typeof(EnergyOrbMaker))]
    [RequireComponent(typeof(RollingBombMaker))]
    [RequireComponent(typeof(MagicCubeMaker))]
    
    public class SpellFactory : MonoBehaviour
    {
        public void BuildSpell(Spells type)
        {
            if(Spells.BlackHole == type)
            {
                var blackHole = this.GetComponent<BlackHoleMaker>().Make();
                blackHole.transform.position = this.transform.position;
            }
            else if (Spells.Fireball == type)
            {
                var fireball = this.GetComponent<FireballMaker>().Make();
                fireball.transform.position = this.transform.position;
            }
            else if (Spells.RollingBomb == type)
            {
                var rollingBomb = this.GetComponent<RollingBombMaker>().Make();
                rollingBomb.transform.position = this.transform.position;
            }
            else if (Spells.EnergyOrb == type)
            {
                var energyOrb = this.GetComponent<EnergyOrbMaker>().Make();
                energyOrb.transform.position = this.transform.position;
            }
            else if (Spells.MagicCube == type)
            {
                var MagicCube = this.GetComponent<MagicCubeMaker>().Make();
                MagicCube.transform.position = this.transform.position;
            }
        }

        public void Update()
        {
            if (Input.GetButtonDown("Jump"))
            {
                this.BuildSpell(Spells.BlackHole);
            }
            else if(Input.GetButtonDown("Fire1"))
            {
                this.BuildSpell(Spells.MagicCube);
            }
            else if (Input.GetButtonDown("Fire2"))
            {
                this.BuildSpell(Spells.RollingBomb);
            }
            else if (Input.GetKeyDown(KeyCode.K))
            {
                this.BuildSpell(Spells.EnergyOrb);
            }
        }

    }

}
