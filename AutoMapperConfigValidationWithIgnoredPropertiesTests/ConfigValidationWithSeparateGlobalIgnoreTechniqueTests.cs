using AutoMapper;
using NUnit.Framework;

namespace ConfigValidation;

[Ignore("This scenario is known not to work.  Usages of 'GlobalIgnore' inside a profile ONLY applies within that profile and not outside.")]
public class ConfigValidationWithSeparateGlobalIgnoreTechniqueTests : TestBase
{
    protected override MapperConfiguration GetConfig()
        => new MapperConfiguration(cfg => {
            cfg.AddProfile<SourceToDestinationProfile>();
            cfg.AddProfile<GlobalIgnoresProfile>();
        });
}