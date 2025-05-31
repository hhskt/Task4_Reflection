using System.Reflection;

namespace AksenovaReflectionApp
{
    public partial class MainForm : Form
    {
        private Type selectedType;
        private object createdInstance;
        private Assembly assembly;

        public MainForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "DLL Files (*.dll)|*.dll";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var assemblyName = openFileDialog.FileName;
                    assembly = Assembly.LoadFile(assemblyName);
                    var implementedClasses = GetImplementedClasses(assembly.GetTypes());
                    FillComboBox(implementedClasses);
                }
            }
        }
        private void FillComboBox(Type[] types)
        {
            classComboBox.DataSource = types.Select(t => t.FullName).ToList();
        }
        private Type[] GetImplementedClasses(Type[] types)
        {
            return types.Where(t => t.IsClass)
                        .Where(t => !t.IsAbstract)
                        .ToArray();
        }
        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClassName = classComboBox.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedClassName))
            {
                selectedType = assembly.GetType(selectedClassName);
                var constructors = selectedType.GetConstructors();
                constructorPanel.Controls.Clear();
                foreach (var constructor in constructors)
                {
                    var parameters = constructor.GetParameters();
                    foreach (var param in parameters)
                    {
                        var textBox = new TextBox
                        {
                            Margin = new Padding(5, 5, 0, 0),
                            Tag = param.ParameterType,
                            Text = param.Name
                        };
                        constructorPanel.Controls.Add(textBox);
                    }
                }
                executeConstructorButton.Enabled = true;
            }
        }
        private void executeConstructorButton_Click(object sender, EventArgs e)
        {
            if (selectedType != null)
            {
                try
                {
                    var parameters = new List<object>();
                    foreach (TextBox textBox in constructorPanel.Controls)
                    {
                        var value = Convert.ChangeType(textBox.Text, textBox.Tag as Type);
                        parameters.Add(value);
                    }
                    createdInstance = Activator.CreateInstance(selectedType, parameters.ToArray());
                    var methods = selectedType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
                    methodComboBox.DataSource = methods;
                    executeMethodButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void methodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMethod = methodComboBox.SelectedItem as MethodInfo;
            if (selectedMethod != null)
            {
                var parameters = selectedMethod.GetParameters();
                methodParameterPanel.Controls.Clear();
                foreach (var param in parameters)
                {
                    var textBox = new TextBox
                    {
                        Margin = new Padding(5, 5, 0, 0),
                        Tag = param.ParameterType,
                        Text = param.Name
                    };
                    methodParameterPanel.Controls.Add(textBox);
                }
                executeMethodButton.Enabled = true;
            }
        }
        private void executeMethodButton_Click(object sender, EventArgs e)
        {
            var selectedMethod = methodComboBox.SelectedItem as MethodInfo;
            if (selectedMethod != null)
            {
                try
                {
                    var parameters = new List<object>();
                    foreach (TextBox textBox in methodParameterPanel.Controls)
                    {
                        var value = Convert.ChangeType(textBox.Text, (Type)textBox.Tag);
                        parameters.Add(value);
                    }
                    var result = selectedMethod.Invoke(createdInstance, parameters.ToArray());
                    MessageBox.Show("Result: " + result.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
