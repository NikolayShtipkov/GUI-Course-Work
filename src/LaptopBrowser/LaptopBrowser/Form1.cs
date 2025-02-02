namespace LaptopBrowser
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Laptop>? laptops;

        public Form1()
        {
            InitializeComponent();
            InitializeLaptops();
        }

        private void InitializeLaptops()
        {
            laptops = new Dictionary<string, Laptop>
            {
                { "Dell XPS 13",
                    new Laptop("Dell XPS 13", "xps13.jpg", 2000, "Intel i7", "16GB", 13.3, "Intel Iris") },
                { "HP Spectre x360",
                    new Laptop("HP Spectre x360", "spectre.jpg", 1800, "Intel i5", "8GB", 14, "Intel UHD") }
            };

            foreach (var model in laptops.Keys)
            {
                comboBoxModels.Items.Add(model);
            }
        }

        //private void comboBoxModels_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBoxModels.SelectedItem is string selectedModel && laptops!.ContainsKey(selectedModel))
        //    {
        //        var laptop = laptops[selectedModel];
        //        labelTitle.Text = laptop.Name;
        //        pictureBoxLaptop.ImageLocation = laptop.ImagePath;
        //        labelPrice.Text = $"Цена: {laptop.Price} лв.";
        //        labelProcessor.Text = $"Процесор: {laptop.Processor}";
        //        labelMemory.Text = $"Памет: {laptop.Memory}";
        //        labelDisplay.Text = $"Дисплей: {laptop.Display}";
        //        labelGraphics.Text = $"Видео карта: {laptop.GraphicsCard}";
        //    }
        //}

        //private void buttonBuy_Click(object sender, EventArgs e)
        //{
        //    if (comboBoxModels.SelectedItem is string selectedModel && laptops!.ContainsKey(selectedModel))
        //    {
        //        var laptop = laptops[selectedModel];
        //        decimal finalPrice = laptop.Price;

        //        if (checkBoxBackpack.Checked) finalPrice += 50;
        //        if (checkBoxOS.Checked) finalPrice += 100;

        //        string paymentMethod = radioButtonFull.Checked ? "Еднократно" : "На изплащане";
        //        string message = $"Закупихте: {laptop.Name}\nЦена: {finalPrice} лв.\nНачин на плащане: {paymentMethod}";

        //        MessageBox.Show(message, "Покупка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
    }
}
