namespace ExercicioVetores
{
    class CadastroCliente
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public CadastroCliente(string nome, string email)
        {
            Name = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
