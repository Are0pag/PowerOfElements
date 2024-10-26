using System;
using UnityEngine;

namespace Scripts.Characters {
    public abstract class Character : MonoBehaviour, IStateChangable, IElement, IAnimatable {
        public StateProvider StateProvider { get; protected set; }        
        public Element Element { get; protected set; }
        public AnimationController AnimationController { get; protected set; }
        
        public virtual void Init(StateProvider stateProvider, Element element, AnimationController animationController) {
            StateProvider = stateProvider;
            Element = element;
            AnimationController = animationController;
        }

        protected virtual void Update() {
            StateProvider.UpdateCurrentState();
        }
    }
}
