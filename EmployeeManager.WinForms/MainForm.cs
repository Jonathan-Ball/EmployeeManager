using EmployeeManager.DataAccess;
using EmployeeManager.ViewModel;

namespace EmployeeManager.WinForms
{
    public partial class MainForm : Form
    {
        private readonly MainViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            _viewModel = new MainViewModel(new EmployeeDataProvider());
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            _viewModel.Load();
            employeeBindingSource.DataSource = _viewModel.Employees;
            lsbEmployees.DataSource = employeeBindingSource;
            lsbEmployees.DisplayMember = "FirstName";
        }
    }
}