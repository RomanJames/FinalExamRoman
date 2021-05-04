using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    
    public int Value = 0;
    public UnityEngine.UI.Text TextObject = null;

    public void Increment()
    {
        if (TextObject != null)
        {
            ++Value;
            TextObject.text = Value.ToString();
        }
    }

    public void Decrement()
    {
        if (TextObject != null)
        {
            --Value;
            TextObject.text = Value.ToString();
        }
    }

}
