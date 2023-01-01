# AutoMapper config validation with globally-ignored properties

A reproduction case for a suspected bug in AutoMapper related to configuration validation when there are globally-ignored properties.

As it turns out, this is not a bug in AutoMapper at all.
I had not read the docs correctly.  See the two ignored tests:

* `ConfigValidationWithSeparateGlobalIgnoreTechniqueTests`
* `ConfigValidationWithSeparateShouldMapPropertyTechniqueTests`

If these are un-ignored then they will fail, but AutoMapper is not supposed to work that way.
Usages of those techniques within a profile are kept local to that profile and do not affect anything else.
