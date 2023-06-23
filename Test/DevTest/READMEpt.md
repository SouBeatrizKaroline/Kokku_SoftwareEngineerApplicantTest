# Teste de Candidatura a Engenheiro de Software Kokku

## RPG de batalha automática

Este aplicativo é um RPG de batalha automática que possui uma grade com células/tiles/caixas organizadas como uma matriz. Seus objetivos são consertar o programa, polir o código e implementar um recurso extra [(conforme detalhado abaixo)](#extra-features).

### Requisitos

- Este teste deve ser feito exclusivamente como um aplicativo de console. Não use nenhum motor
- A solução deve compilar e o jogo deve ser jogável do início ao fim
- Você **deve** usar o git para controle de origem. Você pode configurar um repositório em qualquer host de sua preferência. Por favor, dê acesso à seguinte conta: `dev@kokku.com.br`
  - Seu uso do git será avaliado
- Você é livre para modificar os scripts o quanto quiser
  - Adicionar, remover ou modificar scripts existentes são aceitáveis
  - Você será avaliado em sua capacidade de escrever código limpo, de alto desempenho e de fácil manutenção, seguindo princípios de design saudáveis
- Documente as alterações feitas no código
  - Forneça breves explicações sobre suas alterações. Você não precisa documentar cada linha que modificar

### Regras do jogo

Na inicialização, o jogo deve pedir ao jogador para escolher uma classe e um tamanho de campo de batalha. O personagem inimigo deve ser escolhido aleatoriamente. Ambos os personagens devem receber um ladrilho aleatoriamente no campo de batalha e se revezar para tentar matar seu oponente. A funcionalidade do programa também será avaliada. Abaixo estão algumas regras que devem ser seguidas:

- Cada personagem deve realizar apenas uma ação por turno
    - Se estiverem dentro do alcance de um alvo, devem atacar. Caso contrário, eles se moverão em direção ao alvo mais próximo
    - Seu [recurso extra](#recursos-extra) pode adicionar algumas ações extras que podem ser feitas em um turno
- O jogo deve funcionar com um campo de batalha de qualquer tamanho, incluindo uma matriz não quadrada (6x6 ou 6x10, por exemplo)
- O jogo deve informar ao jogador quando a batalha termina, e quem saiu vitorioso
- O campo de batalha só deve ser reimpresso/redesenhado se houver alguma alteração visual nele
- Apenas um personagem é permitido por telha
- Tente tornar o programa o mais dinâmico possível
    - Evite regras codificadas como "o jogador sempre se move primeiro"


### Recursos Extras

- Cada classe deve implementar um "Efeito de Status" que pode ser aplicado a outros personagens. Exemplos:
    - "Bleed": Danifica o alvo afetado a cada turno por um tempo limitado
    - "Knock down": Impede o alvo afetado de fazer qualquer ação em seu próximo turno
    - "Heal": Cura o alvo afetado
- Cada classe deve implementar uma "Habilidade Especial" que pode ser executada aleatoriamente. Exemplos:
    - "Knockback": Conheça o alvo de volta um ladrilho
    - "Ataque forte": Causa dano de ataque 2x a um alvo
    - "Teleport": Teletransporta o personagem para qualquer ladrilho
    - "Invisibilidade": Deixa o personagem "escondido", impedindo inimigos de persegui-lo ou atacá-lo
    - "Throw rock": Personagem pode danificar um alvo de longe
- Em vez de apenas 2 personagens, o jogo deve ter duas equipes adversárias. O jogador ainda pode escolher a classe de seu personagem. Quando uma equipe é completamente eliminada, eles perdem