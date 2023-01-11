using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer _videoPlayer;

    private void Start() => _videoPlayer.Prepare();
}
