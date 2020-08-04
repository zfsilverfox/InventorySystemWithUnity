using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventoryScript : MonoBehaviour
{
   public List<UIItemScript> uiItems = new  List<UIItemScript>();

    public GameObject slotPrefabs;

    public Transform slotsPanelTransform;

    private void Awake()
    {
        for (int i = 0; i <24; i++)
        {
            GameObject instanObject = Instantiate(slotPrefabs);

            instanObject.transform.SetParent(slotsPanelTransform);

            uiItems.Add(instanObject.GetComponentInChildren<UIItemScript>());
        }
    }



    public void UpdateSlotFunction(int slotsIndex,ItemScript items) 
    {

        uiItems[slotsIndex].UpdateItemFunction(items);
    }

    public void AddNewItemFunction(ItemScript items ) 
    {

        UpdateSlotFunction(uiItems.FindIndex(i => i.items == null),items);

    }

    public void RemoveItemFunction(ItemScript item) 
    {
        UpdateSlotFunction(uiItems.FindIndex(i => i.items == item),null);
    }

}
