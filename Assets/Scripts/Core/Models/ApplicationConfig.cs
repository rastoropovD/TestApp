using UniRx;

public class ApplicationConfig
{
    public ReactiveProperty<bool> IsSoundEnabled { get; set; }
    public ReactiveProperty<bool> IsMusicEnabled { get; set; }

    public ApplicationConfig()
    {
        IsSoundEnabled = new ReactiveProperty<bool>(true);
        IsMusicEnabled = new ReactiveProperty<bool>(true);
    }
}
