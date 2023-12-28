namespace Basic.Entities.Execptions
{
    class DomainExeception : ApplicationException
    {
        public DomainExeception(string messagem) : base(messagem) 
        { 
        }
    }
}
