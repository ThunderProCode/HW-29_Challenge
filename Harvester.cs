public class Harvester
{
    private CharberryTree _tree;

    public Harvester(CharberryTree tree)
    {
        _tree = tree;
        // Subscribe to the Ripened event
        _tree.Ripened += OnRipened;
    }

    // Event handler for Ripened event
    public void OnRipened(object sender, EventArgs e)
    {
        // Harvest the fruit by setting the Ripe property back to false
        _tree.Ripe = false;
    }
}
