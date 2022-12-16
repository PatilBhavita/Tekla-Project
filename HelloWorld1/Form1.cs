
using System.Reflection;

namespace HelloWorld1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Model model = new Model();
            if (!model.GetConnectionStatus())
            {
                MessageBox.Show("Tekla structure not connected");
                return;
            }
            ModelInfo modelInfo = model.GetInfo();
            string name = modelInfo.ModelName;
            MessageBox.Show(string.Format("Hello World! Your current model is named :(0)", name));

            Operation.DisplayPrompt(string.Format("Hello World! Your current model is named :(0)", name));

        }
    }
}