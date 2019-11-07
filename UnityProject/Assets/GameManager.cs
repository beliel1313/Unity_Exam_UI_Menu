using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public AudioMixer mixer;
    public Text loadingText;
    public Slider loadingBar;

    public void BGM_vol (float value)
    {
        mixer.SetFloat("VBGM", value);
    }

    public void SFX_vol(float value)
    {
        mixer.SetFloat("VSFX", value);
    }

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
