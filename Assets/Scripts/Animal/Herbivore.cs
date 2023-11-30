using UI;

namespace Animals
{
    /// <summary>
    /// Has behaviour of a herbivore animal.
    /// </summary>
    public class Herbivore : Animal
    {
        /// <summary>
        /// Behaviour to eat leaves.
        /// </summary>
        private GiveLeavesBehaviour _giveLeaves;

        /// <summary>
        /// Instantiates the behaviour.
        /// </summary>
        private void Awake() => _giveLeaves = new GiveLeavesBehaviour(_balloon, _text);

        /// <summary>
        /// Adds the behaviour as a listener to the Eat Leaves button.
        /// </summary>
        protected override void Start()
        {
            base.Start();

            GiveLeavesButton.eatLeaves.AddListener(delegate { _giveLeaves.EatLeaves("Leaves are tasty!"); });
        }
    }
}
