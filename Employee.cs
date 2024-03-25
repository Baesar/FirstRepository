namespace Employees
{
    internal class Employee
    {
        protected BenefitPackage EmpBenefits = new BenefitPackage();

        public double GetBenefitCost()
            => EmpBenefits.ComputePayDeduction();

        public BenefitPackage Benefits
        {
            get { return EmpBenefits; }
            set { EmpBenefits = value; }
        }

        // Field data
        private string _empName;
        private int _empAge;
        private int _empId;
        private float _currPay;
        private string _empSSN;
        private EmployeePayTypeEnum _payType;


        // Properties
        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }
        public int Age
        {
            get { return _empAge; }
            set { _empAge = value; }
        }
        public int Id
        {
            get { return _empId; }
            set { _empId = value; }
        }
        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }
        public string SocialSecurityNumber => _empSSN;
        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }


        // Constructors
        public Employee() { }
        public Employee(string name, int id, float pay, string empSsn) : this(name, 0, id, pay, empSsn, EmployeePayTypeEnum.Salaried) { }

        public Employee(string name, int age, int id, float pay, string snn, EmployeePayTypeEnum payType)
        {
            Name = name;
            Age = age;
            Id = id;
            Pay = pay;
            _empSSN = snn;
            PayType = payType;
        }

        // Methods
        public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commission }
                    => Pay += .10F * amount,
                { PayType: EmployeePayTypeEnum.Hourly }
                    => Pay += 40F * amount / 2080F,
                { PayType: EmployeePayTypeEnum.Salaried }
                    => Pay += amount,
                _ => Pay += 0
            };
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("Pay: {0}", Pay);
        }
    }
}
