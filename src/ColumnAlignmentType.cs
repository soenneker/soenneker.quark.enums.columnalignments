using Intellenum;

namespace Soenneker.Quark.Enums;

/// <summary>
/// An enumeration for Quark, representing Bootstrap flexbox column alignment values.
/// This enum contains the standard Bootstrap alignment values used for column positioning.
/// </summary>
[Intellenum<string>]
public partial class ColumnAlignmentType
{
    /// <summary>
    /// Align to the start (flex-start).
    /// Bootstrap class: align-self-start
    /// </summary>
    public static readonly ColumnAlignmentType Start = new("start");

    /// <summary>
    /// Align to the center.
    /// Bootstrap class: align-self-center
    /// </summary>
    public static readonly ColumnAlignmentType Center = new("center");

    /// <summary>
    /// Align to the end (flex-end).
    /// Bootstrap class: align-self-end
    /// </summary>
    public static readonly ColumnAlignmentType End = new("end");

    /// <summary>
    /// Stretch to fill the container.
    /// Bootstrap class: align-self-stretch
    /// </summary>
    public static readonly ColumnAlignmentType Stretch = new("stretch");

    /// <summary>
    /// Align to the baseline.
    /// Bootstrap class: align-self-baseline
    /// </summary>
    public static readonly ColumnAlignmentType Baseline = new("baseline");
}
