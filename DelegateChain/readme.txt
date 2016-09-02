c sharp中提供了以下泛型化的委托，一般的需求都能满足，所以建议使用System库提供的委托类型，不建议自己再定义。
无返回值，最多16个参数：
> public delegate void Action();
> public delegate void Action<T>(T arg1);  //带一个参数
> public delegate void Action<T1, T2>(T1 arg1, T2 arg2);
> ...
> public delegate void Action<T1,..,T16>(T1 arg1,.., T16 arg16);

有返回值，最多16个参数：
> public delegate TResult Func<TResult>();
> public delegate TResult Func<T, TResult>(T arg1);  //带一个参数
> public delegate TResult Func<T1, T2, TResult>(T1 arg1, T2 arg2);
> ...
> public delegate TResult Func<T1,..,T16, TResult>(T1 arg1,.., T16 arg16);

上述实例中自定义的委托完全可以直接使用系统提供的泛型委托Func<string>替换
> Func<string> delegateChain = null;