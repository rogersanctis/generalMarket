/*using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using WebMatrix.Data;

public class Mapper<T> {
	private Func<T> factory;
	private Dictionary<string, Action<T, object>> setters = new Dictionary<string, Action<T, object>>();
	private static Lazy<Mapper<T>> _instance = new Lazy<Mapper<T>>(() => new Mapper<T>());
 
	public static Mapper<T> Create() {
		return _instance.Value;
	}
 
	private Mapper() {
		factory = CreateActivatorDelegate();
 
		foreach (var property in typeof(T).GetProperties()) {
			if (property.CanWrite) {
				setters[property.Name] = BuildSetterDelegate(property);
			}
		}
	}
 
	public T Map(DynamicRecord record) {
		var instance = factory();
 
		foreach(var column in record.Columns) {
			Action<T, object> setter;
 
			if(setters.TryGetValue(column, out setter)) {
				setter(instance, record[column]);
			}
		}
 
		return instance;
	}
 
 
	private static Func<T> CreateActivatorDelegate() {
		return CreateActivatorDelegate(typeof(T).GetConstructor(Type.EmptyTypes));
	}
 
	private static Func<T> CreateActivatorDelegate(ConstructorInfo constructor) {
		return Expression.Lambda<Func<T>>(Expression.New(constructor)).Compile();
	}
 
	private static Action<T, object> BuildSetterDelegate(PropertyInfo prop) {
 
		var instance = Expression.Parameter(typeof(T), "x");
		var argument = Expression.Parameter(typeof(object), "v");
 
		var setterCall = Expression.Call(
			instance,
			prop.GetSetMethod(true),
			Expression.Convert(argument, prop.PropertyType));
 
 
		return (Action<T, object>)Expression.Lambda(setterCall, instance, argument).Compile();
	}
}*/