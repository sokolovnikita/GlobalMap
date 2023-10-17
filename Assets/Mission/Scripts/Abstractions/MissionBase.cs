using UnityEngine;

public abstract class MissionBase : MonoBehaviour
{
    [SerializeField] protected IChooseable _chooseStrategy;

    private void Start()
    {
        InitStrategies();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Choose();
    }

    public void Choose()
    {
        _chooseStrategy.Choose();
    }

    protected abstract void InitStrategies();
}
