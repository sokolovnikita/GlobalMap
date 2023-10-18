using UnityEngine;

public abstract class MissionBase : MonoBehaviour
{
    [SerializeField] protected IChooseable _chooseStrategy;
    [SerializeField] protected GameObject _hoverFrame;

    private bool _isHovered = false;
   

    private void Start()
    {
        InitStrategies();
    }

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

    public void Select()
    {
        _chooseStrategy.Choose();
    }

    public void EnableFrame()
    {
        _hoverFrame.SetActive(true);
    }

    public void DisableFrame()
    {
        _hoverFrame.SetActive(false);
    }

    protected abstract void InitStrategies();
}
