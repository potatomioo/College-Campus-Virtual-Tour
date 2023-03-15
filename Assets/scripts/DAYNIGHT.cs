using UnityEngine;

public class DAYNIGHT : MonoBehaviour
{
    public Material daySkybox;
    public Material nightSkybox;

    private bool isDaytime = true;

    void OnMouseDown()
    {
        if (isDaytime)
        {
            RenderSettings.skybox = nightSkybox;
        }
        else
        {
            RenderSettings.skybox = daySkybox;
        }
        isDaytime = !isDaytime;
    }
}
