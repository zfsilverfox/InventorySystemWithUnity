using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor.Animations;
using UnityEngine;

public class ItemScript 
{
    public int id;

    public string ItemTitle;

    public string Description;

    public Sprite IconSprite;

    public Dictionary<string, int> state = new Dictionary<string, int>();


    public ItemScript
        (int id,string ItemTitle, string Description ,Dictionary<string,int> state) 
    {
        this.id = id;
        this.ItemTitle = ItemTitle;
        this.Description = Description;
        this.IconSprite = Resources.Load<Sprite>("Sprites/"+ItemTitle);
        this.state =state ;
    }

    public ItemScript(ItemScript items) 
    {
        this.id = items.id;
        this.ItemTitle = items.ItemTitle;
        this.Description =items. Description;
        this.IconSprite = Resources.Load<Sprite>("Sprites/" +items. ItemTitle);
        this.state =items. state;



    }




}
