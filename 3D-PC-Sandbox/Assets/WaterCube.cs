using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCube : MonoBehaviour
{
    
    public void showIt(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void hideIt(GameObject obj)
    {
        obj.SetActive(false);
    }

}