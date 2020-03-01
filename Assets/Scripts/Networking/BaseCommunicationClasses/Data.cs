﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public abstract class Data
{
    public string ToJSon()
    {
        return JsonUtility.ToJson(this);
    }

    public abstract void SetValues(string d);
}
