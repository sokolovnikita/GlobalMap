using UnityEngine;
using Zenject;

public class WindowInstaller : MonoInstaller
{
    [SerializeField] private Window _windowPrefab;

    public override void InstallBindings()
    {
        BindWindow();
    }

    private void BindWindow()
    {
        Window window = Container.InstantiatePrefabForComponent<Window>
            (_windowPrefab, _windowPrefab.transform.position, Quaternion.identity, null);

        Container
            .Bind<Window>()
            .FromInstance(window)
            .AsSingle();
    }
}
