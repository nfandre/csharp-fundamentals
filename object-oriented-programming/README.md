## Anotações
#### Modificadores de acesso

`private`:  Disponível apenas na classe

`protected`: Disponível na própria classe e nas filhas

`internal`: Disponível no mesmo namespace

`public`: Disponível para todos



#### Como acessar classe pai

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
