using UnityEngine;
using UnityEngine.UI;

namespace Animals
{
    /// <summary>
    /// Makes the animal talk.
    /// </summary>
    public class TalkBehaviour
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
        /// <param name="balloon"><see cref="TalkBehaviour._balloon"/></param>
        /// <param name="text"><see cref="TalkBehaviour._text"/></param>
        public TalkBehaviour(GameObject balloon, Text text)
        {
            _balloon = balloon;
            _text = text;
        }

        /// <summary>
        /// Makes the animal talk.
        /// </summary>
        /// <param name="text">Text to display when talking.</param>
        public void Talk(string text)
        {
            _balloon.SetActive(true);
            _text.text = text;
        }
    }
}
