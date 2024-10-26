

namespace Scripts.GameControl {

    public abstract class GameState {
        public abstract void EnterState();
        public abstract void UpgradeState();
        public abstract void ExitState();
    } 
}