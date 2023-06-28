# RPG-Csharp

Trabalho RPG De Turno

Analise as diretrizes básicas abaixo e, em grupo, crie um rpg de turno.

OBS: Nomes de classes, variáveis, conteúdo e valores podem ser alterados.

1. Criação de Personagens:

   - Crie uma classe base chamada `Personagem` com os seguintes atributos:
     - `Nome` (string): o nome do personagem.
     - `PontosVida` (int): os pontos de vida do personagem.
     - `Forca` (int): a força do personagem.
     - `Defesa` (int): a defesa do personagem.

   - Crie classes derivadas para cada classe específica, como `Guerreiro`, `Mago` e `Arqueiro`, que herdam da classe `Personagem`.
   
   - Adicione atributos específicos para cada classe, como `PontosMagia` para o Mago, `Destreza` para o Arqueiro, etc.

2. Combate:

   - Crie uma classe chamada `Batalha` que será responsável por controlar as ações de combate.
   
   - A classe `Batalha` deve ter um método para determinar a ordem dos turnos.
   
   - Cada personagem deve ter um método `Atacar` que calcula o dano do ataque baseado na força do personagem e na defesa do alvo.
   
   - Crie métodos para as outras ações possíveis durante o combate, como `UsarMagia`, `Defender` e `Fugir`.

3. Inimigos:
   - Crie uma classe `Inimigo` que também derive da classe `Personagem`.
   
   - Adicione atributos específicos para os inimigos, como `Tipo` (por exemplo, "Monstro", "Chefe", etc.), `RecompensaXP` (experiência ganha ao derrotar o inimigo), etc.

4. Vantagens e Fraquezas:
   - Crie uma classe `Habilidade` com os seguintes atributos:
     - `Nome` (string): o nome da habilidade.
     - `Tipo` (string): o tipo da habilidade (por exemplo, "Fogo", "Gelo", "Elétrico", etc.).
     - `DanoBase` (int): o dano base causado pela habilidade.
   
   - Adicione um atributo `Habilidades` na classe `Personagem` que será uma lista de habilidades.
   
   - Adicione um método `CalcularDano` na classe `Personagem` que verifique as vantagens e fraquezas do personagem e do alvo com base no tipo da habilidade utilizada.

5. Fim de Batalha:

   - Quando a batalha terminar, atualize os atributos dos personagens, como pontos de vida, pontos de experiência, etc.
   
   - Crie uma classe `Jogo` que controla o fluxo do jogo, como a criação dos personagens, a criação dos inimigos, a execução das batalhas, etc.

6. Conteúdo Extras

As funções abaixo podem ser adicionadas para tornar a experiência do jogo mais dinâmica (avalie com o seu grupo o tempo, a necessidade e confiabilidade dos itens citados, e decidam se cabe ou não a implementação dessas funções).

Sistema de Nível (cada monstro derrotada dá X pontos de experiência ao personagem, ao atingir Y pontos de experiência o personagem aumenta de nível)
Sistema de Defesa (quanto maior a defesa menos dano é causado em ambos os combatentes)
Sistema de Golpe Crítico: Todo golpe que é efetuado por um combatente tem X % de chance de ser crítico. Golpes críticos dão 50% a mais de dano.

Sistema de Efeitos de Combate:
  - Envenenado: O combatente que estiver envenenado toma X dando a cada rodada.
  - Atordoado: O combatente que estiver atordoado fica 1 turno sem atacar
  - Queimado: O Combatente que estiver queimado toma X dano a cada turno.
  - Dormindo: O Combatente que estiver dormindo fica X turnos sem atacar até levar um golpe.

Sistema de ganho de itens: Ao matar X inimigos aparece um baú, neste baú podem vir itens aleatórios.
Sistema de Raridade de Itens: Pode existir de 2 - 4 tipos de raridade de itens, com atributos e efeitos diferentes.
Sistema de Habilidades de Itens: Pode existir uma classificação de itens chamada “Únicos”, como:  “Raio de Zeus”, “Cajado de Merlin”, etc. Estes itens adicionam habilidades extras à lista de habilidades do personagem. 

---
### Diagrama de classes:
![DiagramaClassesRPG](https://github.com/Rafael-RD/RPG-Csharp/assets/12214387/cd6328e9-4675-4c11-8798-3f5e233e172e)
