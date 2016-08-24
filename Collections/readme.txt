集合(https://msdn.microsoft.com/en-us/library/mt654013.aspx)

按照以下两个命名空间，c#中集合可以分为两大类。

System.Collections.Generic
类型  |  描述
-----|-----
Dictionary<TKey, TValue> | 存储键值对
List<T>  | 存储类型为T的一组对象
Queue<T> | 队列中存储类型为T的一组对象
Stack<T> | 栈中存储类型为T的一组对象

System.Collections
类型  | 描述
-----|---
ArrayList | 存储一组对象，弱类型
Hashtable | 存储一组键值对，弱类型
Queue | 队列中存储一组弱类型对象
Stack | 栈中存储一组若类型对象


dictionary  https://msdn.microsoft.com/en-us/library/xfhwa508.aspx



*ArrayList* 在命名空间**System.Collections**下，定义如下：
> public class ArrayList : **IList**, ICollection, **IEnumerable**, ICloneable

*ArrayList* 是专门用来存储不同类型的对象的，其性能并不总是最好。ArrayList不保证对存储的元素排序，除非调用其*Sort* 方法。


*List<T>* 在命名空间**System.Collections.Generic**下，其主要用于存储类型明确（强类型)的一组对象，常用的方法如下：
	    List < string > colors = new List < string > ();

            //add items in a List collection
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Green");

            //insert an item in the list
            colors.Insert(1, "violet");

            //retrieve items using foreach loop
            foreach (string color in colors)
            {
                MessageBox.Show(color);
            }

            //remove an item from list
            colors.Remove("violet");

	    //copy array to list
            string[] strArr = new string[3];
            strArr[0] = "Red";
            strArr[1] = "Blue";
            strArr[2] = "Green";
            List < string > arrlist = new List < string > (strArr);

            foreach (string str in strArr)
            {
                MessageBox.Show(str);
            }

            //call clear method
            arrlist.Clear ();

List<T>是实现了IList<T>接口的一个类，一般使用时，推荐按照如下方法使用：
> IList<MyClass> list = new List<MyClass>();

这样定义，可以达到松耦合的目的，如果以后不使用List结构了，改使用实现了IList的其它结构时，更方便更改；
