using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class GameUIController : MonoBehaviour
{
    private GameViewModel _viewModel;
    private UIDocument _uiDocument;

    void OnEnable()
    {
        _viewModel = new GameViewModel();
        _uiDocument = GetComponent<UIDocument>();

        _viewModel.BindTo(_uiDocument);
    }

    private void Update()
    {
        var dt = Time.deltaTime;

        var scorePerSec = (_viewModel.A * _viewModel.B).Pow((double)_viewModel.P);

        _viewModel.Score += dt * scorePerSec;
    }
}
