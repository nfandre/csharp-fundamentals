using System;

namespace CsharpPOO
{
    // Events
    public class Room
    {
        public Room(int seats)
        {
            Seats = seats;
            seatsInUse = 0;
        }

        private int seatsInUse = 0;

        public int Seats { get; set; }

        public void ReserveSeat()
        {
            seatsInUse++;
            if (seatsInUse >= Seats)
            {
                // Evento fechado
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Assento liberado");
            }
        }

        //handler = manipulador
        public event EventHandler OnRoomSoldOutEvent;

        protected virtual void OnRoomSoldOut(EventArgs e)
        {
            EventHandler handler = OnRoomSoldOutEvent;
            handler?.Invoke(this, e);
        }
    }

    class Program
    {

        static void Emprestar()
        {
            Console.WriteLine("emprestado");
        }



        static void OnRoomSoldOut(object sender, EventArgs e)
        {
            Console.WriteLine("Sala lotada");
        }

        static void Main(string[] args)
        {

            /// Events

            var room = new Room(3);
            room.OnRoomSoldOutEvent += OnRoomSoldOut;
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();

            Aluno aluno = new Aluno();
            aluno.Matricula = "abc22333";
            aluno.Idade = 22;
            Console.WriteLine($"Aluno: {aluno.ResponderPresenca()}");


            Professor jose = new Professor();
            jose.Idade = 40;
            jose.ValorHora = 10;
            jose.Bonus = 0;
            jose.Tipo = 1;

            Console.WriteLine($"Professor1: {jose.ResponderPresenca()}");
            Console.WriteLine("Professor1 Valor hora: {0:c}", jose.CalcularSalarioFinal(120));

            Professor maria = new Professor();
            maria.Idade = 40;
            maria.ValorHora = 10;
            maria.Tipo = 2;
            maria.Bonus = 15;


            Console.WriteLine("Professor2 Valor hora: {0:c}", maria.CalcularSalarioFinal(120));


            /// Garbage collect
            // Forma manual
            // Cria instancia na memória
            Aluno aluno2 = new Aluno();
            // remove elemento da memória
            aluno2.Dispose();

            // Forma automática
            using(var aluno3 = new Aluno())
            {
                // remove elemento memória automáticamente
            }


            // Delegate
            var alunoDelegate = new Aluno.Emprestar(Emprestar);
            alunoDelegate();

            Console.ReadKey();
        }
    }


}
