namespace RecipeProjectServe.Entities
{
    public class Recipe
    {
        public static int count = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int PreparationTimeInMinutes { get; set; }
        public int DifficultyLevel { get;set; }
        public DateTime DateAdded { get; set; }
        public string[] Ingredients { get; set; }
        public string PreparationMethod {  get; set; }
        public int UserId { get; set; }
        public string Image { get; set; }
        public Recipe(Recipe recipe)
        {
            Id =count++;
            Name = recipe.Name;
            CategoryId = recipe.CategoryId;
            PreparationTimeInMinutes = recipe.PreparationTimeInMinutes;
            DifficultyLevel = recipe.DifficultyLevel;
            DateAdded = recipe.DateAdded;
            UserId = recipe.UserId;
            Image = recipe.Image;
            PreparationMethod = recipe.PreparationMethod;
            Ingredients = recipe.Ingredients;
        }
        public Recipe() { }
    }
}
