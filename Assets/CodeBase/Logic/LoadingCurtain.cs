using System.Collections;
using UnityEngine;

namespace Assets.CodeBase.Logic
{
    public class LoadingCurtain : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _curtain;
        private WaitForSeconds _fadeInTimer = new(0.03f);

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }

        public void Show()
        {
            gameObject.SetActive(true);
            _curtain.alpha = 1f;
        }

        public void Hide()
        => StartCoroutine(FadeIn());

        private IEnumerator FadeIn()
        {
            while (_curtain.alpha > 0)
            {
                _curtain.alpha -= 0.03f;
                yield return _fadeInTimer;
            }

            gameObject.SetActive(false);
        }
    }
}