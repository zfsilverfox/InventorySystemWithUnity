using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabaseScript : MonoBehaviour
{
    public List<ItemScript> itemListScript = new List<ItemScript>();

    private void Awake()
    {

        BuildDatabaseFunction();
       
    }

    public ItemScript GetItemFunction(int id) 
    {
      return     itemListScript.Find(itemListScript=>itemListScript.id == id);
      
    }


    public ItemScript GetItemFunction(string itemName)
    {
        return itemListScript.Find(itemListScript => itemListScript.ItemTitle == itemName);

    }
    void BuildDatabaseFunction() 
    
    {
        itemListScript = new List<ItemScript>() 
        {
            new ItemScript(0,
            "DiamondSword"
            ,"A sword make of the Diamonds",
            new Dictionary<string, int>()
            {
                {  "Power",15},
                {"Defense",10 }
            }),

             new ItemScript(1,
            "OreDiamond"
            ,"A pretty Diamonds",
            new Dictionary<string, int>()
            {
                {  "Value",300},
                {"Defense",10 }
            })
             ,
                new ItemScript(2,
            "Diamond PickUP "
            ,"A  pick That Could Pick Up",
            new Dictionary<string, int>()
            {
                {  "Power",5},
                {"Mining",20 }
            })


        };
    }


}

