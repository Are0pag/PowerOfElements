using UnityEngine;

namespace Scripts.Characters {
    public abstract class StateProvider {
        public StateCharacter CurrentState { get; protected set; }
        protected Character _character;

        protected StateProvider(Character character) {
            _character = character;
        }

        public virtual void EnterState(StateCharacter state) {
            CurrentState.ExitState(ref _character);
            CurrentState = state;
            CurrentState.EnterState(ref _character);
        }
        public virtual void UpdateCurrentState() {
            CurrentState?.UpdateState(ref _character);
        }
    }
}