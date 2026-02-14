using Leap.Forward.IdleHelpers;
using System.ComponentModel;
using System.Runtime.CompilerServices;

[IdleViewModel]
public partial class GameViewModel : INotifyPropertyChanged
{
    public GameViewModel()
    {
    }

    [IdleProperty]
    private BigNumber _a = 1;

    [IdleProperty]
    private BigNumber _b = 1;

    [IdleProperty]
    private BigNumber _p = 1;

    [IdleProperty]
    private BigNumber _score = 0;

    [IdleProperty]
    private bool canUpgrade1;

    [PropertyUpdater]
    void UpdateCanUpgrade1()
    {
        CanUpgrade1 = Score >= 20;
    }


    [ClickHandler("Upgrade1")]
    public void IncrementA()
    {
        A += 1;
        Score -= 20;
    }

    [ClickHandler("Upgrade2")]
    public void IncrementB()
    {
        B += 1;
    }

    [ClickHandler("Upgrade3")]
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
