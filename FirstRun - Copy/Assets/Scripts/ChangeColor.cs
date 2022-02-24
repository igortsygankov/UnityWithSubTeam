using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color myColor;
    public int colorNum = 0;
    public Renderer renderer;

    public void changeTheColor()
    {

        renderer = gameObject.GetComponent<Renderer>();
        if (colorNum < 3)
        {
            colorNum++;
        }
        else
        {
            colorNum = 0;
        }

        switch (colorNum)
        {
            case 0:
                myColor = Color.white;
                break;
            case 1:
                myColor = Color.red;
                break;
            case 2:
                myColor = Color.green;
                break;
            case 3:
                myColor = Color.blue;
                break;
            default:
                myColor = Color.white;
                break;
        }

        renderer.material.color = myColor;
    }
}

 