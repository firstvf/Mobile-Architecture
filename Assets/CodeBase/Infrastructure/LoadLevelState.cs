using Assets.CodeBase.CameraLogic;
using CodeBase.Infrastructure;
using UnityEngine;

namespace Assets.CodeBase.Infrastructure
{
    public class LoadLevelState : IPayloadedState<string>
    {
        private const string INITIAL_POINT = "InitialPoint";
        private readonly GameStateMachine _gameStateMachine;
        private readonly SceneLoader _sceneLoader;

        public LoadLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader)
        {
            _gameStateMachine = gameStateMachine;
            _sceneLoader = sceneLoader;
        }

        public void Enter(string sceneName)
        => _sceneLoader.Load(sceneName, OnLoaded);

        public void Exit()
        {

        }

        private void OnLoaded()
        {
            var initialPoint = GameObject.FindWithTag(INITIAL_POINT);

            var hero = Instantiate("Hero/hero", initialPoint.transform.position);
            Instantiate("Hud/Hud", Vector3.zero);
            CameraFollow(hero);
        }

        private void CameraFollow(GameObject target)
        => Instantiate("Hero/Camera", Vector3.zero).GetComponent<CameraFollow>().Follow(target);

        private GameObject Instantiate(string path, Vector3 at)
        {
            var prefab = Resources.Load<GameObject>(path);
            return Object.Instantiate(prefab, at, Quaternion.identity);
        }
    }
}