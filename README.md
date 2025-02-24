# Ebac_Adventure_3d_Task Unity 3D

Projeto feito no cursos Ebac, nesse curso eu aprendi a desenvolver game utilizando Unity 3D

Esse jogo é 3D e permite controlar um personagem que pode andar para todos lados e atira, pula e pegar moedas e lifePack e também powerUps.

<html>

  <table border="0">
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_019.gif" width="230" height="300"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_025.gif" width="230" height="300"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_026.gif" width="230" height="300"/></td>
    </tr>
  </table>
</html>

   Mostrando screenshot das configurações scripts e do inspector player: playerController e playerAbilityShoot, 
   healthBase. E tem especificação character controller e box collider.
    
<html>

  <table border="0">
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script-playercontroller.png" width="230" height="300"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script-playerAbillityShoot.png" width="230" height="300"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_transform-chanactarController-boxCollider.png" width="230" height="300"/></td>
    </tr>
  </table>
  
  O player vai ter um barra de life em cima da cabeça quando personagem for atingido pelo inimigo a barra vai diminuir, 
  se barra da vida abarcar o player morre.

  <table border="0">
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_039.gif" width="330" height="400"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/life_player.png" width="330" height="400"/></td>
    </tr>
  </table>

  O personagem pode atirar por um tiros limitado e tem barra circular cada tiro que o jogador tirar da barra diminui seu tamanho, 
  e quando barra circular desaparecer o player vai ficar uns segundos sem poder atirar e barra volta seu tamanho original.

   <table border="0">
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_027.gif" width="330" height="400"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img-knob-shoot.png" width="330" height="400"/></td>
    </tr>
  </table>

  O jogo tem 3 tipos powerUps ItemClothStrong e ItemClothSpeed, ItemClothJump os powerUps pode dar poderes ao jogador por um segundos,
  como aumentar velocidade do player dar mais força e dar pula maior e também muda cor da roupa do player

  Image dos 3 powerUps
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

  Aqui 3 screenshot dos configurações do powerUps:

  <table border="0">
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_ItemClothJump.png" width="230" height="300"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_ItemClothSpeed.png" width="230" height="300"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_ItemClothStrong.png" width="230" height="300"/></td>
    </tr>
  </table>

  O game vai ter baú que vai dar moedas para jogador, o baú vai detectar o player com Sphere Collider ativado Is Trigger e quando jogador estiver
  perto do baú ele aperta a tecla E o bau abre e sair moedas.

  <table border="0">
      bau - Script ChestBase 
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script_chestBase.png" width="330" height="400"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_Chest.gif" width="230" height="300"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_Chest_2.gif" width="230" height="300"/></td>
    </tr>
  </table>

 O jogo vai ter árvores que podem ser destruídas com os tiros cada tiro que acerta árvores sai moedas, até a árvore perder toda sua vida e vai ser morre.

  <table border="0">
      Tree - Script DestructableItemBase
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script_DestructableItemBase_HealthBase.png" width="330" height="400"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_034_Tree_Coins.gif" width="330" height="400"/></td>
    </tr>
  </table>
 

  O jogo vai ter 2 tipos de inimigo um e o Enemy Shoot que vai ficar parado e vai atirar quando player fica perto dele e vai mirar no personagem, 
  outro Enemy Walk que vai seguir um caminho programado pelos objetos waypoints point_a, point_b e point_c que ele vai seguir.

  <table border="0">
      Enemy Shoot - Script EnemyShoot
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_042.gif" width="330" height="400"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script_Enemy_shoot.png" width="330" height="400"/></td>
    </tr>
  </table>

  <table border="0">
      Enemy Walk - Script EnemyWalk
    <tr>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_043.gif" width="330" height="400"/></td>
      <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_script_Enemy_Walk.png" width="330" height="400"/></td>
    </tr>
  </table>

  O Boss pode ser controlado pelo script boss base no inspector unity no gameobject Boss tem 3 botão que vai fazer ações como iniciar boss Switch Init
  e fazer boss andar no cenário seguindo objetos waypoints A, B e C Switch Walk, e último botão faz boss atacar Switch Attack.

  <table border="0">
    Boss - Script Boss Base
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
        Boss - Switch Walk
        <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Boss_2.gif" width="230" height="300"/></td>
        <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Boss_3.gif" width="230" height="300"/></td>
        <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Boss_4.gif" width="230" height="300"/></td>
        </tr>
  </table>
  <table>
        <tr>
           Quando inimigo chegar no waypoint ele vai ataque e depois ele segue outro waypoint.
           <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Boss_5.gif" width="230" height="300"/></td>
        </tr>
  </table>

  Checkpoint
  
   <table>
        <tr>
           CheckpointBase
           <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_CheckpointBase.png" width="130" height="200"/></td>
           <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_Checkpoint_0.gif" width="330" height="400"/></td>
           <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_Checkpoint_1.gif" width="330" height="400"/></td>
        </tr>
  </table>

  CinemachineStateDrivenCamera está configurado 3 câmera virtual e opções Follow e Look At está selecionado player.

  <table>
        <tr>
          VFX_Rain - Particle System - Emission - Shape
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_particleSystem.png" width="330" height="400"/></td>
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_particleSystem_Emission_Shape.png" width="330" height="400"/></td>
        </tr>
  </table>
  

  CinemachineStateDrivenCamera está configurado 3 câmera virtual e opções Follow e Look At está selecionado player.
  
  <table>
        <tr>
          Câmera - CinemachineStateDrivenCamera
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_DrivenCamera.png" width="330" height="400"/></td>
        </tr>
  </table>

  O GameObject VFX_Rain vai estar com configurações Particle System que está simulando chuva.

  <table>
      <tr>
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/Recordings/Movie_vfx.gif" width="330" height="400"/></td>
      </tr>
  </table>

   <table>
        <tr>
          VFX_Rain - Particle System - Emission - Shape
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_particleSystem.png" width="330" height="400"/></td>
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_particleSystem_Emission_Shape.png" width="330" height="400"/></td>
        </tr>
  </table>
  
  <table>
        <tr>
          Size over Lifetime - Rotation over Lifetime - Noise - Renderer
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_particleSystem_Size-over-Lifetime_Rotation-over-Lifetime_Noise.png" width="330" height="400"/</td>
          <td><img src="https://github.com/guiardev/Ebac_Adventure_3d_Task/blob/develop/Assets/imgs/img_particleSystem_Renderer.png" width="330" height="400"/></td>
        </tr>
  </table>
  
</html>
