# 📁 Arquivos de Configuração e 🗄️Estruturas de Dados

## 🧮 BalancedExpressions 

**Descrição:**
Este projeto contém uma função para verificar se uma expressão matemática está balanceada. 
A função utiliza uma `Stack<>` para lidar com operadores de abertura e fechamento, garantindo que para cada operador de abertura haja um operador de fechamento correspondente. 
Ela suporta três tipos de operadores de abertura e fechamento: `()`, `{}` e `[]`.

**Exemplo de Uso:**
```csharp
var expression = "(2+1)*80/(7-[√9 + {4² * 0}])";
PrintBalanceResult(expression);
```

## 🥔 HotPotato

**Descrição:**
Neste projeto, há uma simulação do jogo da batata quente. A função `PlayHotPotatoGame` recebe o número de jogadores como parâmetro e simula a passagem da batata em um círculo. 
Um número aleatório entre 1 e 100 determina a quantidade de passes até a batata explodir. Jogadores que sobrevivem ao passe vão para o final da fila até que a batata exploda.

**Exemplo de Uso:**
```csharp
int NUMBER_OF_PLAYERS = 10;
HotPotatoGame.Play(NUMBER_OF_PLAYERS);
```
## 🔍 ListFilter

**Descrição:**
Este projeto contém uma função que filtra uma lista de strings, retornando uma nova lista contendo apenas strings com 10 ou mais caracteres. 
Utiliza a estrutura de dados `List<T>`.

**Exemplo de Uso:**
```csharp
MIN_LENGTH = 10;
var input = GenericValues<string>.GenerateList("Idiossincrasia", "Ambivalente", "Quimérica", "Perpendicular", "Efêmero", "Pletora", "Obnubilado", "Xilografia", "Quixote", "Inefável");
List<string> result = FilterListByMinLength(input, MIN_LENGTH);
```
**Outro Exemplo de Uso:**
```csharp
MIN_LENGTH = 5;
var input = GenericValues<long>.GenerateList(12345678912, 1234567812, 123, 12, 12345678912345, 12345, 124467689790);
List<string> result = FilterListByMinLength(input, MIN_LENGTH);
```

## ⚙️ OptionsConfigPattern

**Descrição:**
O projeto Options Config Pattern demonstra como usar o padrão Options em uma web API. 
Ele ilustra a configuração de configurações usando a interface `IOptions<>` no framework ASP.NET Core. 
O `WeatherForecastController` na web API mostra como acessar valores de configuração por meio da injeção de dependência.

**Uso:**
1. Execute o projeto da web API.
2. Habilite no arquivo de configuração appsettings.json as customizações, através do `EnableOptionsWeatherForecast`.
3. Insira os parâmetros de customização. Por exemplo: 

```json
  "WeatherOptions": {
    "EnableOptionsWeatherForecast": true,
    "MinTemperatureCelsius": -5,
    "MaxTemperatureCelsius": 10,
    "FixedSummary": "Warm"
  }
```

Este projeto destaca a utilização do padrão Options no contexto do ASP.NET Core, proporcionando uma maneira eficiente de configurar e acessar opções específicas em uma aplicação. 
Pode ser expandido para incluir mais configurações conforme necessário para diferentes cenários de aplicação.

## 🔢 WordCounter

**Descrição:**
Este projeto implementa um contador de palavras usando um dicionário. O programa recebe um texto como entrada e utiliza um `Dictionary<string, int>` 
para contar as ocorrências de cada palavra no texto. Não utiliza métodos de extensão LINQ.

**Exemplo de Uso:**
```csharp
var input = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla auctor porta velit a tincidunt. Nam efficitur iaculis placerat. Aenean lectus dui, sollicitudin id rhoncus tristique, aliquet sed quam. Phasellus blandit magna at elementum consequat. Nam vitae nunc vehicula, blandit felis a, placerat augue. Quisque bibendum a ipsum at scelerisque. Duis molestie turpis quis orci vehicula aliquam. Duis non elementum erat. Phasellus et dui odio. Nunc vitae leo sem. Curabitur nec enim id mi aliquet commodo at et sapien. Fusce sit amet nisi elit. Interdum et malesuada fames ac ante ipsum primis in faucibus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Duis vitae dolor at sem ultrices euismod. Morbi aliquet, felis et mattis congue, justo nunc pharetra lectus, a lobortis mauris eros et nulla.";
Dictionary<string, int> wordCount = CountWords(input);
```
