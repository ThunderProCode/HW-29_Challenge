using System;

public class CharberryTree
{
    private Random _random = new Random();

    public bool Ripe { get; set; }

    // Event declaration
    public event EventHandler Ripened;

    public void MaybeGrow()
    {
        // Only a tiny chance of ripening each time, but we try a lot!
        if (_random.NextDouble() < 0.00000001 && !Ripe)
        {
            Ripe = true;
            // Raise the Ripened event when the tree ripens
            OnRipened();
        }
    }

    protected virtual void OnRipened()
    {
        // Check if there are any subscribers to the Ripened event
        EventHandler handler = Ripened;
        if (handler != null)
        {
            // Raise the event
            handler(this, EventArgs.Empty);
        }
    }
}
