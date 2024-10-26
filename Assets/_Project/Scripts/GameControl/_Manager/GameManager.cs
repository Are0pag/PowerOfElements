using UnityEngine;

namespace Scripts.GameControl {
	public class GameManager : MonoBehaviour {
		public static GameState CurrentState {  get; private set; }

		public static void SwithState(GameState state) {
			CurrentState.ExitState();
			CurrentState = state;
			state.EnterState();
		}

        private static void Update() {
            CurrentState?.UpgradeState();
        }
    } 
}