using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    public Vector3 ReadInput()
    {
        int y = 0;
        if (Input.GetKey(KeyCode.W))
            y = 1;
        else if (Input.GetKey(KeyCode.S))
            y = -1;

        int x = 0;
        if (Input.GetKey(KeyCode.D))
            x = 1;
        else if (Input.GetKey(KeyCode.A))
            x = -1;

        if (x != 0 || y != 0)
        {
            Vector3 direction = new Vector3(x, y, 0);
            return direction;
        }
        
        return Vector3.zero;
    }

    public bool ReadUndo()
    {
        return Input.GetKey(KeyCode.R);
    }

    public int ReadScale()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            return 1;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            return -1;
        }

        return 0;
    }
}
