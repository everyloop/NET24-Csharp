
Cage<double> myStringCage = new Cage<double>();
Cage<double> myDoubleCage = new Cage<double>();
Cage<bool> myBoolCage = new Cage<bool>();

myDoubleCage.MyProperty = 5.3;
myBoolCage.MyProperty = true;

var v = myDoubleCage.MyProperty;

class Cage<T>
{
    public T MyProperty { get; set; }
}
