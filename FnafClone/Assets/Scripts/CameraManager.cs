using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> cameraPoints;
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject defaultPoint;
    [SerializeField] private GameObject mainCameraPonto;
    [SerializeField] private GameObject postFx;

    private bool isPainelAberto = false;
    private Volume volume;

    private void Awake()
    {
        volume = postFx.GetComponent<Volume>();
        MouseOver.OnPointerEntered += AbrirCamera;
    }

    private void OnDestroy()
    {
        MouseOver.OnPointerEntered -= AbrirCamera;
    }

    public void AbrirCamera()
    {
        Debug.Log("Camera aberta");
        if (isPainelAberto)
        {
            VoltarPraMain();
            return;
        }

        FilmGrain filmGrain;

        if (volume.profile.TryGet<FilmGrain>(out filmGrain))
        {
            filmGrain.intensity.value = 1f;
        }

        mainCamera.transform.position = defaultPoint.transform.position;
        mainCamera.transform.rotation = defaultPoint.transform.rotation;
        isPainelAberto = true;
    }

    public void MudarParaCamera(GameObject pontoDeCamera)
    {
        mainCamera.transform.position = pontoDeCamera.transform.position;
        mainCamera.transform.rotation = pontoDeCamera.transform.rotation;
        defaultPoint = pontoDeCamera;
    }

    public void VoltarPraMain()
    {
        Debug.Log("Voltar pra Main");
        Debug.Log(mainCamera.transform.position + " " + mainCameraPonto.transform.position);

        FilmGrain filmGrain;

        if (volume.profile.TryGet<FilmGrain>(out filmGrain))
        {
            filmGrain.intensity.value = 0f;
        }

        mainCamera.transform.position = mainCameraPonto.transform.position;
        mainCamera.transform.rotation = mainCameraPonto.transform.rotation; 
        isPainelAberto = false;
    }
}
