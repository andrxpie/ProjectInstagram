using BusinessLogic.DTOs;

namespace BusinessLogic.Interfaces
{
    public interface IPostsService
    {
        IEnumerable<PostDto> GetAll();
        PostDto Get(int id);
        void Create(PostDto post);
        void Update(PostDto post);
        void Delete(int id);
    }
}
