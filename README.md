# Ebac_Adventure_3d_Task Unity 3D

Projeto feito no cursos Ebac, nesse curso eu aprendi a desenvolver game utilizando Unity 3D.

<h2>Sumário</h2>
    <ol>
        <li><h4><a href="#C1">Menu Game</a></h4></li>
        <li><h4><a href="#C2">Movimentação do personagem e controle</a></h4></li>
        <li><h4><a href="#C3">Vida do player</a></h4></li>
        <li><h4><a href="#C4">Attack do player</a></h4></li>
        <li><h4><a href="#C5">Item coletáveis</a></h4></li>
        <li><h4><a href="#C6">PowerUps e Roupas</a></h4></li>
        <li><h4><a href="#C7">Baú</a></h4></li>
        <li><h4><a href="#C8">Arvores</a></h4></li>
        <li><h4><a href="#C9">Enemy Shoot e Enemy Walk</a></h4></li>
        <li><h4><a href="#C10">Boss</a></h4></li>
        <li><h4><a href="#C11">Checkpoint</a></h4></li>
        <li><h4><a href="#C12">Save</a></h4></li>
        <li><h4><a href="#C13">Camera</a></h4></li>
        <li><h4><a href="#C14">VFX and Particulas</a></h4></li>
        <li><h4><a href="#C15">Sound do game</a></h4></li>
    </ol>

<h1 id="C1">Menu do game</h1>

+ O Menu do jogo terá duas opções: um play para entrar cena gameplay e outro exit para sair do game e informações sobre como controlar o personagem e sobre comando do game.

<td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_menu.gif" width="630" height="500"/></td>

<h1 id="C2">Movimentação do personagem e controle</h1>

