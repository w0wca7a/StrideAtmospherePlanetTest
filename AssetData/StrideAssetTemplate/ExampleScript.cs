using Stride.Core.Mathematics;
using Stride.Engine;

namespace StrideAssetTemplate;

/// <summary>
/// Example drop-in <see cref="SyncScript"/> — the "attach it and press play" entry point of your
/// asset. Replace it with your real component(s); keep the pattern:
/// <list type="bullet">
/// <item>a <c>[ComponentCategory]</c> so users find it in Game Studio's component picker,</item>
/// <item>public properties with defaults that work out of the box,</item>
/// <item>XML docs — they show up as tooltips in Game Studio.</item>
/// </list>
/// </summary>
[ComponentCategory("Template")]
public class ExampleScript : SyncScript
{
    /// <summary>Message drawn on screen while the script runs (proof it's alive).</summary>
    public string Message { get; set; } = "Hello from StrideAssetTemplate — replace me!";

    public override void Update()
    {
        DebugText.Print(Message, new Int2(20, 20));
    }
}
