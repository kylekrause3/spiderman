using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable] //so that we can use it in editor, ItemWorldSpawner.cs
public class Item
{
   public enum Type
    {
        //see ItemAssets when adding new items
        JumpBoost,
        SpeedBoost,
        RegenBoost,
        AttackBoost,
    }

    public Type itemType;
    public int amt;
    //public int/string rarity;

    public Sprite getSprite()
    {
        //for UI_Inventory
        switch (itemType)
        {
            
            case Type.JumpBoost:    return ItemAssets.Instance.JumpBoostSprite;
            case Type.SpeedBoost:   return ItemAssets.Instance.SpeedBoostSprite;
            case Type.RegenBoost:   return ItemAssets.Instance.RegenBoostSprite;
            case Type.AttackBoost:  return ItemAssets.Instance.AttackBoostSprite;
            default: break;
        }
        return ItemAssets.Instance.JumpBoostSprite;
    }

    public GameObject getPrefab()
    {
        //ItemAssets.prtins();
        switch (itemType)
        {
            
            case Type.JumpBoost: return ItemAssets.Instance.JumpBoostPrefab;
            case Type.SpeedBoost: return ItemAssets.Instance.SpeedBoostPrefab;
            case Type.RegenBoost: return ItemAssets.Instance.RegenBoostPrefab;
            case Type.AttackBoost: return ItemAssets.Instance.AttackBoostPrefab; 
            default: break;
                //GameObject.Instantiate(...) is how you'd make a copy of a gameobject
        }
        return ItemAssets.Instance.JumpBoostPrefab; //placeholder for now
    }

    public bool IsStackable()
    {
        switch (itemType)
        {
            default :
            case Type.SpeedBoost:
            case Type.RegenBoost:
            case Type.AttackBoost:
                return true;
            case Type.JumpBoost:
                return false;
        }
    }
}
