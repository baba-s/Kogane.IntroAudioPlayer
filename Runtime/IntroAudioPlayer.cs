using UnityEngine;

namespace Kogane
{
    [DisallowMultipleComponent]
    public sealed class IntroAudioPlayer : MonoBehaviour
    {
        //================================================================================
        // 変数(SerializeField)
        //================================================================================
        [SerializeField] private AudioSource m_introAudioSource;
        [SerializeField] private AudioSource m_loopAudioSource;

        //================================================================================
        // 関数
        //================================================================================
        /// <summary>
        /// 再生します
        /// </summary>
        public void Play
        (
            AudioClip introAudioClip,
            AudioClip loopAudioClip
        )
        {
            Stop();

            m_introAudioSource.clip = introAudioClip;
            m_introAudioSource.Play();
            m_loopAudioSource.clip = loopAudioClip;
            m_loopAudioSource.PlayScheduled( AudioSettings.dspTime + introAudioClip.length );
        }

        /// <summary>
        /// 停止します
        /// </summary>
        public void Stop()
        {
            m_introAudioSource.Stop();
            m_loopAudioSource.Stop();
        }

        /// <summary>
        /// 音量を設定します
        /// </summary>
        public void SetVolume( float volume )
        {
            m_introAudioSource.volume = volume;
            m_loopAudioSource.volume  = volume;
        }
    }
}