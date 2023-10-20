using UnityEngine;

public abstract class MissionWindowBase : MonoBehaviour
{
    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
