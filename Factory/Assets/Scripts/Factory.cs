using UnityEngine;

public class Factory : MonoBehaviour
{
    public enum Spells { Fireball, Nerf, Meteor, RollingBomb }

    private static int SerialID = 0;

    public MonoBehaviour GetNewInstance(Spells type)
    {
        //return Instantiate(GameObject);
        return null;
    }
}