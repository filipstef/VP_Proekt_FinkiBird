# Финки птица

Windows forms project by: Симон Мирчевски 181207, Филип Стефановски 186102

Нашиот проект финки птица е игра инспирирана од познатата мобилна игра flappy bird. Нашата игра е направена во windows forms користејќи C#. Самата игра е поинаква од flappy bird од аспект на контоли и изглед, но главната цел на играта останува иста ( да се пази птицата, односно кругот во овој случај да не се удри во правоаголниците).

## Упатство на користење

Со цел да се укличи играта потребно е да се навигира до bin/Debug и да се притиснe на .exe фајлот (VPFinkiBirdProekt.exe).

По вклучување на аплијацијата, играта одма почнува и во средина на екранот се појавува прозорецот:

![Screenshot 2022-09-03 185318](C:\Users\filip\OneDrive\Desktop\Screenshot 2022-09-03 185318.png)



## Упатство за играње

Играта е доста проста со тоа што бара само една команда од корисникот, а тоа е <u>space</u> копчето. При притискање и држење на копчето кругот се движи нагоре, а при пуштање на копчето кругот паѓа надоле. Целта на играта е да се избегнат темно плавите правоаголници, при што секое избегнување на правоаголник додава еден поен на играчот.

![Animation](C:\Users\filip\OneDrive\Desktop\Animation.gif)

Играта завршува кога кругот ќе допре еден од правоаголниците, при што се прикажува текст Game over!!! и вкупниот број на поени освоени од играчот (како на сликата долу). За да се игра повторно мора да се изгаси прозорецот и да се кликне на програмата од ново.

![image-20220903191253732](C:\Users\filip\AppData\Roaming\Typora\typora-user-images\image-20220903191253732.png)

## Кодот на играта

Целата игра е напишана во една класа `public class Form1`. Оваа класа ја содржи целата логика и сите податоци зад играта.

- Методата `gameTimerEvent` ја проверува позицијата на топката (дали е удрена во цилиндрите или дали е искочена од екранот), во случај топката да не е на посакувано место, методата ја завршува играта и ги прикажува поените. Методата е исто така должна да провери колку поени има корисникот и врз основа на тоа да го убрза движењето на правоаголниците (на 5, 15 и 50 поени се убрзува).

  ```c#
          private void gameTimerEvent(object sender, EventArgs e)
          {
              FinkiBird.Top += gravity;
              pipeBottom.Left -= pipeSpeed;
              pipeTop.Left -= pipeSpeed;
              ScoreLabel.Text = "Score: " + score;  
          if(pipeTop.Left < -100)
          {
              pipeTop.Left = rnd.Next(65, 100) * 10;
              score++;
          }
          if(pipeBottom.Left < -100)
          {
              pipeBottom.Left = rnd.Next(65, 100) * 10;
              score++;
          }
  
          if(FinkiBird.Bounds.IntersectsWith(pipeBottom.Bounds)||
              FinkiBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
              FinkiBird.Bounds.IntersectsWith(grounds.Bounds) ||
              FinkiBird.Top < -25)
          {
              endGame();
          }
          if (score > 5)
          {
              pipeSpeed = 15;
          }
          if(score > 15)
          {
              pipeSpeed = 20;
          }
          if (score > 50)
          {
              pipeSpeed = 30;
          }
         
      }
  ```

- Методите `gameKeyDown` и `gameKeyUp` проверуваат дали е притиснато копчето space (при притискање на копчето до движат кругот нагоре, при пуштање на копчето надолу)

  ```c#
      private void gameKeyDown(object sender, KeyEventArgs e)
      {
          if(e.KeyCode == Keys.Space)
          {
              gravity = -10;
          }
      }
  
      private void gameKeyUp(object sender, KeyEventArgs e)
      {
          if (e.KeyCode == Keys.Space)
          {
              gravity = 10;
          }
      }
  ```

-  Metodata `endGame()` е должна за гасење на играта при губење. Таа ја гаси логиката на играта и ги прикажува поените.

          private void endGame()
          {
              timer1.Stop();
              ScoreLabel.Text = "Game over!!! Your score was : " + score ;
          }