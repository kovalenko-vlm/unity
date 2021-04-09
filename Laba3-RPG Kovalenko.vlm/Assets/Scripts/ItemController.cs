using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ItemController : MonoBehaviour, Interactable
    {
        private float radius = 1;
        public float Radius => radius;

        [SerializeField] private Canvas canvas;
        [SerializeField] private Button button;
        [SerializeField] private TMP_Text text;

        public void Interact()
        {
            Time.timeScale = 0;

            text.text = "Nice sphere!";

            button.onClick.AddListener(OnClickInteract);

            canvas.gameObject.SetActive(true);
        }

        private void OnClickInteract()
        {
            Time.timeScale = 1;
            canvas.gameObject.SetActive(false);

            button.onClick.RemoveListener(OnClickInteract);

            Destroy(gameObject);
        }
    }
}