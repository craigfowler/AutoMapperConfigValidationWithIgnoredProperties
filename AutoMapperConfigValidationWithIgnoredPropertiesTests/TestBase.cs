using AutoMapper;
using NUnit.Framework;

namespace ConfigValidation;

[TestFixture]
public abstract class TestBase
{
    [Test]
    public void ConfigShouldBeValid()
    {
        var mapperConfig = GetConfig();
        mapperConfig.AssertConfigurationIsValid();
    }

    [Test]
    public void IgnoredPropertyShouldNotBeMapped()
    {
        var source = new Source
        {
            Name = "Foo",
            Description = "Bar",
        };
        var mapper = GetConfig().CreateMapper();
        var result = mapper.Map<Destination>(source);

        Assert.Multiple(() =>
        {
            Assert.That(result, Has.Property(nameof(Destination.Name)).EqualTo("Foo"), $"{nameof(Destination.Name)} property has correct value");
            Assert.That(result, Has.Property(nameof(Destination.Description)).EqualTo("Bar"), $"{nameof(Destination.Description)} property has correct value");
            Assert.That(result, Has.Property(nameof(Destination.IgnoredProperty)).Null, $"{nameof(Destination.IgnoredProperty)} property has not been mapped");
        });
    }

    protected abstract MapperConfiguration GetConfig();
}
