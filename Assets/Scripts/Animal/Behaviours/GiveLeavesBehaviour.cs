using UnityEngine;
using UnityEngine.UI;

namespace Animals
{
    /// <summary>
    /// Makes the animal eat leaves.
    /// </summary>
    public class GiveLeavesBehaviour
    {
        /// <summary>
        /// Balloon object to enable where the text is put in.
        /// </summary>
        GameObject _balloon;

        /// <summary>
        /// UI Text element that displays the text.
        /// </summary>
        Text _text;

        /// <summary>
        /// Sets the variables.
        /// </summary>
        /// <param name="balloon"><see cref="GiveLeavesBehaviour._balloon"/></param>
        /// <param name="text"><see cref="GiveLeavesBehaviour._text"/></param>
        public GiveLeavesBehaviour(GameObject balloon, Text text) : base()
        {
            _balloon = balloon;
            _text = text;
        }

        /// <summary>
        /// Makes the animal eat leaves.
        /// </summary>
        /// <param name="text">Text to display when eating leaves.</param>
        public void EatLeaves(string text)
        {
            _balloon.SetActive(true);
            _text.text = text;
        }
    }
}
