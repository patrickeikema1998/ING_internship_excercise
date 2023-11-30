using UI;

namespace Animals
{

    /// <summary>
    /// Has both carnivore and herbivore behaviour.
    /// </summary>
    public class Omnivore : Animal
    {
        /// <summary>
        /// Behaviour to eat meat.
        /// </summary>
        private EatMeatBehaviour _eatMeat;

        /// <summary>
        /// Behaviour to eat leaves.
        /// </summary>
        private GiveLeavesBehaviour _giveLeaves;

        /// <summary>
        /// Instantiates the behavioural classes.
        /// </summary>
        private void Awake()
        {
            _eatMeat = new EatMeatBehaviour(_balloon, _text);
            _giveLeaves = new GiveLeavesBehaviour(_balloon, _text);
        }

        /// <summary>
        /// Adds the behaviour as a listener to both the Eat Meat and Eat Leaves buttons.
        /// </summary>
        protected override void Start()
        {
            base.Start();

            GiveMeatButton.eatMeat.AddListener(delegate { _eatMeat.EatMeat("I eat EVERYTHING"); });
            GiveLeavesButton.eatLeaves.AddListener(delegate { _giveLeaves.EatLeaves("EveryTHING"); });
        }
    }
}
