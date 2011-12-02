/*
using WebMatrix.Data;
using System.Collections.Generic;

public static class DataExtensions {
	public static IEnumerable<T> Query<T>(this Database db, string commandText, params object[] args) {
		var queryResults = db.Query(commandText, args);
		var mapper = Mapper<T>.Create();
		return (from DynamicRecord record in queryResults select mapper.Map(record)).ToList();
	}
}*/