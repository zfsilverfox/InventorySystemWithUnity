using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using UnityEngine.EventSystems;



public class UIItemScript : 
    MonoBehaviour,IPointerDownHandler,IPointerEnterHandler,IPointerExitHandler
{
    public ItemScript items;

    private Image spriteImage;

    private UIItemScript selectedItemScript;
    private TooltipScript tooltipScript;


    private void Awake()
    {
        selectedItemScript = GameObject.Find("SelectedItems").GetComponent<UIItemScript>();
        tooltipScript = GameObject.Find("Tooltip").GetComponent<TooltipScript>();


        spriteImage = GetComponent<Image>();
        UpdateItemFunction(null);
    
    }
    public void UpdateItemFunction(ItemScript items) 
    {
        this.items = items;

        if (this.items != null) 
        {
            spriteImage.color = Color.white;
            spriteImage.sprite = items.IconSprite;
        }
        else 
        {
            spriteImage.color = Color.clear;

        }




    }

    public void OnPointerDown(PointerEventData eventData)
    {
   
        if(this.items != null) 
        {
            if(selectedItemScript.items != null) 
            {
                ItemScript cloneItemScript = new ItemScript(selectedItemScript.items);

                selectedItemScript.UpdateItemFunction(this.items);
                UpdateItemFunction(cloneItemScript);

            }
            else 
            {
                selectedItemScript.UpdateItemFunction(this.items);
                UpdateItemFunction(null);
            }



        }
        else if(selectedItemScript.items != null) 
        {
            UpdateItemFunction(selectedItemScript.items);
            selectedItemScript.UpdateItemFunction(null);
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
       if(this.items != null) 
        {

            tooltipScript.GenerateTooltipFunction(this.items);


        }


    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tooltipScript.gameObject.SetActive(false);
    }
}
