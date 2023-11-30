using UnityEngine;
using UnityEngine.UI;

namespace Animals
{
    /// <summary>
    /// Makes the animals eat meat.
    /// </summary>
    public class EatMeatBehaviour
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
        /// Sets the variables
        /// </summary>
        /// <param name="balloon"><see cref="EatMeatBehaviour._balloon"/></param>
        /// <param name="text"><see cref="EatMeatBehaviour._text"/></param>
        public EatMeatBehaviour(GameObject balloon, Text text)
        {
            _balloon = balloon;
            _text = text;
        }

        /// <summary>
        /// Makes the animal eat meat.
        /// </summary>
        /// <param name="text">Text to display when eating meat.</param>
        public void EatMeat(string text)
        {
            _balloon.SetActive(true);
            _text.text = text;
        }
    }
}
