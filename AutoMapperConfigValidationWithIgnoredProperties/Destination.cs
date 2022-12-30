namespace ConfigValidation;

public class Destination : IHasIgnoredProperty
{
    public string? IgnoredProperty { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }
}
