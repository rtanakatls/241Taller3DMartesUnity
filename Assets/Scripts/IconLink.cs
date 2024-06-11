using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class IconLink 
{
    [SerializeField] private Transform originalObject;
    [SerializeField] private Transform icon;

    public Transform OriginalObject
    {
        get
        {
            return originalObject;
        }
    }
    public Transform Icon
    {
        get
        {
            return icon;
        }
    }
}
