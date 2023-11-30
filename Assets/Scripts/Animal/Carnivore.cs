using UI;

namespace Animals
{
    /// <summary>
    /// Behaviour of a carnivore.
    /// </summary>
    public class Carnivore : Animal
    {
        /// <summary>
        /// Behaviour to eat meat.
        /// </summary>
        private EatMeatBehaviour _eatMeat;

        private void Awake() => _eatMeat = new EatMeatBehaviour(_balloon, _text);

        /// <summary>
        /// Adds the behaviour as a listener to the Eat Meat button.
        /// </summary>
        protected override void Start()
        {
            base.Start();
            GiveMeatButton.eatMeat.AddListener(delegate { _eatMeat.EatMeat("nomnomnom"); });
        }
    }    
}
