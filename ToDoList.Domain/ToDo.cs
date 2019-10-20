namespace ToDoList.Domain
{
    public class ToDo
    {
        public ToDo(){}
        public ToDo(int id, string name, int priority, int description, int age, TypeToDo typeToDo)
        {
            this.id = id;
            this.name = name;
            this.priority = priority;
            this.description = description;
            this.age = age;
            this.TypeToDo = typeToDo;

        }
        public int id { get; set; }
        public string name { get; set; }
        public int priority { get; set; }
        public int description { get; set; }
        public int age { get; set; }

        public TypeToDo TypeToDo { get; set; }

    }
}