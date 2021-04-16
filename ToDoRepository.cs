using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Dto;

namespace WebApi
{
    public class ToDoRepository
    {
        private class ToDo
        {
            public ToDo( int id, string name, bool done)
            {
                Id = id;
                Name = name;
                Done = done;
                CreationDate = DateTime.Now;
            }

            public int Id { get; }
            public string Name { get; set; }
            public bool Done { get; set; }
            public DateTime CreationDate { get; }
        }

        private static List<ToDo> Database = new List<ToDo>();
        private int GetId() => Database.Count > 0 ? Database.Max( x => x.Id ) + 1 : 1;

        public List<ToDoDto> GetAll() => Database.Select( x => new ToDoDto { Id = x.Id, Name = x.Name, Done = x.Done } ).ToList();
        public int Add(ToDoDto toDoDto) {
            int id = GetId();
            Database.Add(new ToDo(GetId(), toDoDto.Name, toDoDto.Done));
            return id;    
        }
        public void Update( int id, ToDoDto toDoDto ) {
            ToDo todo = Database.FirstOrDefault( x => x.Id == id );
            if ( todo == null ) return;
            todo.Name = toDoDto.Name;
            todo.Done = toDoDto.Done;
        }

    }
}
