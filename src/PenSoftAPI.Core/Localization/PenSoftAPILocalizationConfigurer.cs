using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PenSoftAPI.Localization
{
    public static class PenSoftAPILocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PenSoftAPIConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PenSoftAPILocalizationConfigurer).GetAssembly(),
                        "PenSoftAPI.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
