namespace ExercicioLivraria.Blibioteca
{
    public class Emprestimo
    {
        public bool LivroEmprestado { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public Usuario Usuarios { get; set; }
        public Livro Livros {get; set;}
        

    }
}