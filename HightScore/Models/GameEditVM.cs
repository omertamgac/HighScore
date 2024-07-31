public class GameEditVM
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime RelaseDate { get; set; }
    public string? Iframe { get; set; }
    public string? ExistingPhoto { get; set; }
    public IFormFile? Photo { get; set; }
    public List<string>? Categories { get; set; }
    public List<string>? Platforms { get; set; }
    public List<int> SelectedCategories { get; set; } = new List<int>();
    public List<int> SelectedPlatforms { get; set; } = new List<int>();
}

