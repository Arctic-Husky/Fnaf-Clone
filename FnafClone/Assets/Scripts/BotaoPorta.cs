using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoPorta : MonoBehaviour
{
    [SerializeField] private GameObject PortaAssociada;

    public static event Action<GameObject> OnClickAbrir;

    public void Click()
    {
        OnClickAbrir?.Invoke(PortaAssociada);
    }
}
