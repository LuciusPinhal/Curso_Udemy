
namespace Basic.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int  Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee() { }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        /// <summary>
        /// Variavel que retorna o valor do pagamento
        /// </summary>
        /// <returns> Hours * ValuePerHour </returns>
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

    }
}
