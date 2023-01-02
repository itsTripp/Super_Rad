using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.TopDownEngine;
using MoreMountains.InventoryEngine;
    public class Magnetic_Stop : MonoBehaviour
    {
    public Magnetic _magnetic;
    public string playerID;
    public string inventoryName;
    public WeaponAmmo ammo;

        // Update is called once per frame
        void Update()
        {
            if(Inventory.FindInventory(inventoryName, playerID).NumberOfFreeSlots == 0)
            {
            _magnetic.StopFollowing();
            }
            else
            {
            _magnetic.StartFollowing();
            }
        }
    }