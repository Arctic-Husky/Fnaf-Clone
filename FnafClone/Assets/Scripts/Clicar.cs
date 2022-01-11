using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicar : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private LayerMask Layer;

    private GameObject lastHit;

    private void Awake()
    {
        InputManager.Controls.Player.Click.started += ctx => Click();
    }

    private void Click()
    {
        RaycastHit hit;
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, 20f, Layer))
        {
            lastHit = hit.transform.gameObject;

            if (lastHit.layer == 7)
                lastHit.GetComponent<BotaoPorta>().Click();
            else if (lastHit.layer == 8)
                lastHit.GetComponent<BotaoLuz>().Click();

            Debug.Log(lastHit.name);
        }
    }
}
