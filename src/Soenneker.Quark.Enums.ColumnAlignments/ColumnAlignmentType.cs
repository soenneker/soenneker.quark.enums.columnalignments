using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Cross-axis self-alignment values for grid or flex children.
/// </summary>
[EnumValue<string>]
public partial class ColumnAlignmentType
{
    /// <summary>
    /// Align to the start (flex-start).
    /// CSS/Tailwind token: self-start
    /// </summary>
    public static readonly ColumnAlignmentType Start = new("start");

    /// <summary>
    /// Align to the center.
    /// CSS/Tailwind token: self-center
    /// </summary>
    public static readonly ColumnAlignmentType Center = new("center");

    /// <summary>
    /// Align to the end (flex-end).
    /// CSS/Tailwind token: self-end
    /// </summary>
    public static readonly ColumnAlignmentType End = new("end");

    /// <summary>
    /// Stretch to fill the container.
    /// CSS/Tailwind token: self-stretch
    /// </summary>
    public static readonly ColumnAlignmentType Stretch = new("stretch");

    /// <summary>
    /// Align to the baseline.
    /// CSS/Tailwind token: self-baseline
    /// </summary>
    public static readonly ColumnAlignmentType Baseline = new("baseline");
}
