using UnityEngine;

namespace Scripts.Characters {
    public abstract class StateCharacter {
		public abstract void EnterState(ref Character character);
		public abstract void UpdateState(ref Character character);
		public abstract void ExitState(ref Character character);
	} 
}