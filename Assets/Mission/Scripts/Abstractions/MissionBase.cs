using UnityEngine;

public abstract class MissionBase : MonoBehaviour
{
    [SerializeField] protected GameObject _hoverFrame;
    [SerializeField] protected Window _window;

    private bool _isHovered = false;

    public bool IsHovered
    {
        get { return _isHovered; }
        set 
        { 
            _isHovered = value;
            if (_isHovered == true)
                EnableFrame();
            if (_isHovered == false)
                DisableFrame();
        }
    }  

    public void EnableFrame()
    {
        _hoverFrame.SetActive(true);
    }

    public void DisableFrame()
    {
        _hoverFrame.SetActive(false);
    }

    public abstract void ShowStartWindow();
}
