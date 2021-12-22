using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ChooseSkinPanel : MonoBehaviour
{
    public UnityEvent BirdSelected;

    [SerializeField] private RectTransform _itemPrefab;
    [SerializeField] private BirdContainer _birdContainer;
    [SerializeField] private PlayerInit _player;

    private void Awake()
    {
        for(int i = 0; i < _birdContainer.Count; ++i)
        {
            CreateItem(i);            
        }
    }

    private void CreateItem(int index)
    {
        RectTransform item = Instantiate(_itemPrefab, transform, false);
        Image birdImage = item.GetChild(0).GetComponent<Image>();
        Text birdName = item.GetChild(1).GetComponent<Text>();
        Text birdDesc = item.GetChild(2).GetComponent<Text>();
        Button selectBirdBtn = item.GetChild(3).GetComponent<Button>();

        birdName.text = _birdContainer[index].Name;
        birdDesc.text = _birdContainer[index].Description;
        birdImage.sprite = _birdContainer[index].RepresentBirdImage;
        selectBirdBtn.onClick.AddListener(() =>
        {
            _player.SetPlayerBird(index);
            BirdSelected?.Invoke();
            gameObject.SetActive(false);
        });
    }
}
