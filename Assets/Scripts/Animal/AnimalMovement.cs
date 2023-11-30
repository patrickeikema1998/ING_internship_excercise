using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Animals
{
    /// <summary>
    /// Contains all movement of the animal.
    /// </summary>
    public class AnimalMovement : MonoBehaviour
    {
        /// <summary>
        /// Positions on the borders of the screen.
        /// </summary>
        [SerializeField]
        private int _left, _right, _top, _bottum;

        /// <summary>
        /// Speed of the movement.
        /// </summary>
        [SerializeField]
        private float _speed;

        /// <summary>
        /// If the animal is able to do a trick.
        /// </summary>
        [SerializeField]
        private bool _canDoTrick;

        /// <summary>
        /// <see cref="AnimalMovement._canDoTrick"/>
        /// </summary>
        public bool CanDoTrick => _canDoTrick;

        /// <summary>
        /// Contains the spiral movement behaviour.
        /// </summary>
        private SpiralMovement _spiralMovement = new SpiralMovement();

        /// <summary>
        /// <see cref="AnimalMovement._spiralMovement"/>
        /// </summary>
        public SpiralMovement SpiralMovement => _spiralMovement;

        /// <summary>
        /// Next goal to move to.
        /// </summary>
        private Vector3 goal;

        /// <summary>
        /// If the animal is able to move.
        /// </summary>
        public bool canMove = true;

        /// <summary>
        /// 
        /// </summary>
        private void Start() => PickGoal();

        /// <summary>
        /// 
        /// </summary>
        private void Update()
        {
            if (canMove)
            {
                Vector3 direction = goal - transform.localPosition;
                transform.Translate(direction.normalized * _speed * Time.deltaTime);
                if (direction.magnitude < 5)
                    PickGoal();
            }
        }

        private void PickGoal()
        {
            goal = new Vector2(
                Random.Range(_left, _right),
                Random.Range(_bottum, _top));
        }
    }
}
