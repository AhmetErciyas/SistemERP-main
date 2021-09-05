using NRules.Fluent.Dsl;
using NRules.RuleModel;

namespace ERP.Domain.RuleEngine
{
    public abstract class BaseCustomValidationRule<TCustomModel, TRepository1> : Rule where TCustomModel : class
    {
        private TCustomModel customModel = default;
        private TRepository1 repository1 = default;

        public override void Define()
        {
            When()
                .Match(() => customModel)
                .Match(() => repository1);

            Then().Do((ctx) => Validate(ctx, customModel, repository1));
        }

        protected abstract void Validate(IContext ctx, TCustomModel customModel, TRepository1 repository1);
    }

    public abstract class BaseCustomValidationRule<TCustomModel, TRepository1, TRepository2> : Rule where TCustomModel : class
    {
        private TCustomModel customModel = default;
        private TRepository1 repository1 = default;
        private TRepository2 repository2 = default;

        public override void Define()
        {
            When()
                .Match(() => customModel)
                .Match(() => repository1)
                .Match(() => repository2);

            Then().Do((ctx) => Validate(ctx, customModel, repository1, repository2));
        }

        protected abstract void Validate(IContext ctx, TCustomModel customModel, TRepository1 repository1, TRepository2 repository2);
    }

    public abstract class BaseCustomValidationRule<TCustomModel, TRepository1, TRepository2, TRepository3> : Rule where TCustomModel : class
    {
        private TCustomModel customModel = default;
        private TRepository1 repository1 = default;
        private TRepository2 repository2 = default;
        private TRepository3 repository3 = default;

        public override void Define()
        {
            When()
                .Match(() => customModel)
                .Match(() => repository1)
                .Match(() => repository2)
                .Match(() => repository3);

            Then().Do((ctx) => Validate(ctx, customModel, repository1, repository2, repository3));
        }

        protected abstract void Validate(IContext ctx, TCustomModel customModel, TRepository1 repository1, TRepository2 repository2, TRepository3 repository3);
    }

    public abstract class BaseCustomValidationRule<TCustomModel, TRepository1, TRepository2, TRepository3, TRepository4> : Rule where TCustomModel : class
    {
        private TCustomModel customModel = default;
        private TRepository1 repository1 = default;
        private TRepository2 repository2 = default;
        private TRepository3 repository3 = default;
        private TRepository4 repository4 = default;

        public override void Define()
        {
            When()
                .Match(() => customModel)
                .Match(() => repository1)
                .Match(() => repository2)
                .Match(() => repository3)
                .Match(() => repository4);

            Then().Do((ctx) => Validate(ctx, customModel, repository1, repository2, repository3, repository4));
        }

        protected abstract void Validate(IContext ctx, TCustomModel customModel, TRepository1 repository1, TRepository2 repository2, TRepository3 repository3, TRepository4 repository4);
    }

    public abstract class BaseCustomValidationRule<TCustomModel, TRepository1, TRepository2, TRepository3, TRepository4, TRepository5> : Rule where TCustomModel : class
    {
        private TCustomModel customModel = default;
        private TRepository1 repository1 = default;
        private TRepository2 repository2 = default;
        private TRepository3 repository3 = default;
        private TRepository4 repository4 = default;
        private TRepository5 repository5 = default;

        public override void Define()
        {
            When()
                .Match(() => customModel)
                .Match(() => repository1)
                .Match(() => repository2)
                .Match(() => repository3)
                .Match(() => repository4)
                .Match(() => repository5);

            Then().Do((ctx) => Validate(ctx, customModel, repository1, repository2, repository3, repository4, repository5));
        }

        protected abstract void Validate(IContext ctx, TCustomModel customModel, TRepository1 repository1, TRepository2 repository2, TRepository3 repository3, TRepository4 repository4, TRepository5 repository5);
    }
}
