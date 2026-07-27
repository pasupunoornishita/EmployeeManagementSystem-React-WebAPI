namespace EmployeeManagementAPI.Decorator
{
    public class BonusDecorator : ISalaryComponent
    {
        private readonly ISalaryComponent _component;

        public BonusDecorator(ISalaryComponent component)
        {
            _component = component;
        }

        public double GetSalary()
        {
            return _component.GetSalary() + 5000;
        }
    }
}