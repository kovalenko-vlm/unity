﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D info)
    {
        ServiceManager.Instance.EndLevel();
    }
}
