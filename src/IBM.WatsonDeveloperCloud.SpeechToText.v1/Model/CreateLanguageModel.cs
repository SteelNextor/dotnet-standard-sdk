/**
* Copyright 2018 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IBM.WatsonDeveloperCloud.SpeechToText.v1.Model
{
    /// <summary>
    /// CreateLanguageModel.
    /// </summary>
    public class CreateLanguageModel : BaseModel
    {
        /// <summary>
        /// The name of the base language model that is to be customized by the new custom language model. The new
        /// custom model can be used only with the base model that it customizes.
        ///
        /// To determine whether a base model supports language model customization, use the **Get a model** method and
        /// check that the attribute `custom_language_model` is set to `true`. You can also refer to [Language support
        /// for customization](https://cloud.ibm.com/docs/services/speech-to-text/custom.html#languageSupport).
        /// </summary>
        /// <value>
        /// The name of the base language model that is to be customized by the new custom language model. The new
        /// custom model can be used only with the base model that it customizes.
        ///
        /// To determine whether a base model supports language model customization, use the **Get a model** method and
        /// check that the attribute `custom_language_model` is set to `true`. You can also refer to [Language support
        /// for customization](https://cloud.ibm.com/docs/services/speech-to-text/custom.html#languageSupport).
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BaseModelNameEnum
        {
            
            /// <summary>
            /// Enum DE_DE_BROADBANDMODEL for de-DE_BroadbandModel
            /// </summary>
            [EnumMember(Value = "de-DE_BroadbandModel")]
            DE_DE_BROADBANDMODEL,
            
            /// <summary>
            /// Enum DE_DE_NARROWBANDMODEL for de-DE_NarrowbandModel
            /// </summary>
            [EnumMember(Value = "de-DE_NarrowbandModel")]
            DE_DE_NARROWBANDMODEL,
            
            /// <summary>
            /// Enum EN_GB_BROADBANDMODEL for en-GB_BroadbandModel
            /// </summary>
            [EnumMember(Value = "en-GB_BroadbandModel")]
            EN_GB_BROADBANDMODEL,
            
            /// <summary>
            /// Enum EN_GB_NARROWBANDMODEL for en-GB_NarrowbandModel
            /// </summary>
            [EnumMember(Value = "en-GB_NarrowbandModel")]
            EN_GB_NARROWBANDMODEL,
            
            /// <summary>
            /// Enum EN_US_BROADBANDMODEL for en-US_BroadbandModel
            /// </summary>
            [EnumMember(Value = "en-US_BroadbandModel")]
            EN_US_BROADBANDMODEL,
            
            /// <summary>
            /// Enum EN_US_NARROWBANDMODEL for en-US_NarrowbandModel
            /// </summary>
            [EnumMember(Value = "en-US_NarrowbandModel")]
            EN_US_NARROWBANDMODEL,
            
            /// <summary>
            /// Enum EN_US_SHORTFORM_NARROWBANDMODEL for en-US_ShortForm_NarrowbandModel
            /// </summary>
            [EnumMember(Value = "en-US_ShortForm_NarrowbandModel")]
            EN_US_SHORTFORM_NARROWBANDMODEL,
            
            /// <summary>
            /// Enum ES_ES_BROADBANDMODEL for es-ES_BroadbandModel
            /// </summary>
            [EnumMember(Value = "es-ES_BroadbandModel")]
            ES_ES_BROADBANDMODEL,
            
            /// <summary>
            /// Enum ES_ES_NARROWBANDMODEL for es-ES_NarrowbandModel
            /// </summary>
            [EnumMember(Value = "es-ES_NarrowbandModel")]
            ES_ES_NARROWBANDMODEL,
            
            /// <summary>
            /// Enum FR_FR_BROADBANDMODEL for fr-FR_BroadbandModel
            /// </summary>
            [EnumMember(Value = "fr-FR_BroadbandModel")]
            FR_FR_BROADBANDMODEL,
            
            /// <summary>
            /// Enum FR_FR_NARROWBANDMODEL for fr-FR_NarrowbandModel
            /// </summary>
            [EnumMember(Value = "fr-FR_NarrowbandModel")]
            FR_FR_NARROWBANDMODEL,
            
            /// <summary>
            /// Enum JA_JP_BROADBANDMODEL for ja-JP_BroadbandModel
            /// </summary>
            [EnumMember(Value = "ja-JP_BroadbandModel")]
            JA_JP_BROADBANDMODEL,
            
            /// <summary>
            /// Enum JA_JP_NARROWBANDMODEL for ja-JP_NarrowbandModel
            /// </summary>
            [EnumMember(Value = "ja-JP_NarrowbandModel")]
            JA_JP_NARROWBANDMODEL,
            
            /// <summary>
            /// Enum KO_KR_BROADBANDMODEL for ko-KR_BroadbandModel
            /// </summary>
            [EnumMember(Value = "ko-KR_BroadbandModel")]
            KO_KR_BROADBANDMODEL,
            
            /// <summary>
            /// Enum KO_KR_NARROWBANDMODEL for ko-KR_NarrowbandModel
            /// </summary>
            [EnumMember(Value = "ko-KR_NarrowbandModel")]
            KO_KR_NARROWBANDMODEL,
            
            /// <summary>
            /// Enum PT_BR_BROADBANDMODEL for pt-BR_BroadbandModel
            /// </summary>
            [EnumMember(Value = "pt-BR_BroadbandModel")]
            PT_BR_BROADBANDMODEL,
            
            /// <summary>
            /// Enum PT_BR_NARROWBANDMODEL for pt-BR_NarrowbandModel
            /// </summary>
            [EnumMember(Value = "pt-BR_NarrowbandModel")]
            PT_BR_NARROWBANDMODEL
        }

        /// <summary>
        /// The name of the base language model that is to be customized by the new custom language model. The new
        /// custom model can be used only with the base model that it customizes.
        ///
        /// To determine whether a base model supports language model customization, use the **Get a model** method and
        /// check that the attribute `custom_language_model` is set to `true`. You can also refer to [Language support
        /// for customization](https://cloud.ibm.com/docs/services/speech-to-text/custom.html#languageSupport).
        /// </summary>
        [JsonProperty("base_model_name", NullValueHandling = NullValueHandling.Ignore)]
        public BaseModelNameEnum? BaseModelName { get; set; }
        /// <summary>
        /// A user-defined name for the new custom language model. Use a name that is unique among all custom language
        /// models that you own. Use a localized name that matches the language of the custom model. Use a name that
        /// describes the domain of the custom model, such as `Medical custom model` or `Legal custom model`.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        /// <summary>
        /// The dialect of the specified language that is to be used with the custom language model. The parameter is
        /// meaningful only for Spanish models, for which the service creates a custom language model that is suited for
        /// speech in one of the following dialects:
        /// * `es-ES` for Castilian Spanish (the default)
        /// * `es-LA` for Latin American Spanish
        /// * `es-US` for North American (Mexican) Spanish
        ///
        /// A specified dialect must be valid for the base model. By default, the dialect matches the language of the
        /// base model; for example, `en-US` for either of the US English language models.
        /// </summary>
        [JsonProperty("dialect", NullValueHandling = NullValueHandling.Ignore)]
        public string Dialect { get; set; }
        /// <summary>
        /// A description of the new custom language model. Use a localized description that matches the language of the
        /// custom model.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

}
