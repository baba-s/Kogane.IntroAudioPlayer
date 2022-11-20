# Kogane Intro Audio Player

AudioClip のイントロ付きループ再生ができるコンポーネント

## 使用例

```cs
using Kogane;
using UnityEngine;

public sealed class Example : MonoBehaviour
{
    [SerializeField] private IntroAudioPlayer m_player;
    [SerializeField] private AudioClip        m_introAudioClip;
    [SerializeField] private AudioClip        m_loopAudioClip;

    private void Start()
    {
        // 再生します
        m_player.Play
        (
            introAudioClip: m_introAudioClip,
            loopAudioClip: m_loopAudioClip
        );

        // 停止します
        m_player.Stop();

        // 音量を設定します
        m_player.SetVolume( 1.0f );
    }
}
```

![2022-11-20_211900](https://user-images.githubusercontent.com/6134875/202901533-281bb9eb-2bb4-4e05-b04c-808a63ccd5bc.png)
