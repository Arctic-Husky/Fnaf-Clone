using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    public bool Aberto { get; private set; } = false;

    private void Start()
    {
        gameObject.SetActive(Aberto);
    }

    public void Abrir()
    {
        Aberto = !Aberto;

        this.gameObject.SetActive(Aberto);
        //animacao
    }
}
