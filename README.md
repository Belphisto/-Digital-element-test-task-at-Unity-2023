# -Digital-element-test-task-at-Unity-2023
Multimeter programming on Unity 3D

Version of Unity: 2021.3.17f1 

# С применением паттерна MVC 
Для удобства редактирования отдельных элементов независимо друг от друга.

- class MultimeterView - отвечает за визуальное представление результатов на Canvas и дисплей мультиметра.
- class MultimeterModel - отвечает за логику расчета результата самого мультиметра. Здесь хранятся заданные состояния мультиметра: мощность и сопротивление
- class MultimeterController - служит связущим звеном между визуальным представлением и логикой работы
- class GameManager - управляющий класс, находящийся на пустом объекте GameObject на сцене. 
- class ToggleSwithHighlight - служит для управления тумблером: изменение материала при наведении мыши и поворот тумблера при вращении колесика мыши. В классе есть заданные точки - углы поворота, в которые происходит переключение. 


# Пример работы
Состояние мультиметра: сопротивление R = 1000 om, Мощность P = 400 watt. Точность числа = 2 знака после запятой

Начальное состояние - тумблер подсвечивается при наведении мыши ![image](https://user-images.githubusercontent.com/100871374/235433412-755bdc14-790b-44ef-98ba-308c95516c42.png)

Состояние V: P = V*V/R ![image](https://user-images.githubusercontent.com/100871374/235433428-501a1e18-20c1-4a59-9eb7-d03511ffaf3a.png)

Состояние V~: в позиции переменного = 0.01 ![image](https://user-images.githubusercontent.com/100871374/235433455-8eed30ba-1180-4165-9167-96a9d6cbe220.png)

Состояние А: P = А*А*R ![image](https://user-images.githubusercontent.com/100871374/235433479-d61e7936-0b91-4571-851c-dc5f84c50b1c.png)

Состояние Ω: ![image](https://user-images.githubusercontent.com/100871374/235433499-618f5ead-6362-469d-8164-f1e040fbc284.png)

Состояние - тумблер не подсвечивается ![image](https://user-images.githubusercontent.com/100871374/235433521-ccfd7d05-a876-4712-8320-9f2cf28f9617.png)
