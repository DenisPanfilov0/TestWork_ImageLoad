using CodeBase.AssetManagement;
using CodeBase.Infrastructure.Services;

namespace CodeBase.Infrastructure.States
{
    public class BootstrapState : IState
    {
        private readonly GameStateMachine _stateMachine;
        private readonly AllServices _services;

        public BootstrapState(GameStateMachine stateMachine, AllServices services)
        {
            _stateMachine = stateMachine;
            _services = services;

            RegisterServices();
        }

        public void Enter() => 
            _stateMachine.Enter<LoadLevelState>();

        public void Exit()
        {
        }

        private void RegisterServices() => 
            RegisterAssetProvider();

        private void RegisterAssetProvider()
        {
            AssetProvider assetProvider = new AssetProvider();
            assetProvider.Initialize();
            _services.RegisterSingle<IAssets>(assetProvider);
        }
    }
}