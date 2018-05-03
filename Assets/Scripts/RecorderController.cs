using UnityEngine;
using UTJ.FrameCapturer;

public class RecorderController : MonoBehaviour
{
    public Camera RenderCamera;
    private MovieRecorder recorder;
    private bool isRecord = false;

    void Start()
    {
        recorder = RenderCamera.GetComponent<MovieRecorder>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isRecord = !isRecord;

            if (isRecord)
            {
                StartVideoCapture();
            }

            if (!isRecord)
            {
                StopVideoCapture();
            }
        }
    }

    void StartVideoCapture()
    {
        var success = recorder.BeginRecording();
        Debug.Log(string.Format("BeginRecording -> {0}", success));
    }

    void StopVideoCapture()
    {
        recorder.EndRecording();
        Debug.Log("EndRecording");
    }
}