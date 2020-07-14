# SolidSample
SOLID原則の勉強用。C#で記述。
Study for SOLID principle. It's written C#.

処理内容は車のタイプを受け取り、その車を走らせる（実際には音を鳴らすのみ）。

## 0-Initial
SOLID原則適用前。構造化プログラミングされておらず、処理が直列に書かれている。

## 1-SplitMethod
構造化プログラミングを意識し、メソッド分割を行った状態。

## 2-SplitClass
SOLID原則の「S」：単一責任の原則に従い、メソッドを別クラスに移した状態。

## 3-SplitCar
SOLID原則の「S」：単一責任の原則に従い、車のタイプごとにクラス分けを実施。

## 4-ImplementInterface
車のタイプにインターフェースを導入。  
SOLID原則の「D」：依存性逆転の原則に対応。  
変更前は車を走らせるメソッドが車のタイプでばらばらだったが、インターフェースを導入することでメソッドが統一され、CarRunnerが車のタイプを意識せずに車を走らせることができるようになった。

## 5-ImplementFactory
SOLID原則の「S」：単一責任の原則を深化。  
インターフェースICar導入により、車のインスタンス生成と車を走らせるのは別の責務であることがわかったので、CarFactoryに車のインスタンス生成の責務を移譲し、CarRunnerは車を走らせる責務に特化。

さらにこの状態でSOLID原則の「O」：解放閉鎖の原則にも対応している。  
もし、車のタイプが増えた場合は、新たな車のタイプクラスを作成し、CarFactoryに分岐を追加するのみでよい。  
つまり、容易に車のタイプクラスの追加が行え、既存の車のタイプクラスやCarRunnerには変更がないため、拡張に対して開いており、修正に対して閉じていることがわかる。

## 6-AddSirenInterfaceMethod
SOLID原則の「I」：インタフェース分離の原則の説明のため、車のサイレンを鳴らすメソッド（BeatSiren）をインターフェースICarに追加。  
バスはサイレンを持っていないが、メソッドの実装が必要になる。通常の乗用車についてもサイレンはないので、ICarインターフェースにBeatSirenを追加するのは間違いであり、サイレンは車の汎化の際に入れるのは適切ではない。  

## 7-InterfaceSegregation
SOLID原則の「I」：インタフェース分離の原則に従い、BeatSirenを別インターフェースに定義。Busクラスに不要なメソッドを導入せずに済むことがわかる。

## 8-LiskovSubstitution
SOLID原則の「L」：リスコフの置換原則の説明。  
スーパークラスにロジックを導入したいため、ICarインターフェースをCarBaseクラスに変更し、SetVelocityメソッドとGetRemainingGasolineメソッドを導入。  
* SetVelocity（事前条件）  
  CarBaseクラスでは100km以内に制限しているが、Busクラスでは80km、FireEngineクラスでは120km以内に制限している。  
  リスコフの置換原則では、すべてのサブクラスはスーパークラスと同様に扱えないといけないので、90kmで走ることを考えた場合、Busクラスはクラス内で定義した制限速度をオーバーしているため、走らすことができない。これはスーパークラスではできることがBusクラスではできないことを意味しており、リスコフの置換原則に違反している。
* GetRemainingGasoline（事後条件）  
  CarBaseクラスではガソリン残量は50l以内に制限しているが、Busクラスでは30l、FireEngineクラスでは100l以内に制限している。  
  リスコフの置換原則では、すべてのサブクラスはスーパークラスと同様に扱えないといけないので、ガソリン残量60lで値を返すことができるFireEngineクラスはスーパークラスで定義したガソリン残量をオーバーしているため、リスコフの置換原則に違反している。


# SolidSample
Study for SOLID principle. It's written in C#.

It takes a car type and makes it run (actually, it just makes a sound).

## 0-Initial.
Before applying the SOLID principle. The process is written in series with no structured programming.

## 1-SplitMethod.
With structured programming in mind, method splitting is done.

## 2-SplitClass.
The "S" in SOLID principle: The method is moved to a separate class, following the principle of single responsibility.

## 3-SplitCar.
The "S" in SOLID Principle: Classifying each type of car according to the principle of single responsibility.

## 4-ImplementInterface.
Introduce interfaces to car types.  
Corresponds to the "D" in SOLID principle: Dependency Inversion Principle.  
Before the change, the methods for driving cars were disparate across car types, but interfaces are introduced. This unifies the method and allows CarRunner to drive the car without being aware of the car type. You can now.

## 5-ImplementFactory.
The "S" in SOLID principles: deepening the principle of single responsibility.  
With the introduction of the interface ICar, instantiation of the car and driving the car are two separate responsibilities. So we transferred the responsibility of instantiating the car to the CarFactory, and then the CarRunner specializes in the responsibility of running cars.

It also supports the SOLID principle "O": the principle of release closure in this state.  
If you have more car types, you can create a new car type class and send it to CarFactory All you need to do is add a branch.  
This means that you can easily add car type classes, and you can use existing car type classes and CarRunner is open for expansion and closed for modification.

## 6-AddSirenInterfaceMethod.
The "I" in the SOLID principle: Car siren blaring to illustrate the principle of interface separation A method (BeatSiren) was added to the interface ICar.  
Buses do not have a siren, but the method needs to be implemented. Since regular passenger cars also do not have a siren, we have added BeatSiren is a mistake, and sirens are not appropriate to include during car generalization.  

## 7-InterfaceSegregation.
The "I" in SOLID Principle: Following the principle of interface separation, BeatSiren is separate interface, which saves introducing unnecessary methods in the Bus class.

## 8-LiskovSubstitution.
The "L" in SOLID principle: an explanation of Liskov's substitution principle.  
To introduce logic into the superclass, the ICar interface is CarBase class and set the SetVelocity method and Introduced the GetRemainingGasoline method.  
* SetVelocity (preconditions)  
  The CarBase class limits you to 100km, while the Bus class limits you to 80km and The FireEngine class is limited to 120km.  
  Under Liskov's substitution principle, all subclasses must be treated the same way as superclasses. So, if you want to run at 90km, the speed limit for Bus class is the speed limit defined in the class. You can't run it because it's over. This means that what you can do in Super Class you can't do in Bus Class. Liskov's substitution principle is violated.
* GetRemainingGasoline (Posterior Condition)  
  The CarBase class limits the remaining gasoline to 50l, while the Bus class limits it to 30 l, and the FireEngine class limits it to 100l.  
  Liskov's substitution principle requires that all subclasses must be treated the same as superclasses So the FireEngine class, which can return a value with 60l of gasoline remaining, is super It violates Liskov's substitution principle because it is in excess of its class-defined gasoline residue.

Translated with www.DeepL.com/Translator (free version)