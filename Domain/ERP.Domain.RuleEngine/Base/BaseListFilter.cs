using NRules;
using NRules.AgendaFilters;
using System.Linq;

namespace ERP.Domain.RuleEngine
{
    public class BaseListFilter : IAgendaFilter
    {
        private string[] _nRuleList;

        public BaseListFilter(params string[] NRuleList) : base()
        {
            _nRuleList = NRuleList;
        }

        public bool Accept(AgendaContext context, Activation activation)
        {
            return _nRuleList.Intersect(activation.Rule.Tags).Count() > 0;
        }
    }
}
