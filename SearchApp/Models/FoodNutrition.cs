namespace SearchApp.Models
{
    public class ServingOption
    {
        public string? Text { get; set; }
        public double Gram { get; set; }
    }

    public class NutritionPerUnit
    {
        public string? NutritionPoint { get; set; }
        public double Value { get; set; }
        public string? Unit { get; set; }
        public double? PctDailyValue { get; set; }
    }

    public class FoodNutrition
    {
        public List<ServingOption>? ServingOptions { get; set; }
        public List<NutritionPerUnit>? NutritionPer100g { get; set; }
    }
}
