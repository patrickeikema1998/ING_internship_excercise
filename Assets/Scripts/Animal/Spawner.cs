using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private Canvas _parent;

        [SerializeField]
        private List<GameObject> _animalsToSpawn;

        public List<GameObject> Animals => _animalsToSpawn;

        RectTransform _transform;

        private void Start() 
        { 
            _transform = _parent.GetComponent<RectTransform>();

            foreach (GameObject animal in _animalsToSpawn)
            {
                float left = _transform.rect.xMax - _transform.rect.width / 2;
                float right = _transform.rect.xMax + _transform.rect.width / 2;
                float up = _transform.rect.yMax + _transform.rect.height / 2;
                float down = _transform.rect.yMax - _transform.rect.height / 2;

                float posX = Random.Range(left, right);
                float posY = Random.Range(up, down);

                Instantiate(animal, new Vector3(posX, posY, 0), Quaternion.identity, _parent.transform);
            }
        }

        private void Update()
        {
        }
    }
}
