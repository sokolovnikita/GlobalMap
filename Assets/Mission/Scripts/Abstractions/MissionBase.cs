using UnityEngine;
using Zenject;

public abstract class MissionBase : MonoBehaviour, IMission
{
    [SerializeField] protected GameObject _hoverFrame;
    [SerializeField] protected MissionStateMachine.MissionState _startState;

    protected Window _window;

    private MissionStateMachine _stateMachine;

    [Inject]
    private void Construct(Window window)
    {
        _window = window;
    }

    private void Start()
    {
        _stateMachine = new MissionStateMachine(this, _startState);
    }

    public void Hover(bool isHovered)
    {
        _stateMachine.CurrentState.Hover(isHovered);
    }

    public void ShowWindow()
    {
        _stateMachine.CurrentState.ShowWindow();
    }

    public void HoverFrame(bool isHovered)
    {
        if (isHovered == true)
            EnableFrame();
        if (isHovered == false)
            DisableFrame();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    private void EnableFrame()
    {
        _hoverFrame.SetActive(true);
    }

    private void DisableFrame()
    {
        _hoverFrame.SetActive(false);
    }

    public abstract void ShowStartWindow();
}
