using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace FortisAPI.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<V1ElementsTransactionIntentionRequestSaveAccountTitle>),
        new Type[] {
            typeof(MStringCase)
        },
        false
    )]
    public abstract class V1ElementsTransactionIntentionRequestSaveAccountTitle
    {
        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The V1ElementsTransactionIntentionRequestSaveAccountTitle instance, wrapping the provided string value.
        /// </returns>
        public static V1ElementsTransactionIntentionRequestSaveAccountTitle FromString(string mString)
        {
            return new MStringCase().Set(mString);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<string, T> mString);

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : V1ElementsTransactionIntentionRequestSaveAccountTitle, ICaseValue<MStringCase, string>
        {
            public string _value;

            public override T Match<T>(Func<string, T> mString)
            {
                return mString(_value);
            }

            public MStringCase Set(string value)
            {
                _value = value;
                return this;
            }

            public string Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }
    }
}