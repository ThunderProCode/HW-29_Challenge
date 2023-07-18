public class Program
{
    public static void Main()
    {
        CharberryTree tree = new CharberryTree();
        Notifier notifier = new Notifier(tree);
        Harvester harvester = new Harvester(tree);

        while (true)
        {
            tree.MaybeGrow();
        }
    }
}
