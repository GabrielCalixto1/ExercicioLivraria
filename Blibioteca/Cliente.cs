namespace ExercicioLivraria.Blibioteca
{
    public class Cliente
    {
        public string Curso { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTerminoPrevista { get; set; }
        public Emprestimo EmprestimoUtilizado { get; set; }
        

    }
}