using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenarioManager : MonoBehaviour
{
    //[SerializeField] private GameObject BotaoPorta;
    //[SerializeField] private GameObject BotaoLuz;

    // Start is called before the first frame update
    void Start()
    {
        BotaoPorta.OnClickAbrir += Abrir;
        BotaoLuz.OnClickLuz += Acender;
    }

    private void OnDestroy()
    {
        BotaoPorta.OnClickAbrir -= Abrir;
        BotaoLuz.OnClickLuz += Acender;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Abrir(GameObject portaAssociada)
    {
        Porta portaTemp = portaAssociada.GetComponent<Porta>();
        portaTemp.Abrir();
    }

    void Acender(GameObject luzAssociada)
    {
        Light luzTemp = luzAssociada.GetComponent<Light>();
        luzTemp.enabled = !luzTemp.enabled;
    }
}
