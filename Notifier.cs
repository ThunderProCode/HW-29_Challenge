public class Notifier
{
    private CharberryTree _tree;

    public Notifier(CharberryTree tree)
    {
        _tree = tree;
        // Subscribe to the Ripened event
        _tree.Ripened += OnRipened;
    }

    // Event handler for Ripened event
    public void OnRipened(object sender, EventArgs e)
    {
        Console.WriteLine("A charberry fruit has ripened!");
    }
}
