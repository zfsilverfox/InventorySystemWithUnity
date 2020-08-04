using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsFollowMouseScript : MonoBehaviour
{


    private void Update()
    {
        transform.position = Input.mousePosition;

    }



}
