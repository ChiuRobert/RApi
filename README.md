<h1 align="center">C# SQL API</h1>

<p align="center">
  This is an API made in C# that can be used for creating the SQL queries in a more secure and visually friendly way.
</p>

### Usage

<p>
In order to use the API you need to add the .dll file and import the library using:

```C#
using ScotchBoardSQL;
```

</p>

[![Download API](https://img.shields.io/badge/download-laps.zip-blue?style=for-the-badge)](https://github.com/ChiuRobert/SQL_API/releases/latest/download/ScotchBoardSQL.dll)

### Documentation

For SELECT queries:

```C#
string selectQuery = new Query("tableName").Select().Where().
    Column("firstColumnName").Less().Value("givenValue").
    And().
    Column("secondColumnName").Higher().Value(42).
    OrderBy().Asc().Execute();
```

with the outcome:

```SQL
SELECT * FROM tableName WHERE firstColumnName < givenValue AND secondColumnName > 42 ORDER BY ASC;
```

For UPDATE queries:

```C#
string updateQuery = new Query("tableName").Update().
    Column("firstColumnName").Value("givenValue").
    Column("secondColumnName").Value(42).
    Where().Column("conditionColumn").Equal().Value(12).Execute();
```

with the outcome:

```SQL
UPDATE tableName SET firstColumnName = givenValue, secondColumnName = 42 WHERE conditionColumn = 12;
```

For INSERT queries:

```C#
string insertQuery = new Query("tableName").Insert().
    Column("id").Column("name").Column("age").
    Values().
    Value(1).Value("John Smith").Value(42).
    Execute();
```

with the outcome:

```SQL
INSERT INTO tableName (id, name, age) VALUES (1, John Smith, 42);
```

For DELETE queries:

```C#
string deleteQuery = new Query("tableName").Delete().Where().
    Column("columnName").Equal().Value("John Smith").
    Execute();
```

with the outcome:

```SQL
DELETE FROM tableName WHERE columnName = John Smith;
```