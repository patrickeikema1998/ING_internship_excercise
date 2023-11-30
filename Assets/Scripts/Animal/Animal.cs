using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Animals
{

    /// <summary>
    /// Base class of all animals. Currently only has talk behaviour.
    /// </summary>
    [RequireComponent(typeof(AnimalMovement))]
    public class Animal : MonoBehaviour
    {
        /// <summary>
        /// Balloon that gets enabled when talking
        /// </summary>
        [SerializeField]
        protected GameObject _balloon;

        /// <summary>
        /// UI Text component to configure the text.
        /// </summary>
        [SerializeField]
        protected Text _text;

        /// <summary>
        /// Name of the animal.
        /// </summary>
        [SerializeField]
        protected string _name;

        /// <summary>
        /// The actual text the animal says when saying hello.
        /// </summary>
        [SerializeField]
        protected string _talkText;

        /// <summary>
        /// Behaviour to say hello.
        /// </summary>
        protected TalkBehaviour _talkBehaviour;

        /// <summary>
        /// Movement of the animal.
        /// </summary>
        private AnimalMovement _movement;

        /// <summary>
        /// <see cref="Animal._movement"/>
        /// </summary>
        public AnimalMovement movement => _movement;

        /// <summary>
        /// Makes the animal talk if either the textfield is empty, or the animals <see cref="Animal._name"/> is typed in the field.
        /// </summary>
        protected virtual void Start()
        {
            _movement = GetComponent<AnimalMovement>();

            _talkBehaviour = new TalkBehaviour(_balloon, _text);

            if(_movement.CanDoTrick)
                TrickButton.trick.AddListener(delegate { _movement.SpiralMovement.StartSpin(this); }) ;

            HelloButton.s_animalsTalk.AddListener(delegate (string enteredName)
            {
                if(string.IsNullOrEmpty(enteredName) || enteredName == _name)
                    _talkBehaviour.Talk(_talkText);
            });
        }
    }
}
