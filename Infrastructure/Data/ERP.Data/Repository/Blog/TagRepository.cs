using ERP.Data.Entities;

namespace ERP.Data
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(DataContext context)
            : base(context)
        {
        }
    }
}
