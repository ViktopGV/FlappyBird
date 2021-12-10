using UnityEngine;

public class PlayerInit : MonoBehaviour
{
    [SerializeField] private BirdContainer _birdsContainer;

    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        PlayerInitialization();
    }

    private void PlayerInitialization()
    {
        int activeBirdIndex = LoadPlayerData.LoadUsedPlayerBird();
        BirdScriptObj birdPlayer = _birdsContainer[activeBirdIndex];
        SetAnimatorController(birdPlayer.AnimatorController);
        SetRepresentationImage(birdPlayer.RepresentBirdImage);
    }

    private void SetAnimatorController(RuntimeAnimatorController animator)
    {
        _animator.runtimeAnimatorController = animator;
    }

    private void SetRepresentationImage(Sprite sprite)
    {
        _spriteRenderer.sprite = sprite;
    }

    public void SetPlayerBird(int index)
    {
        SetAnimatorController(_birdsContainer[index].AnimatorController);
        SetRepresentationImage(_birdsContainer[index].RepresentBirdImage);
        SavePlayerData.SaveUsedPlayerBird(index);
    }
}
