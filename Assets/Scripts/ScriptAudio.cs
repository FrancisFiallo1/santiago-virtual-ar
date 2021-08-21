using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptAudio : MonoBehaviour
{
	public GameObject PanelPrincipal;
	public	AudioSource Audios;
	public Button BotonDeTransicion;
	public bool Reproduciendo;
    // Start is called before the first frame update
    void Start()
	{
		
		/*	if(PanelPrincipal.SetActive(true)){
		AudioSource[] audios = GameObject.Find("03 - PanelPrincipal").GetComponents<AudioSource>();
		audios[0].Play();//musica ambiental
		}*/
	
		
		Audios = GetComponent<AudioSource>();
		BotonDeTransicion = GetComponent<Button>();
		BotonDeTransicion.onClick.AddListener(AudioPlay);
		
        
    }

    void Update()
    {
	    
	
    }
    
		public void AudioPlay(){
		if(!Reproduciendo){
			Audios.Play();
			Reproduciendo = true;
		}
		else{
			Audios.Pause();
			Reproduciendo=false;
		}
	}
	
		
	}

