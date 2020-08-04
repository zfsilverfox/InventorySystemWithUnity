using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public List<ItemScript> playerCharacterItems = new List<ItemScript>();

    public ItemDatabaseScript itemDatabaseScript;

    public UIInventoryScript uiInventory;

    private void Start()
    {
        AddItemFunction(1);
        AddItemFunction(0);
        AddItemFunction(1);
        AddItemFunction(0);
        AddItemFunction(1);
        AddItemFunction(0);
    }

  

    public void AddItemFunction(int id) 
    {
        ItemScript itemToAdd = itemDatabaseScript.GetItemFunction(id);
        playerCharacterItems.Add(itemToAdd);
        uiInventory.AddNewItemFunction(itemToAdd);
        Debug.Log("Item To Added"+ itemToAdd.ItemTitle);
    }

    public void AddItemFunction(string itemName)
    {
        ItemScript itemToAdd = itemDatabaseScript.GetItemFunction(itemName);
        playerCharacterItems.Add(itemToAdd);
        Debug.Log("Item To Added" + itemToAdd.ItemTitle);
    }

    public ItemScript CheckForItemFunction(int id) 
    {
        return playerCharacterItems.Find(item => item.id== id);
    }

    public void RemoveItemFunction(int id) 
    {
        ItemScript itemToRemove = CheckForItemFunction(id);

        if(itemToRemove != null) 
        {
            playerCharacterItems.Remove(itemToRemove);
            uiInventory.RemoveItemFunction(itemToRemove);
            Debug.Log("The Item has To Been Removed "+itemToRemove.ItemTitle);
        }

    }

}