+ Esse jogo é 3D e permite controlar um personagem que pode andar para todos lados e atira, pula e pegar moedas e lifePack e também powerUps.

  <table border="0">
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_019.gif" width="230" height="300"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_025.gif" width="230" height="300"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_026.gif" width="230" height="300"/></td>
    </tr>
  </table>

 + Mostrando screenshot das configurações scripts e do inspector player: playerController e playerAbilityShoot, healthBase. E tem especificação character controller e box collider.

  <table border="0">
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script-playercontroller.png" width="230" height="300"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script-playerAbillityShoot.png" width="230" height="300"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_transform-chanactarController-boxCollider.png" width="230" height="300"/></td>
    </tr>
  </table>

  <h1 id="C3">Vida do player</h1>
  
  + O player vai ter um barra de life em cima da cabeça quando personagem for atingido pelo inimigo a barra vai diminuir, se barra da vida abarcar o player morre.

  <table border="0">
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_039.gif" width="330" height="400"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/life_player.png" width="330" height="400"/></td>
    </tr>
  </table>

  <h1 id="C4">Attack do player</h1>

  + O personagem pode atirar por um tiros limitado e tem barra circular cada tiro que o jogador tirar da barra diminui seu tamanho, e quando barra circular desaparecer o player vai
    ficar uns segundos sem poder atirar e barra volta seu tamanho original.

   <table border="0">
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_027.gif" width="330" height="400"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img-knob-shoot.png" width="330" height="400"/></td>
    </tr>
  </table>

  <h1 id="C5">Item coletáveis</h1>
  
  + Os Itens que podem ser coletadas são moedas e life. o script itemcollectableBase será configurado para qualquer item que coletava.
  
  <table border="0">
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_ItemCoin.gif" width="330" height="300"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_ItemLife.gif" width="330" height="300"/></td>
    </tr>
  </table>

  <h3>Script - ItemCollectableBase</h3>
  
  <img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_ItemCollectableBase.png" width="400" height="200"/>

  + O item manager vai gerenciar os itens coletáveis na cena.
  <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_ItemManager.png" width="430" height="300"/></td>

  <h1 id="C6">PowerUps e Roupas</h1>

  + O jogo tem 3 tipos powerUps ItemClothStrong e ItemClothSpeed, ItemClothJump os powerUps pode dar poderes ao jogador por um segundos, 
  como aumentar velocidade do player ou dar mais força e aumentar pula e também muda cor da roupa do player depende do powerUps.

  + Image dos 3 powerUps
  <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_powerUps.png" width="430" height="100"/></td>

  <table border="0">
    <tr>
      PowerUps - Super Jump |
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_037.gif" width="230" height="300"/></td>
      PowerUps - Super Speed |
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_038.gif" width="230" height="300"/></td>
      PowerUps - Super Strong
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_034.gif" width="230" height="300"/></td>
    </tr>
  </table>

  + O script cloth manager vai gerir roupas do player e os tipos de roupas e com os nomes delas.
  
  + <h3>Script - ClothManager</h3>
  <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script_ClothManager.png" width="430" height="300"/></td>

  + Aqui 3 screenshot dos configurações do powerUps:

  <table border="0">
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_ItemClothJump.png" width="230" height="300"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_ItemClothSpeed.png" width="230" height="300"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_ItemClothStrong.png" width="230" height="300"/></td>
    </tr>
  </table>

  <h1 id="C7">Baú</h1>

  + O game vai ter baú que vai dar moedas para jogador, o baú vai detectar o player com Sphere Collider ativado Is Trigger e quando jogador estiver
  perto do baú ele aperta a tecla E o bau abre e sair moedas.

  <table border="0">
      <h3>bau - Script ChestBase</h3>
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script_chestBase.png" width="330" height="400"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_Chess_0.gif" width="230" height="300"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_Chess_1.gif" width="230" height="300"/></td>
    </tr>
  </table>

  <h1 id="C8">Arvores</h1>

 + O jogo vai ter árvores que podem ser destruídas com os tiros cada tiro que acerta árvores sai moedas, até a árvore perder toda sua vida e vai ser morre.

  <table border="0">
      <h3>Tree - Script DestructableItemBase</h3>
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script_DestructableItemBase_HealthBase.png" width="330" height="400"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_034_Tree_Coins.gif" width="330" height="400"/></td>
    </tr>
  </table>

  <h1 id="C9">Enemy Shoot e Enemy Walk</h1>

  + O jogo vai ter 2 tipos de inimigo um e o Enemy Shoot que vai ficar parado e vai atirar quando player fica perto dele e vai mirar no personagem, 
  outro Enemy Walk que vai seguir um caminho programado pelos objetos waypoints point_a, point_b e point_c que ele vai seguir.

  <table border="0">
      <h3>Enemy Shoot - Script EnemyShoot</h3>
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_042.gif" width="330" height="400"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script_Enemy_shoot.png" width="330" height="400"/></td>
    </tr>
  </table>

  <table border="0">
       <h3>Enemy Walk - Script EnemyWalk</h3>
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_043.gif" width="330" height="400"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script_Enemy_Walk.png" width="330" height="400"/></td>
    </tr>
  </table>

  <h1 id="C10">Boss</h1>

  + O Boss pode ser controlado pelo script boss base no inspector unity no gameobject Boss tem 3 botão que vai fazer ações como iniciar boss Switch Init
  e fazer boss andar no cenário seguindo objetos waypoints A, B e C Switch Walk, e último botão faz boss atacar Switch Attack.

  <table border="0">
    <h3>Boss - Script Boss Base</h3>
    <tr>
        <tr>
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script_Boss_Base.png" width="330" height="400"/></td>
          Boss - Switch Init |
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Boss_0.gif" width="230" height="300"/></td>
          Boss - Switch Attack
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Boss_1.gif" width="230" height="300"/></td>
        </tr>
    </tr>
  </table>
  <table border="0">
    <tr>
        <h3>Boss - Switch Walk</h3>
        <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Boss_2.gif" width="230" height="300"/></td>
        <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Boss_3.gif" width="230" height="300"/></td>
        <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Boss_4.gif" width="230" height="300"/></td>
        </tr>
  </table>
  <table>
        <tr>
           + Quando inimigo chegar no waypoint ele vai ataque e depois ele segue outro waypoint.
           <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Boss_5.gif" width="230" height="300"/></td>
        </tr>
  </table>

  <h1 id="C11">Checkpoint</h1>

  + Checkpoint vai salvar o jogo quando o player morre no game, e quando jogador passar checkpoint vai aparecer texto em cima do checkpoint Save Game, o 
  checkpoint Manager vai gerenciar quantos checkpoint tem fase e qual e última key do checkpoint.
  
   <table>
        <tr>
           <h3>Script CheckpointBase and CheckpointManager</h3>
           <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_CheckpointBase.png" width="400" height="100"/><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script_CheckpointManager.png" width="400" height="100"/></td>
           <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_Checkpoint_0.gif" width="230" height="300"/></td>
           <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_Checkpoint_1.gif" width="230" height="300"/></td>
        </tr>
  </table>

  <h1 id="C12">Save</h1>

  + O Save Manager vai ser responsável por salvar informações do jogador como coins último level e nome do player, e o script vai criar arquivo do game.

  <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script_SaveManager.png" width="330" height="200"/></td>

  <h1 id="C13">Camera</h1>
  
  + CinemachineStateDrivenCamera está configurado 3 câmera virtual e opções Follow e Look At está selecionado player.
  
  <table>
        <tr>
          <h3>Câmera - CinemachineStateDrivenCamera</h3>
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_DrivenCamera.png" width="330" height="400"/></td>
        </tr>
  </table>

  <h1 id="C14">VFX e Particle System</h1>

  + O GameObject VFX_Rain vai estar com configurações Particle System que está simulando chuva.

  <table>
      <tr>
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_vfx.gif" width="330" height="400"/></td>
      </tr>
  </table>

   <table>
        <tr>
          <h3>VFX_Rain - Particle System - Emission - Shape</h3>
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_particleSystem.png" width="330" height="400"/></td>
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_particleSystem_Emission_Shape.png" width="330" height="400"/></td>
        </tr>
  </table>
  
  <table>
        <tr>
          <h3>Size over Lifetime - Rotation over Lifetime - Noise - Renderer</h3>
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_particleSystem_Size-over-Lifetime_Rotation-over-Lifetime_Noise.png" width="330" height="400"/</td>
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_particleSystem_Renderer.png" width="330" height="400"/></td>
        </tr>
  </table>

  <h1 id="C15">Sound do game</h1>

  + O sistema de áudio do game SoundManager é responsável com todos áudios do jogo com name som e com áudio clip o SoundManager terá dois tipos de setups music e sfx.
  No AudioSource com script MusicPlayer vai ser responsável tocar música no jogo. 

  <table>
        <tr>
          <h3>Script SoundManager - AudioSource - Script MusicPlayer</h3>
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script_SoundManager.png" width="330" height="400"/></td>
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_Music_AudioSource_MusicPlayer.png" width="330" height="400"/></td>
        </tr>
  </table>

  + O sfxPool vai resolver um problema quando toca vários audios ele corta último áudio, e script sfxpool vai criar lista áudios assim ele toca um por vez.

  <h3>Script SFXPool</h3>
  <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script_SFXPool.png" width="450" height="100"/></td>
