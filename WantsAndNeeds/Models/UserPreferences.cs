namespace WantsAndNeeds.Models {
    public class UserPreferences {
        public required string Name { get; set; }
        
        public List<string> Wants { get; set; } = [];
        public List<string> Needs { get; set; } = [];
    }
}
