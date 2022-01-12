using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Image imagem;

    public bool isOver { get; private set; } = false;

    public static event Action OnPointerEntered;

    public void OnPointerEnter(PointerEventData eventData)
    {
        isOver = true;
        imagem.color = new Color(imagem.color.r, imagem.color.g, imagem.color.b, 0.15f);
        Debug.Log("Mouse OVER");
        OnPointerEntered?.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse OUT");
        isOver = false;
        imagem.color = new Color(imagem.color.r, imagem.color.g, imagem.color.b, 0.04f);
    }
}
