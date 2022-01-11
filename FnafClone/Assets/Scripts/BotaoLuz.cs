using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoLuz : MonoBehaviour
{
    [SerializeField] private GameObject LuzAssociada;

    public static event Action<GameObject> OnClickLuz;

    public void Click()
    {
        OnClickLuz?.Invoke(LuzAssociada);
    }
}
