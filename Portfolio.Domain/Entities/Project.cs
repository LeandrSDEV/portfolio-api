namespace Portifolio.Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Tech { get; set; }
        public string GithubUrl { get; set; }
        public string ImageUrl { get; set; }
    }
}
