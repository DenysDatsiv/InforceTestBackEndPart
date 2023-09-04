using InforceTest.Models;
using InforceTest.Repository;

namespace InforceTest.Services
{
    public class LinkService:ILinkService
    {
        public Link Create(Link link)
        {
            link.Id = LinkRepository.Link.Count + 1;
            LinkRepository.Link.Add(link);

            return link;
        }

        public Link Get(int id)
        {
            var link = LinkRepository.Link.FirstOrDefault(o => o.Id == id);
            if (link is null) return null;
            return link;
        }

        public List<Link> List() {
            var links = LinkRepository.Link;
            return links;
           
        }
        public bool Delete(int id)
        {
            var oldLink = LinkRepository.Link.FirstOrDefault(o =>o.Id== id);
            if (oldLink is null) return false;
            LinkRepository.Link.Remove(oldLink); 
            return true;
        }
    }
}
