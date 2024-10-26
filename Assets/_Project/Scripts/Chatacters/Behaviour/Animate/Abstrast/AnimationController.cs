using UnityEditor;
using UnityEngine;

namespace Scripts.Characters {
    public class AnimationController : MonoBehaviour {
        [SerializeField] protected Animator _animator;

        #region AnimationsNames
        public const string IDLE_ANIMATION_NAME = "Idle";
        public const string MOVE_ANIMATION_NAME = "Move";
        public const string ATTACK_ANIMATION_NAME = "Attack";
        #endregion

        public virtual void PlayAnimation(string animationName) {
            if (_animator == null) {
                _animator.Play(animationName);
            }
            else {
                throw new System.Exception("Animator == null");
            }
        }

    }
}