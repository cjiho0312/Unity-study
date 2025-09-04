using UnityEngine;

[System.Serializable]
public class Ability
{
    [SerializeField] int strength = 5 ;

    public int Strength { get {  return strength; } }

    public Ability()
    {
        Debug.Log("Created Ability");
    }
}
