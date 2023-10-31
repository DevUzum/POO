namespace POO.Heranca
{
    public class Cliente
    {
        public Cliente(Guid id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        
        public bool EnviarEmail()
        {
            Random random = new Random();
            return random.Next(2) == 0;
        }

    }
}
