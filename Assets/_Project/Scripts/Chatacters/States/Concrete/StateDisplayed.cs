using UnityEngine;

namespace Scripts.Characters {
	public class StateDisplayed : StateCharacter  {
        public override void EnterState(ref Character character) {
            character.AnimationController.PlayAnimation(AnimationController.IDLE_ANIMATION_NAME);
        }

        public override void UpdateState(ref Character character) {

        }

        public override void ExitState(ref Character character) {

        }
    } 
}