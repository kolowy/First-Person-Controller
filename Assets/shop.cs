using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shop : MonoBehaviour
{

    [Header("Shop")]
    [Tooltip("Shop GameObject of the menu used to toggle its activation")]
    public GameObject Shop;
    public PlayerCharacterController Player;
    [Header("Blaster")]
    [Tooltip("The prefab for the weapon that will be added to the player on buy Blaster")]
    public WeaponController weaponPrefab_lvl1;
    public WeaponController weaponPrefab_lvl2;
    public WeaponController weaponPrefab_lvl3;
    [Tooltip("The button text (for the blaster")]
    public TextMeshProUGUI blastertext;
    [Header("Launcher")]
    [Tooltip("The prefab for the weapon that will be added to the player on buy Launcher")]
    public WeaponController LauncherPrefab_lvl1;
    [Tooltip("The button text (for the blaster")]
    public TextMeshProUGUI launchertext;



//--------------SHOP--------------
    //Blasterbuy
    public void PurchaseBlasterClicked(PlayerCharacterController byPlayer)
    {
        Debug.Log("test");
        /*if(Coin.moneyAmount > 4){
                    PlayerWeaponsManager playerWeaponsManager = byPlayer.GetComponent<PlayerWeaponsManager>();
            if (playerWeaponsManager) {
                if (playerWeaponsManager.HasWeapon(weaponPrefab_lvl3)) {
                    blastertext.text = "Level max";
                    return;
                } else if (playerWeaponsManager.HasWeapon(weaponPrefab_lvl2)) {
                    playerWeaponsManager.RemoveWeapon(weaponPrefab_lvl2);
                    if (playerWeaponsManager.HasWeapon(weaponPrefab_lvl2)) {
                        Debug.Log("j'en ai marre");
                    }
                    playerWeaponsManager.AddWeapon(weaponPrefab_lvl3);
                    Coin.moneyAmount = Coin.moneyAmount-5;
                    if (playerWeaponsManager.GetActiveWeapon() == null){
                        playerWeaponsManager.SwitchWeapon(true);
                    }
                    return;
                } else if (playerWeaponsManager.HasWeapon(weaponPrefab_lvl1)) {
                    /*foreach(Transform t in GetComponentsInChildren<Transform>())
                    {
                        if (t != transform)
                            t.weaponPrefab_lvl1.layer = 0;
                    }*/
                    /*playerWeaponsManager.RemoveWeapon(weaponPrefab_lvl1);
                    if (playerWeaponsManager.RemoveWeapon(weaponPrefab_lvl1) == false) {
                        Debug.Log("j'en ai marre");
                    }
                    if (playerWeaponsManager.AddWeapon(weaponPrefab_lvl2)) {
                        Coin.moneyAmount = Coin.moneyAmount-5;
                    }
                    return;
                } else {
                    if (playerWeaponsManager.AddWeapon(weaponPrefab_lvl1)) {
                        Coin.moneyAmount = Coin.moneyAmount-5;
                        if (playerWeaponsManager.GetActiveWeapon() == null){
                            playerWeaponsManager.SwitchWeapon(true);
                        }
                    }
                    return;
                }
            }
        } else {
            blastertext.text = "Not enough money";
            return;
        }*/
    }
    public void PurchaseLauncherClicked()
    {
        Debug.Log("la ca passe");
        PlayerWeaponsManager playerWeaponsManager = Player.GetComponent<PlayerWeaponsManager>();
        Debug.Log("la ca passe");
        //if (playerWeaponsManager)
        //{
        playerWeaponsManager.AddWeapon(LauncherPrefab_lvl1);
        
            // Handle auto-switching to weapon if no weapons currently
        return;
            
        //}
    }
}
