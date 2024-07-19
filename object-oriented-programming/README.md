## Anotações
Código fonte balta: https://github.com/nfandre/balta-fundamentos-POO

### Modificadores de acesso

`private`:  Disponível apenas na classe

`protected`: Disponível na própria classe e nas filhas

`internal`: Disponível no mesmo namespace

`public`: Disponível para todos

`partial`: Possibilita separar uma única classe diversos "pedaços"



### Como acessar classe pai

Utiliza sintax abaixo `base`:

```csharp
public class Aluno : Pessoa
{
    public Aluno()
    {
        var nameFromHerance = base.Nome;
    }
}
```

### Classes estáticas
- Não é possível instanciar pois é estático
- Já fica disponível na memória no start da aplicação


### Classes seladas (sealed)
- inibe a possibilidade de herança da classe
- garante que uma classe só tenha uma forma


### Delegates (Delegação) => Anonymous Methods
- Delega uma função para outro ponto do sistema implmentar
```csharp
public class Pessoa
{
    public delegate void Emprestar();
}

class Program
{
    static void Emprestar()
    {
        Console.WriteLine("emprestado");
    }

    static void Main(string[] args)
    {
        // Delegate
        var alunoDelegate = new Aluno.Emprestar(Emprestar);
        alunoDelegate();
    }
}
```

### Events
<details>
    <summary>Exemplo prático</summary>

```csharp
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

        
    }
}
```

</details>


### Upcast e Downcast
`Upcast`: possibilidade de tornar uma classe filha do tipo de uma classe pai

`Downcast`: possibilidade de tornar uma classe pai do tipo de uma classe filha


### Comparando objetos:
```csharp
public class Pessoa: IEquatable<Pessoa>
{
    private string nome;

    public bool Equals(Pessoa other)
    {
        return nome == other.nome;
    }
}
``````


### Garbage Collection
Gerencia itens na memória automaticamente

```csharp
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
```
