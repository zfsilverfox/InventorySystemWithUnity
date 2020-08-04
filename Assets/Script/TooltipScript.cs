using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;



public class TooltipScript : MonoBehaviour
{
    Text tooltipText;

    private void Awake()
    {
        GetComponentFunction();
    }

    //Function : GetComponentFunction
        //Method : This is the Function that used 
        //For Getting The Component
    void GetComponentFunction() 
    {
        tooltipText = GetComponentInChildren<Text>();
     //   gameObject.SetActive(false);
    }

    //Function : GenerateTooltipFunction
        //Method : This is the Function that used 
            //For Generate Tooltip
    public void GenerateTooltipFunction(ItemScript items) 
    {

        string statText = "";
        if (items.state.Count > 0) 
        {
            foreach (var stat in items.state) 
            {

                statText += stat.Key.ToString()+ ":" + stat.Value+ "\n";
            }
        }


        string tooltipstringText = string.Format("<b>{0}</b>\n" +
            "Description:{1} \n \n,<b>{2}</b>",items.ItemTitle,items.Description,statText);

        tooltipText.text = tooltipstringText;
        gameObject.SetActive(true);
    }

}
