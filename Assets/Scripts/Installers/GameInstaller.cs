using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private ObjectGrower _objectGrower;

    public override void InstallBindings()
    {
        Container.Bind<ObjectGrower>().FromInstance(_objectGrower).AsSingle();
    }
}
