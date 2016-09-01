使用**delegate**关键字创建委托之后MyDelegate之后，编译器在后台实际做了很多隐藏了委托的复杂性。可以将创建委托实例的过程，
> MyDelegate myDelegate1 = new MyDelegate(MyStaticMehod);

看作新建类型对象的过程。实际后台创建了一个叫MyDelegate的类，主要函数成员定义如下：
internal class MyDelegate : System.MulticastDelegate
{
    // constructor
    public MyDelegate(Object @object, IntPtr method){...}

    public virtual void Invoke(string name){...}

    public virtual IAsyncResult BeginInvoke(string name, AsyncCallback callback, Object @object){...}

    public virtual void EndInvoke(IAsyncResult result){...}
}

这里，第三个和第四个方法设计异步回调，暂时不讲解。除了这些主要的函数成员，还有三个主要的字段，**_target"" ,**_methodPtr** ,**_invocationList**。新建委托实例之后，传入的静态方法名/实例方法名将保存在类MyDelegate中的_methodPtr字段，实例（此处是Program对象）将保存在_target变量中（静态方法没有实例对象，_target则设置为null）。

新建委托对象造成上述步骤的操作，等到实际调用委托执行方法时（myDelegate1("Owen")），实际运行的是MyDelegate类的Invoke方法，该方法指明调用传入对象的实例方法(program.MyInstanceMethod)，获知指示调用静态方法(MyStaticMethod)。