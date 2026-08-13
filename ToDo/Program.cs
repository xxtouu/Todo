

Todo.Task[] items = [new("Сходить в магазин"), new("Поесть"), new("Отдохнуть"), new("Улыбуться")];
Todo.TaskList List = new(items);
System.Console.WriteLine(List);


List.MarkInProgress("Отдохнуть");
List.MarkDone("сходить в магазин");
System.Console.WriteLine(List);

List.RemoveDone();
System.Console.WriteLine(List);
