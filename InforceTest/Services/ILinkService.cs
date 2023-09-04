using InforceTest.Models;

namespace InforceTest.Services
{
    public interface ILinkService
    {
        public Link Create(Link link);
        public Link Get(int id);
        public List<Link> List();
        public bool Delete(int id);
    }
}
