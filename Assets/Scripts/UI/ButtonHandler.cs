using Animals;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


namespace UI
{
    [RequireComponent(typeof(Button))]
    public abstract class ButtonHandler : MonoBehaviour
    {
        /// <summary>
        /// Adds the function as a listener to the button.
        /// </summary>
        private void Start()
        {
            Button button = GetComponent<Button>();

            if (button != null)
                button.onClick.AddListener(HandleButtonClick);
            else
                Debug.LogError("Button component not found on GameObject: " + gameObject.name);

        }

        /// <summary>
        /// The button executes this function.
        /// </summary>
        protected virtual void HandleButtonClick()
        {
        }
    }
}
