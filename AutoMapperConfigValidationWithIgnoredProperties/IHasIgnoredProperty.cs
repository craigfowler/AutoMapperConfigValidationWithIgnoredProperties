namespace ConfigValidation;

public interface IHasIgnoredProperty
{
    /// <summary>
    /// Represents a property that should always be ignored when mapping any destination object.
    /// </summary>
    /// <remarks>
    /// <para>
    /// In reality this is a contextual property that is used for framework/architectural purposes but is
    /// never relevant to any mapping operation.
    /// </para>
    /// </remarks>
    string? IgnoredProperty { get; set; }
}