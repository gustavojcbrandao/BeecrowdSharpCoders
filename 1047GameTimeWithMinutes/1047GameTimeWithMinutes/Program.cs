namespace GameTimeWithMinutes {

    public class Program {

        public static void Main(string[] args) {

            string[] horas = Console.ReadLine().Split();

            int horaInicio = int.Parse(horas[0]);
            int minInicio = int.Parse(horas[1]);
            int horaFim = int.Parse(horas[2]);
            int minFim = int.Parse(horas[3]);

            int horaInicioEmMinutos = minInicio + (60 * horaInicio);
            int horaFimEmMinutos = minFim + (60 * horaFim);


            if (horaInicioEmMinutos == horaFimEmMinutos) {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else if (horaFimEmMinutos > horaInicioEmMinutos){
                int duracaoEmMinutos = horaFimEmMinutos - horaInicioEmMinutos;
                int duracaoHoras = duracaoEmMinutos / 60;
                int duracaoMinutos = duracaoEmMinutos % 60;
                Console.WriteLine($"O JOGO DUROU {duracaoHoras} HORA(S) E {duracaoMinutos} MINUTO(S)");

            }
            else if (horaFimEmMinutos < horaInicioEmMinutos) {
                int duracaoEmMinutos = (24 * 60) - horaInicioEmMinutos + horaFimEmMinutos;
                int duracaoHoras = duracaoEmMinutos / 60;
                int duracaoMinutos = duracaoEmMinutos % 60;
                Console.WriteLine($"O JOGO DUROU {duracaoHoras} HORA(S) E {duracaoMinutos} MINUTO(S)");
            }
        }
    }
}