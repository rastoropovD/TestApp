using UnityEngine;
using Zenject;

public class DependencyInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IStorageService>().To<StorageService>().AsSingle();
        Container.Bind<ISettingsService>().To<SettingsService>().AsSingle();
    }
}