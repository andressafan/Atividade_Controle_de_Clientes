# Como Funciona o Código

## Classe `Clientes`

Essa classe é herdada tanto por `Pessoa_Fisica` quanto por `Pessoa_Juridica` e fornece atributos comuns para ambos.

- **`namespace Atividade`**: Define o namespace para organizar o código e indica que todas as classes estão dentro da pasta `Atividade`.
- **`public class Clientes`**: Define a classe `Clientes` como pública, permitindo que outras classes em diferentes namespaces possam acessá-la.
- **`public string Nome { get; set; }`**: Propriedade pública `Nome` com métodos `get` e `set`, permitindo leitura e escrita de valores por outras classes.
- **`public string Endereco { get; set; }`**: Propriedade pública `Endereco` para armazenar o endereço.
- **`public float Valor { get; protected set; }`**: Propriedade pública `Valor` com um setter protegido. Isso permite que outras classes ou classes derivadas da classe `Clientes` alterem o valor, mas não classes externas.
- **`public float ValorImposto { get; protected set; }`**: Propriedade pública `ValorImposto` com um setter protegido.
- **`public float Total { get; protected set; }`**: Propriedade pública `Total` com um setter protegido.
- **`public virtual void PagarImposto(float v)`**: Método público `PagarImposto`. O modificador `virtual` indica que o método pode ser sobrescrito em uma classe derivada. Este método é responsável por calcular o imposto com base no valor `v` e definir as propriedades `Valor`, `ValorImposto` e `Total`.

## Classe `Pessoa_Juridica`

Essa classe herda de `Clientes` e sobrescreve o método `PagarImposto` para implementar uma lógica específica para pessoas jurídicas.

- **`public class Pessoa_Juridica : Clientes`**: Define a classe `Pessoa_Juridica` que herda da classe `Clientes`. Isso significa que `Pessoa_Juridica` terá todas as propriedades e métodos de `Clientes`, mas pode sobrescrevê-los.
- **`public string Cnpj { get; set; }`**: Propriedade pública `Cnpj` para armazenar o CNPJ.
- **`public string Ie { get; set; }`**: Propriedade pública `Ie` para armazenar a Inscrição Estadual.
- **`public override void PagarImposto(float v)`**: Sobrescreve o método `PagarImposto` da classe base `Clientes`. O modificador `override` é utilizado para definir que o método está substituindo a implementação da classe base. 

## Classe `Pessoa_Fisica`

Esta classe também herda de `Clientes` e define propriedades adicionais específicas para pessoas físicas.

- **`public class Pessoa_Fisica : Clientes`**: Define a classe `Pessoa_Fisica` que herda de `Clientes`.
- **`public string Cpf { get; set; }`**: Propriedade pública `Cpf` para armazenar o CPF.
- **`public string Rg { get; set; }`**: Propriedade pública `Rg` para armazenar o RG.

## Classe `Program`

- **`using System;`**: Importa o namespace `System`, que contém classes básicas de C#, como `Console`.
- **`namespace Atividade`**: Define o namespace para organizar o código.
- **`class Program`**: Define a classe `Program`, que contém o método `Main`, a parte principal do código.
- **`static void Main(string[] args)`**: Define o método principal `Main`, que é executado quando o aplicativo é iniciado.
  - **`Console.WriteLine("Informar Nome");`**: Exibe uma mensagem solicitando ao usuário que informe o nome.
  - **`string var_nome = Console.ReadLine();`**: Lê a entrada do usuário e armazena na variável `var_nome`.
  - **`Console.WriteLine("Informar Endereço");`**: Solicita ao usuário que informe o endereço.
  - **`string var_endereco = Console.ReadLine();`**: Lê a entrada do usuário e armazena na variável `var_endereco`.
  - **`Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");`**: Pergunta ao usuário se ele deseja informar uma pessoa física ou jurídica.
  - **`string var_tipo = Console.ReadLine();`**: Lê a entrada do usuário e armazena na variável `var_tipo`.
  - **`if (var_tipo == "f")`**: Verifica se o usuário escolheu "f" para pessoa física.
    - Cria um objeto `Pessoa_Fisica`, define suas propriedades e solicita o CPF, RG e valor da compra.
    - Chama o método `PagarImposto` e exibe as informações do cliente, incluindo valor da compra, imposto e total a pagar.
  - **`if (var_tipo == "j")`**: Verifica se o usuário escolheu "j" para pessoa jurídica.
    - Cria um objeto `Pessoa_Juridica`, define suas propriedades e solicita o CNPJ, Inscrição Estadual e valor da compra.
    - Chama o método `PagarImposto` e exibe as informações do cliente, incluindo valor da compra, imposto e total a pagar.
