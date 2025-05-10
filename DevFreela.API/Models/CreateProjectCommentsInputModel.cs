namespace DevFreela.API.Models
{
    public class CreateProjectCommentsInputModel
    {
        public int IdProject { get; set; }
        public int IdUser { get; set; }
        public string Content { get; set; }
    }
}
