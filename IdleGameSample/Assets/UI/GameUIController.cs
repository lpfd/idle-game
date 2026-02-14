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

        // 1. Get a reference to the root element
        var root = _uiDocument.rootVisualElement;

        // 2. Set the DataSource (this is the key for Data Binding)
        root.dataSource = _viewModel;

        // 3. Manually hook up the button click (Logic side)
        var button = root.Q<Button>("Upgrade1");
        if (button != null)
        {
            button.clicked += () => _viewModel.IncrementA();
        }
        button = root.Q<Button>("Upgrade2");
        if (button != null)
        {
            button.clicked += () => _viewModel.IncrementB();
        }
        button = root.Q<Button>("Upgrade3");
        if (button != null)
        {
            button.clicked += () => _viewModel.IncrementP();
        }
    }

    private void Update()
    {
        var dt = Time.deltaTime;

        var scorePerSec = (_viewModel.A * _viewModel.B).Pow((double)_viewModel.P);

        _viewModel.Score += dt * scorePerSec;
    }
}
