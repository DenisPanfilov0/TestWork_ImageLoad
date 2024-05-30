using CodeBase.UI;
using UnityEngine;
using CodeBase.AssetManagement;

namespace CodeBase.Infrastructure.States
{
    public class LoadLevelState : IState
    {
        private readonly GameStateMachine _stateMachine;
        private readonly IAssets _assets;

        public LoadLevelState(GameStateMachine stateMachine, IAssets assets)
        {
            _stateMachine = stateMachine;
            _assets = assets;
        }

        public void Enter()
        {
            var allLoadSprites = Object.FindObjectsOfType<LoadSprite>();

            foreach (var loadSprite in allLoadSprites) 
                loadSprite.Construct(_assets);

            var prefabSpawner = Object.FindObjectOfType<LoadPrefab>();
            prefabSpawner.Construct(_assets);
            
            // _assets.CleanUp();
        }

        public void Exit()
        {
        }
    }
}