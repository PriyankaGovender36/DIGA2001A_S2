using UnityEngine;

[CreateAssetMenu(fileName= "InventoryItem", menuName ="Scriptable Objects/Potion")]
    public class PotionData: ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public int itemValue;
        
    }


