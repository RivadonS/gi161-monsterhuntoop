using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string WeaponName {  get; private set; }
    public int BonusDamage { get; private set; }
    public void InitWeapon(string weaponName, int weaponDamage)
    {
        WeaponName = weaponName;
        BonusDamage = weaponDamage;
    }
}
