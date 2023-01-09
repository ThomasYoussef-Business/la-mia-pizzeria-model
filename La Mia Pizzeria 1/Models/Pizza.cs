namespace La_Mia_Pizzeria_1.Models {
    public class Pizza {
        public static List<Pizza> Pizzas { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }

        public Pizza(int id, string name, string description, string imageUrl, double price) {
            Id = id;
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            Price = price;
        }

        public static List<Pizza> GetPizzas() {

            if (Pizzas != null) { return Pizzas; }

            Pizzas = new() {
                new(1, "Pizza margherita", "Una pizza margherita", "https://upload.wikimedia.org/wikipedia/commons/c/c8/Pizza_Margherita_stu_spivack.jpg", 4.75),
                new(2, "Pizza ai quattro formaggi", "Mmm, formaggio!", "https://blog.giallozafferano.it/zeroglutine/wp-content/uploads/2020/04/IMG_5544-720x411.jpg", 4.25),
                new(3, "Pizza napoletana", "L'originale", "https://www.tavolartegusto.it/wp/wp-content/uploads/2020/05/Pizza-napoletana-Ricetta-della-Pizza-Napoletana-Pizza-Margherita.jpg", 6.50),
                new(4, "Pizza alla Nutella", "Per i golosoni!", "https://www.petitchef.it/imgupl/recipe/pizza-alla-nutella--455637p707856.jpg", 7.50),
            };

            return Pizzas;
        }
    }
}
