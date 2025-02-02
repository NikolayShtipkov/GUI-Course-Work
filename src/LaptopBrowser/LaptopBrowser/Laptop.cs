namespace LaptopBrowser
{
    public class Laptop
    {
        public string Name { get; }
        public string ImagePath { get; }
        public decimal Price { get; }
        public string Processor { get; }
        public string Memory { get; }
        public double Display { get; }
        public string GraphicsCard { get; }

        public Laptop(string name, string imagePath, decimal price, string processor, 
            string memory, double display, string graphicsCard)
        {
            Name = name;
            ImagePath = imagePath;
            Price = price;
            Processor = processor;
            Memory = memory;
            Display = display;
            GraphicsCard = graphicsCard;
        }
    }
}
