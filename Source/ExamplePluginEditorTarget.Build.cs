using Flax.Build;

public class ExamplePluginEditorTarget : GameProjectEditorTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for editor
        Modules.Add("ExamplePlugin");
        Modules.Add("ExamplePluginEditor");
    }
}
