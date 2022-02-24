using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTexture : MonoBehaviour
{
    [SerializeField]
    private GameObject ground;

    [SerializeField]
    private Texture[] textures;

    private Renderer groundRenderer;
    
    private int randomTextureIndex;

    // Start is called before the first frame update
    void Start()
    {
        groundRenderer = ground.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeGroundTexture);
        
    }


    private void ChangeGroundTexture()
    {
        randomTextureIndex = Random.Range(0, textures.Length);
        groundRenderer.material.mainTexture = textures[randomTextureIndex];
    }
}
