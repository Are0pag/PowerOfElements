using UnityEngine;

namespace Resources.ScriptableObjects.Characters {

    [CreateAssetMenu(fileName = "NewScriptableChatacter", menuName = "ScriptableObjects/NewScriptableChatacter")]
	public class ScriptableChatacter : ScriptableObject {
        [SerializeField] private string _name;
		[SerializeField] private GameObject _prefab;
	} 
}
