using LeapForward.IdleHelpers;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Unity.Properties;

public class GameViewModel : INotifyPropertyChanged
{
    public GameViewModel()
    {
    }

    private BigNumber _a = 1;
    private BigNumber _b = 1;
    private BigNumber _p = 1;
    private BigNumber _score = 0;

    [CreateProperty]
    public BigNumber Score
    {
        get => _score;
        set
        {
            if (_score != value)
            {
                _score = value;
                OnPropertyChanged();
            }
        }
    }

    [CreateProperty]
    public BigNumber A
    {
        get => _a;
        set
        {
            if (_a != value)
            {
                _a = value;
                OnPropertyChanged();
            }
        }
    }

    [CreateProperty]
    public BigNumber B
    {
        get => _b;
        set
        {
            if (_b != value)
            {
                _b = value;
                OnPropertyChanged();
            }
        }
    }

    [CreateProperty]
    public BigNumber P
    {
        get => _p;
        set
        {
            if (_p != value)
            {
                _p = value;
                OnPropertyChanged();
            }
        }
    }

    public void IncrementA()
    {
        A += 1;
    }

    public void IncrementB()
    {
        B += 1;
    }

    public void IncrementP()
    {
        P += 1;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}