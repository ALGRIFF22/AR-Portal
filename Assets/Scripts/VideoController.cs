using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{

	[SerializeField]
	private VideoPlayer videoPlayer;

	[SerializeField]
	private VideoClip videoClip;


	public IEnumerator PlayVideo(MeshRenderer renderer)
	{
		if (videoPlayer.targetMaterialRenderer == null)
		{
			videoPlayer.targetMaterialRenderer = renderer;
		}
		if (!videoPlayer.isPlaying)
		{
			if (videoPlayer.clip == null)
			{
				videoPlayer.clip = videoClip;
			}

			videoPlayer.Prepare();
			while (!videoPlayer.isPrepared)
			{
				yield return null;
			}
			Debug.Log("Video Prepared");

			videoPlayer.Play();
		}
		else if (videoPlayer.isPlaying)
		{
			yield return null;
		}
	}

	public IEnumerator PauseVideo()
	{
		if (videoPlayer.isPlaying)
		{
			videoPlayer.Pause();
		}
		else
		{
			 yield return null;
		}
	}

}
