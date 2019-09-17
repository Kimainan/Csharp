1. 设计项目s4-1。创建一个Vehicle类并将它声明为抽象类。在Vehicle类中声明一个NoOfWheels方法 使它返回一个字符串值。创建两个类Car和Motorbike从Vehicle类继承 并在这两个类中实现NoOfWheels方法。在Car类中 应当显示“四轮车”信息 而在Motorbike类中应当显示“双轮车”信息。创建另一个带Main方法的测试类，在该类中创建Car和Motorbike的实例 并在控制台中显示消息。


2. 设计项目s4-2。定义一个接口，用于描述动物的生活习性，包含食性、捕食、分布区域、睡觉方式、群居方式等；接口里面包括属性和方法。
\<br>例如：
\<br>interface IHabit
\<br>{
\<br>    void CatchFood();
\<br>    string food{get;set;}
\<br>    ……
\<br>} 
\<br>然后定义猫、老虎、狮子、大象等几个动物类来实现该接口；
\<br>最后定义一个调用类，来运行程序，查看接口的使用情况。


3. 设计项目s4-3。抽象类、继承、接口综合：设计一个系统 XXX门的实现过程。流程：设计一张抽象的门Door，那么对于这张门来说就应该拥有所有门的共性：开门openDoor()和关门closeDoor() ，然后对门进行另外的功能设计,防盗--theftproof()、防水--waterproof()、防弹--bulletproof()、防火、防锈…… 要求：利用继承、抽象类、接口的知识设计该门。
