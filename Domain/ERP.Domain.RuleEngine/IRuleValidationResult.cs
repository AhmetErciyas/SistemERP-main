using System;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Domain.RuleEngine
{
    public interface IRuleValidationResult
    {
        /// <summary>
        /// Rule validation result [success, fail]
        /// </summary>
        bool Success { get; }

        /// <summary>
        /// Error messages when the rule validation check fails.
        /// </summary>
        string[]? Errors { get; }

        /// <summary>
        /// If validation succeeds, its better to return some Entity instances to be utilized in later operations
        /// </summary>
        TEntity Get<TEntity>();
    }

    public class RuleValidationResult : IRuleValidationResult
    {
        /// <summary>
        /// Rule validation result [success, fail]
        /// </summary>
        public bool Success { get; }

        private List<object> ReturnData { get; }

        /// <summary>
        /// Error messages when the rule validation check fails.
        /// </summary>
        public string[]? Errors { get; }

        public RuleValidationResult(bool success, string[]? errorMessages = null)
        {
            Success = success;
            Errors = errorMessages;
        }

        public RuleValidationResult(bool success, string[]? errorMessages = null, List<object>? data = null)
        {
            Success = success;
            Errors = errorMessages;
            ReturnData = data;
        }

        public TEntity Get<TEntity>()
        {
            return (TEntity)ReturnData.FirstOrDefault(o => o.GetType() == typeof(TEntity));
        }
    }
}
