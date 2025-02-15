using UnityEngine;
using UnityEngine.SceneManagement;

namespace SLibrary.StateExample
{
    /// <summary>
    /// The template for a state object
    /// </summary>
    public class MainMenuState : BaseGameStateMachineState
    {
        public override bool CanEnter(GameStateMachineStates lastState)
        {
            return base.CanEnter(lastState);
        }

        public override async void OnEnterState(GameStateMachineStates lastState)
        {
            base.OnEnterState(lastState);

            LevelManager.instance.LoadLevel(GameProperties.instance.mainMenuScene);
            
            UIManager.instance.mainMenuController.gameObject.SetActive(true);
        }

        public override void OnExitState(GameStateMachineStates nextState)
        {
            base.OnExitState(nextState);

            UIManager.instance.mainMenuController.gameObject.SetActive(false);
        }

        public override void Update()
        {
            base.Update();
        }

    }
}