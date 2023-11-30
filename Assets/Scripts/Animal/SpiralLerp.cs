using Animals;
using System.Collections;
using UnityEngine;

namespace Animals
{
    public class SpiralMovement
    {
        /// <summary>
        /// The speed of the movement.
        /// </summary>
        private const float speed = .1f;

        /// <summary>
        /// The increment of the angle per frame.
        /// </summary>
        private const float angleIncrement = .04f;

        /// <summary>
        /// The maximum angle to stop the movement.
        /// </summary>
        private const float maxAngle = 4 * Mathf.PI;

        /// <summary>
        /// The radius of the spiral.
        /// </summary>
        private float _currentRadius = .5f;

        /// <summary>
        /// The angle of the spiral.
        /// </summary>
        private float _currentAngle = 0f;

        /// <summary>
        /// Current position of the animal.
        /// </summary>
        private Vector3 _startPosition;

        /// <summary>
        /// Starts spinning the animal on the Archimedes spiral.
        /// </summary>
        /// <param name="animal">Animal to spin.</param>
        /// <returns></returns>
        public IEnumerator spin(Animal animal)
        {
            animal.movement.canMove = false;

            _startPosition = animal.transform.position;

            // Check if the angle has reached the maximum
            while (_currentAngle < maxAngle)
            {
                // Calculate the position based on the archimedes spiral formula
                // x = r * cos(theta)
                // y = r * sin(theta)
                // r = a + b * theta

                float x = (_currentRadius + _currentAngle) * Mathf.Cos(_currentAngle);
                float y = (_currentRadius + _currentAngle) * Mathf.Sin(_currentAngle);

                // Move the transform to the position
                animal.transform.position = _startPosition + new Vector3(x, y, 0f);

                // Increase the angle by the increment
                _currentAngle += angleIncrement;

                // Increase the radius by the speed
                _currentRadius += speed * _currentAngle * Time.deltaTime;

                yield return null; // Wait for the next frame
            }

            ResetValues();
            animal.movement.canMove = true;
        }

        /// <summary>
        /// Starts the coroutine.
        /// </summary>
        /// <param name="animal">Animal to spin.</param>
        public void StartSpin(Animal animal) => animal.StartCoroutine(spin(animal));

        /// <summary>
        /// Resets the values afterwards to make another spin possible.
        /// </summary>
        private void ResetValues()
        {
            _currentRadius = .5f;
            _currentAngle = 0f;
        }
    }
}